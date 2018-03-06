using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class TypePokemon : PokeApiModel
    {
        public int Slot { get; set; }

        public NamedAPIResource<Pokemon> Pokemon { get; set; }
    }
}
