using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Gamma : IClinica
    {
        public string Nombre
        {
            get
            {
                return "Clinica Gamma";
            }
        }

        public double CalcularCosto()
        {
            return 30000;
        }
    }
}
