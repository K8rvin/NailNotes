using Flurl.Http;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace LizokasNail.Http
{
    public abstract class ServiceBase
    {
        protected ServiceBase()
        {
            Url = GetUrl();
            //FlurlHttp.Configure(s => s.OnErrorAsync = HandleFlurlErrorAsync);
            FlurlHttp.Configure(x=>x.AllowedHttpStatusRange = "404,409");
            FlurlHttp.Configure(x => x.OnError = HandleFlurlError);
        }

        private void HandleFlurlError(HttpCall call)
        {
            call.ExceptionHandled = true;
            switch (call.HttpStatus)
            {
                case System.Net.HttpStatusCode.Conflict:
                    var message = ((FlurlHttpException)call.Exception).GetResponseStringAsync().Result;
                    Console.WriteLine($"status: {call.HttpStatus}. message: {message}");
                    break;                
                default:
                    call.ExceptionHandled = false;
                    break;
            }
        }

        private const string DefaultUrl = "http://localhost:44357/api/";

        protected string Url { get; }

        private static string GetUrl()
        {
            try
            {
                return ConfigurationManager.AppSettings.Get("apiUrl");
            }
            catch
            {
                return DefaultUrl;
            }

        }
    }
}
