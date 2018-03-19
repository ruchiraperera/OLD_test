using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
              

        static void Main(string[] args)
        {

            // IenumarableVsIquerable_test();
            //_linqTosqlTest();
            // _lambdatosqlforeachperformance();


            manual_test1 _m = new manual_test1();
            _m.linqtosqlqueries();


            Console.Read();
        }

        static void IenumarableVsIquerable_test() {


            //cloudchargepaymentEntities _en1 = new cloudchargepaymentEntities();

            //var _p = (from cx in _en1.msg_logs orderby cx.Id ascending select cx).AsEnumerable<msg_logs>();
            //var _t = (from cx in _en1.msg_logs orderby cx.Id ascending select cx).AsQueryable<msg_logs>();
            //var cf = _t.Skip(10).ToString();
            //var cv = _p.Skip(10).ToString();          

           // var t = _p.ToList().Skip(10).ToString();
           

        }

        static void _linqTosqlTest()
        {

            //cloudchargepaymentEntities _en1 = new cloudchargepaymentEntities();

            //get top 10 record in desc order from ipn logs table


            #region let into lambda expressions

            //Into – Hides the previous variable when used in a query, as you see in the above example.Which means it hides the previous range variable and creates a temporary range variable which you can use in further operations.
            //Let – Doesn’t hide the previous variable and creates a new variable.Which means you create a new variable and you can also use the previous variable, so you can use both in further operations.


            //var _ipnlogs2 = from cd in _en1.IPN_logs group cd by new { cd.merchant, cd.type } into cds select cds;

            //var cv = _ipnlogs2.Take(10).ToList();

            //var _ipnlogs3 = from cd in _en1.IPN_logs select new { cd.merchant,cd.Id} into cds select cds;

            //var _ipnlogs4 = from cd in _en1.IPN_logs group cd by cd.merchant into cds select cds;

            //var _ipnlogs5 = from cd in _en1.IPN_logs let bvc = "cloudcharge" where cd.merchant == bvc  select cd;

            //var l = from cd in _en1.IPN_logs as IQueryable<IPN_logs> select cd;

            #endregion


            #region

            //inner join query
            //var _query1 = from cx in _en1.UserMappings join cs in _en1.subscriptions on new { cx.subscriptionId } equals new { cs.subscriptionId } select cx;

            //var str = _query1.ToString();


            //left join query
            var _query2 = from cx in _en1.UserMappings
                          join cs in _en1.subscriptions on cx.subscriptionId equals cs.subscriptionId
                          into cds
                          from cxx in cds.DefaultIfEmpty()
                          select cxx;
            
            var _str1 = _query2.ToString();

            #endregion


        }

        static void _lambdatosqlforeachperformance()
        {

            Stopwatch _c = new Stopwatch();
            _c.Start();

           // cloudchargepaymentEntities _en = new cloudchargepaymentEntities();

            //get top 10 record in desc order from ipn logs table
            //lambda expression
          //  IQueryable<IPN_logs> _ipnlogs = _en.IPN_logs.OrderByDescending(x => x.receivedDate).Take(10);
            _ipnlogs.ToList().ForEach(xs =>
            {
                Console.WriteLine(xs.Id.ToString());
            });


            _c.Stop();

            Console.WriteLine(string.Format("linq {0}", _c.ElapsedMilliseconds));


            Stopwatch _c1 = new Stopwatch();
            _c1.Start();

            //cloudchargepaymentEntities _en1 = new cloudchargepaymentEntities();

            //get top 10 record in desc order from ipn logs table
          //  IQueryable<IPN_logs> _ipnlogs1 = _en.IPN_logs.OrderByDescending(x => x.receivedDate).Take(10);

           // var xc = _ipnlogs1.ToList();

            foreach (IPN_logs cn in xc)
            {

                Console.WriteLine(cn.Id.ToString());

            }

            _c1.Stop();

            Console.WriteLine(string.Format("just foreach {0}", _c1.ElapsedMilliseconds));



        }
    }


    
}
