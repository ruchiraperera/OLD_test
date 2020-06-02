using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class ProductModel<T> : IProduct<T> where T : product
    {
        public T CurrentProduct { get; private set; }

        public ProductModel(T product)
        {
            this.CurrentProduct = product;
        }

        public InfoModel InfoModel { get; set; }

    }


    public static class ProductModel
    {
        public static ProductModel<T> Data<T>(T product) where T: product
        {
            return new ProductModel<T>(product);
        }
    }
}
