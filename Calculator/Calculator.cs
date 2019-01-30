﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class Calculator
    {

        public double Accumulator { get; private set; }



        public Calculator()
        {
            
        }

        public double Add(double a, double b)
        {

            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {

            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }


        public double Add(double addend)
        {
            return Accumulator + addend;
        }

        public double Subtract(double subtractor)
        {
            return Accumulator - subtractor;
        }

    }
}
