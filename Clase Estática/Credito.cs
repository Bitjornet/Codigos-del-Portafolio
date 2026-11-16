using System;

namespace Prestamos
{
    public class Credito
    {
        public float Cantidad { get; set; }
        public int Plazo { get; set; }
        public float Mensualidad { get; set; }

        public Credito() { }

        public float CalculaMens()
        {
            Mensualidad = Cantidad / Plazo;
            return Mensualidad;
        }

        public bool EvaluaCred(float salario)
        {
            float limiteSueldo = salario * 0.30f;
            return Mensualidad < limiteSueldo;
        }
    }
}