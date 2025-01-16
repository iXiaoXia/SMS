using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace SMS.Views
{
    public partial class ChartTest : Form
    {
        public ChartTest()
        {
            InitializeComponent();
            //给chart1添加数据
            // 创建数据
            this.chart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Category A",
                    Values = new ChartValues<double> { 40 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Category B",
                    Values = new ChartValues<double> { 10 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Category C",
                    Values = new ChartValues<double> { 20 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Category D",
                    Values = new ChartValues<double> { 10 },
                    DataLabels = true
                }
            };
        }
    }
}
