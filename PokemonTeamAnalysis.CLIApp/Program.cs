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
            // Pokemon
            // - PokemonType
            //   - SingleType
            //     - TypeRelations
            //       - SingleType
            //       - etc.
        }

        static IList<Pokemon> promptForPokemon()
        {
            return PromptForPokemon.PromptAndFindPokemon();
        }
    }
}
