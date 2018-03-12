using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class Pokemon : PokeApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public virtual List<PokemonType> Types { get; set; }

        public virtual List<VersionGameIndex> GameIndices { get; set; }
    }
}
