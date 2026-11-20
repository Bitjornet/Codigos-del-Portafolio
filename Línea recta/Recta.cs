using System;

namespace Geoanalitica
{
    public class Recta
    {
        private Punto p1;
        private Punto p2;

        public Punto P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Punto P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        public Recta()
        {
            p1 = new Punto();
            p2 = new Punto();
        }

        public Recta(Punto p1, Punto p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public float Distancia()
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public Punto PuntoMedio()
        {
            float xm = (p1.X + p2.X) / 2f;
            float ym = (p1.Y + p2.Y) / 2f;
            return new Punto(xm, ym);
        }
    }
}