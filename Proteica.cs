using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Proteica : Dieta
    {
        public override string Descripcion
        {
            get
            {
                return "Proteica";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override List<string> Alimientos()
        {
            List<string> Alimentos = new List<string>();

            Alimentos.Add("Mariscos");
            Alimentos.Add("Cerdo");
            Alimentos.Add("Aves");
            Alimentos.Add("Carnes Rojas");

            return Alimentos;
        }
    }
}
