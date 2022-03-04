//Programa calclule la suma de los numers del 40 al 3000

using System;

public class pr46 {
    public pr46(){
    	int suma=0;

		int i = 40;
    	while (i<=3000) 
    	{
    		suma += i;
			i++;
    	}
    	
    	Console.WriteLine($"La suma es {suma}");
    }
}