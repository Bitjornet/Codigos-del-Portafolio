using System;

namespace FiguraTr
{
    class Circulo
    {
        private float radio;

        public float Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public Circulo()
        {
            this.radio = 0;
        }

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float area()
        {
            return Convert.ToSingle(Math.PI * this.radio * this.radio);
        }

        public float area(float r)
        {
            return Convert.ToSingle(Math.PI * r * r);
        }

        public float perimetro()
        {
            return Convert.ToSingle(2 * Math.PI * this.radio);
        }

        public float perimetro(float r)
        {
            return Convert.ToSingle(2 * Math.PI * r);
        }

        public float diametro()
        {
            return 2 * this.radio;
        }

        public float diametro(float r)
        {
            return 2 * r;
        }
    }
}