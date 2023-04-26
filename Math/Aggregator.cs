namespace Math
{
    public class Aggregator
    {
        public AggregatorResult Maximum(double[][] data)
        {
            AggregatorResult result = new AggregatorResult();
            for(int i  = 0; i < data.Length; i++)
            {
                if (data[i] == null)
                {
                    
                    result.BrokenRows.Add(i);
                    continue;
                }
                double sum = GetSumAllElements(data[i]);
                if (result.Value < sum)
                {
                    result.Value = sum;
                    result.FoundInRows.Add(i);
                    continue;
                }
                if(result.Value == sum)
                {
                    result.FoundInRows.Add(i);
                }
            }
            return result;
        }

        private double GetSumAllElements(double[] data)
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
