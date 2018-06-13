using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallel_programming
{

    //ContinueWithWhenAll
    //ContinueWithWhenAny

    class TaskContinueWith
    {

        public void process() {
            
            var t1 = new Task(()=> {
                System.Threading.Thread.Sleep(10000);
            });


            var t2 = Task.Run(() => {
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("First Thread - {0}", 1);
            });

           

            t2.ContinueWith(t => {
                Console.WriteLine(t.Id);
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine("Second Thread is over");
            },TaskContinuationOptions.OnlyOnRanToCompletion);

           // var t2 = t1.Start();          


        }


        public async void parent_process() {



            //old way
            var parent = new Task(() =>
            {

                var child = new Task(()=> {

                    Console.WriteLine("Child task started");
                    System.Threading.Thread.Sleep(10000);
                    Console.WriteLine("Child task ended");

                });

                child.Start();

            });


            parent.Start();
            //parent.Wait();

            // new way
            var parent1 = Task<int>.Run(() =>
            {

                var child = Task.Run(() =>
                {

                    Console.WriteLine("Child task1 started");
                    System.Threading.Thread.Sleep(10000);
                    Console.WriteLine("Child task1 ended");

                });

                return 1;
            });

           


            Console.WriteLine("Result - {0}",parent1.Result);

            Console.WriteLine("dsadsadadas");




        }
    }
}
