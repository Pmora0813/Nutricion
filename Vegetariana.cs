using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Vegetariana : Dieta
    {
        public override string Descripcion
        {
            get
            {
                return "Vegetaria";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override List<string> Alimientos()
        {
            List<string> Alimentos = new List<string>();

            Alimentos.Add("Verduras");
            Alimentos.Add("Semillas");
            Alimentos.Add("Frutas");
            Alimentos.Add("Legumbres");

            return Alimentos;
        }
    }
}
