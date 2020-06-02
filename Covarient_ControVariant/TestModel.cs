using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class TestModel<T> : IProduct1<T> where T : product
    {

        public TestModel(T currentProduct)
        {
            CurrentProduct = currentProduct;
        }
        public InfoModel infoModel { get; set; }
        public T CurrentProduct { get; private set; }
    }


    //public static class TestModel
    //{
    //    public static TestModel<T> Data<T> (T _product) where T:product
    //    {
    //        return new TestModel<T>(_product);
    //    }
    //}
}
