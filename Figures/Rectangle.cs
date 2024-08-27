using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Figures
{
    internal class Rectangle
    {
        private float h;
        private float b;

        public Rectangle(float h, float b)
        {
            this.h = h;
            this.b = b;
        }

        public float GetArea()
        {
            return b * h;
        }
    }
}
