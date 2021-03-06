﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Hombre : Paciente
    {


        public override double CalcularIndiceMetabolicoBasal()
        {

            double IMB = 0;

            IMB = 66 + (13.7 * base.Peso) + (5 * base.Estatura) + (6.8 * base.Edad);
            return IMB;
        }

        public override Dieta ObtenerDieta()
        {
            Dieta Dieta = null;
            double IMB = CalcularIndiceMetabolicoBasal();
            if (IMB <= 1700)
            {
                Dieta = new Mixta();
            }
            else
            {
                if (IMB > 1700 && IMB <= 2000)
                {
                    Dieta = new Proteica();
                }
                else
                {
                    if (IMB > 2000)
                    {
                        Dieta = new Vegetariana();
                    }
                }
            }

            return Dieta;

        }
    }
}