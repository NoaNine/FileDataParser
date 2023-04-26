namespace MathTest.Data
{
    public class DataFileReaderTest
    {
        public static IEnumerable<object[]> Data_ReaderTest()
        {
            return new[]
            {
                new object[]
                {
                    @"E:\Foxminded\Task3\Files\SomeFile.txt",
                    new string[]
                    {
                        "12,45.34,1245.345,675.2,23,2,4,9,0.5,0,0,467.45,5",
                        "23.5,567,54.3sd-sd,567,43,2,3.4,777,23,2.4,ha",
                        "sdv,sdvnr,ergmjty,234b,nmrtr,-u,\\,/,?,234,3,vly",
                        "23,5,456,10000",
                        "32,3,4,5.5,10,111.111,590,900",
                        "999,999,999,999",
                        "df.dfb,sdfb.sdf,tyn.etw,qweg,wrb23,3rgerg4,tskyi",
                        "10000,2.5,6,15,5,400,25,31"
                    }
                },

                new object[]
                {
                    @"E:\Foxminded\Task3\Files\Test2.txt",
                    new string[]
                    {
                        "dfb,345 67,3",
                        "56,fg"
                    }
                },

                new object[]
                {
                    @"E:\Foxminded\Task3\Files\Test3.txt",
                    new string[]
                    {
                    "23,2345,",
                    "3246dfb,sdfb,   ; '21 23,24,5, ,56 "
                    }
                }
            };
        }
    }
}
