using System;
using System.Collections.Generic;
using System.Text;

namespace CirclePorgram
{
    class Circle
    {
        private float Area;
        private float Volume;
        private float Circumference;
        private float Radius;
        private float Height;
        private float Pi = 3.141f;
        public Circle(float radius)
        {
            this.Radius = radius;
        }
        public Circle(float radius, float height)
        {
            this.Radius = radius;
            this.Height = height;
        }
        public float GetArea()
        {
            Area = Radius * Radius * 3.141f;
            return Area;
        }
        public float GetVolume()
        {
            Volume = Pi * (Radius * Radius) * Height;
            return Volume;
        }
        public float GetCircumference()
        {
            Circumference = (Radius * 2) * Pi;
            return Circumference;
        }
    }
}
