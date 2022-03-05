// Programa 62: Programa que ponga el siguiente menú y calcule el resultado
// según la opción elegida.  1. Suma de dos números  2. suma de tres números 
// 3. Suma de n números, 4. salir.
using System;

public class pr62 {
    public pr62() {
        bool exit = false;
        int opcion, suma;

        do
        {   
            Console.WriteLine("---Eliga una opcion---");
            Console.WriteLine("1. Suma de dos números");
            Console.WriteLine("2. suma de tres números");
            Console.WriteLine("3. Suma de n números");
            Console.WriteLine("4. Salir");
            Console.Write("> ");
            opcion = int.Parse(Console.ReadLine());
            suma = 0;
            switch (opcion)
            {
                case 1:
                    // Console.Clear();
                    for (int i = 1; i <= 2; i++)
                    {
                        Console.Write($"ingrese el {i}° numero: ");
                        suma += int.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    // Console.Clear();
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.Write($"ingrese el {i}° numero: ");
                        suma += int.Parse(Console.ReadLine());
                    }
                    break;
                case 3:                    
                    // Console.Clear();
                    int n;
                    Console.Write("Cuantos numeros quiere contar? ");
                    n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        Console.Write($"ingrese el {i}° numero: ");
                        suma += int.Parse(Console.ReadLine());
                    }
                    break;
                case 4:
                    exit = true;
                    break;
            }

            Console.WriteLine($"El resultado de la suma es: {suma} \n");
        } while (!exit);
    }
}