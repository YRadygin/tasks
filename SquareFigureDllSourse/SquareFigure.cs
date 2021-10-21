using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFigure
{
    public class Figure
    {
        public double SquareCircle(int rCircle)  //Вычисляем площадь круга, входной параметр радиус
        {
            double sCircle = Math.PI * rCircle;
            return sCircle;      //Возвращаем значение
        }

        public void SquareTriangle(int a, int b, int c, out string typeTriangle, out double sTriangle) //Принимаем размеры сторон, возвращаем тип треугольника и площадь
        {
            if ((a + b) > c && (b + c) > a && (a + c) > b) { //Проверяем существование треугольника
                if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) //Проверяем прямоугольный или нет треугольник 
                {
                    typeTriangle = "Треугольник прямоугольный";

                }
                else
                {
                    typeTriangle = "Треугольник не прямоугольный";

                }
                double p = (a + b + c) / 2; //Находим полупериметр
                sTriangle = Math.Sqrt((p * (p - a)) * (p - b) * (p - c)); //Находим площадь
            }
            else
            {
                typeTriangle = "Треугольник не существует";
                sTriangle = 0;

            }
        }

    }
}
