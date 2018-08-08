using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    abstract class Rect
    {
        protected abstract float GetSize();
        public virtual float GetSize2()
        {
            return 6f;
        }
    }
    class Program : Rect
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.Write(p.GetSize2()); //virtual 선언은 구현해도 되고 구현하지 않아도 된다.
            Console.Write(p.GetSize());
            Console.ReadKey();
        }

        protected override float GetSize()
        {
            //사용자가 구현해야한다.
            //무언가 동작해서 5f를 반환한다고 가정한다.
            return 5f;
        }

        //public override float GetSize2()
        //{
        //    return 7f;
        //}
    }
}
