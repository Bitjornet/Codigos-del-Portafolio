using System;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FormNoAceptado : Form
    {
        public FormNoAceptado()
        {
            InitializeComponent();
        }

        private void FormNoAceptado_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + DatosGlobales.T.Nombre;
            lblNumTrabajador.Text = "No. de trabajador: " + DatosGlobales.T.NumTrabajador.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}