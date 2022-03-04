//PROGRAMA 54. PROGRAMA QUE PIDE 8 CALIFICIONES, CALCULA E IMPRIME SU PROMEDIO.

using System;

public class pr54 {
    public pr54(){
    	double cal, suma=0, prom=0;
        int i=1;
        
        do{
            Console.Write($"Dame la {i} calificacion: ");
            cal = double.Parse(Console.ReadLine());
            suma += cal;

            prom = suma/8;

            i++;
        }while (i<=8);

        Console.WriteLine($"Tu promedio es de {prom}");
    }
}