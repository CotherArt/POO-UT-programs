//PROGRAMA 56. Programa calclule la suma de los numers del 40 al 3000

using System;

public class pr56 {
    public pr56(){
    	int suma=0;

		int i = 40;
    	 
    	do{
    		suma += i;
			i++;
    	}while (i<=3000);
    	
    	Console.WriteLine($"La suma es {suma}");
    }
}