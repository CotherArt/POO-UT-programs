//48. PROGRAMA QUE SOLICITE LA TABLA QUE QUIERA IMPRIMIR Y LA IMPRIMA MULTIPLICANDO EL NUMERO DESDE 0 HASTA 12.
using System;

public class pr48 {
    public pr48(){
        int tabla;

        Console.Write("Que tabla quiere usted?");
        tabla = int.Parse(Console.ReadLine());

        int i=0;
    	while (i<=12) 
        {
            Console.WriteLine($"{tabla} x {i} = {i*tabla}"); 
            i++;
        }
    }
}