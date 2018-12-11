using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/** 
 * Class to manage the production of orders. Inventory will be checked within this class.
 * 
 * */
namespace mgis350_project3
{
    class Order
    {
        public decimal amt = 0;
        public bool strawberry = false;
        public bool banana = false;
        public bool size = false; // false = small, true = large
        public bool honey = false;
        // initializing no inventory for this order
        public decimal strawbInv = 0;
        public decimal bananInv = 0;
        public decimal honeyInv = 0;
        public decimal milkInv = 0;
        public decimal smallCupsInv = 0;
        public decimal largeCupsInv = 0;

        public Order() {  }

        public Order(decimal _amt, bool s, bool b, bool _size, bool h)
        {
            amt = _amt;
            strawberry = s;
            banana = b;
            size = _size;
            honey = h;
        }
    }
}
