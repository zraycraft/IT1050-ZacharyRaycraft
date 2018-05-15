using System;

namespace Lab03ZackRaycraft
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            int sumab = a + b;
            Console.WriteLine(sumab);



            int x = 1;
            int y = 2;
            int z = 3;
            int sumxyz = (x + y) * (z + 10);
            Console.WriteLine(sumxyz);

            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("\"Hello World!\" ");
            Console.WriteLine("Hello // World!");
        }
    }
}
