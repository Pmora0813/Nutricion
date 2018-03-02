using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    abstract class Dieta
    {
        public abstract string Descripcion { get; set; }
        public abstract List<string> Alimientos();
    }
}
