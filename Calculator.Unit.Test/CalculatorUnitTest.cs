﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator _uut;


        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_Add2And4_Returns6()
        {

            Assert.That(_uut.Add(2, 4), Is.EqualTo(6));
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(3, 0, 3)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
   
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        public void Multiply_MultiplyNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
        [TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }


        [Test]
        public void Accumulator_Add_resultSavedInAccumulator()
        {
            _uut.Add(2, 2);

            Assert.That(_uut.Accumulator, Is.EqualTo(4));

        }

        [TestCase(8, 2, 4)]
        [TestCase(10, 2, 5)]
        [TestCase(28, 0.5, 56)]
        [TestCase(9, 3, 3)]
        public void Divide_DivideAWithB_ResultIsCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [TestCase(9, 0)]
        [TestCase(19, 0)]
        public void Divide_DivideWithZero_ThrowException(double dividend, double divisor)
        {
            Assert.That(() => _uut.Divide(dividend, divisor), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(5, 2, 7, 14)]
        [TestCase(-3, 9, -4, 2)]
        [TestCase(3, -14, 1, 10)]
        [TestCase(99, 100, 10, 209)]
        [TestCase(3, 0, 0,3)]
        public void Accumulator_Add_AddNumbers_ResultIsCorrect(int a, int b, int c, int result)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Add(c), Is.EqualTo(result));
        }


    }
}

