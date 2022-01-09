using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace SimpleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var people = new List<Person>();
            var person = new Person(100, "ali", "fallah");

            for (int i = 0; i < 10000; i++)
            {
                people.Add(person);
            }

            //var timer = new Stopwatch();
            //timer.Start();

            //var result = person.GetFullName(people, 300, 100);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

           // timer.Stop();

            var timer2 = new Stopwatch();
            timer2.Start();

            var result2 = person.GetFullName(people);

            foreach (var item2 in result2)
            {
                Console.WriteLine(item2);
            }

            timer2.Stop();

            //Console.WriteLine(timer.Elapsed);
            Console.WriteLine(timer2.Elapsed);


            Console.ReadKey();
        }



        //Console.WriteLine("Main thread starts here.");

        //Thread backgroundThread = new Thread(new ThreadStart(First));
        //backgroundThread.Start();


        //Thread backgroundThread2 = new Thread(new ThreadStart(second));
        //backgroundThread2.Start();

        //Console.WriteLine("Main thread ends here.");
        //Console.ReadKey();


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
