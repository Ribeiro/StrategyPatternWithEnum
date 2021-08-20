using StrategyPatternSample.Enums;
using StrategyPatternSample.Interfaces;


namespace StrategyPatternSample.Operators
{
    public class MultiplyOperator : IMathOperator<Operator>
    {
        public Operator Operator => Operator.Multiply;

        public int Calculate(int a, int b) => a * b;
    }
}
