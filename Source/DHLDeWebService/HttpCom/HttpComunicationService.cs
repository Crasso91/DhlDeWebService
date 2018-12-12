using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DHLDeWebService.Extensions;

namespace DHLDeWebService.HttpCom
{
    public class HttpComunicationService
    {
        public Task<HttpResponseMessage> GetAsync(string url, string username, string password, bool isSecureConnection)
        {
            Task<HttpResponseMessage> _result = null;
            if (isSecureConnection)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            var credentials = new NetworkCredential(username, password);
            var handler = new HttpClientHandler { Credentials = credentials };

            using (var httpClient = new HttpClient())
            {
                _result = httpClient.GetAsync(url);

            }
            return _result;
        }

        public Task<HttpResponseMessage> PostAsync(string url, string username, string password, bool isSecureConnection, object content, string soapAction = "", bool debug = false)
        {
            Task<HttpResponseMessage> _result = null;
            if (isSecureConnection)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            var body = new StringContent(XMLService.Serialize(content), Encoding.UTF8, "application/xml");

            if (debug)
            {

                var folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\DHLDE_Debug";
                var filename = "Req-DHLde-" + DateTime.Now.ToString("yyyy-MM-dd") + "-" + Guid.NewGuid().ToString();
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                var debugFilename = System.IO.Path.Combine(folderPath, filename);
                System.IO.File.WriteAllText(debugFilename, XMLService.Serialize(content));
            }

            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add(HttpRequestHeader.Authorization.ToString(), string.Format("Basic {0}", credentials));
                if (!string.IsNullOrEmpty(soapAction)) httpClient.DefaultRequestHeaders.Add("SOAPAction", soapAction);
                _result = httpClient.PostAsync(url, body);
                _result.Wait();
            }
            return _result;
        }

        public T Get<T>(string url, string username, string password, bool isSecureConnection) where T : new()
        {
            T _result = new T();
            HttpResponseMessage response = null;
            var tsk = GetAsync(url, username, password, isSecureConnection).ContinueWith(x => { response = x.Result; });
            tsk.Wait();
            var content = response.Content.ReadAsStringAsync().Result;
            return XMLService.Deserialize<T>(content);
        }

        public T Post<T>(string url, string username, string password, bool isSecureConnection, object content, string soapAction = "", bool debug = false) where T : new()
        {
            T _result = new T();
            HttpResponseMessage response = null;
            var tsk = PostAsync(url, username, password, isSecureConnection, content, soapAction, debug).ContinueWith(x => { response = x.Result; });
            tsk.Wait();
            var respContent = response.Content.ReadAsStringAsync().Result;

            if (debug)
            {
                var folderPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\DHLDE_Debug";
                var filename = "Res-DHLde-" + DateTime.Now.ToString("yyyy-MM-dd") + "-" + Guid.NewGuid().ToString();
                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                var debugFilename = System.IO.Path.Combine(folderPath, filename);
                System.IO.File.WriteAllText(debugFilename, respContent);
            }

            return XMLService.Deserialize<T>(respContent);
        }
    }
}
