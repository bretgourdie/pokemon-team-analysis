using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class TypeRelations : PokeApiModel
    {
        public List<NamedAPIResource<Type>> NoDamageTo { get; set; }

        public List<NamedAPIResource<Type>> HalfDamageTo { get; set; }

        public List<NamedAPIResource<Type>> DoubleDamageTo { get; set; }

        public List<NamedAPIResource<Type>> NoDamageFrom { get; set; }

        public List<NamedAPIResource<Type>> HalfDamageFrom { get; set; }

        public List<NamedAPIResource<Type>> DoubleDamageFrom { get; set; }

    }
}
