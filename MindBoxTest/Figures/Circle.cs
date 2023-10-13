using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Figures
{
    internal class Circle : ICircle
    {
        public const double MinRadius = 0.0;

        public Circle(double radius)
        {
            if (radius >= MinRadius)
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException("Wrong radius", nameof(radius));
            }
        }

        public double Radius { get; }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
