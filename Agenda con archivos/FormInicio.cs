using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormInicio : Form
    {
        private Agenda agenda;

        public FormInicio()
        {
            InitializeComponent();
            agenda = new Agenda();

            if (agenda.CargarArchivo())
            {
                txtPropietario.Text = agenda.Propietario;
                txtTelefono.Text = agenda.TelPropietario;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPropietario.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor ingresa los datos del propietario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            agenda.Propietario = txtPropietario.Text.Trim();
            agenda.TelPropietario = txtTelefono.Text.Trim();
            agenda.GuardarArchivo();

            FormMenu menu = new FormMenu(agenda);
            menu.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}