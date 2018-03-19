using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{
    class Class1
    {

        public async void ThreadRun()
        {

            System.Threading.CancellationTokenSource _cts = new System.Threading.CancellationTokenSource();
            List<Task> _taskList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                var h = i;
                _taskList.Add(Task.Run(() => { display(h); }, _cts.Token));

                // }
            }
            await Task.WhenAll(_taskList);
            //_cts.Cancel();

            Console.WriteLine("All Task are completed");
        }

        public void display(int x)
        {
            Console.WriteLine("Thread number - {0}", x);
            var rand = new Random();
            while (true)
            {
                var val = rand.Next(1, 99);

                if (val == 88)
                {
                    Console.WriteLine("{0} - value {1}", x, val);
                    break;
                }

                else { }


            }
        }
    }
}
