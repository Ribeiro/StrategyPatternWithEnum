using StrategyPatternSample.Enums;
using StrategyPatternSample.Interfaces;
using StrategyPatternSample.Operators;
using StrategyPatternSample.Strategies;
using System;
using System.Collections.Generic;

namespace StrategyPatternSample
{
    public class Program
    {

        private static readonly IMathStrategy _mathStrategy = new MathStrategy(GetMathOperators());
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine(_mathStrategy.Calculate(a, b, Operator.Add));
        }

        private static IList<IMathOperator<Operator>> GetMathOperators()
        {
            return new List<IMathOperator<Operator>>() { new AddOperator(), new SubtractOperator(), new MultiplyOperator(), new DivideOperator() };
        }
    }
}
