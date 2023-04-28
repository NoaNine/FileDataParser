using System.Globalization;

namespace Math
{
    public class Converter
    {
        public char lineSeparator = ',';
        public static string numberDecimalSeparator = ".";
        private NumberFormatInfo _numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = numberDecimalSeparator };

        public double[][] Convert(string[] rows)
        {
            if (rows.Length == 0)
            {
                throw new ArgumentException();
            }
            double[][] data = new double[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                data[i] = Convert(rows[i]);
            }
            return data;
        }

        private double[] Convert(string row)
        {
            List<double> dataRow = new List<double>();
            ArgumentNullException.ThrowIfNull(row);
            string[] rowElements = row.Split(lineSeparator);
            for (int j = 0; j < rowElements.Length; j++)
            {
                double doubles;
                if (!double.TryParse(rowElements[j], NumberStyles.Number, _numberFormatInfo, out doubles))
                {
                    return null;
                }
                dataRow.Add(doubles);
            }
            return dataRow?.ToArray();
        }
    }
}
