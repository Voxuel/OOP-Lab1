using System;
using System.Collections.Generic;
using System.Text;

namespace CirclePorgram
{
    class Triangle
    {
        private float Base, Volume, Length, Area, Height;

        public Triangle(float _base, float _height)
        {
            this.Base = _base;
            this.Height = _height;
        }
        public Triangle(float _base, float _height, float _length)
        {
            this.Base = _base;
            this.Height = _height;
            this.Length = _length;
        }
        public float GetArea()
        {
            Area = 0.5f * Base * Height;
            return Area;
        }
        public float GetPrismVolume()
        {
            Volume = 0.5f * Base * Height * Length;
            return Volume;
        }
    }
}
