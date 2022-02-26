//Programa calclule la suma de los numers del 40 al 3000

using System;

public class pr36 {
    public pr36(){
    	int suma=0;

    	for (int i=40; i<=3000; i++) 
    	{
    		suma += i;
    	}
    	
    	Console.WriteLine($"La suma es {suma}");
    }
}