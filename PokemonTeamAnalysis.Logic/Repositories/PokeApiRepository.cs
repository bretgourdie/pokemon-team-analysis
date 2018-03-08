using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using PokemonTeamAnalysis.Common.Models;

namespace PokemonTeamAnalysis.DataAccess.Repositories
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

            else if (response.ResponseStatus != ResponseStatus.Completed)
            {
                const string message = "Error transporting response. Check server status. ResponseStatus: {0}";
                var exception = new ApplicationException(String.Format(message, response.ResponseStatus));
                throw exception;
            }

            else if (!response.IsSuccessful)
            {
                const string message = "Request was not successful. Response status code: {0}";
                var exception = new ApplicationException(String.Format(message, response.StatusCode));
                throw exception;
            }

            return response.Data;
        }

        public T Get<T>(string sid) where T : PokeApiModel, new()
        {
            var request = new RestRequest();
            var instance = Activator.CreateInstance<T>();
            var resource = instance.ResourceName;
            request.Resource = resource + "/{" + resource + "Sid}/";
            request.AddParameter(resource + "Sid", sid.ToLower(), ParameterType.UrlSegment);

            return Execute<T>(request);
        }

        public T Get<T>(int id) where T : PokeApiModel, new()
        {
            return Get<T>(id.ToString());
        }

        public T Get<T>(Uri url) where T : new()
        {
            var request = new RestRequest(url);
            return Execute<T>(request);
        }
    }
}
