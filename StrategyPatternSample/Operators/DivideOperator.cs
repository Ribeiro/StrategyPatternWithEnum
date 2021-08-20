﻿using StrategyPatternSample.Enums;
using StrategyPatternSample.Interfaces;
using System;


namespace StrategyPatternSample.Operators
{
    public class DivideOperator : IMathOperator<Operator>
    {
        public Operator Operator => Operator.Divide;

        public int Calculate(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}
