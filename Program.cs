using System;

namespace IT1050MidtermZackRaycraft
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            bool keepLooping = true;
            while (keepLooping == true)
            {
                Console.WriteLine("infinite loop");
            }

            int i;
            for ( i = 2 ; i < 130; i += 2 )
            {
                Console.WriteLine("[" + i + "]");
            }


            for (int i = 49; i > 0; i--)
            {
                if (i == 49)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write("," + i);
                }
            }

            int i = -1;
            while (i++ < 22)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


            int n = 8;
            int i = 10; // initialize
            do
            {
                Console.Write("*");
                i++; // update!
            } while (i < n); // test condition

            int n = 8;
            int i = 10;
            while (i < n)
            {
                Console.Write("*");
                i++;
            }
            //The Do-While will always run the first do when the program run. Whereas the while will only run if it is true.
            */

            Boolean icyRain = false;
            Boolean tornadoWarning = false;

            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("Let's go outside!");
            }

        }
    }
}
