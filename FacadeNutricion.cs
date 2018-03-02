using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;

namespace Nutricion
{
    class FacadeNutricion : IFacade
    {
        public IClinica Clinica;
        public Paciente Paciente;

        public void AgregarClinica(IClinica clinica)
        {
            this.Clinica = clinica;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            this.Paciente = paciente;
        }

        public void GuardarXML(string Ruta)
        {
            XmlDocument doc = new XmlDocument();

            if (File.Exists(Ruta) == false)
            {
                doc.LoadXml("<Facturas></Facturas>");

            }
            else
            {
                doc.Load(Ruta);
            }


            XmlElement root = doc.DocumentElement;

            XmlElement NodoFactura = doc.CreateElement("Factura");
            //NodoFactura.SetAttribute("Numero", Numfactura().ToString());         

            // NodoCliente.SetAttribute("Telefono", Cliente.Telefono.ToString());



            root.AppendChild(NodoFactura);


            // Salvar
            doc.Save(Ruta);
        }

        public string TransformXMLToHTML(string rutaXML)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            myXslTrans.Load("\\Xslt\\Nutricion.xslt");
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, "Clinica.html");

            return "Clinica.html";
        }
    }
}
