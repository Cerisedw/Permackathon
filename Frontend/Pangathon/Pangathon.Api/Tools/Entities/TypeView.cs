using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools.Entities
{
    public class TypeView
    {

        private string _nom;
        private TypeView _parent;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public TypeView Parent
        {
            get
            {
                return _parent;
            }

            set
            {
                _parent = value;
            }
        }
    }
}
