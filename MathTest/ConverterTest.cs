using Math;

namespace MathTest
{
    [TestClass]
    public class ConverterTest
    {
        [DataTestMethod]
        [DynamicData(nameof(StorageData.Data_ConvertStringToDoubleTest), typeof(StorageData), DynamicDataSourceType.Method)]
        public void ConvertStringToDoubleTest(string[] input, double?[][] expected)
        {
            Converter converter = new Converter();
            double?[][] actual = converter.Convert(input);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}
