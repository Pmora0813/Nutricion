using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class FactoryClinica
    {
        public static IClinica CrearClinica(bool alfa, bool beta, bool gamma)
        {
            IClinica clinica = null;

            if (alfa)
            {
                clinica = new Alfa();
            }

            if (beta)
            {
                clinica = new Beta();
            }

            if (gamma)
            {
                clinica = new Gamma();
            }

            return clinica;
        }
    }
}
