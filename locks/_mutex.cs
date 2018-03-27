using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace locks
{
    public class _mutex
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

        public virtual void Transfer(_mutex BA, dynamic balance)
        {
            Balance -= balance;
            BA.Deposit(balance);
        }
    }




    public class _mutesProcess {


        public void process() {

            Mutex _m1 = new Mutex();
            Mutex _m2 = new Mutex();

            var b1 = new _mutex();
            var b2 = new _mutex();

            var t1 = new Task(() =>
            {

                for (int i = 0; i < 1000; i++)
                {
                    bool lockTaken = _m1.WaitOne();
                    try
                    {                        
                        b1.Deposit(100);
                    }
                    finally {
                        if (lockTaken) _m1.ReleaseMutex();
                    }
                }
            });

            var t2 = new Task(() => {

                for (int i = 0; i < 1000; i++)
                {
                    bool lockTaken = _m2.WaitOne();
                    try {
                        b2.Deposit(100);
                    } finally {
                        if (lockTaken) _m2.ReleaseMutex();
                    }
                }
            });


            var t3 = new Task(() => {

                for (int i = 0; i < 1000; i++)
                {
                    bool lockTaken = WaitHandle.WaitAll(new[] { _m1, _m2 });

                    try {

                        b1.Transfer(b2, 100);

                    } finally {

                        if (lockTaken) {
                            _m1.ReleaseMutex();
                            _m2.ReleaseMutex();
                        }
                    }
                }
            });

            t1.Start();
            t2.Start();
            t3.Start();

            Task.WaitAll(new[] { t1, t2, t3 });

            Console.WriteLine("{0} - bank Account 1 balance", b1.Balance);
            Console.WriteLine("{0} - bank Account 2 balance", b2.Balance);


        }
    }
}
