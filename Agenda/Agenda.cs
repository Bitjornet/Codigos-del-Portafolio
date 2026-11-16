using System;
using System.Collections;

namespace AgendaClientes
{
    public class Agenda
    {
        private string propietario = "";
        private string telPropietario = "";
        private ArrayList listaClientes;

        public Agenda()
        {
            listaClientes = new ArrayList();
        }

        public Agenda(string propietario, string telPropietario, ArrayList listaClientes)
        {
            this.propietario = propietario;
            this.telPropietario = telPropietario;
            this.listaClientes = listaClientes ?? new ArrayList();
        }

        public string Propietario { get => propietario; set => propietario = value; }
        public string TelPropietario { get => telPropietario; set => telPropietario = value; }
        public ArrayList ListaClientes { get => listaClientes; set => listaClientes = value; }

        public void AgregarCliente(Cliente cli)
        {
            listaClientes.Add(cli);
        }

        public Cliente? BuscarCliente(string nombre)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return cli;
                }
            }
            return null;
        }

        public bool EliminarCliente(string nombre)
        {
            Cliente? cli = BuscarCliente(nombre);
            if (cli != null)
            {
                listaClientes.Remove(cli);
                return true;
            }
            return false;
        }

        public bool ActualizarCliente(string nombreOriginal, string nuevoNombre, string nuevoTel, string nuevaEmpresa, string nuevoEmail)
        {
            Cliente? cli = BuscarCliente(nombreOriginal);
            if (cli != null)
            {
                cli.Nombre = nuevoNombre;
                cli.TelefonoCli = nuevoTel;
                cli.Empresa = nuevaEmpresa;
                cli.Email = nuevoEmail;
                return true;
            }
            return false;
        }

        public ArrayList MostrarClientes()
        {
            return listaClientes;
        }
    }
}