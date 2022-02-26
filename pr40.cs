//40. PROGRAMA QUE LEA UN NUMERO Y A QUE POTENCIA SE QUIER ELEVAR Y CALCULE SU RESULTADO.
using System;

public class pr40 {
    public pr40() {
        int num, pot, resultado;

        Console.Write("Dame un numero: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Dame una potencia: ");
        pot = int.Parse(Console.ReadLine());

        resultado = num;
        for (int i = 1; i < pot; i++)
        {
            resultado *= num;
            Console.WriteLine(resultado);
        }
        Console.WriteLine($"El resultado es {resultado}");
    }
}