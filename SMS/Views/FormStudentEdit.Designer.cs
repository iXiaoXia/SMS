﻿namespace SMS
{
    partial class FormStudentEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSNO = new System.Windows.Forms.TextBox();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.radioButtonBoy = new System.Windows.Forms.RadioButton();
            this.radioButtonGirl = new System.Windows.Forms.RadioButton();
            this.dateTimePickerSBirthday = new System.Windows.Forms.DateTimePicker();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "出生日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "所在院系";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "地址";
            // 
            // textBoxSNO
            // 
            this.textBoxSNO.Location = new System.Drawing.Point(286, 79);
            this.textBoxSNO.Name = "textBoxSNO";
            this.textBoxSNO.Size = new System.Drawing.Size(184, 28);
            this.textBoxSNO.TabIndex = 2;
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(710, 86);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(184, 28);
            this.textBoxSName.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(286, 268);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(608, 28);
            this.textBoxAddress.TabIndex = 2;
            // 
            // radioButtonBoy
            // 
            this.radioButtonBoy.AutoSize = true;
            this.radioButtonBoy.Checked = true;
            this.radioButtonBoy.Location = new System.Drawing.Point(286, 201);
            this.radioButtonBoy.Name = "radioButtonBoy";
            this.radioButtonBoy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonBoy.Size = new System.Drawing.Size(51, 22);
            this.radioButtonBoy.TabIndex = 3;
            this.radioButtonBoy.TabStop = true;
            this.radioButtonBoy.Text = "男";
            this.radioButtonBoy.UseVisualStyleBackColor = true;
            // 
            // radioButtonGirl
            // 
            this.radioButtonGirl.AutoSize = true;
            this.radioButtonGirl.Location = new System.Drawing.Point(376, 201);
            this.radioButtonGirl.Name = "radioButtonGirl";
            this.radioButtonGirl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonGirl.Size = new System.Drawing.Size(51, 22);
            this.radioButtonGirl.TabIndex = 3;
            this.radioButtonGirl.Text = "女";
            this.radioButtonGirl.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSBirthday
            // 
            this.dateTimePickerSBirthday.Location = new System.Drawing.Point(286, 135);
            this.dateTimePickerSBirthday.Name = "dateTimePickerSBirthday";
            this.dateTimePickerSBirthday.Size = new System.Drawing.Size(184, 28);
            this.dateTimePickerSBirthday.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(298, 369);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(109, 45);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "确 定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(644, 369);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(109, 45);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取 消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(710, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 26);
            this.comboBox1.TabIndex = 7;
            // 
            // FormStudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 596);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateTimePickerSBirthday);
            this.Controls.Add(this.radioButtonGirl);
            this.Controls.Add(this.radioButtonBoy);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.textBoxSNO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStudentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormStudentEdit";
            this.Load += new System.EventHandler(this.FormStudentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSNO;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.RadioButton radioButtonBoy;
        private System.Windows.Forms.RadioButton radioButtonGirl;
        private System.Windows.Forms.DateTimePicker dateTimePickerSBirthday;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}