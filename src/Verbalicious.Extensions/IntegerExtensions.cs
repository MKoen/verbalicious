using System;
using System.Linq;
using Verbalicious.Extensions.Utilities;

namespace Verbalicious.Extensions
{
    public static class IntegerExtensions
    {
        public static bool IsZero(this int number) => number == 0;

        public static bool IsNotZero(this int number) => !number.IsZero();

        public static bool IsEven(this int number) => number % 2 == 0;

        public static bool IsOdd(this int number) => !number.IsEven();

        public static bool IsPrime(this int number) => MathUtility.IsPrime(number);

        public static bool IsComposite(this int number) => !number.IsPrime();

        public static bool IsGreaterThan(this int number, int operand) => number > operand;

        public static bool IsEqualOrGreaterThan(this int number, int operand) => number >= operand;

        public static bool IsLesserThan(this int number, int operand) => number < operand;

        public static bool IsEqualOrLesserThan(this int number, int operand) => number <= operand;

        public static bool IsPositive(this int number) => number.IsGreaterThan(0);

        public static bool IsNegative(this int number) => number.IsLesserThan(0);

        public static bool IsSumOf(this int sum, params int[] numbers) => sum == numbers.Sum();

        public static bool IsNotSumOf(this int sum, params int[] numbers) => sum.IsNotSumOf(numbers);

        public static bool IsDifferenceOf(this int difference, int minuend, int subtrahend) => difference == minuend - subtrahend;

        public static bool IsNotDifferenceOf(this int difference, int minuend, int subtrahend) => !difference.IsDifferenceOf(minuend, subtrahend);

        public static bool IsDivisibleBy(this int dividend, int divisor) => dividend % divisor == 0;

        public static bool IsNotDivisibleBy(this int dividend, int divisor) => !dividend.IsDivisibleBy(divisor);

        public static bool IsSquareOf(this int square, int multiplicand) => square == multiplicand * multiplicand;

        public static bool IsNotSquareOf(this int square, int multiplicand) => square.IsNotSquareOf(multiplicand);

        public static bool IsSquareRootOf(this int squareRoot, int radicand) => squareRoot == Math.Sqrt(radicand);

        public static bool IsNotSquareRootOf(this int squareRoot, int radicand) => squareRoot.IsNotSquareRootOf(radicand);
    }
}