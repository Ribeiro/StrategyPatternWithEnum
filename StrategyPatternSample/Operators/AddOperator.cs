﻿using StrategyPatternSample.Enums;
using StrategyPatternSample.Interfaces;


namespace StrategyPatternSample.Operators
{
    public class AddOperator : IMathOperator<Operator>
    {
        public Operator Operator => Operator.Add;

        public int Calculate(int a, int b) => a + b;
    }
}
