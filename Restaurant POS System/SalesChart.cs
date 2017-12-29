using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant_POS_System
{
    public partial class SalesChart : Form
    {
        public SalesChart()
        {
            InitializeComponent();
            //drawChart();
        }

        //public void drawChart(List<Sales> salesList)
        //{
        //    for (int i = 0; i < salesList.Count; i++)
        //    {
        //        salesPieChart.Series[0].Points.AddY(salesList[i].Quantity);
        //        salesPieChart.Series[0].Points[i].LegendText = salesList[i].ItemName;
        //        salesPieChart.Series[0].Points[i].Label = salesList[i].Quantity.ToString();
        //    }
        //}
    }
}