using System;

namespace Geoanalitica
{
    public class Punto
    {
        private float x;
        private float y;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Punto()
        {
            x = 0;
            y = 0;
        }

        public Punto(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}