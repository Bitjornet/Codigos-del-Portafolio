using System;

namespace AgendaClientes
{
    public class Cliente
    {
        private string nombre;
        private string telefonoCli;
        private string empresa;
        private string email;

        public Cliente() { }

        public Cliente(string nombre, string telefonoCli, string empresa, string email)
        {
            this.nombre = nombre;
            this.telefonoCli = telefonoCli;
            this.empresa = empresa;
            this.email = email;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string TelefonoCli { get => telefonoCli; set => telefonoCli = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Email { get => email; set => email = value; }

        public string ImprimirCliente()
        {
            return $"Nombre: {Nombre} | Teléfono: {TelefonoCli} | Empresa: {Empresa} | Email: {Email}";
        }
    }
}