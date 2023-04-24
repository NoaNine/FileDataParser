using Math;

namespace MathTest
{
    [TestClass]
    public class FileReaderTest
    {
        [DataTestMethod]
        [DynamicData(nameof(StorageData.Data_ReaderTest), typeof(StorageData), DynamicDataSourceType.Method)]
        public void ReaderTest(string input, string[] expected)
        {
            FileReader fileReader = new FileReader();
            string[] actual = fileReader.Reader(input);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ExistFileTest()
        {
            string path = @"E:\Foxminded\Task3\Files\Test1000.txt";
            FileReader fileReader = new FileReader();
            fileReader.Reader(path);
        }
    }
}
