using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinayShoppingList2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(1);
            list.Add(2);
            list.Add(10);
            list.Add(13);
            list.Add(5);
            list.Add(21);

            list.Remove(13);
        }
    }
}
