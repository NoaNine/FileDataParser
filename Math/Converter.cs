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
                data[i] = Convert(rows[i]);
            }
            return data;
        }

        private double[] Convert(string row)
        {
            List<double> dataRow = new List<double>();
            ArgumentNullException.ThrowIfNull(row);
            string[] rowElements = row.Split(',');
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };

            if (IsEmpty(rowElements))
            {
                dataRow = null;
                return dataRow?.ToArray();
            }
            for (int j = 0; j < rowElements.Length; j++)
            {
                double doubles;
                if (!double.TryParse(rowElements[j], NumberStyles.Number, numberFormatInfo, out doubles))
                {
                    dataRow = null;
                    break;
                }
                dataRow.Add(doubles);
            }
            return dataRow?.ToArray();
        }

        private bool IsEmpty(string[] row)
        {
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i] != string.Empty)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
