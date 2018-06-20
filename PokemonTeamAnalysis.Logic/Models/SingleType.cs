using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace PokemonTeamAnalysis.Logic.Models
{
    [DeserializeAs(Name = "Type")]
    public class SingleType : PokeApiModel
    {
        // TODO: Make this readable
        public override string ResourceName => ((DeserializeAsAttribute)Attribute.GetCustomAttribute(this.GetType(), typeof(DeserializeAsAttribute))).Name.ToLower();

        public int Id { get; set; }

        public string Name { get; set; }

        public int TypeRelationsId { get; set; }

        public virtual TypeRelations DamageRelations { get; set; }

        public List<GenerationGameIndex> GameIndices { get; set; }

        public NamedAPIResource<Generation> Generation { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
