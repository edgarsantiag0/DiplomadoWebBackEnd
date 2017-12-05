using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsProject
{
    public partial class WebFormEmpleado : System.Web.UI.Page
    {

        static List<Estudiante> listaEstudiantes = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelHora.Text = DateTime.Now.ToShortTimeString();

            //listaEstudiantes = new List<Estudiante>();

            //List<Estudiante> listaEstudiantes = new List<Estudiante>()
            //{
            //    new Estudiante() { Nombre = "Edgar", Matricula = "2008-0664" },
            //    new Estudiante() {  Nombre = "Josue", Matricula = "2008-0864" },
            //    new Estudiante() { Nombre = "Marcos", Matricula = "2008-0764" },
            //};

            //GridViewListaEstudiantes.DataSource = listaEstudiantes;
            ////GridViewListaEstudiantes.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text;
            string apellido = TextBoxApellido.Text;
            string fecha = TextBoxFecha.Text;

            string curso = DropDownListCursos.SelectedValue;

            string mensaje = string.Format("{0} {1} {2} {3}", nombre, apellido, fecha, curso);

            LabelMensajeSalida.Text = mensaje;

            Estudiante nuevoEstudiante = new Estudiante();

            nuevoEstudiante.Nombre = nombre;
            nuevoEstudiante.Matricula = apellido;


          //  listaEstudiantes.RemoveAt(1);



            listaEstudiantes.Add(nuevoEstudiante);

           

            GridViewListaEstudiantes.DataSource = listaEstudiantes;
            GridViewListaEstudiantes.DataBind();
        }
    }

    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }


    }
}