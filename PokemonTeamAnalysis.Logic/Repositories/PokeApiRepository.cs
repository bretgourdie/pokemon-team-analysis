using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using PokemonTeamAnalysis.Logic.Models;

namespace PokemonTeamAnalysis.Logic.Repositories
{
    public class PokeApiRepository
    {
        //const string baseUrl = "https://pokeapi.co/api/v2/";
        const string baseUrl = "https://pokeapi.co/";

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient(baseUrl);

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
            const string versionPrefix = "api/v2";
            var request = new RestRequest();
            var instance = Activator.CreateInstance<T>();
            var resource = versionPrefix + "/" + instance.ResourceName;
            request.Resource = resource + "/{" + resource + "Sid}/";
            request.AddParameter(resource + "Sid", sid.ToLower(), ParameterType.UrlSegment);

            return Execute<T>(request);
        }

        public T Get<T>(int id) where T : PokeApiModel, new()
        {
            return Get<T>(id.ToString());
        }

        public T Get<T>(Uri uri) where T : new()
        {
            var request = new RestRequest(uri);
            return Execute<T>(request);
        }
    }
}
