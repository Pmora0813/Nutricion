using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    abstract class Paciente : IIndiceMetabolicoBasal
    {
        public double Cintura { get; set; }
        public int Edad
        {
            get
            {
                int annos = FechaNacimiento.Year;

                annos = DateTime.Now.Year - annos;
                if(DateTime.Now.Month < FechaNacimiento.Month)
                {
                    if (DateTime.Now.Day < FechaNacimiento.Day)
                    {
                        annos = annos - 1;
                    }
                }
                
                return annos;
            }
            
        }
        public float Estatura { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Generos Genero { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public long Telefono { get; set; }

        public double CalcularIndiceCinturaAltura()
        {
            double ICA = 0;
            ICA =  Cintura / Estatura;
            return ICA;
        }
        public double CalcularIndiceMasaCorporal()
        {
            double IMC = 0;
            IMC = Peso / ((Estatura/100) * (Estatura/100));
            return IMC;
        }

        public abstract double CalcularIndiceMetabolicoBasal();

        public abstract Dieta ObtenerDieta();

        
    }
}
