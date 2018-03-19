using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class product1
    {
        public int product1Id { get; set; }
        public string product1Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }

    class order1
    {

        public int order1Id { get; set; }
        public int productId { get; set; }
        public int order1Quantity { get; set; }
    }

    public class Class6
    {
        List<product1> _product1 = null;
        List<order1> _order1 = null;

        public Class6()
        {
            _product1 = new List<product1>() {
                new product1(){product1Id = 1, product1Name ="product1 A", Price= 10, Quantity = 100},
                new product1(){product1Id = 2, product1Name ="product1 B", Price= 20, Quantity = 30},
                new product1(){product1Id = 3, product1Name ="product1 C", Price= 50, Quantity = 0},
                new product1(){product1Id = 4, product1Name ="product1 D", Price= 40, Quantity = 10},
                new product1(){product1Id = 5, product1Name ="product1 E", Price= 60, Quantity = 200},
            };

            _order1 = new List<order1>()
            {
                new order1(){ order1Id =1, productId=1, order1Quantity=10 },
                new order1(){ order1Id =2, productId=2, order1Quantity=10 },
                new order1(){ order1Id =3, productId=2, order1Quantity=10 },
                new order1(){ order1Id =4, productId=4, order1Quantity=10 },
                new order1(){ order1Id =5, productId=3, order1Quantity=10 },
                new order1(){ order1Id =6, productId=4, order1Quantity=10 }
            };
        }



        public void run()
        {

            //get all product1s
            var t1 = from cv in _product1 select cv;
            var l1 = _product1.ToList();

            //get all order1s with product1
            var t2 = from cv in _product1 join cb in _order1 on cv.product1Id equals cb.productId into cbs select new { cv, cbs };
            var l2 = _product1.Join(_order1, c => c.product1Id, p => p.productId, (c, p) => new { c, p }).ToList();


            //get all product1 with order1s using left join
            var t3 = from cv in _order1 join cb in _product1 on cv.productId equals cb.product1Id into cbs from cbss in cbs.DefaultIfEmpty() select new { cv, cbss };
            //var l3 = _product1.GroupJoin(_order1, c => c.product1Id, p => p.product1Id, (c, p) => new { _product1 = c, _order1 = p.SingleOrDefault() }).ToList();


            //get product1 doesnt have order1s
            var t4 = from cv in _product1 where !(from cd in _order1 select cd.productId).Contains(cv.product1Id) select cv;
            var l4 = _product1.Where(x => !(_order1.Select(c => c.productId).Contains(x.product1Id))).ToList();


            //get all order1s count group by product1s
            var t5 = from cv in _order1 group cv by cv.productId into cbs select new { cbs.Key, count = cbs.Count() };
            var l5 = _order1.GroupBy(c => c.productId).Select(c => new { c.Key, count = c.Count() });

            //get all order1s order1 by id desc
            var t6 = from cv in _order1 orderby cv.productId descending select cv;
            var l6 = _order1.OrderByDescending(c => c.order1Id).ToList();

            //total order1s
            var t7 = from cv in _order1 group cv by 1 into cbs select new { count = cbs.Count() };
            var l7 = _order1.Count();

            //total order1s and total sum of price

            var t8 = from cv in _order1 group cv by 1 into cbs select new { count = cbs.Count(), sum = cbs.Sum(x => x.order1Quantity) };
            var t9 = (from cv in _order1
                      join cb in _product1 on cv.productId equals cb.product1Id into cbs
                      from cbss in cbs
                      group cbss by 1
                     into cbsss
                      select new { count = cbsss.Count(), price = cbsss.Sum(c => c.Price) }).ToList();


            var l8 = _order1.Join(_product1, c => c.productId, p => p.product1Id, (c, p) => new { c, p }).GroupBy(v => v.c.order1Id).Select(x => new { x.Key, sum = x.Sum(n => n.p.Price) }).ToList();




            //get all product1 count
            var t10 = from cv in _product1 group cv by 1 into cbs select cbs.Count();
            var l10 = _product1.Count();

            //get order1s skip 1 and take 2
            var t11 = (from cv in _order1 select cv).Skip(1).Take(2).ToList();
            var l11 = _order1.Skip(1).Take(2).ToList();

        }




    }
}
