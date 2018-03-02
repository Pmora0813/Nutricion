using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Hombre : Paciente, IIndiceMetabolicoBasal
    {
        public Paciente paciente;

        public override double CalcularIndiceCinturaAltura()
        {
            return paciente.Cintura * paciente.Estatura;
        }

        public override double CalcularIndiceMasaCorporal()
        {
            return paciente.Peso * ()
        }

        public double CalcularIndiceMetabolicoBasal()
        {
            throw new NotImplementedException();
        }

        public override double CalcularIndiceMetabolismoBasal()
        {
            throw new NotImplementedException();
        }

        public override Dieta ObtenerDieta()
        {
            throw new NotImplementedException();
        }
    }
}