// Programa 16. Programa que pida el nombre y la edad
// y te diga si puedes votar
using System;
public class pr16
{
    public pr16()
    {
        string nombre;
        int edad;

        Console.Write("Dame tu nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Dame tu edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Tu si puedes votar");
        }
        else
        {
            Console.WriteLine("Tu no si puedes votar");
        }
    }
}