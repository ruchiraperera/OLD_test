using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = 1;

            using (databaseFirstEntities _db = new databaseFirstEntities())
            {
                tbl_customer _cus = new tbl_customer();
                _cus.customer_name = "ruchira1";
                _cus.customer_desc = "testing purposes";

                _db.tbl_customer.Add(_cus);
               // _db.SaveChanges();


                var t = 10;
                g = 2;
            }

            Console.WriteLine(g);
            
                Console.Read();


        }
    }
}
