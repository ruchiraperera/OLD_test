using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_n_Algorithm
{
    public class manual_linkedList
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public manual_linkedList Next { get; set; }

    }


    public class linked_list
    {

        manual_linkedList first;

        public manual_linkedList getter {
            get {
                return this.first;
            }
        }

        public linked_list(object _object)
        {
            first = (manual_linkedList)_object;
        }


        public void addAfter(object _obj)
        {

            manual_linkedList demo = first;

            while (demo.Next != null)
            {
                demo = demo.Next;
            }

            demo.Next = (manual_linkedList)_obj;
        }


    }







}
