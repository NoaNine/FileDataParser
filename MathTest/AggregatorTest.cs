using Math;
using Math.Models;
using MathTest.Data;

namespace MathTest
{
    [TestClass]
    public class AggregatorTest
    {
        [DataTestMethod]
        [DynamicData(nameof(Data.DataAggregatorTest.Data_MaximumSumTest), typeof(DataAggregatorTest), DynamicDataSourceType.Method)]
        public void MaximumSum(double[][] input, AggregatorResult expected)
        {
            Aggregator aggregator = new Aggregator();
            AggregatorResult aggregatorResult = aggregator.Maximum(input);
            Assert.AreEqual(expected.Value, aggregatorResult.Value);
        }

        [DataTestMethod]
        [DynamicData(nameof(Data.DataAggregatorTest.Data_SeveralIdenticalMaximumSumTest), typeof(DataAggregatorTest), DynamicDataSourceType.Method)]
        public void SeveralIdenticalMaximumSum(double[][] input, AggregatorResult expected)
        {
            Aggregator aggregator = new Aggregator();
            AggregatorResult aggregatorResult = aggregator.Maximum(input);
            Assert.AreEqual(expected.FoundInRows.Count, aggregatorResult.FoundInRows.Count);
            for (int i = 0; i < expected.FoundInRows.Count; i++)
            {
                Assert.AreEqual(expected.FoundInRows[i], aggregatorResult.FoundInRows[i]);
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(Data.DataAggregatorTest.Data_NumberBrokenLinesTest), typeof(DataAggregatorTest), DynamicDataSourceType.Method)]
        public void NumberBrokenLinesTest(double[][] input, AggregatorResult expected)
        {
            Aggregator aggregator = new Aggregator();
            AggregatorResult aggregatorResult = aggregator.Maximum(input);
            Assert.AreEqual(expected.BrokenRows.Count, aggregatorResult.BrokenRows.Count);
            for (int i = 0; i < expected.BrokenRows.Count; i++)
            {
                Assert.AreEqual(expected.BrokenRows[i], aggregatorResult.BrokenRows[i]);
            }
        }
    }
}