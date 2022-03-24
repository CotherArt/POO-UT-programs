//PROGRAMA 34. PROGRAMA QUE PIDE 8 CALIFICIONES, CALCULA E IMPRIME SU PROMEDIO.

using System;

public class pr34 {
    public pr34(){
    	double cal, suma=0, prom=0;
        for (int i=1; i<=8; i++) 
        {
            Console.Write($"Dame la {i} calificacion: ");
            cal = double.Parse(Console.ReadLine());
            suma += cal;

            prom = suma/8;
        }

        Console.WriteLine($"Tu promedio es de {prom}");
    }
}