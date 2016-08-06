using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenz.ShopwareApi
{
    public class ApiRequestExecutor
    {
        public ApiResponse<TResponse> execute<TResponse>(IRestClient client, ApiRequest apiRequest)
        {
            var restRequest = new RestRequest(apiRequest.Url, apiRequest.Method);
            restRequest.RequestFormat = DataFormat.Json;

            if (apiRequest.Parameters != null)
            {
                foreach (KeyValuePair<String, String> parameter in apiRequest.Parameters)
                {
                    restRequest.AddUrlSegment(parameter.Key, parameter.Value); // replaces matching token in request.Resource
                }
            }

            // send body if it is available
            restRequest.AddParameter("application/json; charset=utf-8", apiRequest.Body, ParameterType.RequestBody);

            // execute the request
            IRestResponse response = client.Execute(restRequest);

            if (response.ErrorException != null)
            {
                Debug.WriteLine("Api Error:");
                Debug.WriteLine(response.ErrorException.Message);
            }
            else
            {
                string content = response.Content; // raw content as string
                Debug.WriteLine(content);

                ApiResponse<TResponse> apiResponse = this.convertResponseStringToObject<TResponse>(content);

                return apiResponse;
            }
            return null;
        }

        private ApiResponse<A> convertResponseStringToObject<A>(string responseString)
        {
            return JsonConvert.DeserializeObject<ApiResponse<A>>(responseString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
