using StrategyPatternSample.Enums;


namespace StrategyPatternSample.Interfaces
{
    public interface IMathStrategy
    {
        int Calculate(int a, int b, Operator op);
    }
}
