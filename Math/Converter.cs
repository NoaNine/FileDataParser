using System.Globalization;

namespace Math
{
    public class Converter
    {
        public double[][] ConvertEnUS(string[] rows)
        {
            double[][] data = new double[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                data[i] = Convert(rows[i]);
            }
            return data;
        }

        private double[] Convert(string row)
        {
            List<double> dataRow = new List<double>();
            // check row
            string[] rowElements = row.Split(',');
            //check rowElements
            for (int j = 0; j < rowElements.Length; j++)
            {
                double doubles;
                if(!double.TryParse(rowElements[j], out doubles))
                {
                    dataRow = null;
                    break;
                }
                dataRow.Add(doubles);
            }
            return dataRow.ToArray();
        }
    }
}
