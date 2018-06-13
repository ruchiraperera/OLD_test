using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace locks
{
    public class manual_auto_reset_event
    {
        AutoResetEvent _autoReset = new AutoResetEvent(false);
        ManualResetEvent _manual = new ManualResetEvent(false);

        public void process()
        {

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    _manual.Reset();
                    System.Threading.Thread _thread = new Thread(() => { Display(i); });
                    _thread.Start();
                    _manual.WaitOne();
                    // _autoReset.WaitOne();

                    Console.WriteLine(" Thread is over {0}", i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message - {0} ", ex.Message);
            }
        }

        public void Display(int Id)
        {

            System.Threading.Thread.Sleep(1000);
            // _autoReset.Set();
            _manual.Set();
            Console.WriteLine("Completed  {0}", Id);
        }
    }




}
