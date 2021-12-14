using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TriangleSqr
{
    class Program
    {
        /*
         * Обязательная задача*. Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше (создать метод 
         * для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона.
         * 
         * Программа:
         * 2 метода. Метод 1 считывает введенные пользователем данные. С помощбю него осуществляется присваивание значение сторон треугольников.
         * Метод 2. Вычисляет площадь треугольника, возвращает значение площади.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник 1");
            int side1Triangle1 = EnterTriangleSides();
            int side2Triangle1 = EnterTriangleSides();
            int side3Triangle1 = EnterTriangleSides();
            Console.WriteLine("Треугольник 2");
            int side1Triangle2 = EnterTriangleSides();
            int side2Triangle2 = EnterTriangleSides();
            int side3Triangle2 = EnterTriangleSides();
            Console.WriteLine();

            double sqrTriangle1 = CalcTriangleSqr(side1Triangle1, side2Triangle1, side3Triangle1);
            double sqrTriangle2 = CalcTriangleSqr(side1Triangle2, side2Triangle2, side3Triangle2);

            if (sqrTriangle1 == sqrTriangle2)
                Console.WriteLine($"Площади треугольников равны: {sqrTriangle1:f3}");
            else
            {
                Console.WriteLine((sqrTriangle1 > sqrTriangle2) ?
                 $"Площадь треугольника 1: {sqrTriangle1:f3} больше треугольника 2: {sqrTriangle2:f3}" :
                 $"Площадь треугольника 2: {sqrTriangle2:f3} больше треугольника 1: {sqrTriangle1:f3}");
            }
            Console.ReadKey();
        }

        static int EnterTriangleSides()
        {
            Console.Write("Введите сторону треугольника: ");
            int side = Convert.ToInt32(Console.ReadLine());
            return side;
        }
        static double CalcTriangleSqr(int side1, int side2, int side3)
        {
            int halfPerimetr = (side1 + side2 + side3) / 2;
            double triangleSqr = Math.Sqrt(halfPerimetr * (halfPerimetr - side1) * (halfPerimetr - side2) * (halfPerimetr - side3));
            return triangleSqr;
        }
    }
}
