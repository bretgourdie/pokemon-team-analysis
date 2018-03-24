using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTeamAnalysis.Logic.Models;
using PokemonTeamAnalysis.Logic.Repositories;

namespace PokemonTeamAnalysis.CLIApp
{
    class PromptForPokemon
    {
        public static IList<Pokemon> PromptAndFindPokemon()
        {
            var inputPokemonList = getUserPokemonList();

            return getPokemonFromInput(inputPokemonList);
        }

        private static IList<string> getUserPokemonList()
        {
            Console.WriteLine("Enter the team, entering a blank line as the end.");

            var inputPokemonList = new List<string>();
            var input = "";

            do
            {
                input = Console.ReadLine();

                if (inputIsNotEnding(input))
                {
                    inputPokemonList.Add(input);
                }

            } while (inputIsNotEnding(input));

            return inputPokemonList;
        }

        private static IList<Pokemon> getPokemonFromInput(IList<string> inputPokemonList)
        {
            var pokemonList = new List<Pokemon>();

            string statusMessage = "Attempting to find {0} Pokemon(s)";
            Console.WriteLine(
                String.Format(statusMessage, inputPokemonList.Count)
            );

            var repo = new PokeApiRepository();

            foreach (var inputPokemon in inputPokemonList)
            {
                try
                {
                    const string lookingForMessage = "Looking for \"{0}\"...";
                    Console.WriteLine(
                        String.Format(lookingForMessage, inputPokemon)
                    );

                    var pokemon = repo.Get<Pokemon>(inputPokemon);
                    pokemonList.Add(pokemon);

                    const string foundMessage = "\tFound \"{0}\"!";
                    Console.WriteLine(
                        String.Format(foundMessage, pokemon.Name)
                    );
                }
                catch (ApplicationException ex)
                {
                    const string couldNotFindMessage = "\tCould not find \"{0}\"...";
                    Console.WriteLine(
                        String.Format(couldNotFindMessage, inputPokemon)
                    );
                }
            }

            return pokemonList;
        }

        private static bool inputIsNotEnding(string input)
        {
            return input.Trim() != "";
        }
    }
}
