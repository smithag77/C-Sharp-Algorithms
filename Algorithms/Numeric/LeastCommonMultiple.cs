namespace Algorithms.Numeric
{
    public static class LeastCommonMultiple
    {
        public static uint FindLCM(uint a, uint b)
        {
            return a * b / GreatestCommonDivisor.FindGCDRecursive(a, b);
        }
    }
}
