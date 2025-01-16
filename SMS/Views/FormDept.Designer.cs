namespace SMS.Views
{
    partial class FormDept
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
            this.DeptNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Size = new System.Drawing.Size(1230, 130);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 36);
            this.button1.Text = "查  询";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(299, 56);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.Text = "学院名称";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 48);
            this.textBox1.Size = new System.Drawing.Size(227, 28);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeptNO,
            this.DeptName,
            this.StudentCount});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 731);
            this.dataGridView1.TabIndex = 1;
            // 
            // DeptNO
            // 
            this.DeptNO.DataPropertyName = "DeptNO";
            this.DeptNO.HeaderText = "学院编号";
            this.DeptNO.MinimumWidth = 8;
            this.DeptNO.Name = "DeptNO";
            this.DeptNO.ReadOnly = true;
            this.DeptNO.Width = 150;
            // 
            // DeptName
            // 
            this.DeptName.DataPropertyName = "DeptName";
            this.DeptName.HeaderText = "学院名称";
            this.DeptName.MinimumWidth = 8;
            this.DeptName.Name = "DeptName";
            this.DeptName.ReadOnly = true;
            this.DeptName.Width = 200;
            // 
            // StudentCount
            // 
            this.StudentCount.DataPropertyName = "StudentCount";
            this.StudentCount.HeaderText = "学院人数";
            this.StudentCount.MinimumWidth = 8;
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.ReadOnly = true;
            this.StudentCount.Width = 150;
            // 
            // FormDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1230, 861);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDept";
            this.Text = "学院信息";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCount;
    }
}
