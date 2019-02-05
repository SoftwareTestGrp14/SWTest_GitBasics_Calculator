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
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Divide(double a)
        {
            Accumulator = Accumulator / a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator= Math.Pow(x, exp);
            return Accumulator;
        }
        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            Accumulator = dividend / divisor;
            return Accumulator;
        }
    }
}
