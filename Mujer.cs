using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Mujer : Paciente
    {

        public override double CalcularIndiceMetabolicoBasal()
        {
            double IMB = 0;

            IMB = 655 + (9.6 * base.Peso) + (1.8 * base.Estatura) + (4.7 * base.Edad);
            return IMB;
        }

        public override Dieta ObtenerDieta()
        {
            Dieta Dieta = null;
            double IMB = CalcularIndiceMetabolicoBasal();
            if (IMB <= 1000)
            {
                Dieta = new Mixta();
            }
            else
            {
                if (IMB > 1000 && IMB <= 1500)
                {
                    Dieta = new Proteica();
                }
                else
                {
                    if (IMB > 1500)
                    {
                        Dieta = new Vegetariana();
                    }
                }
            }

            return Dieta;

        }
    }
}
