using System;
using System.Threading;
using System.Threading.Tasks;

namespace locks
{

    public class BankAccount
    {
        private float _balance;
        public float Balance { get { return _balance; } private set { this._balance = value; } }
        private object _lock = new object();

        public virtual void Deposit(dynamic balance)
        {
            //System.Threading.Interlocked.Add(ref _balance, balance); //it allows only integer values.
            lock (_lock)
            {
                Balance += balance;
            }

        }


        public virtual void Withdraw(dynamic balance)
        {

            lock (_lock)
            {
                Balance -= balance;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var mutexLock = new _mutesProcess();
            mutexLock.process();

            Console.Read();

            var _spinLocks = new _spinlockProcess();
            _spinLocks.process();

            Console.Read();



            var ba = new BankAccount();

            var _t1 = new Task(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    ba.Deposit(100);
                }
            });

            var _t2 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    ba.Withdraw(100);
                }
            });


            _t1.Start();
            _t2.Start();



            Task.WaitAll(new[] { _t1, _t2 });

            Console.WriteLine("{0} - bank account balance", ba.Balance);


            Console.Read();           
        }
    }
}
