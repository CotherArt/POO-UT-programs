//PROGRAMA 41. PROGRAMA QUE IMPRIME LOS NUMEROS DEL 1 AL 10.

using System;

public class pr41
{
    public pr41()
    {
        // Incrementar de 1 en 1
        Console.WriteLine("Incrementar de 1 en 1");

        int i=1;
        while(i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.ReadKey();

    }
}