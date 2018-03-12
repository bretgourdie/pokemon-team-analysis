using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class PokemonType
    {
        public int Id { get; set; }

        public int Slot { get; set; }

        public int PokemonId { get; set; }

        public int SingleTypeId { get; set; }

        public virtual NamedAPIResource<SingleType> Type { get; set; }
    }
}
