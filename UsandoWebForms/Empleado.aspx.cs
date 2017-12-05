using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsandoWebForms
{
    public partial class Empleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LabelHora.Text = DateTime.Now.ToShortTimeString();

        }

        protected void ButtonEnviar_Click(object sender, EventArgs e)
        {

            string primerNombre = TextBoxPrimerNombre.Text;
            string apellido = TextBoxApellido.Text;

            string fechaNacimiento = TextBoxFechaNacimiento.Text;

            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = 


            LabelDatosSalida.Text = primerNombre + " " + apellido + " " + fechaNacimiento;

        }

        protected void ApellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}