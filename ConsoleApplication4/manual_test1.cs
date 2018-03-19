using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    internal class manual_test1
    {
        private List<productx> _product;
        private List<order> _order;
        public manual_test1()
        {
            this._product = new List<productx>() {
                new productx {productId =1, productName = "product1", Price = 20 },
                new productx {productId =2, productName = "product2", Price = 40 },
                new productx {productId =3, productName = "product3", Price = 60 },
                new productx {productId =4, productName = "product4", Price = 10 }
            };

            this._order = new List<order>() {
                  new order { OrderId = 1, ProductId=1 },
                  new order { OrderId = 2, ProductId=1 },
                  new order { OrderId = 3, ProductId=2 },
                  new order { OrderId = 4, ProductId=1 },
                  new order { OrderId = 5, ProductId=2 },
                  new order { OrderId = 6, ProductId=3 }
            };

            //get all product doesn't have orders using left join

        }



        public void linqtosqlqueries()
        { 
            //get all products
            var q1 = (from cv in _product select cv).ToList();    

            //get all orders with product
            var q2 = (from cv in _order join cb in _product on cv.ProductId equals cb.productId into cbs from cbss in cbs select new { cv, cbss }).ToList();

            //get all product with orders using left join
            var q3 = (from cv in _product join cb in _order on cv.productId equals cb.ProductId into cbs from cbss in cbs.DefaultIfEmpty() select new { cv, cbss }).ToList();

            //get product doesnt have orders
            var q7 = from cv1 in _product
            where !(from cb in _order select cb.ProductId).Contains(cv1.productId)
            select cv1;

            //get all orders count group by products
            var q4 = (from cv in _order group cv by cv.ProductId into cvs select new { name = cvs.Key, count = cvs.Select(x => x.OrderId).Count() }).ToList();
            
            //get all orders order by id desc
            var q5 = (from cv in _order orderby cv.OrderId descending select cv).ToList();

            //total orders
            var t5 = from cv in _order group cv by cv.OrderId into cbs select new { total = cbs.Count() };

            //total orders and total sum of price
            var q6 = (from cv in _order
                      join cd in _product on cv.ProductId equals cd.productId
                      group cd by 1
                                  into cds
                      select new { Count = cds.Select(c => c.Price).Sum() }).ToList();


            //var t9 = (from cv in _order
            //          join cb in _product on cv.ProductId equals cb.ProductId into cbs
            //          from cbss in cbs
            //          group cbss by 1
            //        into cbsss
            //          select new { count = cbsss.Count(), price = cbsss.Sum(c => c.Price) }).ToList();

            //get all product count
            var q7 = (from cv in _product group cv by 1 into cxs select cxs.Select(c => c.productId).Count()).First();
            //var t10 = from cv in _product group cv by 1 into cbs select cbs.Count();

            //get orders skip 1 and take 2
            var q8 = (from cx in _order join cd in _product on cx.ProductId equals cd.productId into cxs from cxss in cxs select new { cx, cxss }).Skip(1).Take(2).ToList();
            

        }


    }


    public class productx
    {

        public int productId { get; set; }
        public string productName { get; set; }

        private int? price;

        public int? Price
        {

            get { return price; }
            set { this.price = value; }
        }
    }

    public class order
    {

        private int orderId;

        public int OrderId
        {

            get { return this.orderId; }
            set { this.orderId = value; }

        }

        private int productId;

        public int ProductId
        {

            get;
            set;
        }
    }
}
