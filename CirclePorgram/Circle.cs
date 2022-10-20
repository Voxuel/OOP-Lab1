using System;
using System.Collections.Generic;
using System.Text;

namespace CirclePorgram
{
    class Circle
    {
        // Create fields that will be used.
        private float Area,Volume,Circumference,Radius,Height;
        private float Pi = 3.141f;

        // Creates overload constructors depending on the type one would calculate.
        public Circle(float _radius)
        {
            this.Radius = _radius;
        }
        public Circle(float _radius, float _height)
        {
            this.Radius = _radius;
            this.Height = _height;
        }

        // Methods to calculate different things.
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
