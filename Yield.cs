//using System;
//using System.Collections.Generic;

//namespace ConsoleApp2
//{
//    class Yield
//    {
//        static Random rand = new Random();
//        static IEnumerable<int> GetRandomNumbers(int count)
//        {
//            List<int> ints = new List<int>();
//            for (int i = 0; i < count; i++)
//                ints.Add(rand.Next());
//            return ints;
//        }

//        static void Main(string[] args)
//        {
//            foreach (int num in GetRandomNumbers(10))
//            {
//                Console.WriteLine(num);

//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Yield
    {
        static Random rand = new Random();
        static IEnumerable<int> GetRandomNumbers(int count)
        {
            for (int i = 0; i < count; i++)
                yield return rand.Next();
        }

        static void Main(string[] args)
        {
            foreach (int num in GetRandomNumbers(10))
            {
                Console.WriteLine(num);

            }
        }
    }
}
