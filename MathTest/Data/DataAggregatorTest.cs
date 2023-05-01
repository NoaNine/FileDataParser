using Math.Models;

namespace MathTest.Data
{
    public class DataAggregatorTest
    {
        public static IEnumerable<object[]> Data_MaximumSumTest()
        {
            return new[]
            {
                new object[]
                {
                    new double[][]
                    {
                        new double[] { 4.5, 10, 12 },
                        new double[] { 2, 1.1 },
                        new double[] { 100, 25.9 }
                    },
                    new AggregatorResult
                    {
                        Value = 125.9
                    }
                }
            };
        }

        public static IEnumerable<object[]> Data_SeveralIdenticalMaximumSumTest()
        {
            return new[]
            {
                new object[]
                {
                    new double[][]
                    {
                        new double[] { 4.5, 10, 12 },
                        new double[] { 2, 1.1 },
                        new double[] { 100, 25.9 },
                        new double[] { 100, 25.9 }
                    },
                    new AggregatorResult
                    {
                        Value = 125.9,
                        FoundInRows = new List<int>() { 3, 4 }
                    }
                }
            };
        }

        public static IEnumerable<object[]> Data_NumberBrokenLinesTest()
        {
            return new[]
            {
                new object[]
                {
                    new double[][]
                    {
                        new double[] { 4.5, 10, 12 },
                        new double[] { 2, 1.1 },
                        null,
                        null
                    },
                    new AggregatorResult
                    {
                        Value = 26.5,
                        BrokenRows = new List<int>() { 3, 4 }
                    }
                }
            };
        }
    }
}
