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
    public partial class FormGradeChart : Form
    {
        public FormGradeChart()
        {
            InitializeComponent();
            this.pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "不及格人数",
                    Values = new ChartValues<double> { 0 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "良好人数",
                    Values = new ChartValues<double> { 0 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "优秀人数",
                    Values = new ChartValues<double> { 0 },
                    DataLabels = true
                },
            };
        }

        private void FormGradeChart_Load(object sender, EventArgs e)
        {
            studentMS.BLL.course bll = new studentMS.BLL.course();
            this.comboBox1.DataSource = bll.GetAllList().Tables[0];
            this.comboBox1.DisplayMember = "CName";
            this.comboBox1.ValueMember = "CNO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentMS.BLL.core bll = new studentMS.BLL.core();
            string cno = comboBox1.SelectedValue.ToString();
            //获取数据
            DataSet ds = bll.GetGradeDistribution(cno); // 获取 DataSet
            //获取里面的数据
            int value1 = Convert.ToInt32(ds.Tables[0].Rows[0]["value1"]);
            int value2 = Convert.ToInt32(ds.Tables[0].Rows[0]["value2"]);
            int value3 = Convert.ToInt32(ds.Tables[0].Rows[0]["value3"]);

            this.pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "不及格人数",
                    Values = new ChartValues<double> { value1 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "良好人数",
                    Values = new ChartValues<double> { value2 },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "优秀人数",
                    Values = new ChartValues<double> { value3 },
                    DataLabels = true
                },
            };
        }
    }
}
