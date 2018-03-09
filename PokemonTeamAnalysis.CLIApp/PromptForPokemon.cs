using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTeamAnalysis.Logic.Models;

namespace PokemonTeamAnalysis.CLIApp
{
    class PromptForPokemon
    {
        public IList<Pokemon> PromptAndFindPokemon()
        {
            var inputPokemonList = getUserPokemonList();

            return getPokemonFromInput(inputPokemonList);
        }

        private IList<string> getUserPokemonList()
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

        private IList<Pokemon> getPokemonFromInput(IList<string> inputPokemonList)
        {
            string statusMessage = "Attempting to find {0} Pokemon(s)";
            Console.WriteLine(
                String.Format(statusMessage, inputPokemonList.Count)
            );
        }

        private bool inputIsNotEnding(string input)
        {
            return input.Trim() != "";
        }
    }
}
