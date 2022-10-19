using System;
using System.Collections.Generic;
using System.Text;

namespace CirclePorgram
{
    class Circle
    {
        private float Area;
        public Circle(float radius)
        {
            this.Area = radius * radius * 3.141f;
        }
        public float GetArea()
        {
            return Area;
        }
    }
}
