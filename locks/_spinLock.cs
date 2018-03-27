using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace locks
{


    class _spinLock
    {

        private float _balance;
        public float Balance { get { return _balance; } private set { this._balance = value; } }
        private object _lock = new object();

        public virtual void Deposit(dynamic balance)
        {
            Balance += balance;
        }


        public virtual void Withdraw(dynamic balance)
        {
            Balance -= balance;
        }
    }

    class _spinlockProcess
    {

        public void process()
        {
            _spinLock _s = new _spinLock();

            SpinLock _sl = new SpinLock();

            

            var t1 = new Task(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        bool lockToken = false;
                        _sl.Enter(ref lockToken);
                        _s.Deposit(100);

                    }
                    finally
                    {
                        _sl.Exit();
                    }

                }
            });


            var t2 = new Task(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        bool lockToken = false;
                        _sl.Enter(ref lockToken);
                        _s.Withdraw(100);
                    }
                    finally
                    {
                        _sl.Exit();
                    }
                }
            });


            t1.Start();
            t2.Start();

            Task.WaitAll(new[] { t1, t2 });

            Console.WriteLine("{0} - bank balance", _s.Balance);




        }
    }
}
