using DHLDeWebService.Attributes;
using DHLDeWebService.Entities;
using DHLDeWebService.Entities.Request.Abstract;
using DHLDeWebService.Entities.Request.Concrete;
using DHLDeWebService.Entities.Response.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DHLDeWebService
{
    /// <summary>
    /// Client to communicate with DHL De WS (SOAP).
    /// The client validate all request prior to send those to the server, it raises ValidationException if isn't valid.
    
    /// </summary>
    public class DHLDeService : HttpCom.HttpComunicationService
    {
        public string UserID { get; set; }
        public string UserSingature { get; set; }
        public string Endpoint { get; set; }
        public string DeveloperID { get; set; }
        public string EportalPassword { get; set; }
        public bool Debug { get; set; }
        private List<ValidationResult> ValidationExceptions = new List<ValidationResult>();

        public DHLDeService()
        {
        }
        /// <summary>
        /// Simple client Constructor
        /// </summary>
        /// <param name="userID">
        /// sendbox: developername
        /// production: eportal username</param>
        /// <param name="userSingature">
        /// sandbox: account password 
        /// production: eportal password</param>
        /// <param name="endpoint">
        /// sandbox: https://cig.dhl.de/services/sandbox/soap
        /// production: https://cig.dhl.de/services/sandbox/rest
        /// </param>
        /// <param name="developerID"> 
        /// sandbox: developer username
        /// production: application id</param>
        /// <param name="eportalPassword">
        /// sandbox: developer password
        /// production: application token
        /// </param>
        /// <param name="debug">
        /// If you set this parameter to true the request and response are saved in assembly location inside the DHLDE_Debug folder (auto-generated)
        /// </param>
        public DHLDeService(string userID, string userSingature, string endpoint, string developerID, string eportalPassword, bool debug = false)
        {
            UserID = userID ?? throw new ArgumentNullException(nameof(userID));
            UserSingature = userSingature ?? throw new ArgumentNullException(nameof(userSingature));
            Endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            DeveloperID = developerID ?? throw new ArgumentNullException(nameof(developerID));
            EportalPassword = eportalPassword ?? throw new ArgumentNullException(nameof(eportalPassword));
            Debug = debug;
        }

        private T Send<T>(IDHLRequest Request) where T : new()
        {
            ValidationContext context = new ValidationContext(Request, null, null);
            var isValid = Validator.TryValidateObject(Request, context, ValidationExceptions, true);
            if (!isValid)
            {
                throw new ValidationException();
            }
            else
                return this.Post<T>(Endpoint, DeveloperID, EportalPassword, Endpoint.Contains("https"), Request, Request.Header.SOAPAction, Debug);
        }
        /// <summary>
        /// Returns WEb service version
        /// </summary>
        /// <returns>Response</returns>
        public DHLGetVersionResponse GetVersion()
        {
            var request = new DHLRequest<DHLGetVersionRequest>();
            return this.Send<DHLResponse<DHLGetVersionResponse>>(request).Body;
        }
        /// <summary>
        /// Method to request a pick
        /// </summary>
        /// <param name="_req">Request</param>
        /// <returns>Response</returns>
        public DHLCreateShipmentOrderResponse CreateShipmentOrder(DHLCreateShipmentOrderRequest _req) 
        {
            var _reqWrapper = GetRequest<DHLCreateShipmentOrderRequest>();
            _reqWrapper.Header.SOAPAction = "urn:createShipmentOrder";
            _reqWrapper.Body = _req;
            var _response = this.Send<DHLResponse<DHLCreateShipmentOrderResponse>>(_reqWrapper);
            var body = _response?.Body;
            
            return body;
        }
        /// <summary>
        /// Method to update a pick
        /// </summary>
        /// <param name="_req">Request</param>
        /// <returns>Response</returns>
        public DHLUpdateShipmentOrderResponse UpdateShipmentOrder(DHLUpdateShipmentOrderRequest _req)
        {
            var _reqWrapper = GetRequest<DHLUpdateShipmentOrderRequest>();
            _reqWrapper.Header.SOAPAction = "urn:updateShipmentOrder";
            _reqWrapper.Body = _req;
            var _response = this.Send<DHLResponse<DHLUpdateShipmentOrderResponse>>(_reqWrapper);
            var body = _response.Body;
            return body;
        }
        /// <summary>
        /// Method to update a pick
        /// </summary>
        /// <param name="_req">Request</param>
        /// <returns>Response</returns>
        public DHLDeleteShipmentOrderResponse DeleteShipmentOrder(DHLDeleteShipmentOrderRequest _req)
        {
            var _reqWrapper = GetRequest<DHLDeleteShipmentOrderRequest>();
            _reqWrapper.Header.SOAPAction = "urn:deleteShipmentOrder";
            _reqWrapper.Body = _req;
            var _response = this.Send<DHLResponse<DHLDeleteShipmentOrderResponse>>(_reqWrapper);
            var body = _response.Body;
            return body;
        }
        /// <summary>
        /// Method to update a pick
        /// </summary>
        /// <param name="_req">Request</param>
        /// <returns>Response</returns>
        public DHLGetLabelResponse GetLabel(DHLGetLabelRequest _req)
        {
            var _reqWrapper = GetRequest<DHLGetLabelRequest>();
            _reqWrapper.Header.SOAPAction = "urn:getLabel";
            _reqWrapper.Body = _req;
            var _response = this.Send<DHLResponse<DHLGetLabelResponse>>(_reqWrapper);
            var body = _response.Body;
            return body;
        }
        /// <summary>
        /// By this method you can invoke every operation that you need 
        /// </summary>
        /// <typeparam name="T">The body of the response</typeparam>
        /// <typeparam name="T1">The body of the request</typeparam>
        /// <param name="_req">Request</param>
        /// <param name="soapAction">The action that you are excecuting, not necessary for testing
        /// Ex: "urn:getLabel"
        /// </param>
        /// <returns>Response</returns>
        public T Invoke<T,T1>(T1 _req, string soapAction = "")
            where T : new()
            where T1 : new()
        {
            var _reqWrapper = GetRequest<T1>();
            _reqWrapper.Header.SOAPAction = soapAction;
            _reqWrapper.Body = _req;
            return this.Send<DHLResponse<T>>(_reqWrapper).Body;
        }
        private DHLRequest<T> GetRequest<T>() where T : new()
        {
            var _req = new DHLRequest<T>();
            if (_req.Header == null)
                _req.Header = new Entities.Misc.DHLHeader();
            if (_req.Header.Authentification == null)
                _req.Header.Authentification = new Entities.Misc.Authentification();
            if (string.IsNullOrEmpty(_req.Header.Authentification.user))
                _req.Header.Authentification.user = UserID;
            if (string.IsNullOrEmpty(_req.Header.Authentification.signature))
                _req.Header.Authentification.signature = UserSingature;
            return _req;
        }
        /// <summary>
        /// Every time you try to send a request the client try to validate. 
        /// By this method you can get all the exception caused by invalid input in request when the client raise a ValidationException
        /// </summary>
        /// <returns>A list of string containings all validation errors</returns>
        public List<string> GetValidationErrors()
        {
            var validationErrors = new List<string>();
            ValidationExceptions.ForEach(x => {
                validationErrors.AddRange(((CompositeValidationResult)x).GetErrors());
            });
            return validationErrors;
        }
    }
}
