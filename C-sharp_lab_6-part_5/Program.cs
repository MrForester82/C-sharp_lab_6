using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab_6_part_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 5, 7, 4, 8 };
            Console.WriteLine(avarage(mas));
            //Console.WriteLine(avarage(3, 5, 8));   <тип>[] принимает только массивы, в отличие от  params <тип>[] 

            Console.WriteLine(avaragePar(mas));
            Console.WriteLine(avaragePar(3, 5, 8));

            string str = "строка.";

            strings(ref str);
            Console.WriteLine("Строка после изменения изменения в main: {0}", str);

            int z = 0;
            float m = 0.0F;
            bool f = true;
            type(z);
            type(m);
            type(f);
            type(mas);

        }

        /*
        Создайте проекты, иллюстрирующие следующие особенности передачи параметров в функцию.
            Отличие параметров <тип>[] от params <тип>[]. Передача массивов в функцию. 
            params – по значению или по ссылке.
            Передача в методы строк. Изменение строк в методе.
            Object как формальный параметр функции. Определение типа переданного в функцию аргумента.

        */
        public static double avaragePar(params int[] par)   // только по значению
        {
            double av = 0;
            foreach (int elem in par)
                av += elem;
            return (av / par.Length);
        }

        public static double avarage(int[] par)
        {
            double av = 0;
            foreach (int elem in par)
                av += elem;
            return (av / par.Length);
        }

        public static void strings(ref string str)
        {
            Console.WriteLine("Строка до изменения: {0}", str);

            str = "новая строка.";

            Console.WriteLine("Строка после изменения изменения в методе strings: {0}", str);
        }

        public static void type(Object obj)
        {
            Console.WriteLine("Тип переданного объекта: {0}", obj.GetType());
        }
    }
}
