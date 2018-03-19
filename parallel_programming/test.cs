using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace parallel_programming
{
    class test
    {

        public test()
        {

            Task.Factory.StartNew(() => VAsync().Wait());
            Task.Run(() => VAsync().Wait());

            Task _task1 = new Task(() => VAsync().Wait());
            Task _task2 = new Task(() => VAsync().Wait());

            Task.WhenAll(_task1, _task2);


            System.Threading.ThreadPool.QueueUserWorkItem(t=>VAsync().Wait());



        }


        private async Task<string> VAsync()
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromMilliseconds(1000)).ConfigureAwait(false);
            return "1";
        }






    }
}
