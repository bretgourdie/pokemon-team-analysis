using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class PokemonType
    {
        public int Slot { get; set; }

        public NamedAPIResource<SingleType> Type { get; set; }
    }
}
