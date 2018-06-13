using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace parallel_programming
{
    public class ThreadPrority
    {

        public ThreadPrority()
        {
            Thread _t = new Thread(() => display(1));
            Thread _t1 = new Thread(() => display(2));


            _t.Priority = ThreadPriority.Lowest;
            _t1.Priority = ThreadPriority.Highest;

            _t.Start();
            _t1.Start();

           // _t.Join();
           // _t1.Join();

        }



        private void display(int id) {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0} - {1}", id, i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread {0} is compeleted !!!!!",id);
        }
    }
}
