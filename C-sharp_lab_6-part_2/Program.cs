using System;

namespace C_sharp_lab_6_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 17.28;
            double y = 0.98;
            double a = 7.23;
            double c;

            Console.WriteLine("До метода sqr.\t\t x = {0}\ty = {1}", x, y);

            Example.sqr(ref x, ref y);
            //Example.sqr(ref a, ref c);
            Console.WriteLine("После метода sqr.\t x = {0}\ty = {1}", x, y);

            Example ex = new Example(8);

            Console.WriteLine("В методе Main:\t Obj.x = {0}\tObj.y = {1}", ex.x, ex.y);
            Example.init(ref ex);
            Console.WriteLine("В методе Main:\t Obj.x = {0}\tObj.y = {1}", ex.x, ex.y);
        }
    }
}
