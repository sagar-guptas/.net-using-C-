using System;

class A4P5
{ 
    delegate void TemperatureConverter(double celsius);
    static void CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit = " + fahrenheit);
    }
    static void CelsiusToKelvin(double celsius)
    {
        double kelvin = celsius + 273.15;

        Console.WriteLine("Kelvin = " + kelvin);
    }

    static void Main()
    {
        TemperatureConverter convert = CelsiusToFahrenheit;

        convert += CelsiusToKelvin;
        convert(25);
    }
}