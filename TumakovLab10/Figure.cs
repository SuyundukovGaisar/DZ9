using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    abstract class Figure
    {
        protected string color;
        protected bool IsVisible;

        public Figure(string color, bool IsVisible)
        {
            this.color = color;
            this.IsVisible = IsVisible;
        }
        public abstract void MoveX(int distance);
        public abstract void MoveY(int distance);
        public abstract void ChangeColor(string newcolor);
        public abstract string CheckVisibility();
        public abstract void Print();

    }
}
