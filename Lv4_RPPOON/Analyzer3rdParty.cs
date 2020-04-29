using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    class Analyzer3rdParty
    {
        public double[] PerRowAverage(double[][] data)
        {
            int rowCount = data.Length;
            double[] results = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                results[i] = data[i].Average();
            }
            return results;
        }
        public double[] PerColumnAverage(double[][] data)
        {
            int rowCount = data.GetLength(0);
            int columnCount = data[0].GetLength(0);
            double[] results = new double[columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                for (int j = 0; j < rowCount; j++) { 
                results[i] += data[j][i];
            }
            results[i] /= rowCount;
            }          
            return results;
        }
    }
}
