using System;
using System.Windows.Forms;

namespace AgendaClientes
{
    public partial class FormMenu : Form
    {
        private Agenda agenda;

        public FormMenu(Agenda agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            lblPropietario.Text = "Agenda de: " + agenda.Propietario;
            lblTelefono.Text = "Teléfono: " + agenda.TelPropietario;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FormMostrar formMostrar = new FormMostrar(agenda);
            formMostrar.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar(agenda);
            formAgregar.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBuscar formBuscar = new FormBuscar(agenda);
            formBuscar.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FormInicio inicio = new FormInicio();
            inicio.Show();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}