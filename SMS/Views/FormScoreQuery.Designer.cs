namespace SMS.Views
{
    partial class FormScoreQuery
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
            this.CNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(1230, 117);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.textBox1, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.textBox2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.textBox3, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1048, 22);
            this.button1.Text = "查  询";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.Text = "学号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 34);
            this.textBox1.Size = new System.Drawing.Size(170, 28);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNO,
            this.SName,
            this.SSex,
            this.CNO,
            this.CName,
            this.Score});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 744);
            this.dataGridView1.TabIndex = 1;
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
            // CNO
            // 
            this.CNO.DataPropertyName = "CNO";
            this.CNO.HeaderText = "课程编号";
            this.CNO.MinimumWidth = 8;
            this.CNO.Name = "CNO";
            this.CNO.ReadOnly = true;
            this.CNO.Width = 200;
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
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "成绩";
            this.Score.MinimumWidth = 8;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 28);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "课程名称";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(710, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 28);
            this.textBox3.TabIndex = 4;
            // 
            // FormScoreQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1230, 861);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormScoreQuery";
            this.Text = "成绩查询";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
