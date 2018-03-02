using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    interface IClinica
    {
        string Nombre { get;  }
        double CalcularCosto();
    }
}
