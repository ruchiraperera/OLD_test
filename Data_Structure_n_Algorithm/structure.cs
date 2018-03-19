using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_n_Algorithm
{
    //struct is value type and  store in stack
    interface gt {
        void test();
    }


    struct customer
    {
        public int MyProperty { get; set; }
        //no constructors
        //no inheritance support
    }

    //implement interface support
    struct marks : gt
    {
        //this is explicitly 
        void gt.test()
        {
            throw new NotImplementedException();
        }

        //this is implicit
        public void test()
        {
            throw new NotImplementedException();
        }
    }
}
