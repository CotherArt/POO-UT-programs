//50. PROGRAMA QUE LEA UN NUMERO Y A QUE POTENCIA SE QUIER ELEVAR Y CALCULE SU RESULTADO.
using System;

public class pr50 {
    public pr50() {
        int num, pot, resultado;

        Console.Write("Dame un numero: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Dame una potencia: ");
        pot = int.Parse(Console.ReadLine());

        resultado = num;
        int i=1;
        while(i < pot)
        {
            resultado *= num;
            Console.WriteLine(resultado);
            i++;
        }
        Console.WriteLine($"El resultado es {resultado}");
    }
}