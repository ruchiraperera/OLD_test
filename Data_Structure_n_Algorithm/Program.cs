
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_n_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Linkedlist with data structure

            LinkedList<manual_linkedList> _lm = new LinkedList<manual_linkedList>();
            _lm.AddLast(new manual_linkedList() { ID = 1, Name = "Ruchira" });
            _lm.AddLast(new manual_linkedList() { ID = 2, Name = "Ruchira1" });
            _lm.AddLast(new manual_linkedList() { ID = 3, Name = "Ruchira2" });

            //get object
            var item = _lm.Where(x => x.ID == 2).First();

            //get node
            LinkedListNode<manual_linkedList> _node1 = _lm.Find(_lm.Where(x => x.ID == 2).FirstOrDefault());
            LinkedListNode<manual_linkedList> _node = _lm.Find(item);

            //add after find node 
            _node.List.AddAfter(_node, new manual_linkedList() { ID = 1, Name = "Ruchira3" });

            //get max ID
            _lm.Max(x => x.ID);

            //add first new object
            LinkedListNode<manual_linkedList> _mn = new LinkedListNode<manual_linkedList>(new manual_linkedList() { ID = 5, Name = "Ruchira5" });
            _node.List.AddFirst(_mn);

            Console.Read();

            #endregion
            
            #region Manual process......!!!!

            //manula process...

            linked_list _linked_List = new linked_list(new manual_linkedList() { ID = 1, Name = "Ruchira" });
            _linked_List.addAfter(new manual_linkedList() { ID = 2, Name = "Ruchira2" });

            Console.Read();




            #endregion
            
            //structure.....
            var _cus = new customer();
            _cus.MyProperty = 12;

            var _m = new marks();
            _m.test();


            Console.Read();
        }
    }
}
