using System.Collections.Concurrent;

namespace ConsoleApp;

class Program
{
    public static double CalculateAreaCircle (double radius)
    {
        return Math.PI * radius * radius;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"The area is {CalculateAreaCircle(radius)}");
        
    }

}