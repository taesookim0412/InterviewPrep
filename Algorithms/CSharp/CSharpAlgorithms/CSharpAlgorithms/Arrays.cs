using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    internal class Arrays
    {
        public Arrays()
        {
            Console.WriteLine("Collections");
            Console.WriteLine("Arrays");
            arrays();
            Console.WriteLine("ArraysTwo");
            arraysTwo();
            Console.WriteLine("ArrayList");
            arrayList();
            Console.WriteLine("List");
            list();
            Console.WriteLine("ListObject");
            listObject();
        }

        /** 
         Primitive type fixed-size array */
        public void arrays()
        {
            string[] arr = new string[10];
            arr[0] = "hello";
            arr[1] = "world";
            Console.WriteLine(string.Join(" ", arr));
        }
        /**
         * These fixed size arrays can wrap any object.*/
        public void arraysTwo()
        {
            String[] arr = new String[10];
            arr[0] = "hello";
            arr[1] = "world";
            Console.WriteLine(String.Join(" ", arr));
        }

        /** 
         * Collections ArrayList is very slow.
         * Should use List instead.
         */
        public void arrayList()
        {
            ArrayList list = new ArrayList(3);
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");

            // ArrayList Indexing:
            Console.WriteLine(list[0]);

            // Must convert ToArray or WriteLine doesn't like it.
            String s = String.Join(" ", list.ToArray());
            Console.WriteLine(s);
        }

        public void list()
        {
            List<string> list = new List<string>();
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");


            Console.WriteLine(list[0]);

            Console.WriteLine(String.Join(" ", list));
        }

        public void listObject()
        {
            List<String> list = new List<String>();
            list.Add("Item1");
            list.Add("Item2");
            list.Add("Item3");


            Console.WriteLine(list[0]);

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
