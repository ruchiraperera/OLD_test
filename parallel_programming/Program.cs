using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace parallel_programming
{
    class Program
    {
        static async Task<string> ebookDownload()
        { 

            #region MyRegion

            //async function will wait till the process to complete ConfigureAwait(false)
            //so the result will be 
            // E Book downloaded
            // tested
            // if not print tested and then E Book downloaded
            await Task.Delay(TimeSpan.FromMilliseconds(10000)).ConfigureAwait(false);
            //await Task.Delay(TimeSpan.FromMilliseconds(10000));
            Console.WriteLine("E Book downloaded");

            return "tested";

            #endregion


        }



        static void Main(string[] args)
        {

            //var _threadprority = new ThreadPrority();

            //Console.WriteLine("Thread Completed");
            //Console.Read();



            //var _taskCon = new TaskContinueWith();
            //_taskCon.parent_process();

            //Console.Read();

            //var _taskContinue = new TaskContinueWith();
            //_taskContinue.process();
            //Console.Read();

            _parallelcls _cls = new _parallelcls();

             _cls.parallelInvoke();

            Console.WriteLine("test");
            //_cls._taskFactory();


            Console.Read();


            //anonymous function 
            Func<int, int, string> _test = (x, y) => (x * y).ToString();
            Console.WriteLine(_test(2, 6));


            //thread pool
            for (int i = 0; i < 3; i++)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(x => ebookDownload().Wait());
            }

            //Task (deadlock example also added) - this actually happen in UI deadlocks

            Task<string> _ebook = ebookDownload();
            _ebook.Wait();
            Console.WriteLine(_ebook.Result);

            //task and background processes





            Trace.WriteLine("completed");

            Console.Read();

        }

        //public async Task<HtmlDocument> LoadPage(Uri address)
        //{
        //    using (var client = new HttpClient())
        //    using (var httpResponse = await client.GetAsync(address))
        //        return await Task.Run(async () =>
        //        {
        //            using (var responseContent = httpResponse.Content)
        //            using (var contentStream = await responseContent.ReadAsStreamAsync())
        //                return LoadHtmlDocument(contentStream); //CPU-bound
        //        });
        //}

        //public async Task<HtmlDocument> LoadPage(Uri address)
        //{
        //    using (var client = new HttpClient())
        //    using (var httpResponse = await client.GetAsync(address).ConfigureAwait(false))
        //    using (var responseContent = httpResponse.Content)
        //    using (var contentStream = await responseContent.ReadAsStreamAsync().ConfigureAwait(false))
        //        return LoadHtmlDocument(contentStream); //CPU-bound
        //}
    }
}
