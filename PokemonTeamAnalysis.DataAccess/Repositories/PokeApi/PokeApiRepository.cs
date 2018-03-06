using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace DataAccess.Repositories.PokeApi
{
    public class PokeApiRepository
    {
        const string BaseUrl = "http://pokeapi.co/api/v2/";

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new System.Uri(BaseUrl);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more information.";
                var exception = new ApplicationException(message, response.ErrorException);
                throw exception;
            }

            return response.Data;
        }

        public T GetByName<T>(string resource, string sid) where T : new()
        {
            var request = new RestRequest();
            request.Resource = resource + "/{" + resource + "Sid}/";
            request.AddParameter(resource + "Sid", sid, ParameterType.UrlSegment);

            return Execute<T>(request);
        }

        public T GetById<T>(string resource, int id) where T : new()
        {
            return GetByName<T>(resource, id.ToString());
        }

        public T GetByUrl<T>(string url) where T : new()
        {
            var request = new RestRequest(new Uri(url));
            return Execute<T>(request);
        }
    }
}
