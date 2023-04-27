namespace Math
{
    public class Aggregator
    {
        public AggregatorResult Maximum(double[][] data)
        {
            AggregatorResult result = new AggregatorResult();
            result.Value = 0;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i] == null)
                {
                    result.BrokenRows.Add(i);
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
                    result.FoundInRows.Add(i);
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
