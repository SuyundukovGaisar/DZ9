using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal class Point : Figure
    {
        protected int x, y;
        public Point(int x, int y, string color, bool IsVisible) : base(color, IsVisible)
        {
            this.x = x;
            this.y = y;
        }
        public override void MoveX(int distance)
        {
            x += distance;
        }
        public override void MoveY(int distance)
        {
            y += distance;
        }
        public override void ChangeColor(string newcolor)
        {
            color = newcolor;
        }
        public override string CheckVisibility()
        {
            if (IsVisible)
            {
                return "Visible";
            }
            else
            {
                return "Invisible";
            }
        }
        public override void Print()
        {
            Console.WriteLine("X: {0}", x);
            Console.WriteLine("Y: {0}", y);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Visible: {0}", CheckVisibility());
        }
    }
}
