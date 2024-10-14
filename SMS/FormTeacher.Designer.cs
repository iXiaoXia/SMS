namespace SMS
{
    partial class FormTeacher
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
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.textBox1, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.textBoxSName, 0);
            // 
            // button1
            // 
            this.button1.Text = "查询";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 34);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.Text = "教师编号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TSNO,
            this.TName,
            this.TSex,
            this.DeptNO,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(2, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 747);
            this.dataGridView1.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.HeaderText = "Column1";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // DeptNO
            // 
            this.DeptNO.HeaderText = "Column1";
            this.DeptNO.MinimumWidth = 8;
            this.DeptNO.Name = "DeptNO";
            this.DeptNO.Width = 150;
            // 
            // TSex
            // 
            this.TSex.HeaderText = "Column1";
            this.TSex.MinimumWidth = 8;
            this.TSex.Name = "TSex";
            this.TSex.Width = 150;
            // 
            // TName
            // 
            this.TName.HeaderText = "Column1";
            this.TName.MinimumWidth = 8;
            this.TName.Name = "TName";
            this.TName.Width = 150;
            // 
            // TSNO
            // 
            this.TSNO.HeaderText = "教师编号";
            this.TSNO.MinimumWidth = 8;
            this.TSNO.Name = "TSNO";
            this.TSNO.Width = 150;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(478, 34);
            this.textBoxSName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(220, 28);
            this.textBoxSName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1230, 861);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
    }
}
