using Microsoft.Win32;
using System;
using System.Resources;

namespace First_C__Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            Console.WriteLine("Hallo " + Name + "\nWelcome to my C# way");

            Console.WriteLine("Input A: ");
            string AStr = Console.ReadLine();
            Console.WriteLine("Input B: ");
            string BStr = Console.ReadLine();
            Console.WriteLine("Input C: ");
            string CStr = Console.ReadLine();

            int A = Convert.ToInt32(AStr);
            int B = Convert.ToInt32(BStr);
            int C = Convert.ToInt32(CStr);

            double Discriminant = System.Math.Pow(B, 2) - 4 * A * C;
            Console.WriteLine(A + "x2+" + B + "x+" + C + " = 0");
            Console.WriteLine("Discriminant = b2-4ac = " + System.Math.Pow(B,2) + "-4*" + A + "*" + C + " = " + Discriminant);
        }
    }
}
