using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Beta : IClinica
    {
        public string Nombre
        {
            get
            {
                return "Clinica Beta";
            }
        }

        public double CalcularCosto()
        {
            return 25000;
        }
    }
}
