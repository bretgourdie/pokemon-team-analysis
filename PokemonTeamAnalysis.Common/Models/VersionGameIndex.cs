﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Common.Models
{
    public class VersionGameIndex
    {
        public int GameIndex { get; set; }

        public NamedAPIResource<Version> Version { get; set; }
    }
}