using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Class1
    {
        public static void Main(String []args)
        {
            Class1 c1 = new Class1();
            Bundle test;
            test = c1.keyvalue() as Bundle;
            Console.WriteLine(test.keyvalue.Key);
        }

        public object keyvalue ()
        {
            Bundle bundle = new Bundle();
            bundle.keyvalue = new KeyValuePair<int, int>(5, 6);
            return bundle;
        }

        
    }

    public class Bundle
    {
        public KeyValuePair<int, int> keyvalue;
    }
}

