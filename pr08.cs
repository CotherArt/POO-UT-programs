// 8. PROGRAMA QUE PIDA GRADOS FARENHEIT Y LOS CONVIERTA A GRADOS CELCIUS
using System;
public class pr08 {
    public pr08(){
        double gradosCelcius, gradosFarenheit;
        
        Console.Write("Ingresa grados Farenheit: ");
        gradosFarenheit = double.Parse(Console.ReadLine());

        gradosCelcius = (gradosFarenheit -32) / 1.8;

        Console.WriteLine(gradosFarenheit + "°F = " + gradosCelcius + "°C");
    }
}