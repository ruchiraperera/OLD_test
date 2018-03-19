using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{
    class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }

    class order
    {

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }

    public class Class6
    {
        List<product> _product = null;
        List<order> _order = null;

        public Class6()
        {
            _product = new List<product>() {
                new product(){ProductId = 1, ProductName ="product A", Price= 10, Quantity = 100},
                new product(){ProductId = 2, ProductName ="product B", Price= 20, Quantity = 30},
                new product(){ProductId = 3, ProductName ="product C", Price= 50, Quantity = 0},
                new product(){ProductId = 4, ProductName ="product D", Price= 40, Quantity = 10},
                new product(){ProductId = 5, ProductName ="product E", Price= 60, Quantity = 200},
            };

            _order = new List<order>()
            {
                new order(){ OrderId =1, ProductId=1, OrderQuantity=10 },
                new order(){ OrderId =2, ProductId=2, OrderQuantity=10 },
                new order(){ OrderId =3, ProductId=2, OrderQuantity=10 },
                new order(){ OrderId =4, ProductId=4, OrderQuantity=10 },
                new order(){ OrderId =5, ProductId=3, OrderQuantity=10 },
                new order(){ OrderId =6, ProductId=4, OrderQuantity=10 }
            };
        }



        public void run()
        {

            //get all products
            var t1 = from cv in _product select cv;
            var l1 = _product.ToList();

            //get all orders with product
            var t2 = from cv in _product join cb in _order on cv.ProductId equals cb.ProductId into cbs select new { cv, cbs };
            var l2 = _product.Join(_order, c => c.ProductId, p => p.ProductId, (c, p) => new { c, p }).ToList();


            //get all product with orders using left join
            var t3 = from cv in _order join cb in _product on cv.ProductId equals cb.ProductId into cbs from cbss in cbs.DefaultIfEmpty() select new { cv, cbss };
            //var l3 = _product.GroupJoin(_order, c => c.ProductId, p => p.ProductId, (c, p) => new { _product = c, _order = p.SingleOrDefault() }).ToList();


            //get product doesnt have orders
            var t4 = from cv in _product where !(from cd in _order select cd.ProductId).Contains(cv.ProductId) select cv;
            var l4 = _product.Where(x => !(_order.Select(c => c.ProductId).Contains(x.ProductId))).ToList();


            //get all orders count group by products
            var t5 = from cv in _order group cv by cv.ProductId into cbs select new { cbs.Key, count = cbs.Count() };
            var l5 = _order.GroupBy(c => c.ProductId).Select(c => new { c.Key, count = c.Count() });

            //get all orders order by id desc
            var t6 = from cv in _order orderby cv.ProductId descending select cv;
            var l6 = _order.OrderByDescending(c => c.OrderId).ToList();

            //total orders
            var t7 = from cv in _order group cv by 1 into cbs select new { count = cbs.Count() };
            var l7 = _order.Count();

            //total orders and total sum of price

            var t8 = from cv in _order group cv by 1 into cbs select new { count = cbs.Count(), sum = cbs.Sum(x => x.OrderQuantity) };
            var t9 = (from cv in _order
                      join cb in _product on cv.ProductId equals cb.ProductId into cbs
                      from cbss in cbs
                      group cbss by 1
                     into cbsss
                      select new { count = cbsss.Count(), price = cbsss.Sum(c => c.Price) }).ToList();


            var l8 = _order.Join(_product, c => c.ProductId, p => p.ProductId, (c, p) => new { c, p }).GroupBy(v => v.c.OrderId).Select(x => new { x.Key, sum = x.Sum(n => n.p.Price) }).ToList();




            //get all product count
            var t10 = from cv in _product group cv by 1 into cbs select cbs.Count();
            var l10 = _product.Count();

            //get orders skip 1 and take 2
            var t11 = (from cv in _order select cv).Skip(1).Take(2).ToList();
            var l11 = _order.Skip(1).Take(2).ToList();

        }




    }
}
