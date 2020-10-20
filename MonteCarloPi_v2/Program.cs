using System;
using System.Diagnostics;

namespace MonteCarloPi_v2
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            double R = 1;
            double nr = 0;
            for (int j = 0; j < 10; j++)
            {
                nr = 0;
                for (int i = 0; i < 1000000; i++)
                {
                    double x = RandomDouble();
                    double y = RandomDouble();
                    double dist = x * x + y * y;
                    //Console.WriteLine(dist);
                    if (dist <= R)
                    {
                        nr++;
                    }
                }
                double P = nr / 1000000;
                Console.WriteLine("PI =" + (4 * P));
                Console.WriteLine((4 * P) - 3.1415926);
                Console.WriteLine("-----------------------");
            }

            //////////////////////////////////////////////////
            TimeSpan ts = stopWatch.Elapsed;
            stopWatch.Stop();
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            //////////////////////////////////////////////////////////


        }

        public static double RandomDouble()
        {
            double num = random.Next(10002);
            return num/ 10001; 
        }
    }
}
