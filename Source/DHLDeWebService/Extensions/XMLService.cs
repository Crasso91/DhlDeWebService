using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DHLDeWebService.Extensions
{
    public class XMLService
    {
        public static string Serialize(object _in)
        {
            var xmlserializer = new XmlSerializer(_in.GetType());
            var stringWriter = new StringWriter();

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("cis", "http://dhl.de/webservice/cisbase");
            ns.Add("bus", "http://dhl.de/webservices/businesscustomershipping");

            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true                
            };

            using (var writer = XmlWriter.Create(stringWriter, settings))
            {
                xmlserializer.Serialize(writer, _in, ns);
                return stringWriter.ToString();
            }
        }

        public static T Deserialize<T>(string _in)
        {
            var xmlserializer = new XmlSerializer(typeof(T));

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("soap", "http://schemas.xmlsoap.org/soap/envelope/");
            ns.Add("cis", "http://dhl.de/webservice/cisbase");
            ns.Add("bcs", "http://dhl.de/webservices/businesscustomershipping");
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            using (var reader = new StringReader(_in))
            {
                return (T)xmlserializer.Deserialize(reader);
            }
        }
    }
}
