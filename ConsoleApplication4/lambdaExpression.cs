using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class lambdaExpression
    {

        private List<productx> _product;
        private List<order> _order;

        public lambdaExpression()
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
        }


        public void display() {

            //get all products
            var t = _order.ToList();

            //get all orders with product
            var t1 = _order.Join(_product, c => c.ProductId, p => p.productId, (c, p) => new { c, p }).ToList();

            //get all product doesn't have orders using left join
            //group join gives u some extra grouping option
            var t2 = _order.GroupJoin(_product, c => c.ProductId, p => p.productId, (c, p) =>
            new { _order= c, _product= p.SingleOrDefault() });

            //get all orders count group by products
            var t3 = _order.GroupBy(c => c.ProductId).Select(n => new { name = n.Key, count = n.Count() });

            //get product doesnt have orders
            var t7 = _product.Where(x => !(_order.Select(c => c.ProductId).Contains(x.productId))).ToList();

            //get all orders order by id desc
            var t4 = _order.OrderByDescending(x => x.ProductId).Select(z => new { z });

            //total orders
            var t5 = _order.Count();

            //total orders and total sum of price

            var t6 = _order.Join(_product, c => c.ProductId, p => p.productId, (c, p) => new { c, p }).GroupBy(x => x.p.productId).ToList();




        }


    }
}
