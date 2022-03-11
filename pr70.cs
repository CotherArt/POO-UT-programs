//70. PROGRAMA QUE LEA UN NUMERO Y A QUE POTENCIA SE QUIER ELEVAR Y CALCULE SU RESULTADO.
using System;

public class pr70 {

    static int potencia(int numero, int potencia){
        int resultado;
        resultado = numero;
        for (int i = 1; i < potencia; i++)
        {
            resultado *= numero;
        }
        return resultado;
    }

    public pr70() {
        int num, pot;

        Console.Write("Dame un numero: ");
        num = int.Parse(Console.ReadLine());

        Console.Write("Dame una potencia: ");
        pot = int.Parse(Console.ReadLine());

        Console.WriteLine($"El resultado es {potencia(num, pot)}");
    }
}