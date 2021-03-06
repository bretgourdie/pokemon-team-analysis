﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PokemonTeamAnalysis.Logic.Models
{
    public abstract class PokeApiModel
    {
        /// <summary>
        /// Takes a "best guess" at the resource name by inserting hyphens between upper-case.
        /// </summary>
        public virtual string ResourceName
        {
            get
            {
                return getClassNameAsResourceName();
            }
        }

        private string getClassNameAsResourceName()
        {
            var name = this.GetType().Name;
            return Regex.Replace(name, @"(?<!_|^)([A-Z])", "-$1").ToLower();
        }
    }
}
