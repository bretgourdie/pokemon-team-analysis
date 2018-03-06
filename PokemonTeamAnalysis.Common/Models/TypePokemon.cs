using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Common.Models
{
    public class TypePokemon
    {
        public int Slot { get; set; }

        public NamedAPIResource<Pokemon> Pokemon { get; set; }
    }
}
