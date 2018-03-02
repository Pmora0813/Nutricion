using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Alfa : IClinica
    {
        public string Nombre
        {
            get
            {
                return "Clinica Alfa";
            }
        }

        public double CalcularCosto()
        {
            return 20000;
        }
    }
}
