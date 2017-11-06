using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        /// <summary>
        /// Построение прямоугольника.
        /// </summary>
        /// <param name="side1">Длина первой стороны</param>
        /// <param name="side2">Длина второй стороны</param>
        private double side1, side2;

        /// <summary>
        /// площадь
        /// </summary>
        public double Area {
            get { return this.AreaCalculator(); }
        }

        /// <summary>
        /// периметр
        /// </summary>
        public double Perimeter {
            get { return this.PerimeterCalculator(); }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// Расчет площади прямоугольника
        /// </summary>
        /// <returns>площадь</returns>
        double AreaCalculator()
        {
            return this.side1 * this.side2;
        }

        /// <summary>
        /// Расчет периметра прямоугольника
        /// </summary>
        /// <returns>периметр</returns>
        double PerimeterCalculator()
        {
            return 2 * (this.side1 + this.side2);
        }
    }
}
