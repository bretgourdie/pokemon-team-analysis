using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonTeamAnalysis.Common.Models;
using PokemonTeamAnalysis.DataAccess.Repositories.PokeApi;

namespace PokemonTeamAnalysis.CLIApp
{
    class Program
    {
        static void Main(string[] args)
        {
            testProgram();
        }

        static void testProgram()
        {
            var repo = new PokeApiRepository();

            var entity = repo.Get<Pokemon>("Diglet");
        }
    }
}
