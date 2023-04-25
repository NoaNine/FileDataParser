using Microsoft.VisualBasic;
using System.Globalization;

namespace Math
{
    public class Converter
    {
        public double?[][] Convert(string[] rows)
        {
            double?[][] data = new double?[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                string[] rowElements = rows[i].Split(',');
                data[i] = ConvertAllToDouble(rowElements);
            }
            return data;
        }

        private double?[] ConvertAllToDouble(string[] rowElements)
        {
            double?[] dataRow = new double?[rowElements.Length];
            for (int j = 0; j < rowElements.Length; j++)
            {
                if(double.TryParse(rowElements[j], out double doubles))
                {
                    dataRow[j] = doubles;
                }
                else
                {
                    return new double?[] { null };
                }
            }
            return dataRow;
        }
    }
}
