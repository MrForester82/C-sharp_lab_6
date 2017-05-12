using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lab_6_part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 5, 7, 4, 8 };
            Console.WriteLine(avarage(mas));

            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(avarage(z, e, v));

            Console.WriteLine(avarage());
        }

        /*
        Добавьте четвертый проект консольного приложения к уже сушествующим.
        Создайте статический метод Avarge, принимающий параметр-массив arr целочисленного типа и возвращающий среднее значение элементов массива. 
            {
            double av = 0;
            foreach (int elem in arr)
            av += elem;
            return (av/arr.Length);
            }
        В функции Main определите массив типа int, состоящий из 4 элементов. С помощью функции Avarge вычислите среднее значение элементов массива. 
        Объявите и инициализируйте две переменные типа short и одну переменную типа byte. Передайте их в качестве параметров функции Avarge.
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(Avarge(z, e, v));
        Вызовите метод Avarge без параметров. 
        Скомпилируйте проект. 
        */
        public static double avarage(params int[] par)
        {
            double av = 0;
            foreach (int elem in par)
                av += elem;
            return (av / par.Length);
        }
    }
}
