﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Logic.Models
{
    public class VersionGroup : PokeApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public NamedAPIResource<Generation> Generation { get; set; }

        public List<NamedAPIResource<GameVersion>> Versions { get; set; }
    }
}
