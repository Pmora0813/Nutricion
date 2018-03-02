using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    class Mixta : Dieta
    {
        public override string Descripcion
        {
            get
            {
                return "Mixta";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override List<string> Alimientos()
        {
            List<string> Alimentos = new List<string>();

            Alimentos.Add("Carnes");
            Alimentos.Add("Vegetales");
            Alimentos.Add("Frutas");
            Alimentos.Add("Pescado");

            return Alimentos;
        }
    }
}
