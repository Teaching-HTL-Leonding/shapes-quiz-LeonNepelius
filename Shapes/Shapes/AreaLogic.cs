using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class AreaLogic
    {
        public static double CircleArea(float r) => Math.Round(Math.PI* Math.Pow(r, 2), 2);

        public static double RectangleArea(float a, float b) => Math.Round(a * b, 2);

        public static double TriangleArea(float ba, float h) => Math.Round((ba * h)/2, 2);
    }
}
