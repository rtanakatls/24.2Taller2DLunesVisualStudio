using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioSemana1.Figures
{
    internal class Circle
    {
        private float radius;
        private float pi = 3.14f;

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float GetArea()
        {
            return pi * radius * radius;
        }
    }
}
