//PROGRAMA 52. PROGRAMA QUE IMPRIME LOS PRIMEROS 10  MULTIPLOS DE 5

using System;
public class pr52
{
    public pr52()
    {
        int i=1;
        do
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }while(i <= 50);
    }
}