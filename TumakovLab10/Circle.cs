using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class Circle : Point
    {
        protected double radius;
        public Circle(int x, int y, string color, bool IsVisible, int radius) : base(x, y, color, IsVisible)
        {
            this.radius = radius;
        }
        public double CalculateAreaCircle()
        {
            return Math.PI * radius * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Radius: {0}", radius);
        }
    }
}
