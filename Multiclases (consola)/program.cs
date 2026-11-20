using FiguraTr;
using System;

namespace figuraas
{
    class Program
    {
        static void Main(string[] args)
        {
            Trian tri1 = new Trian();
            Trian tri2 = new Trian(10, 5);
            Trian tri3 = new Trian();

            float artri1;
            float artri2;

            artri1 = tri1.area(17.0F, 4.0F);
            artri2 = tri2.area();

            Console.WriteLine("El área del triángulo de base 17 y altura 4 es " + artri1);
            Console.WriteLine("El área del triángulo de base 10 y altura 5 es " + artri2);

            Trian lol = new Trian();
            float hiphip;
            hiphip = lol.hipotenusa(10, 5);
            Console.WriteLine("la hipotenusa del triángulo de base 10 y altura 5 es:" + hiphip);

            Trian suba = new Trian(10, 5);
            float per1;
            per1 = suba.perimetro();
            Console.WriteLine("el perímetro del triangulo de base 10 y altura 5 es:" + per1);

            System.Console.WriteLine("Ingresa la base del triángulo 3");
            tri3.Bas = Convert.ToSingle(System.Console.ReadLine());
            System.Console.WriteLine("Ingresa la altura del triángulo 3");
            tri3.Altura = Convert.ToSingle(System.Console.ReadLine());
            Console.WriteLine("El área del Triángulo es " + tri3.area());
            Console.WriteLine("La hipotenusa del triángulo 3 es: " + tri3.hipotenusa());
            Console.WriteLine("El perímetro del triángulo 3 es: " + tri3.perimetro());

            Console.WriteLine("\n--- Pruebas con Círculo ---");

            Circulo cir1 = new Circulo();
            Circulo cir2 = new Circulo(5.0F);
            Circulo cir3 = new Circulo();

            float areacir1 = cir1.area(3.0F);
            float areacir2 = cir2.area();

            Console.WriteLine("El área del círculo de radio 3 es " + areacir1);
            Console.WriteLine("El área del círculo de radio 5 es " + areacir2);

            float perimetrocir = cir2.perimetro();
            Console.WriteLine("El perímetro del círculo de radio 5 es " + perimetrocir);

            float diametro = cir2.diametro();
            Console.WriteLine("El diámetro del círculo de radio 5 es " + diametro);

            System.Console.WriteLine("Ingresa el radio del círculo 3");
            cir3.Radio = Convert.ToSingle(System.Console.ReadLine());
            Console.WriteLine("El área del círculo es " + cir3.area());
            Console.WriteLine("El perímetro del círculo es " + cir3.perimetro());
            Console.WriteLine("El diámetro del círculo es " + cir3.diametro());

            Console.ReadKey();
        }
    }
}