//PROGRAMA 44. PROGRAMA QUE PIDE 8 CALIFICIONES, CALCULA E IMPRIME SU PROMEDIO.

using System;

public class pr44 {
    public pr44(){
    	double cal, suma=0, prom=0;
        int i=1;
        while (i<=8) 
        {
            Console.Write($"Dame la {i} calificacion: ");
            cal = double.Parse(Console.ReadLine());
            suma += cal;

            prom = suma/8;

            i++;
        }

        Console.WriteLine($"Tu promedio es de {prom}");
    }
}