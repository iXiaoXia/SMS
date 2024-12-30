namespace SMS.Views
{
    partial class ChartTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chart2 = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.Location = new System.Drawing.Point(687, 119);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(481, 370);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "pieChart1";
            // 
            // ChartTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 780);
            this.Controls.Add(this.chart2);
            this.Name = "ChartTest";
            this.Text = "ChartTest";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart chart2;
    }
}