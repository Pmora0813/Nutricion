using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class FactoryPaciente
    {
        public static Paciente CrearPaciente(Generos genero)
        {
            Paciente Paciente = null;

            switch (genero)
            {
                case Generos.Masculino:

                    Paciente = new Hombre();
                    break;

                case Generos.Femenino:

                    Paciente = new Mujer();
                    break;

            }

            return Paciente;
        }
    }
}
