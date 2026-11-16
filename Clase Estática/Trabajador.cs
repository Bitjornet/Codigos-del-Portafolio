using Prestamos;
using System;

namespace Prestamos
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public int NumTrabajador { get; set; }
        public float Salario { get; set; }

        public Credito Prestamo { get; set; }

        public Trabajador()
        {
            Prestamo = new Credito();
        }
    }
}