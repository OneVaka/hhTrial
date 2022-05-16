using System;

namespace hhTrial
{
    public abstract class Shape
    {
        protected double area;

        public double Area => area;

        public abstract double getArea();
       
    }
}
