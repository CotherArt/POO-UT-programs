// Programa 19. Pedir un numero e indicar si es multiplo de 5
using System;
public class pr19{
    public pr19(){
        int numero;

        Console.Write("Ingrese numero: ");
        numero = int.Parse(Console.ReadLine());

        if (numero % 5 == 0){
            Console.WriteLine("Tu numero es multiplo de 5");
        }
        else{
            Console.WriteLine("Tu numero no es multiplo de 5");
        }
    }
}