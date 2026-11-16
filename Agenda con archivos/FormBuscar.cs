using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormBuscar : Form
    {
        private Agenda agenda;
        private string clienteEncontradoNombre = "";

        public FormBuscar(Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtNombreBuscar.Text.Trim();
            Cliente? cli = agenda.BuscarCliente(criterio);

            if (cli != null)
            {
                txtNombre.Text = cli.Nombre;
                txtTelefono.Text = cli.TelefonoCli;
                txtEmpresa.Text = cli.Empresa;
                txtEmail.Text = cli.Email;
                clienteEncontradoNombre = cli.Nombre;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteEncontradoNombre))
            {
                MessageBox.Show("Primero debes buscar un cliente para actualizar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exito = agenda.ActualizarCliente(clienteEncontradoNombre, txtNombre.Text, txtTelefono.Text, txtEmpresa.Text, txtEmail.Text);
            if (exito)
            {
                MessageBox.Show("Cliente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clienteEncontradoNombre = txtNombre.Text;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteEncontradoNombre))
            {
                MessageBox.Show("Primero debes buscar un cliente para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Seguro que deseas eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                agenda.EliminarCliente(clienteEncontradoNombre);
                MessageBox.Show("Cliente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreBuscar.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmpresa.Clear();
            txtEmail.Clear();
            clienteEncontradoNombre = "";
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