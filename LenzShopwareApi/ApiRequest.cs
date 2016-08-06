using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Lenz.ShopwareApi
{
    public class ApiRequest
    {
        private String url;
        private RestSharp.Method method;
        private List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<string, string>>();
        private String body;

        public string Url
        {
            get
            {
                return url;
            }
        }

        public Method Method
        {
            get
            {
                return method;
            }
        }

        public List<KeyValuePair<string, string>> Parameters
        {
            get
            {
                return parameters;
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
        }

        public ApiRequest(String url, RestSharp.Method method)
        {
            this.url = url;
            this.method = method;
        }

        public void addParameter(string key, string value)
        {
            KeyValuePair<string, string> parameter = new KeyValuePair<string, string>(key, value);
            parameters.Add(parameter);
        }

        public void setBody(string body)
        {
            this.body = body;
        }
    }
}
