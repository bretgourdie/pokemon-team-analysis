﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public List<PokemonType> Types { get; set; }

        public List<VersionGameIndex> GameIndices { get; set; }
    }
}