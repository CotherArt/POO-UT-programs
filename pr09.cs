// 9. PROGRAMA QUE PIDA GRADOS CELCIUS Y LOS CONVIERTA A GRADOS FARENHEIT.
using System;
public class pr09 {
    public pr09(){
        double gradosFarenheit, gradosCelcius;
        
        Console.Write("Ingresa grados Celcius: ");
        gradosCelcius = double.Parse(Console.ReadLine());

        gradosFarenheit = (gradosCelcius * 1.8) + 32;

        Console.WriteLine(gradosCelcius + "°C = " + gradosFarenheit + "°F");
    }
}