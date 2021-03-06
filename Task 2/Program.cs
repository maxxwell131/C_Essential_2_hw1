﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /*
     * Задание 2
        Используя Visual Studio, создайте проект по шаблону Console Application.
        Требуется: Создать класс с именем Rectangle.
        В теле класса создать два поля, описывающие длины сторон double side1, side2.
        Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
        поля side1 и side2 инициализируются значениями аргументов.
        Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
        прямоугольника - double PerimeterCalculator().
        Создать два свойства double Area и double Perimeter с одним методом доступа get.
        Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
        на экран периметр и площадь.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(100,200);

            Console.WriteLine("Rectangle Area is {0}", myRectangle.Area);
            Console.WriteLine("Rectangle Perimetrf is {0}", myRectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
