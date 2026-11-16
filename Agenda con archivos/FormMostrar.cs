using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormMostrar : Form
    {
        private Agenda agenda;

        public FormMostrar(Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("colNombre", "Nombre");
            dgvClientes.Columns.Add("colTelefono", "Teléfono");
            dgvClientes.Columns.Add("colEmpresa", "Empresa");
            dgvClientes.Columns.Add("colEmail", "Email");

            foreach (Cliente cli in agenda.MostrarClientes())
            {
                dgvClientes.Rows.Add(cli.Nombre, cli.TelefonoCli, cli.Empresa, cli.Email);
            }
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