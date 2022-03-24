//38. PROGRAMA QUE SOLICITE LA TABLA QUE QUIERA IMPRIMIR Y LA IMPRIMA MULTIPLICANDO EL NUMERO DESDE 0 HASTA 12.
using System;

public class pr38 {
    public pr38(){
        int tabla;

        Console.Write("Que tabla quiere usted?");
        tabla = int.Parse(Console.ReadLine());

    	for (int i=0; i<=12; i++) 
        {
            Console.WriteLine($"{tabla} x {i} = {i*tabla}"); 
        }
    }
}