using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class Rectangle : Point
    {
        protected int width;
        protected int height;
        public Rectangle(int x, int y, string color, bool IsVisible, int width, int height) : base(x, y, color, IsVisible)
        {
            this.width = width;
            this.height = height;
        }
        public int CalculateAreaRectangle()
        {
            return width * height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Height: {0}", height);
        }
    }
}
