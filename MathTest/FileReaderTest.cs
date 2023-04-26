using Math;

namespace MathTest
{
    [TestClass]
    public class FileReaderTest
    {
        [DataTestMethod]
        [DynamicData(nameof(Data.DataFileReaderTest.Data_ReaderTest), typeof(Data.DataFileReaderTest), DynamicDataSourceType.Method)]
        public void ReaderTest(string input, string[] expected)
        {
            FileReader fileReader = new FileReader();
            string[] actual = fileReader.Read(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ThrowIfNotExistsTest()
        {
            string path = @"E:\Foxminded\Task3\";
            FileReader fileReader = new FileReader();
            fileReader.Read(path);
        }
    }
}
