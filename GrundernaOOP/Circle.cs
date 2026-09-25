using System;
using System.Collections.Generic;
using System.Text;

namespace GrundernaOOP
{
    internal class Circle //clas called Circle
    {
        private int _radius; //declaring the integer for the radius,
                             //making the field private since the starting code said _radius

        public Circle(int radius) //konstruktor
        {
            _radius = radius; //the int _radius will be the value added in the int radius in the brackets () by the user
        }

        public double GetArea() //method to calculate the circle area
        {
            return _radius * _radius * Math.PI; //returns the value of radius*radius*PI
        }

    }
}
