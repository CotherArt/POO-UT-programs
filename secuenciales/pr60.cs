//60. PROGRAMA QUE LEA UN NUMERO Y A QUE POTENCIA SE QUIER ELEVAR Y CALCULE SU RESULTADO.
using System;

public class pr60 {
    public pr60() {
        int num, pot, resultado;

        Console.Write("Dame un numero: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Dame una potencia: ");
        pot = int.Parse(Console.ReadLine());

        resultado = num;
        int i=1;
        
        do{
            resultado *= num;
            Console.WriteLine(resultado);
            i++;
        }while(i < pot);
        Console.WriteLine($"El resultado es {resultado}");
    }
}