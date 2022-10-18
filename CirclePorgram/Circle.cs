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
            Area = radius * radius * 3.14f;
        }
        public string GetArea()
        {
            return Area.ToString();
        }
    }
}
