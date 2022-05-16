using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTrial
{
    public class Triangle : Shape
    {

        private double side_A, side_B, side_C;

        public Triangle(double A,double B,double C)
        {
            if (!isTriangle(A, B, C))
                throw new Exception("Not a triangle!");

            this.side_A = A;
            this.side_B = B;
            this.side_C = C;
            this.area = getArea();
        }

        public override double getArea()
        {
            double p = (side_A + side_B + side_C) / 2;

            return Math.Sqrt(p * (p - side_A) * (p - side_B) * (p - side_C)); 
        }

        static public bool isTriangle(double A, double B, double C)
        {
            return ((A < B + C) && (B < A + C) && (C < A + B));
        }

        static public bool checkSrtaight(Triangle triangle)
        {
            return checkSrtaight(triangle.side_A, triangle.side_B, triangle.side_C);
        }

        static public bool checkSrtaight(double A, double B, double C)
        {
            if (!isTriangle(A, B, C))
                throw new Exception("Not a triangle!");

            A *= A;
            B *= B;
            C *= C;

            if (C == A + B || B == A + C || A == B + C)
                return true;

            return false;

        }

    }
}
