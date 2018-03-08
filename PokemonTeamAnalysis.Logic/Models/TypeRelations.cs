using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class TypeRelations
    {
        public List<NamedAPIResource<SingleType>> NoDamageTo { get; set; }

        public List<NamedAPIResource<SingleType>> HalfDamageTo { get; set; }

        public List<NamedAPIResource<SingleType>> DoubleDamageTo { get; set; }

        public List<NamedAPIResource<SingleType>> NoDamageFrom { get; set; }

        public List<NamedAPIResource<SingleType>> HalfDamageFrom { get; set; }

        public List<NamedAPIResource<SingleType>> DoubleDamageFrom { get; set; }

    }
}
