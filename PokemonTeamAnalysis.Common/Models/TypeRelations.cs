using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class TypeRelations
    {
        public List<NamedAPIResource<Common.Models.Type>> NoDamageTo { get; set; }

        public List<NamedAPIResource<Common.Models.Type>> HalfDamageTo { get; set; }

        public List<NamedAPIResource<Common.Models.Type>> DoubleDamageTo { get; set; }

        public List<NamedAPIResource<Common.Models.Type>> NoDamageFrom { get; set; }

        public List<NamedAPIResource<Common.Models.Type>> HalfDamageFrom { get; set; }

        public List<NamedAPIResource<Common.Models.Type>> DoubleDamageFrom { get; set; }

    }
}
