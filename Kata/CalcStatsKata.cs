namespace Kata
{
    public static class CalcStatsKata
    {
        public static int GetMinimumValue(IEnumerable<int> values)
        {
            if (values.Count() == 0)
            {
                throw new ArgumentException();
            }

            return values.Min();
        }

        public static int GetMaximumValue(IEnumerable<int> values)
        {
            if (values.Count() == 0)
            {
                throw new ArgumentException();
            }

            return values.Max();
        }

        public static int GetNumberOfElementsInTheSequence(IEnumerable<int> values)
        {
            return values.Count();
        }

        public static double GetAverageValue(IEnumerable<int> values)
        {
            if (values.Count() == 0)
            {
                throw new ArgumentException();
            }

            return (double)values.Average();
        }
    }
}
