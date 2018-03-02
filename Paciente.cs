using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    abstract class Paciente
    {
        public double Cintura { get; set; }
        public int Edad { get; }
        public float Estatura { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Generos Genero { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public long Telefono { get; set; }

        public abstract double CalcularIndiceCinturaAltura();
        public abstract double CalcularIndiceMasaCorporal();
        public abstract double CalcularIndiceMetabolismoBasal();
        public abstract Dieta ObtenerDieta();
    }
}
