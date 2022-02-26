//PROGRAMA 32. PROGRAMA QUE IMPRIME LOS PRIMEROS 10  MULTIPLOS DE 5

using System;
public class pr32
{
    public pr32()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}