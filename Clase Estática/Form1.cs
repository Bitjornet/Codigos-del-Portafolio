using Prestamos;
using System;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosGlobales.T.Nombre = txtNombre.Text;
                DatosGlobales.T.NumTrabajador = Convert.ToInt32(txtNumTrabajador.Text);
                DatosGlobales.T.Salario = Convert.ToSingle(txtSueldo.Text);

                DatosGlobales.T.Prestamo.Cantidad = Convert.ToSingle(txtCantidad.Text);
                DatosGlobales.T.Prestamo.Plazo = Convert.ToInt32(cmbPlazo.SelectedItem);

                DatosGlobales.T.Prestamo.CalculaMens();
                bool esAprobado = DatosGlobales.T.Prestamo.EvaluaCred(DatosGlobales.T.Salario);

                if (esAprobado)
                {
                    FormAceptado formAceptado = new FormAceptado();
                    formAceptado.Show();
                }
                else
                {
                    FormNoAceptado formRechazado = new FormNoAceptado();
                    formRechazado.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Asegúrate de llenar todos los campos con números y elegir un plazo.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmbPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}