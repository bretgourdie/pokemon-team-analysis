using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public abstract class PokeApiModel
    {
        public virtual string ResourceName
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
