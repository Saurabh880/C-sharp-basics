using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class HashCollection
    {
        static void main()
        {

            Hashtable ht = new Hashtable();
            ht.Add(1, "Tom");
            ht.Add(2, "Sam");
            ht.Add(3, "Alex");
            ht.Add(4, "Tom");
            int[] indices = new int[2];
            int i = 0;
            foreach(int key in ht.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine();
        }
    }
}
