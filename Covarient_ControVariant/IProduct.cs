using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public interface IProduct<out T> where T : product
    {
        T CurrentProduct { get;}
        InfoModel InfoModel { get; set; }
    }
}
