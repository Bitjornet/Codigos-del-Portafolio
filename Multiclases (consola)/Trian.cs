using System;

namespace FiguraTr
{
    class Trian
    {
        private float bas;
        private float altura;

        public float Bas
        {
            get { return bas; }
            set { bas = value; }
        }

        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public Trian()
        {
            this.bas = 0;
            this.altura = 0;
        }

        public Trian(float bas, float altura)
        {
            this.bas = bas;
            this.altura = altura;
        }

        public float hipotenusa(float a, float b)
        {
            return Convert.ToSingle(Math.Sqrt(a * a + b * b));
        }

        public float hipotenusa()
        {
            return Convert.ToSingle(Math.Sqrt(this.bas * this.bas + this.altura * this.altura));
        }

        public float perimetro()
        {
            float a = this.altura;
            float b = this.bas;
            return (a + b + this.hipotenusa(a, b));
        }

        public float perimetro(float a, float b)
        {
            return (a + b + this.hipotenusa(a, b));
        }

        public float area()
        {
            return Convert.ToSingle((this.bas * this.altura) / 2);
        }

        public float area(float x, float y)
        {
            return Convert.ToSingle((x * y) / 2);
        }
    }
}