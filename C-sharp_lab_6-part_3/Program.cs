using System;

namespace C_sharp_lab_6_part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 42;
            double y = -12.67;
            double abs, sqr;
            bool isInteger;
            int sign;

            prop(x, out sign, out isInteger, out abs, out sqr);
            Console.WriteLine("numb = {0}\nsign = {1}\nisInteger = {2}\nabs = {3}\nsqr = {4}", x, sign, isInteger, abs, sqr);

            prop(y, out sign, out isInteger, out abs, out sqr);

            Console.WriteLine("\n\n numb = {0}\nsign = {1}\nisInteger = {2}\nabs = {3}\nsqr = {4}", y, sign, isInteger, abs, sqr);
        }

        /*
        Добавьте в существующее решение новый консольный проект так же, как в задании 2.
        Создайте статический метод, принимающий параметр вещественного типа и возвращающий информацию о нём: знак числа,
        является ли число целым, модуль числа, а так же квадрат числа. При этом само число по выходу из функции измениться не должно.
            Объявите функцию с одним параметром-значением типа double и выходными параметрами нужных значений: int для знака числа,
            bool для проверки на целочисленность, double для модуля числа и для квадрата числа. Функция не возвращает значения.
            В теле функции присвойте соответствующим параметрам необходимые значения в зависимости от входного параметра.
            Для этой цели удобно использовать статические методы класса Math из пространства имён System.
                sign = Math.Sign(value);
                isInteger = value % 1 == 0 ? true : false;
                abs = Math.Abs(value);
                sqr = value * value;
        В функции Main создайте две переменных типа double и инициализируйте их значениями 42 и -12.67. 
        Объявите, но не инициализируйте ещё две переменных типа double и по одной переменной типа int и bool. 
        Дважды вызовите метод, формирующий информацию о числе с различными инициализированными переменными.
        Не забудьте указать в качестве выходных параметров переменные нужного типа. После каждого вызова выводите на консоль результаты работы функции. 
        Скомпилируйте программу и посмотрите на результат её работы.
        */
        public static void prop(double value, out int sign, out bool isInteger, out double abs, out double sqr)
        {
            sign = Math.Sign(value);
            isInteger = value % 1 == 0 ? true : false;
            abs = Math.Abs(value);
            sqr = value * value;
        }
    }
}
