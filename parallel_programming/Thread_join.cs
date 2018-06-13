using System;
using System.Collections.Generic;
using System.Text;

namespace parallel_programming
{
    public class Thread_join
    {

        //multiple thread run in one by one.....



        public void process() {

            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread _thread = new System.Threading.Thread(()=> { Display(i); });
                _thread.Start();
                _thread.Join(); //just wait for thread finish and then continue.....
                //_thread.Abort();
            }

        }

        private void Display(int id) {

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Display function completed - {0}",id);

        }
    }




}
