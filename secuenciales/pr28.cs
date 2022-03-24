// 28. Programa que lea dos números enteros, muestre el
// siguiente menú y realice las operaciones indicadas. 1. Suma, 2. Resta, 3. Multiplicación, 4.
// División.

using System;

public class pr28
{
    public pr28()
    {
        int n1, n2, opc, suma, resta, multi;
        double divi;
        Console.WriteLine("Dame primer número");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dame segundo número");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        Console.WriteLine("Elige una opción");
        opc = int.Parse(Console.ReadLine());


        switch (opc)
        {
            case 1:
                suma = n1 + n2;
                Console.WriteLine("La suma es: " + suma);
                break;
            case 2:
                resta = n1 - n2;
                Console.WriteLine("La resta es: " + resta);
                break;
            case 3:
                multi = n1 * n2;
                Console.WriteLine("El producto es: " + multi);
                break;
            case 4:
                divi = n1 / n2;
                Console.WriteLine("La division es: " + divi);
                break;
            default:
                Console.WriteLine("Opción no valida");
                break;
        }
    }
}