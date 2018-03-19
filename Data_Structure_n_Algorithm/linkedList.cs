using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_n_Algorithm
{


    class student {

        public int ID { get; set; }
        public string Name { get; set; }
    }

    class singleLinkedList
    {
        public int data { get; set; }
        public singleLinkedList _next { get; set; }        
    }


    class linkedList {

        private singleLinkedList _first { get; set; }


        public linkedList(singleLinkedList _value)
        {
            _first = _value;
        }

        public void add(object _object) {

            singleLinkedList _temp = _first;

            while (_temp._next != null) {
                _temp = _temp._next;
            }

            _temp._next = (singleLinkedList) _object;
        }


    }


}
