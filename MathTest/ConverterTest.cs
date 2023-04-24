namespace MathTest
{
    [TestClass]
    public class ConverterTest
    {
        [DataTestMethod]
        [DynamicData(nameof(StorageData.Data_ConvertStringToDoubleTest), typeof(StorageData), DynamicDataSourceType.Method)]
        public void ConvertStringToDoubleTest()
        {

        }
    }
}
