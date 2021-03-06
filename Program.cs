using System;

namespace workshophomework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            switch (mode)
            {
                case "time": 
                    if (x >= 0)
                    {
                        Console.WriteLine(Math.Pow(x - 1, 2));
                    }
                    else
                    {
                        Console.WriteLine("Invalid mouse position");
                    }
                    break;
                case "price":
                    if (x >= 0)
                    {
                        Console.WriteLine(Math.Sqrt(y) + 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid mouse position");
                    } 
                    break;
                default:
                    Console.WriteLine("Invalid mode");
                    break;
            }
            Console.ReadLine();
        }
    }
}
