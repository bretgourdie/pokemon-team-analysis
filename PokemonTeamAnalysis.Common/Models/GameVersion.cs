using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace PokemonTeamAnalysis.Common.Models
{
    [DeserializeAs(Name = "Version")]
    public class GameVersion : PokeApiModel
    {
        // TODO: Make this readable
        public override string ResourceName => ((DeserializeAsAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(DeserializeAsAttribute))).Name.ToLower();

        public int Id { get; set; }

        public string Name { get; set; }

        public NamedAPIResource<VersionGroup> VersionGroup { get; set; }
    }
}
