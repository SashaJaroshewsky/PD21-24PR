using System;


namespace Classes
{
    class Program
    {
        static void Main()
        {            
            Point point = new Point("A");
            Console.WriteLine($"{point.Name}.X = {point.X}, {point.Name}.Y = {point.Y}");

            Console.ReadKey();
        }
    }
}
