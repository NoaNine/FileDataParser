﻿namespace MathTest.Data
{
    public class DataConverterTest
    {
        public static IEnumerable<object[]> Data_ConvertStringToDoubleTest()
        {
            return new[]
            {
                new object[]
                {
                    new string[]
                    {
                        "1,2,5",
                        "2,12,23,45",
                        "1"
                    },
                    new double[][]
                    {
                        new double[] { 1, 2, 5 },
                        new double[] { 2, 12, 23, 45 },
                        new double[] { 1 }
                    }
                },

                new object[]
                {
                    new string[]
                    {
                        "1.5,2,5",
                        "2,12.888,23.3,45",
                        "1.2asd"
                    },
                    new double[][]
                    {
                        new double[] { 1.5, 2, 5 },
                        new double[] { 2, 12.888, 23.3, 45 },
                        null
                    }
                },

                new object[]
                {
                    new string[]
                    {
                        "1.5,2,afj",
                        "2ds,12.888,23.3,45",
                        "",
                        ",,,,,"
                    },
                    new double[][]
                    {
                        null,
                        null,
                        null,
                        null
                    }
                }
            };

        }
    }
}
