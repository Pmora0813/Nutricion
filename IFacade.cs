using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutricion
{
    interface IFacade
    {
        void AgregarClinica(IClinica clinica);
        void AgregarPaciente(Paciente paciente);
        void GuardarXML(string ruta);
        string TransformXMLToHTML(string ruta);
    }
}
