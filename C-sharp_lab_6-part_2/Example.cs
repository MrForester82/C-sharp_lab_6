using System;

namespace C_sharp_lab_6_part_2
{
    class Example
    {
        /*
        Добавьте в решение (Solution) из первого задания новый проект консольного приложения. 
            В меню выберите пункт File->Add->Create project.
            Далее в окне выбора проекта укажите тип проекта Console Application.
            Укажите имя проекта и нажмите OK.
        Скопируйте код класса Example и функции Main из первого проекта и вставьте его во второй.
        В методе Sqr измените объявление так, чтобы оба параметра передавались в метод по ссылке. 
            public static void Sqr(ref double a, ref double b)
        В функции Init так же измените тип параметра с параметра-значения на параметр-ссылку. 
        Скомпилируйте проект. 
            При необходимости, измените код функции Main. 
            Если какой-либо из вызовов функций не корректен для параметров-ссылок, закомментируйте его.
            Посмотрите результаты работы программы.
        Вызовите метод Sqr с неинициализированной переменной типа double.
            В теле функции Main объявите, но не инициализируйте новую переменную нужного типа.
            Добавьте вызов метода Sqr, передав в качестве второго аргумента только что объявленную переменную. 
                double c;
                Example.Sqr(ref a, ref c);
        Попробуйте скомпилировать проект.
        */

        public int x;
        public int y;

        public Example(int x)
        {
            this.x = x;
        }

        public static void init(ref Example obj)
        {
            Example newobj = new Example(11);
            obj = newobj;

            obj.x = 1;
            obj.y = 1;

            Console.WriteLine("После метода init.\t x = {0}\ty = {1}", obj.x, obj.y);
        }

        public static void sqr(ref double x, ref double y)
        {
            x = Math.Pow(x, 2);
            y = Math.Pow(y, 2);
            Console.WriteLine("В методе sqr.\t\t x = {0}\ty = {1}", x, y);
        }
    }
}
