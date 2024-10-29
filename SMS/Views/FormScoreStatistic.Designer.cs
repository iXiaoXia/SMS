namespace SMS.Views
{
    partial class FormScoreStatistic
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
            this.SNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreAvg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Size = new System.Drawing.Size(1230, 114);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 29);
            this.button1.Text = "统计";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(131, 51);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.Text = "课程名称";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 41);
            this.textBox1.Size = new System.Drawing.Size(187, 28);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.SSex,
            this.ScoreMax,
            this.ScoreMin,
            this.ScoreAvg});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 747);
            this.dataGridView1.TabIndex = 2;
            // 
            // SNO
            // 
            this.SNO.DataPropertyName = "SNO";
            this.SNO.HeaderText = "学号";
            this.SNO.MinimumWidth = 8;
            this.SNO.Name = "SNO";
            this.SNO.ReadOnly = true;
            this.SNO.Width = 150;
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "姓名";
            this.SName.MinimumWidth = 8;
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Width = 150;
            // 
            // SSex
            // 
            this.SSex.DataPropertyName = "SSex";
            this.SSex.HeaderText = "性别";
            this.SSex.MinimumWidth = 8;
            this.SSex.Name = "SSex";
            this.SSex.ReadOnly = true;
            this.SSex.Width = 150;
            // 
            // ScoreMax
            // 
            this.ScoreMax.DataPropertyName = "ScoreMax";
            this.ScoreMax.HeaderText = "最高分";
            this.ScoreMax.MinimumWidth = 8;
            this.ScoreMax.Name = "ScoreMax";
            this.ScoreMax.ReadOnly = true;
            this.ScoreMax.Width = 200;
            // 
            // ScoreMin
            // 
            this.ScoreMin.DataPropertyName = "ScoreMin";
            this.ScoreMin.HeaderText = "最低分";
            this.ScoreMin.MinimumWidth = 8;
            this.ScoreMin.Name = "ScoreMin";
            this.ScoreMin.ReadOnly = true;
            this.ScoreMin.Width = 200;
            // 
            // ScoreAvg
            // 
            this.ScoreAvg.DataPropertyName = "ScoreAvg";
            this.ScoreAvg.HeaderText = "平均分";
            this.ScoreAvg.MinimumWidth = 8;
            this.ScoreAvg.Name = "ScoreAvg";
            this.ScoreAvg.ReadOnly = true;
            this.ScoreAvg.Width = 200;
            // 
            // FormScoreStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1230, 861);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormScoreStatistic";
            this.Text = "成绩统计--学生";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreAvg;
    }
}
