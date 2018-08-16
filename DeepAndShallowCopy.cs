using System;

namespace ConsoleApp4
{
    class Class1 : ICloneable
    {
        private Model test1;

        public Class1()
        {
            test1 = new Model("원래값");
        }

        public Model GetTest() { return test1; }
        public void SetTest(Model m) { test1 = m; }

        //ICloneable을 구현하지 않고, 그냥 new Object후 값을 입력해주면 깊은 복사가 됨
        public object Clone()
        {
            return new Class1();
        }

        public static void DeepCopy()
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();

            c2 = c1.Clone() as Class1;

            //깊은복사 c2의 값만 바뀜
            c2.SetTest(new Model("다른 값을 넣어볼까?"));
            Console.WriteLine(c2.GetTest().test);
            Console.WriteLine(c1.GetTest().test);

        }

        public static void ShallowCopy()
        {
            Class1 c1 = new Class1();
            Class1 c2 = new Class1();

            c1 = c2;
            //얕은복사 같은 주소를 참조하고있기 때문에 서로 같은 값이 됨
            c2.SetTest(new Model("같은 값을 가지고 있다."));
            Console.WriteLine(c2.GetTest().test);
            Console.WriteLine(c1.GetTest().test);

        }
        public static void Main()
        {
            Class1.DeepCopy();
            Class1.ShallowCopy();
        }

        public class Model
        {
            public string test;

            public Model(string test)
            {
                this.test = test;
            }
        }
    }
}

