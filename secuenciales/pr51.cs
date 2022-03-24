//PROGRAMA 51. PROGRAMA QUE IMPRIME LOS NUMEROS DEL 1 AL 10.

using System;

public class pr51
{
    public pr51()
    {
        // Incrementar de 1 en 1
        Console.WriteLine("Incrementar de 1 en 1");

        int i=1;
        do{
            Console.WriteLine(i);
            i++;
        }while(i <= 10);
        Console.ReadKey();

    }
}