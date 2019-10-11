using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace parallel_programming
{
    class _parallelcls
    {


        Func<int, int, string> _name = (x, y) => (x * y).ToString();

        public _parallelcls()
        {
        }


        #region MyRegion
        private void _threadPool()
        {
            System.Threading.ThreadPool.QueueUserWorkItem(x => TaskAsync().Wait());
        }

        private async Task<string> TaskAsync()
        {
            // await Task.Delay(TimeSpan.FromMilliseconds(10000)).ConfigureAwait(false);
            return "tested";
        }

        private async Task<string> TaskWhenAll()
        {

            Task task1 = Task.FromResult(3);
            Task task2 = Task.FromResult(5);
            Task task3 = Task.FromResult(7);
            await Task.WhenAll(task1, task2, task3);

            return "1";
        }

        private async Task<string> _taskWaitAll() {

            var task1 = Task.Factory.StartNew(() => TaskAsync());
            var task2 = Task.Factory.StartNew(() => TaskAsync());

            // Block the current thread until the last task completes
            //task2.Wait();

            // Block the current thread until all tasks complete
            Task.WaitAll(task1, task2);

            return "1";
        }

        private async Task<int> waitTillTaskCompleted()
        {

            var httpClient = new HttpClient();
            // Start both downloads concurrently.
            Task<byte[]> downloadTaskA = httpClient.GetByteArrayAsync("");
            Task<byte[]> downloadTaskB = httpClient.GetByteArrayAsync("");
            // Wait for either of the tasks to complete.
            Task<byte[]> completedTask =
            await Task.WhenAny(downloadTaskA, downloadTaskB);
            // Return the length of the data retrieved from that URL.
            byte[] data = await completedTask;
            return data.Length;
        }
        #endregion





        #region Task Factory

        /// <summary>
        /// instead of task factory we can use task.run function this was introduced in 4.5
        /// </summary>
        public void _taskFactory()
        {

            //One common use for ConcurrentExclusiveSchedulerPair is to just use the Exclusi
            //veScheduler to ensure only one task is executed at a time.Code that executes on the
            //ExclusiveScheduler will run on the thread pool but will be restricted to executing
            //exclusive of all other code using the same ExclusiveScheduler instance.


            System.Threading.Tasks.TaskFactory _taskFactory = new TaskFactory();

            var schedulerPair = new ConcurrentExclusiveSchedulerPair(TaskScheduler.Default,
                maxConcurrencyLevel: 8);
            TaskScheduler scheduler = schedulerPair.ConcurrentScheduler;

            var cts = new System.Threading.CancellationTokenSource();
            var token = cts.Token;
            cts.CancelAfter(TimeSpan.FromSeconds(5));

            _taskFactory.StartNew(() =>
            {

                Task.Delay(TimeSpan.FromMilliseconds(1000)).ConfigureAwait(false);
                Console.WriteLine("test here");

            }, token, TaskCreationOptions.DenyChildAttach, scheduler);



            _taskFactory.StartNew(() => TaskAsync());
            // _taskFactory.StartNew(new Action(TaskAsync().Result));
            Task.Run(() => TaskAsync());

        }

        private void _taskContinueWith() {

            Task.Factory.StartNew(() => TaskAsync())
            .ContinueWith(t => TaskAsync())
            .Wait();
        }

        #endregion






        #region parallel programming
        /// <summary>
        /// parallel for each function
        /// </summary>
        public void parallelForEach()
        {
            string[] _t = { "a", "b", "c" };
            System.Threading.Tasks.Parallel.ForEach(_t, (_file) => { this.filenameDisplay(_file); });
        }

        /// <summary>
        /// parallel invoke function
        /// Parallel.Invoke performs a WaitAll (blocking the code until all the tasks are completed)
        /// </summary>
        public void parallelInvoke()
        {

            //Parallel.Invoke(() => { throw new Exception(); },
            //            () => { throw new Exception(); });

            string[] _t = new string[8];
            Parallel.Invoke(() => { parallelForEach(); }, () => { parallelForEach(); });
        }

        private void filenameDisplay(string filename)
        {

            Console.WriteLine("{0}", filename);
        }

        #endregion









        //using System.Threading.Tasks;
        //Parallel





    }
}
