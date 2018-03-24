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
                processPokemonList(pokemonList);
            }
        }

        static void processPokemonList(IList<Pokemon> pokemonList)
        {
            foreach (var pokemon in pokemonList)
            {
                foreach (var pokemonType in pokemon.Types)
                {
                    var singleType = pokemonType.Type.Content;


                }
            }
            // Pokemon
            // - PokemonType
            //   - SingleType
            //     - TypeRelations
            //       - SingleType
            //       - etc.
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
