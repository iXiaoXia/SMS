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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeptNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.Text = "教师编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 34);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TNO,
            this.TName,
            this.TSex,
            this.DeptNO,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(2, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 747);
            this.dataGridView1.TabIndex = 1;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripMenuItem,
            this.EditStripMenuItem,
            this.DeleteStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 94);
            // 
            // AddStripMenuItem
            // 
            this.AddStripMenuItem.Name = "AddStripMenuItem";
            this.AddStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.AddStripMenuItem.Text = "新增";
            this.AddStripMenuItem.Click += new System.EventHandler(this.AddStripMenuItem_Click);
            // 
            // EditStripMenuItem
            // 
            this.EditStripMenuItem.Name = "EditStripMenuItem";
            this.EditStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.EditStripMenuItem.Text = "修改";
            this.EditStripMenuItem.Click += new System.EventHandler(this.EditStripMenuItem_Click);
            // 
            // DeleteStripMenuItem
            // 
            this.DeleteStripMenuItem.Name = "DeleteStripMenuItem";
            this.DeleteStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.DeleteStripMenuItem.Text = "删除";
            this.DeleteStripMenuItem.Click += new System.EventHandler(this.DeleteStripMenuItem_Click);
            // 
            // TNO
            // 
            this.TNO.DataPropertyName = "TNO";
            this.TNO.HeaderText = "教师编号";
            this.TNO.MinimumWidth = 8;
            this.TNO.Name = "TNO";
            this.TNO.Width = 150;
            // 
            // TName
            // 
            this.TName.DataPropertyName = "TName";
            this.TName.HeaderText = "姓名";
            this.TName.MinimumWidth = 8;
            this.TName.Name = "TName";
            this.TName.Width = 150;
            // 
            // TSex
            // 
            this.TSex.DataPropertyName = "TSex";
            this.TSex.HeaderText = "性别";
            this.TSex.MinimumWidth = 8;
            this.TSex.Name = "TSex";
            this.TSex.Width = 150;
            // 
            // DeptNO
            // 
            this.DeptNO.DataPropertyName = "DeptName";
            this.DeptNO.HeaderText = "所属学院";
            this.DeptNO.MinimumWidth = 8;
            this.DeptNO.Name = "DeptNO";
            this.DeptNO.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "住址";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1230, 861);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeptNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}
