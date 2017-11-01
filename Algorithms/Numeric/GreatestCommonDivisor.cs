/***
 * Euclidean Algorithm to find the greatest common divisor of two numbers.
 * 
 */


namespace Algorithms.Numeric
{
    public static class GreatestCommonDivisor
    {
        /// <summary>
        /// Finds and returns the greatest common divisor of two numbers
        /// </summary>
        public static uint FindGCD(uint a, uint b)
        {
            if (a == 0)
                return b;
            else if (b == 0)
                return a;

            uint _a = a, _b = b;
            uint r = _a % _b;

            while(r != 0)
            {
                _a = _b;
                _b = r;
                r = _a % _b;
            }

            return _b;
        }

        /// <summary>
        /// Finds and returns the greatest common divisor of two numbers via recursion
        /// </summary>
        public static uint FindGCDRecursive(uint a, uint b)
        {
            if (a % b == 0)
            {
                return b;
            }
            return FindGCDRecursive(b, a % b);
        }

        /// <summary>
        /// Determines given two numbers are relatively prime
        /// </summary>
        public static bool IsRelativelyPrime(uint a, uint b)
        {
            return FindGCD(a, b) == 1;
        }
    }
}
