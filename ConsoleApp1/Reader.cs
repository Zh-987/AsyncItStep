using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Reader
    {
        static Semaphore semobj = new Semaphore(3, 3);
        Thread thread;

        int count = 3;

        public Reader(int i){
            thread = new Thread(Read);
            thread.Name = $"Reader {i}";
            thread.Start();
        }

        public void Read()
        {
            while (count>0)
            {
                semobj.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} enter into library");

                Console.WriteLine($"{Thread.CurrentThread.Name} read the book");
                Thread.Sleep(700);

                Console.WriteLine($"{Thread.CurrentThread.Name} leaved from library");

                semobj.Release();

                count--;
                Thread.Sleep(600);
            }
        }
    }
}
