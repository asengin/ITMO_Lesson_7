using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CubeSqrVolume
{
    class Program
    {
        //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
        static void Main(string[] args)
        {
            Console.Write("Введите размер ребра куба: ");
            int edgeCube = Convert.ToInt32(Console.ReadLine());
            if (edgeCube < 0)
            {
                Console.WriteLine("Значение должно быть положительным!");
                Console.ReadKey();
                return;
            }
            int sqrCube, volumeCube;
            CalcCubeSqrVolume(edgeCube, out sqrCube, out volumeCube);
            Console.WriteLine($"Объем куба: {volumeCube}. Площадь поверхности куба: {sqrCube}");
            Console.ReadKey();
        }
        static void CalcCubeSqrVolume(int edge, out int sqr, out int volume)
        {
            volume = (int)Math.Pow(edge, 3); //Явное преобразование из-за метода Pow возвращающего double. Можно использовать, т.к. сторона куба целое число
            sqr = edge * edge * 6;
        }
    }
}
