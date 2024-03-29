﻿namespace DailyManager
{
    partial class CheckForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NoDateLabel = new System.Windows.Forms.Label();
            this.UnCheckDates = new System.Windows.Forms.Label();
            this.CheckDates = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "년:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "월: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 23);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "체크";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 56);
            this.button2.TabIndex = 5;
            this.button2.Text = "닫기 ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NoDateLabel);
            this.groupBox1.Controls.Add(this.UnCheckDates);
            this.groupBox1.Controls.Add(this.CheckDates);
            this.groupBox1.Controls.Add(this.DateLabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결 과";
            // 
            // NoDateLabel
            // 
            this.NoDateLabel.AutoSize = true;
            this.NoDateLabel.Location = new System.Drawing.Point(70, 84);
            this.NoDateLabel.Name = "NoDateLabel";
            this.NoDateLabel.Size = new System.Drawing.Size(106, 15);
            this.NoDateLabel.TabIndex = 3;
            this.NoDateLabel.Text = "계획 미등록 일수: ";
            // 
            // UnCheckDates
            // 
            this.UnCheckDates.AutoSize = true;
            this.UnCheckDates.Location = new System.Drawing.Point(70, 63);
            this.UnCheckDates.Name = "UnCheckDates";
            this.UnCheckDates.Size = new System.Drawing.Size(78, 15);
            this.UnCheckDates.TabIndex = 2;
            this.UnCheckDates.Text = "미달성 일수: ";
            // 
            // CheckDates
            // 
            this.CheckDates.AutoSize = true;
            this.CheckDates.Location = new System.Drawing.Point(70, 42);
            this.CheckDates.Name = "CheckDates";
            this.CheckDates.Size = new System.Drawing.Size(66, 15);
            this.CheckDates.TabIndex = 1;
            this.CheckDates.Text = "달성 일수: ";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(70, 21);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(38, 15);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "날짜: ";
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CheckForm";
            this.Text = "월별 달성/미달성/미등록 일수 체크";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label UnCheckDates;
        private Label CheckDates;
        private Label DateLabel;
        private Label NoDateLabel;
    }
}