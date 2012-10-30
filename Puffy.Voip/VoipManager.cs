using System;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace Puffy.Voip
{
    public class VoipManager
    {
        public void CallTo(string destination)
        {
            const string phoneCallApiUrl
                = "https://www.{0}/myaccount/makecall.php?username={1}&password={2}&from={3}&to={4}";

            var settings = UserSettings.Instance;

            string requestUrl
                = string.Format(phoneCallApiUrl, settings.Provider, settings.Username,
                    settings.Password, settings.CallBackNumber, destination);

            var webRequest = (HttpWebRequest) WebRequest.Create(requestUrl);
            var webResponse = (HttpWebResponse) webRequest.GetResponse();

            Stream responseStream = webResponse.GetResponseStream();

            var serializer = new XmlSerializer(typeof(CallResponse));
            var response = (CallResponse) serializer.Deserialize(responseStream);

            if (response.Result != CallResult.Success)
                throw new VoipException(response.Description);
        }

    }
}
