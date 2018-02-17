using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Version
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Name> Names { get; set; }

        public NamedAPIResource<VersionGroup> VersionGroup { get; set; }
    }
}
