using System;

namespace FuncionesBasicasLibMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo número");
            double num2 = double.Parse(Console.ReadLine());


            Console.WriteLine($"El valor absoluto de {num1} es = {Math.Abs(num1)}");
            Console.WriteLine($"El valor absoluto de {num2} es = {Math.Abs(num2)}");
            Console.WriteLine($"La potencia de {num1} es = {Math.Pow(num1, num1)}");
            Console.WriteLine($"La potencia de {num2} es = {Math.Pow(num2, num2)}");
            Console.WriteLine($"La raiz cuadrada de {num1} es = {Math.Sqrt(num1)}");
            Console.WriteLine($"La raiz cuadrada de {num2} es = {Math.Sqrt(num2)}");
            Console.WriteLine($"El seno de {num1} es = {Math.Sin(num1)}");
            Console.WriteLine($"El seno de {num2} es = {Math.Sin(num2)}");
            Console.WriteLine($"El coseno de {num1} es = {Math.Cos(num1)}");
            Console.WriteLine($"El coseno de {num2} es = {Math.Cos(num2)}");
            Console.WriteLine($"El número máximo de {num1} y {num2} es = {Math.Max(num1, num2)}");
            Console.WriteLine($"El número mínimo de {num1} y {num2} es = {Math.Min(num1, num2)}");
            Console.WriteLine($"La parte entera del número {num1} es = {Math.Truncate(num1)}");
            Console.WriteLine($"La parte entera del número {num2} es = {Math.Truncate(num2)}");
            Console.WriteLine($"El redondeo del numero {num1} es = {Math.Round(num1)}");
            Console.WriteLine($"El redondeo del número {num2} es = {Math.Round(num2)}");
        }
    }
}
