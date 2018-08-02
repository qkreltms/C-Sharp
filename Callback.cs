using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    
    class Class1
    {
        private delegate void Del(string msg);
        private void Notify(string name)
        {
            Console.WriteLine("my name is : {0}", name);
        }

        public static void Main()
        {
            Class1 c = new Class1();
            Del del = new Del(c.Notify);
            del("Jack");

            Del2 del2 = new Del2(c.Notify);
            del2("Happy");
            c.CallBack(del2);


            Console.ReadKey();


        }

        private delegate void Del2(string msg);
        private void CallBack(Del2 del)
        {

        }
    }
}
