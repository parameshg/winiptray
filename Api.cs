using System.Net;
using Newtonsoft.Json;

namespace WinIpTray
{
    public class Api
    {
        public string GetIpAddress()
        {
            var result = "127.0.0.1";

            try
            {
                var response = new WebClient().DownloadString("https://api.ipify.org/?format=json");

                dynamic json = JsonConvert.DeserializeObject<dynamic>(response);

                result = json.ip;
            }
            catch
            {
                result = "ERROR";
            }

            return result;
        }
    }
}