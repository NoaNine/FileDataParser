using Microsoft.VisualBasic;
using System.Globalization;

namespace Math
{
    public class Converter
    {
        public double[][] Convert(string[] rows)
        {
            double[][] data = new double[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] rowElements = rows[i].Split(',');
                ConvertAllToDouble(data, rowElements, i);
            }
            return data;
        }

        private void ConvertAllToDouble(double[][] data, string[] rowElements, int i)
        {
            for (int j = 0; j < rowElements.Length; j++)
            {
                data[i][j] = Double.Parse(rowElements[j], new NumberFormatInfo { NumberDecimalSeparator = "." });
            }
        }

        private bool CheckNonNumericSymbol(string row, int j)
        {
            if (!char.IsNumber(row[j]) && row[j] != ',' && row[j] != '.')
            { 
                return true; 
            }
            return false;
        }
    }
}
