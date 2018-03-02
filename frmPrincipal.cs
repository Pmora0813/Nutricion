using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutricion
{
    public partial class frmPrincipal : Form
    {
        FacadeNutricion Nutricion = null;
        FactoryPaciente Paciente = null;
        public frmPrincipal()
        {
            InitializeComponent();
            llenarComboGenero();
            Nutricion = new FacadeNutricion();


        }

        private void llenarComboGenero()
        {
            cmbGenero.Items.Add(Generos.Femenino);
            cmbGenero.Items.Add(Generos.Masculino);
            cmbGenero.SelectedIndex = -1;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            IClinica Clinica = FactoryClinica.CrearClinica(rbtAlfa.Checked, rbtBeta.Checked, rbtGamma.Checked);
            if(Clinica == null)
            {
                MessageBox.Show("Seleccione la clinica de Preferencia");
                return;
            }
            Nutricion.AgregarClinica(Clinica);

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre");
                return;
            }

            if(mtxTelefono.Text.Length == 0)
            {
                 MessageBox.Show("Ingrese el Telefono");
                return;
            }

            if (cmbGenero.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un Genero");
                return;
            }
            Generos genero = (Generos)cmbGenero.SelectedItem;

            
            Paciente Paciente = FactoryPaciente.CrearPaciente(genero);
            

            Paciente.Nombre = txtNombre.Text.Trim();
            Paciente.Telefono = Convert.ToInt32(mtxTelefono.Text.Trim());
            Paciente.Genero = genero;

            Paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            //Paciente.GuardarEdad();
            Paciente.Peso = Convert.ToInt32(nudPeso.Value);
            Paciente.Estatura = Convert.ToInt32(nudEstatura.Value);
            Paciente.Cintura = Convert.ToInt32(nudCintura.Value);

            Nutricion.AgregarPaciente(Paciente);

            saveFileDialog.Filter = "Solo XML | *.xml";
            DialogResult resultado = saveFileDialog.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = saveFileDialog.FileName;

                Nutricion.GuardarXML(ruta);

                ruta = Nutricion.TransformXMLToHTML(ruta);

                //Le asignamos el HTML al web broser
                webBrowser.Url = new Uri(Application.StartupPath + "\\" + ruta);



            }
        }
    }
}

