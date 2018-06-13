using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace parallel_programming
{
    public class foregroundVsBackground
    {

        //foreground - till thread close main thread not going to close
        //backgroud - terminated after main thread close.

        // like in task wait option


        public void foregroundThread() {

            Thread _foregroundWoker = new Thread(() => Display(1));
            _foregroundWoker.Start();
        }

        public void backgroundThread() {

            Thread _backgroundWorker = new Thread(() => Display(2));
            _backgroundWorker.IsBackground = true;
            _backgroundWorker.Start();
        }


        public void samethingFromTask() {

            //by defualt task run is background task
            var task = Task.Run(() => Display(3));
            //with wait it will be foreground task
            task.Wait();
        }


        private void Display(int id) {

            Console.WriteLine("Thread Started {0}", id);
            Thread.Sleep(2000);
            Console.WriteLine("Thread Ended {0}", id);
        }





    }
}
