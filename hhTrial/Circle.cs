﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTrial
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            this.area = getArea();
        }

        public override double getArea()
        {
            return Math.PI * (radius * radius);
        }
    }
}
