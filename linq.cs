using System;
using System.Linq;

namespace linq
{
    class Woman
    {
        public string name;
        public int age;
    }
    class Test
    {
        static void Main(string[] args)
        {
            Woman[] womenList =
            {
                new Woman() {name="ara", age=24},
                new Woman() {name="ara2", age=25},
                new Woman() {name="ara3", age=26}
            };

            var women = from woman in womenList
                        where woman.age > 20
                        orderby woman.age
                        select woman;

            foreach(var woman in women)
                Console.WriteLine("{0} : {1}", woman.name, woman.age);

        }
    }
}
