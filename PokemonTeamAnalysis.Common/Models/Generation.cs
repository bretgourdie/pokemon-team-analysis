﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTeamAnalysis.Common.Models
{
    public class Generation : PokeApiModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}