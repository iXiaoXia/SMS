namespace SMS.Views
{
    partial class FormCourseStatistic
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(1578, 145);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 42);
            this.button1.Text = "统  计";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(379, 72);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.Text = "课程名称";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 62);
            this.textBox1.Size = new System.Drawing.Size(186, 28);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNO,
            this.CName,
            this.MaxScore,
            this.MinScore,
            this.AvgScore,
            this.PassCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1578, 716);
            this.dataGridView1.TabIndex = 3;
            // 
            // CNO
            // 
            this.CNO.DataPropertyName = "CNO";
            this.CNO.HeaderText = "课程编号";
            this.CNO.MinimumWidth = 8;
            this.CNO.Name = "CNO";
            this.CNO.ReadOnly = true;
            this.CNO.Width = 150;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "CName";
            this.CName.HeaderText = "课程名称";
            this.CName.MinimumWidth = 8;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 150;
            // 
            // MaxScore
            // 
            this.MaxScore.DataPropertyName = "MaxScore";
            this.MaxScore.HeaderText = "最高分";
            this.MaxScore.MinimumWidth = 8;
            this.MaxScore.Name = "MaxScore";
            this.MaxScore.ReadOnly = true;
            this.MaxScore.Width = 200;
            // 
            // MinScore
            // 
            this.MinScore.DataPropertyName = "MinScore";
            this.MinScore.HeaderText = "最低分";
            this.MinScore.MinimumWidth = 8;
            this.MinScore.Name = "MinScore";
            this.MinScore.ReadOnly = true;
            this.MinScore.Width = 200;
            // 
            // AvgScore
            // 
            this.AvgScore.DataPropertyName = "AvgScore";
            this.AvgScore.HeaderText = "平均分";
            this.AvgScore.MinimumWidth = 8;
            this.AvgScore.Name = "AvgScore";
            this.AvgScore.ReadOnly = true;
            this.AvgScore.Width = 200;
            // 
            // PassCount
            // 
            this.PassCount.DataPropertyName = "PassCount";
            this.PassCount.HeaderText = "合格人数";
            this.PassCount.MinimumWidth = 8;
            this.PassCount.Name = "PassCount";
            this.PassCount.ReadOnly = true;
            this.PassCount.Width = 150;
            // 
            // FormCourseStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1578, 861);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCourseStatistic";
            this.Text = "课程成绩统计";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassCount;
    }
}
