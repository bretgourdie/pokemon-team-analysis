using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Type : PokeApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TypeRelations TypeRelations { get; set; }

        public List<GenerationGameIndex> Game_Indices { get; set; }

        public NamedAPIResource<Generation> Generation { get; set; }

    }
}
