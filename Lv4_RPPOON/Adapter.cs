using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv4_RPPOON
{
    class Adapter:IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            double[][] matrix = new double[dataset.GetData().Count][];
            for (int i = 0; i < dataset.GetData().Count; i++)
            {
                matrix[i] = new double[dataset.GetData()[i].Count];
                for (int j = 0; j < dataset.GetData()[i].Count; j++)
                {
                    matrix[i][j] = dataset.GetData()[i][j];
                }
            }
            return matrix;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
