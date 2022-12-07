using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*static readonly object locker = new object();*/
        /* static AutoResetEvent waitHandler = new AutoResetEvent(true);*/
        /*static Mutex mutexobj = new Mutex();
        static int x = 0;*/
        async static Task Main(string[] args)
        {
            /*
             *    Thread infos
             * Thread currentThread = Thread.CurrentThread;


             Console.WriteLine($"Name: {currentThread.Name}");
             currentThread.Name = "Main";
             Console.WriteLine($"Name: {currentThread.Name}");
             Console.WriteLine($"{currentThread.IsAlive}");
             Console.WriteLine($"{currentThread.ManagedThreadId}");
             Console.WriteLine($"{currentThread.Priority}");
             currentThread.Priority = ThreadPriority.Highest;
             Console.WriteLine($"{currentThread.Priority}");
             Console.WriteLine($"{currentThread.ThreadState}");*/
            /*  Console.WriteLine("Hello World!");
  */
            /*
             * Thread sleed sample
             * 
             * for(int i =0; i<100; i++)
                 {
                     Thread.Sleep(600);
                     Console.WriteLine(i);
                 }*/

            /* 
             * Working with tread and start
             * 
             * Thread thread1 = new Thread(Print);
               Thread thread2 = new Thread(new ThreadStart(Print));
               Thread thread3 = new Thread(()=>Console.WriteLine("System programming"));

               thread1.Start();
               thread2.Start();
               thread3.Start();*/


            /*
             * 2 threads representation via loop
             * 
             * Thread thread1 = new Thread(Print);
              thread1.Start();

              for (int i = 0; i < 20; i++)
              {
                  Console.WriteLine($"Main Thread: {i}");
                  Thread.Sleep(300);
              }*/

            /* 
             * Parameterized Thread sample
             * 
             * Thread thread1 = new Thread(new ParameterizedThreadStart(Print));
              Thread thread2 = new Thread(Print);
              Thread thread3 = new Thread(message => Console.WriteLine(message));

              thread1.Start("Hello");
              thread2.Start("Qwerty");
              thread3.Start("ItStep");*/
            /*
             * Sent int as parametr
             * 
                        int num = 2;

                        Thread thread2 = new Thread(Print);
                        thread2.Start(num);*/
            /*  Person qwerty = new Person("Donald", 13);
              Thread thread1 = new Thread(qwerty.JoinEx);
              Thread thread2 = new Thread(qwerty.Print);

              thread1.Start();

              thread1.Join();
              thread2.Start();*/

            /* for(int i =1; i<6; i++)
             {
                 Reader reader = new Reader(i);*/
            /* Thread thread = new Thread(Print);

             thread.Name = $"Thread {i}";
             thread.Start();*/
            /*}*/
            /*
             * Асинхронность
             * await printAsync();
               Console.WriteLine("Some action inside of Main method");
               static void Print()
               {
                   *//*    Thread.Sleep(300);*//*

                   Console.WriteLine("Hello ItStep");
               }
               async Task printAsync()
               {
                   Console.WriteLine("Starting of printAsync");
                   await Task.Delay(200);
                   await Task.Run(() => Print());
                   Console.WriteLine("End of printAsync");
               }*/

            var zhass = Print("Zhassulan");
            var aid = Print("Aidar");
            var merk = Print("Merkhat");
            /* await Print("Zhassulan");
            await Print("Aidar");
            await Print("Merkhat");*/

            await zhass;
            await aid;
            await merk;
            async Task Print(string Name)
            {
                /* Thread.Sleep(3000);*/
                await Task.Delay(3000);
                Console.WriteLine(Name);
            }
        }

       

        /* static void Print()
         {*/

        /*
         * Синхронизация с помощью lock()
         * lock (locker) { 
         int x = 1;

         for (int i = 1; i < 6; i++)
         {
             Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
             x++;
             Thread.Sleep(100);
             *//* Thread.Sleep(100);*//*
         }
         } */

        /*
         * синхронизация с помощью Monitor
         * bool acquiredLock = false;

         try
         {
             Monitor.Enter(locker, ref acquiredLock);

              x = 1;

             for (int i = 1; i < 6; i++)
             {
                 Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                 x++;
                 Thread.Sleep(100);
             }
         }
         finally
         {
             if (acquiredLock)
             {
                 Monitor.Exit(locker);
             }
         }*/

        /*
         * синхронизация с помощью AutoresetEvent  
         * waitHandler.WaitOne(); //для нескольких объектов WaitAll() WaitHandle[]
          x = 1;

          for (int i = 1; i < 6; i++)
          {
              Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
              x++;
              Thread.Sleep(100);
          }

          waitHandler.Set();*/
        /*
         *  синхронизация Mutex 
                    mutexobj.WaitOne();
                    x = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name} : {x}");
                        x++;
                        Thread.Sleep(100);
                    }
                    mutexobj.ReleaseMutex();*/

        /*  }*/
        /* void, Task, Task<T>, ValueTask<T>*/

    }


        /**/


    }
