using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double length;
        double width;
        double heigth;
        double area;

        Console.WriteLine("Please enter the dimensions of the pyramid");
        Console.WriteLine("");

        Console.Write("length: ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("width: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write("heigth: ");
        heigth = Convert.ToDouble(Console.ReadLine());
        area = ( length * width * heigth ) / 3;
            
        Console.WriteLine("");
        Console.WriteLine("Area: " + area.ToString("0.00") + "cm²");

        Console.WriteLine("\nDone.");
    }
}