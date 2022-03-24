//39. PROGRAMA QUE CALCULE EL numORIAL DE UN NÚMERO. (CONSULTAR PRIMERO QUE ES UN numORIAL Y COMO SE CALCULA).
using System;

public class pr39 {
    public pr39() {
        int num, fact = 1;

        Console.Write("Que numero quiere usted calcular el factorial? ");
        num = int.Parse(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            fact *= i;
        }
        Console.WriteLine($"El factorial de {num} es {fact}");
    }
}