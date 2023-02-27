

namespace NumberGenerators
{
    public class PrimeNumberGenerator
    {
        private static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int Generate(int targetNumberOfPrimeNumbersFound)
        {
            if (targetNumberOfPrimeNumbersFound <= 0)
                throw new ArgumentOutOfRangeException("Input must be greater than zero");

            int numberOfPrimesFound = 0;
            int number = 2;
            while (true)
            {
                if (IsPrime(number))
                    numberOfPrimesFound++;

                if (numberOfPrimesFound == targetNumberOfPrimeNumbersFound)
                    break;

                number++;
            }
            return number;
        }
    }
}
