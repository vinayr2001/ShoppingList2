using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinayShoppingList2._0
{
    public class MyList
    {
        int[] num;

        public MyList()
        {
            num = new int[0];
        }

        public void Add(int value)
        {
            int[] temp = new int[num.Length + 1];

            for (int i = 0; i < num.Length; i++)
            {
                temp[i] = num[i];
            }

            temp[temp.Length - 1] = value;
            num = temp;
        }

        public bool Remove(int value)
        {
            if (Search(value) == true)
            {
                int[] temp = new int[num.Length - 1];                

                for (int i = 0, j = 0; i < num.Length; i++, j++)
                {
                    if (num[i] != value)
                    {
                        temp[j] = num[i];
                    }
                    else
                    {
                        j--;
                    }
                }

                num = temp;
                return true;
            }

            return false;
        }

        public bool Search(int value)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == value)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
