using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class GenerationGameIndex
    {
        public int GameIndex { get; set; }

        public NamedAPIResource<Generation> Generation { get; set; }
    }
}
