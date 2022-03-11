<<<<<<< HEAD
// Programa 65: Programa muestre un menu de restaurante para ordenar. y calcule
// el precio total con iva añadido del 15% (usando ciclos)
=======
// Programa 65: Programa que simule el juego del snake
>>>>>>> 5b38d80dc8cabe17f1371b9f8a77400df6a6ef86
using System;

public class pr65 {
    public pr65() {
<<<<<<< HEAD
        bool exit = false;
        int opcion;
        double total=0, iva;

        do{
            Console.Clear();
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("\t--- Menu ---");
            Console.WriteLine("1. Rollo primavera $150");
            Console.WriteLine("2. Burger $60");
            Console.WriteLine("3. Tacos $50");
            Console.WriteLine("4. Egg fried rice $100");
            Console.WriteLine("5. Ramen $125");
            Console.WriteLine("6. Listo");
            Console.Write("\nOpcion:");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    total += 150;
                    break;
                case 2:
                    total += 60;
                    break;
                case 3:
                    total += 50;
                    break;
                case 4:
                    total += 100;
                    break;
                case 5:
                    total += 125;
                    break;
                case 6:
                    exit = true;
                    break;
            }
        } while (!exit);

        iva = total * 0.15;
        total -= iva;
        Console.WriteLine($"IVA del 15% añadido: ${iva}");
        Console.WriteLine($"Total a pagar: ${total}");
=======
>>>>>>> 5b38d80dc8cabe17f1371b9f8a77400df6a6ef86
    }
}