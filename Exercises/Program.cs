using System;

namespace RetangularBox
{
    class Box
    {
        [STAThread]

        static void Main(string[] args)
    {
            double v, c, l, a;

            Console.Write("Please enter the length of the box in meters: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("Please enter the width of the box in meters: ");
            l = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of the box in meters: ");
            a = double.Parse(Console.ReadLine());

            v = c * a * l;

            Console.WriteLine("The volume is: " + v);



        }
    }
}





