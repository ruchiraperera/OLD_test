using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    interface IProduct1<T> where T: product
    {
        T CurrentProduct { get; }
        InfoModel infoModel { get; set; }
    }
}
