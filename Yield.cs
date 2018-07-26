/*
yield 키워드 (값이 나올 때까지 기다림)
for, foreach등 반복문을 쓸 때 따로 임시 저장하는 변수가 없어도 사용할 수 있도록 함.
참고: https://www.youtube.com/watch?v=L6R08ajgZpU
*/


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
