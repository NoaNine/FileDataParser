namespace Math
{
    public class Aggregator
    {
        public AggregatorResult Maximum(double[][] data)
        {
            AggregatorResult result = new AggregatorResult();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i] == null || data[i].Length == 0)
                {
                    result.BrokenRows.Add(i+1);
                    continue;
                }
                double maxSum = GetSumAllElementsRow(data[i]);
                if (result.Value < maxSum)
                {
                    result.Value = maxSum;
                    result.FoundInRows.Clear();
                }
                if (result.Value == maxSum)
                {
                    result.FoundInRows.Add(i+1);
                }
            }
            return result;
        }

        private double GetSumAllElementsRow(double[] data)
        {
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            return sum;
        }
    }
}
