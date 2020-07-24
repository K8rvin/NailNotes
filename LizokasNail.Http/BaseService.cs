using System;
using System.Configuration;

namespace LizokasNail.Http
{
    public abstract class BaseService
    {
        protected BaseService()
        {
            Url = GetUrl();
            //FlurlHttp.Configure(s => s.OnErrorAsync = HandleFlurlErrorAsync);
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
