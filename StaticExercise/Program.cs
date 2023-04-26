namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit -> Celcius");
            var Fin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TempConverter.FahrenheitToCelsius(Fin));

            Console.WriteLine("Celcius -> Fahrenheit");
            var Cin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(Cin));
        }
    }
}
