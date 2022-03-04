//PROGRAMA 45. PROGRAMA QUE SOLICITE DE CUANTAS CALIFICACIONES DESEA CALCULAR EL PRMEDIO, PIDE LAS CALIFICACIONES, CALCULA E IMPRIME EL PROMEDIO.


using System;

public class pr45 {
    public pr45(){
    	double cal, suma=0, prom=0;
    	int num_cals;

    	Console.Write("Dame el numero de calificaciones: ");
    	num_cals = int.Parse(Console.ReadLine());

        int i=1;
        while (i<=num_cals) 
        {
            Console.Write($"Dame la {i} calificacion: ");
            cal = double.Parse(Console.ReadLine());
            suma += cal;

            prom = suma/num_cals;

            i++;
        }

        Console.WriteLine($"Tu promedio es de {prom}");
    }
}