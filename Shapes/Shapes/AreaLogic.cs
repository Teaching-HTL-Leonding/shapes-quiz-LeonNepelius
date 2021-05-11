using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class AreaLogic
    {
        public static double CircleArea(float r) => Math.PI* Math.Pow(r, 2);

        public static double RectangleArea(float a, float b) => a * b;

        public static double TriangleArea(float ba, float h) => (ba * h)/2;
    }
}
