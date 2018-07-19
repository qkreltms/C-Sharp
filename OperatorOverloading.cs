using System;

namespace ConsoleApp1
{   
    class Vec3
    {
        public int x;
        public int y;
        public int z;

        public Vec3(){}
        public Vec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vec3 operator+ (Vec3 a, Vec3 b)
        {
            Vec3 v = new Vec3();
            v.x = a.x + b.x;
            v.y = a.y + b.y;
            v.z = a.z + b.z;
            return v;
        }
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vec3 a = new Vec3(1, 2, 3);
            Vec3 b = new Vec3(1, 2, 3);
            Vec3 sum;

            sum = a + b;
            Console.WriteLine("{0}, {1}, {2}", sum.x, sum.y, sum.z);
            Console.ReadKey();
        }
    }
}
