using System;
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
        
        [TestCase(2,2,4)]
        [TestCase(49,13,62)]
        [TestCase(8,10,18)]
        public void Accumulator_Add_resultSavedInAccumulator(int a, int b, int result)
        {
            _uut.Add(a,b);

            Assert.That(_uut.Accumulator, Is.EqualTo(result));

        }

        [TestCase(40,2,20)]
        [TestCase(30,3,10)]
        [TestCase(69,3,23)]
        public void Accumulator_Divide_resultSavedInAccumulator(int a, int b, int result)
        {
            _uut.Divide(a, b);

            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(10,10,100)]
        [TestCase(26,2,52)]
        [TestCase(4548,348,1582704)]
        public void Accumulator_Multiply_resultSavedInAccumulator(int a, int b, int result)
        {
            _uut.Multiply(a, b);

            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(3, 2, 24)]
        [TestCase(-3, -2, 24)]
        [TestCase(3, -2, -24)]
        public void Accumulator_Multiply_ContineueousMultiplicationCorrect(int a, int b, int result)
        {
            _uut.Multiply(2, 2);
            _uut.Multiply(a);
            _uut.Multiply(b);

            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }

        [TestCase(8, 2, 1)]
        [TestCase(-8, 2, -1)]
        [TestCase(-8, -2, 1)]
        public void Accumulator_Divide_ContinueousDivisionCorrect(double dividend, double divisor, double result)
        {
            _uut.Divide(dividend, divisor);
            _uut.Divide(divisor);
            _uut.Divide(divisor);

            Assert.That(_uut.Accumulator, Is.EqualTo(result));
        }
        
        [TestCase(8, 2, 4)]
        [TestCase(10, 2, 5)]
        [TestCase(28, 0.5, 56)]
        [TestCase(9, 3, 3)]
        [TestCase(-9, -3, 3)]
        [TestCase(-9, 3, -3)]
        public void Divide_DivideAWithB_ResultIsCorrect(double dividend, double divisor, double result)
        {
            Assert.That(_uut.Divide(dividend, divisor), Is.EqualTo(result));
        }

        [TestCase(9, 0)]
        [TestCase(19, 0)]
        [TestCase(-20, 0)]
        public void Divide_DivideWithZero_ThrowException(double dividend, double divisor)
        {
            Assert.That(() => _uut.Divide(dividend, divisor), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(5, 2, 7, 14)]
        [TestCase(-3, 9, -4, 2)]
        [TestCase(3, -14, 1, -10)]
        [TestCase(99, 100, 10, 209)]
        [TestCase(3, 0, 0,3)]
        public void Accumulator_Add_AddNumbers_ResultIsCorrect(int a, int b, int c, int result)
        {
            _uut.Add(a, b);

            Assert.That(_uut.Add(c), Is.EqualTo(result));
        }

        [TestCase(5, 2, 7, -4)]
        [TestCase(-3, 9, -4, -8)]
        [TestCase(3, -14, 1, 16)]
        [TestCase(99, 100, 10, -11)]
        [TestCase(3, 0, 6, -3)]
        public void Accumulator_Subtract_SubtractNumbers_ResultIsCorrect(int a, int b, int c, int result)
        {
            _uut.Subtract(a, b);

            Assert.That(_uut.Subtract(c), Is.EqualTo(result));
        }

        [TestCase(2, 2, 2, 16)]
        [TestCase(-3, 2, 4, 6561)]
        [TestCase(3, 3, 1, 27)]
        [TestCase(43, 2, 0, 1)]
        public void Accumulator_Power_PowerNumbers_ResultIsCorrect(int a, int b, int c, int result)
        {
            _uut.Power(a, b);

            Assert.That(_uut.Power(c), Is.EqualTo(result));
        }

        [TestCase(2, 2)]
        [TestCase(-2, -3)]
        [TestCase(-5, -5)]
        [TestCase(3, 43)]

        public void Clear_ClearAfterAdding_AccumulatorIsZero(int a, int b)
        {
            _uut.Add(a, b);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));

        }

        [TestCase(2, 2)]
        [TestCase(-2, -3)]
        [TestCase(-5, -5)]
        [TestCase(3, 43)]

        public void Clear_ClearAfterSubtracting_AccumulatorIsZero(int a, int b)
        {
            _uut.Subtract(a, b);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));

        }

        [TestCase(2, 2)]
        [TestCase(-2, -3)]
        [TestCase(-5, -5)]
        [TestCase(3, 43)]

        public void Clear_ClearAfterMultiplying_AccumulatorIsZero(int a, int b)
        {
            _uut.Multiply(a, b);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));

        }

        [TestCase(2, 2)]
        [TestCase(-2, -3)]
        [TestCase(-5, -5)]
        [TestCase(3, 43)]

        public void Clear_ClearAfterDividing_AccumulatorIsZero(int a, int b)
        {
            _uut.Divide(a, b);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));

        }

        [TestCase(2, 2)]
        [TestCase(-2, -3)]
        [TestCase(-5, -5)]
        [TestCase(3, 43)]

        public void Clear_ClearAfterPower_AccumulatorIsZero(int a, int b)
        {
            _uut.Power(a, b);

            _uut.Clear();

            Assert.That(_uut.Accumulator, Is.EqualTo(0));

        }
    }
}

