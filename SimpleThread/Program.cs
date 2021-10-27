using System;
using System.Threading;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts here.");
       
            Thread backgroundThread = new Thread(new ThreadStart(First));
            backgroundThread.Start();


            Thread backgroundThread2 = new Thread(new ThreadStart(second));
            backgroundThread2.Start();

            Console.WriteLine("Main thread ends here.");
            Console.ReadKey();
        }


        public static void First()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }

        public static void second()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}
