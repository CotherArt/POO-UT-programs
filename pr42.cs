//PROGRAMA 42. PROGRAMA QUE IMPRIME LOS PRIMEROS 10  MULTIPLOS DE 5

using System;
public class pr42
{
    public pr42()
    {
        int i=1;
        while(i <= 50)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}