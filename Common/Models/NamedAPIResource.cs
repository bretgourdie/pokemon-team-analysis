using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class NamedAPIResource<T> where T : new()
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public T Content
        {
            get
            {
                if (_t == null)
                {
                    _t = getContent();
                }

                return _t;
            }
        }

        private T _t { get; set; }

        public NamedAPIResource()
        {

        }

        protected T getContent()
        {
            throw new NotImplementedException();
        }
    }
}
