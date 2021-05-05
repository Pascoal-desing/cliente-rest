using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Rest.Models
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string name { get; set; }
        public string alpha2Code { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public string population { get; set; }
        public string area { get; set; }
        public string nativeName { get; set; }
        public string flag { get; set; }
        public IList<string> timezones { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;

        }
        public List<RestClient> makeRequest()
        {

            string strResponseValue = string.Empty;
            List<RestClient> results = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            if (request.ToString() != "The remote server returned an error: (404) Not Found.")
            {
                request.Method = httpMethod.ToString();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Ocorreu um erro " + response.StatusCode);
                    }
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                                results = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RestClient>>(strResponseValue);
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao conectar o servidor");
            }
            return results;
        }
    }
}
