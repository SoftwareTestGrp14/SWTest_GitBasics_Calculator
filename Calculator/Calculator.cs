using System;
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
            Accumulator = 0.00;
        }

        public void Clear()
        {
            Accumulator = 0.00;
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

        public double Multiply(double a)
        {

            return Accumulator * a;
        }

        public double Divide(double a)
        {

            return Accumulator / a;
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
