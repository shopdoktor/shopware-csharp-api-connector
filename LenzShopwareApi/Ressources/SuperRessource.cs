using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Lenz.ShopwareApi.Ressources
{
    public abstract class SuperRessource<TResponse>
    {
        protected String ressourceUrl;

        protected IRestClient client { get; set; }

        public SuperRessource(IRestClient client) {
            this.client = client;
        }

        public TResponse get(int id)
        {
            try
            {
                return this.get(id.ToString());
            }
            catch (Exception e)
            {
                // Pass exception to next level.
                throw e;
            }
        }

        public TResponse get(string id)
        {
            ApiResponse<TResponse> response = convertResponseStringToObject<TResponse>(this.executeGet(id));
            if (!response.success)
            {
                throw new Exception(response.message);
            }
            return response.data;
        }

        public List<TResponse> getAll()
        {
            ApiResponse<List<TResponse>> response = convertResponseStringToObject<List<TResponse>>(executeGetAll());
            if(!response.success)
            {
                throw new Exception(response.message);
            }
            return response.data;
        }

        public void add(TResponse data)
        {
            String response = this.executeAdd(data);
        }

        protected String executeAdd(TResponse data)
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine(json);
            return this.execute(this.ressourceUrl, Method.POST, null, json);
        }

        public void update(TResponse data)
        {
            String response = this.executeUpdate(data, "");
        }

        protected String executeUpdate(TResponse data, String id)
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine(json);

            // set id.
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<String, String>>();
            parameters.Add(new KeyValuePair<String, String>("id", id));
            return this.execute(this.ressourceUrl + "/{id}", Method.PUT, parameters, json);
        }

        public void delete(string id)
        {
            string response = this.executeDelete(id);
        }

        protected String executeDelete(string id)
        {
            // set id.
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<String, String>>();
            parameters.Add(new KeyValuePair<String, String>("id", id));
            String response = this.execute(this.ressourceUrl + "/{id}", Method.DELETE, parameters);
            return response;
        }

        protected ApiResponse<A> convertResponseStringToObject<A>(string responseString)
        {
            return JsonConvert.DeserializeObject<ApiResponse<A>>(responseString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        protected String executeGet(string id)
        {
            // set id.
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<String, String>>();
            parameters.Add(new KeyValuePair<String, String>("id", id));
            String response = this.execute(this.ressourceUrl + "/{id}", Method.GET, parameters);
            return response;
        }

        protected String executeGetAll()
        {
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<String, String>>();

            return this.execute(this.ressourceUrl, Method.GET, parameters);
        }

        private String execute(string ressource, RestSharp.Method method, List<KeyValuePair<String, String>> parameters)
        {
            return execute(ressource, method, parameters, "");
        }

        private String execute(ApiRequest request)
        {

            return "";
        }

        private String execute(string ressource, RestSharp.Method method, List<KeyValuePair<String, String>> parameters, String body)
        {
            var request = new RestRequest(ressource, method);
            request.RequestFormat = DataFormat.Json;

            if (parameters != null)
            {
                foreach (KeyValuePair<String, String> parameter in parameters)
                {
                    request.AddUrlSegment(parameter.Key, parameter.Value); // replaces matching token in request.Resource
                }
            }

            // send body if it is available
            request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);

            // execute the request
            IRestResponse response = client.Execute(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine("Api Error:");
                Debug.WriteLine(response.ErrorException.Message);
            }
            else
            {
                string content = response.Content; // raw content as string
                Debug.WriteLine(content);
                return content;
            }
            return "failed";
        }
    }
}
