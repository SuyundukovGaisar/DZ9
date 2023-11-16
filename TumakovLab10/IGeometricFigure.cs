using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab10
{
    internal interface IGeometricFigure
    {
        void MoveX(int distance);
        void MoveY(int distance);
        void ChangeColor(string newColor);
        string CheckVisibility();
        void Print();
    }
}
