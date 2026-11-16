using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormAgregar : Form
    {
        private Agenda agenda;

        public FormAgregar(Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa al menos el nombre del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente nuevo = new Cliente(txtNombre.Text, txtTelefono.Text, txtEmpresa.Text, txtEmail.Text);
            agenda.AgregarCliente(nuevo);

            MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmpresa.Clear();
            txtEmail.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu(agenda);
            menu.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}