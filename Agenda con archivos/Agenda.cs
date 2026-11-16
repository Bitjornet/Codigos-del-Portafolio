using System;
using System.Collections;
using System.IO;

namespace AgendaClientes
{
    public class Agenda
    {
        private string propietario = "";
        private string telPropietario = "";
        private ArrayList listaClientes;
        private readonly string rutaArchivo = "agenda_clientes.txt";

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
            GuardarArchivo();
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
                GuardarArchivo();
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
                GuardarArchivo();
                return true;
            }
            return false;
        }

        public ArrayList MostrarClientes()
        {
            return listaClientes;
        }

        // Flujo de salida: escribe el propietario y todo el ArrayList en el archivo
        public void GuardarArchivo()
        {
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{propietario}|{telPropietario}");

            foreach (Cliente cli in listaClientes)
            {
                sw.WriteLine($"{cli.Nombre}|{cli.TelefonoCli}|{cli.Empresa}|{cli.Email}");
            }

            sw.Close();
            fs.Close();
        }

        // Flujo de entrada: lee el archivo y reconstruye el ArrayList en memoria
        public bool CargarArchivo()
        {
            if (!File.Exists(rutaArchivo))
            {
                return false;
            }

            FileStream fs = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            listaClientes.Clear();

            string? lineaPropietario = sr.ReadLine();
            if (!string.IsNullOrEmpty(lineaPropietario))
            {
                string[] datosProp = lineaPropietario.Split('|');
                if (datosProp.Length >= 2)
                {
                    this.propietario = datosProp[0];
                    this.telPropietario = datosProp[1];
                }
            }

            string? linea;
            while ((linea = sr.ReadLine()) != null)
            {
                string[] datos = linea.Split('|');
                if (datos.Length == 4)
                {
                    Cliente cli = new Cliente(datos[0], datos[1], datos[2], datos[3]);
                    listaClientes.Add(cli);
                }
            }

            sr.Close();
            fs.Close();
            return true;
        }
    }
}