using Prestamos;
using System;

namespace Prestamos
{
    public static class DatosGlobales
    {
        private static Trabajador t = new Trabajador();

        public static Trabajador T
        {
            get => t;
            set => t = value;
        }
    }
}