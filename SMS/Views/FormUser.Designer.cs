namespace SMS.Views
{
    partial class FormUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPriorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPriorIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxUID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 127);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(206, 41);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(212, 28);
            this.textBoxUID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "查  询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.RoleID,
            this.RoleName,
            this.UPriorTime,
            this.UPriorIP,
            this.Remark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1478, 801);
            this.dataGridView1.TabIndex = 1;
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "用户名";
            this.UID.MinimumWidth = 8;
            this.UID.Name = "UID";
            this.UID.Width = 150;
            // 
            // RoleID
            // 
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.HeaderText = "角色编号";
            this.RoleID.MinimumWidth = 8;
            this.RoleID.Name = "RoleID";
            this.RoleID.Visible = false;
            this.RoleID.Width = 150;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "RoleName";
            this.RoleName.HeaderText = "角色名称";
            this.RoleName.MinimumWidth = 8;
            this.RoleName.Name = "RoleName";
            this.RoleName.Width = 150;
            // 
            // UPriorTime
            // 
            this.UPriorTime.DataPropertyName = "UPriorTime";
            this.UPriorTime.HeaderText = "上次登录时间";
            this.UPriorTime.MinimumWidth = 8;
            this.UPriorTime.Name = "UPriorTime";
            this.UPriorTime.Width = 200;
            // 
            // UPriorIP
            // 
            this.UPriorIP.DataPropertyName = "UPriorIP";
            this.UPriorIP.HeaderText = "上次登录IP";
            this.UPriorIP.MinimumWidth = 8;
            this.UPriorIP.Name = "UPriorIP";
            this.UPriorIP.Width = 200;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注";
            this.Remark.MinimumWidth = 8;
            this.Remark.Name = "Remark";
            this.Remark.Width = 250;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 928);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUser";
            this.Text = "用户管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPriorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPriorIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}