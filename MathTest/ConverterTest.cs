using Math;

namespace MathTest
{
    [TestClass]
    public class ConverterTest
    {
        [DataTestMethod]
        [DynamicData(nameof(Data.DataConverterTest.Data_ConvertStringToDoubleTest), typeof(Data.DataConverterTest), DynamicDataSourceType.Method)]
        public void ConvertStringToDoubleTest(string[] input, double[][] expected)
        {
            Converter converter = new Converter();
            double[][] actual = converter.ConvertEnUS(input);
            Assert.AreEqual(expected.Length, actual.Length);
            for (int i = 0; i < actual.Length; i++)
            {
                CollectionAssert.AreEquivalent(expected[i], actual[i]);
            }

        }
    }
}
