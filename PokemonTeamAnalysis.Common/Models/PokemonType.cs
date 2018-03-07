using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Common.Models
{
    public class PokemonType
    {
        public int Slot { get; set; }

        public NamedAPIResource<Type> Type { get; set; }
    }
}
