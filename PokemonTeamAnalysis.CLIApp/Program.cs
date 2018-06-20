using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTeamAnalysis.Logic.Models;
using PokemonTeamAnalysis.Logic.Repositories;

namespace PokemonTeamAnalysis.CLIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemonList = promptForPokemon();

            if (isValidPokemonList(pokemonList))
            {
                var typeRelationsByPokemon = getTypesByPokemon(pokemonList);
            }
        }

        static IDictionary<Pokemon, IList<SingleType>> getTypesByPokemon(IList<Pokemon> pokemonList)
        {
            IDictionary<Pokemon, IList<SingleType>> typesByPokemon = new Dictionary<Pokemon, IList<SingleType>>();

            foreach (var pokemon in pokemonList)
            {
                var typesList = new List<SingleType>();

                foreach (var pokemonType in pokemon.Types)
                {
                    var singleType = pokemonType.Type.Content;

                    typesList.Add(singleType);
                }

                typesByPokemon[pokemon] = typesList;
            }

            return typesByPokemon;
        }

        static bool isValidPokemonList(IList<Pokemon> pokemonList)
        {
            return pokemonList != null && pokemonList.Count > 0;
        }

        static IList<Pokemon> promptForPokemon()
        {
            return PromptForPokemon.PromptAndFindPokemon();
        }
    }
}
