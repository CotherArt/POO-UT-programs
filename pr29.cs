// 29. Programa que imprima el siguiente menú: 1. Triangulo, 2.
// Cuadrado, 3. Rectángulo; y solicite los datos y calcule su área.

using System;
public class pr29
{
    public pr29()
    {
        double b, a, l, area;
        int opc;

        Console.WriteLine("1.Triangulo");
        Console.WriteLine("2. Cuadrado");
        Console.WriteLine("3. Rectangulo");

        Console.WriteLine("Elige una opción para calcular el area");
        opc = int.Parse(Console.ReadLine());

        switch (opc)
        {
            case 1:
                Console.WriteLine("Dame la base");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Dame la altura");
                a = Double.Parse(Console.ReadLine());
                area = (b * a) / 2;
                Console.WriteLine("El area del triangulo es " + area);
                break;
            case 2:
                Console.WriteLine("Dame el lado");
                l = Double.Parse(Console.ReadLine());
                area = l * l;
                Console.WriteLine("El area del cuadrado es " + area);
                break;
            case 3:
                Console.WriteLine("Dame la base");
                b = Double.Parse(Console.ReadLine());
                Console.WriteLine("Dame la altura");
                a = Double.Parse(Console.ReadLine());
                area = (b * a);
                Console.WriteLine("El area del rectangulo es " + area);
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
    }
}