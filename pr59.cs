//59. PROGRAMA QUE CALCULE EL numORIAL DE UN NÚMERO. (CONSULTAR PRIMERO QUE ES UN numORIAL Y COMO SE CALCULA).
using System;

public class pr59 {
    public pr59() {
        int num, fact = 1;

        Console.Write("Que numero quiere usted calcular el factorial? ");
        num = int.Parse(Console.ReadLine());

        int i=num;
        
        do{
            fact *= i;
            i--;
        }while(i >= 1);
        Console.WriteLine($"El factorial de {num} es {fact}");
    }
}