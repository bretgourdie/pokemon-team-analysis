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
                var typeRelationsByPokemon = getTypeRelationsByPokemon(pokemonList);
            }
        }

        static IDictionary<Pokemon, IList<TypeRelations>> getTypeRelationsByPokemon(IList<Pokemon> pokemonList)
        {
            IDictionary<Pokemon, IList<TypeRelations>> typeRelationsByPokemon = new Dictionary<Pokemon, IList<TypeRelations>>();

            foreach (var pokemon in pokemonList)
            {
                var typeRelationsList = new List<TypeRelations>();

                foreach (var pokemonType in pokemon.Types)
                {
                    var singleType = pokemonType.Type.Content;

                    var damageRelations = singleType.DamageRelations;

                    typeRelationsList.Add(damageRelations);
                }

                typeRelationsByPokemon[pokemon] = typeRelationsList;
            }

            return typeRelationsByPokemon;
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
