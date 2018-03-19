using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallel_programming
{
    class Tasks
    {

        public Tasks()
        {
            threading();
        }

        public static async void threading()
        {


            List<Task> _task = new List<Task>();
            CancellationTokenSource _cts = new CancellationTokenSource();

            for (int i = 0; i < 10; i++)
            {
                //_task.Add(new Task(() => { Display(i); }));
                var h = i;
                _task.Add(Task.Run(() => { Display(h); }, _cts.Token));
            }
            //_task.ForEach(x => x.Start());
            //Parallel.ForEach(_t, task => task.Start());

            await Task.WhenAny(_task);
            _cts.Cancel();


            // _task.RemoveAll(x => x.IsCanceled == false);

        }



        public static void Display(int a)
        {
            Random _t = new Random();
            int t = 0;

            while (true)
            {
                t = _t.Next(1, 1000);
                if (t == 8888)
                {
                    Console.WriteLine("{0}Value - {1}", a, t);
                    break;
                }
                else
                {
                    Console.WriteLine("Matched Value - {0}", t);
                }


            }
        }
    }
}
