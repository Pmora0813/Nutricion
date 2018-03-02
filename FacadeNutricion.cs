using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                doc.LoadXml("<Nutricion></Nutricion>");

            }
            else
            {
                doc.Load(Ruta);
            }


            XmlElement root = doc.DocumentElement;

            XmlElement NodoClinica = doc.CreateElement("Clinica");
            NodoClinica.SetAttribute("Nombre", Clinica.Nombre.ToString());

            XmlElement NodoPaciente = doc.CreateElement("Paciente");
            NodoPaciente.SetAttribute("Nombre", Paciente.Nombre.ToString());
           // NodoPaciente.SetAttribute("Telefono", Paciente.Telefono.ToString());
           // NodoPaciente.SetAttribute("Edad", Paciente.Edad.ToString());
            NodoPaciente.SetAttribute("Genero", Paciente.Genero.ToString());
            NodoClinica.AppendChild(NodoPaciente);

            //XmlElement NodoConsulta = doc.CreateElement("CostoConsulta");
            //NodoConsulta.InnerText = Clinica.CalcularCosto().ToString();
            //NodoPaciente.AppendChild(NodoConsulta);

            XmlElement NodoIndiceMasaCorporal = doc.CreateElement("IndiceMasaCorporal");
            NodoIndiceMasaCorporal.InnerText = Paciente.CalcularIndiceMasaCorporal().ToString("0.000");
            NodoPaciente.AppendChild(NodoIndiceMasaCorporal);

            XmlElement NodoIndiceCircunferenciaAltura = doc.CreateElement("IndiceCircunferenciaAltura");
            NodoIndiceCircunferenciaAltura.InnerText = Paciente.CalcularIndiceCinturaAltura().ToString("0.000");
            NodoPaciente.AppendChild(NodoIndiceCircunferenciaAltura);

            XmlElement NodoIndiceMetabolicoBasal = doc.CreateElement("IndiceMetabolicoBasal");
            NodoIndiceMetabolicoBasal.InnerText = Paciente.CalcularIndiceMetabolicoBasal().ToString("0.000");
            NodoPaciente.AppendChild(NodoIndiceMetabolicoBasal);

            XmlElement NodoDieta = doc.CreateElement("Dieta");
            NodoDieta.SetAttribute("Clase", Paciente.ObtenerDieta().Descripcion.ToString());

            foreach (object item in Paciente.ObtenerDieta().Alimientos())
            {
                XmlElement NodoAlimentos = doc.CreateElement("Alimento");
                NodoAlimentos.InnerText = item.ToString();
                NodoDieta.AppendChild(NodoAlimentos);

            }
            NodoPaciente.AppendChild(NodoDieta);



            root.AppendChild(NodoClinica);


            // Salvar
            doc.Save(Ruta);
        }

        public string TransformXMLToHTML(string rutaXML)
        {
            // Transformación del XMl utilizando XSLT
            XslCompiledTransform myXslTrans = new XslCompiledTransform();
            // Carga en memoria la lectura xslt
            string rutaXslt = Application.StartupPath + "\\Xslt\\Nutricion.xslt";
            myXslTrans.Load(rutaXslt);
            // Transforma el archivo xml aun archivo HTML
            myXslTrans.Transform(rutaXML, "Clinica.html");

            return "Clinica.html";
        }
    }
}
