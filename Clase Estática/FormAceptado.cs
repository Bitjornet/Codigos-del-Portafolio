using Prestamos;
using System;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class FormAceptado : Form
    {
        public FormAceptado()
        {
            InitializeComponent();
        }

        private void FormAceptado_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre: " + DatosGlobales.T.Nombre;
            lblNumTrabajador.Text = "No. de trabajador: " + DatosGlobales.T.NumTrabajador.ToString();

            lblMensualidad.Text = "La cantidad mensual a pagar es: $" + DatosGlobales.T.Prestamo.Mensualidad.ToString("0.00");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}