using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPropietario.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor ingresa los datos del propietario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Agenda agenda = new Agenda(txtPropietario.Text, txtTelefono.Text, new System.Collections.ArrayList());
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