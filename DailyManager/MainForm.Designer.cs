namespace DailyManager
{
    partial class MainForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.No_radiobtn = new System.Windows.Forms.RadioButton();
            this.Yes_radiobtn = new System.Windows.Forms.RadioButton();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.월별계획달성여부체크ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDailyManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Modify_radiobtn = new System.Windows.Forms.RadioButton();
            this.Read_radiobtn = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(438, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(385, 105);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(438, 131);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "날짜:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "일정 계획:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.No_radiobtn);
            this.groupBox1.Controls.Add(this.Yes_radiobtn);
            this.groupBox1.Location = new System.Drawing.Point(37, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 61);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "계획 달성 여부";
            // 
            // No_radiobtn
            // 
            this.No_radiobtn.AutoSize = true;
            this.No_radiobtn.Checked = true;
            this.No_radiobtn.Location = new System.Drawing.Point(96, 22);
            this.No_radiobtn.Name = "No_radiobtn";
            this.No_radiobtn.Size = new System.Drawing.Size(101, 19);
            this.No_radiobtn.TabIndex = 6;
            this.No_radiobtn.TabStop = true;
            this.No_radiobtn.Tag = "No";
            this.No_radiobtn.Text = "달성하지 않음";
            this.No_radiobtn.UseVisualStyleBackColor = true;
            // 
            // Yes_radiobtn
            // 
            this.Yes_radiobtn.AutoSize = true;
            this.Yes_radiobtn.Location = new System.Drawing.Point(29, 22);
            this.Yes_radiobtn.Name = "Yes_radiobtn";
            this.Yes_radiobtn.Size = new System.Drawing.Size(61, 19);
            this.Yes_radiobtn.TabIndex = 0;
            this.Yes_radiobtn.Tag = "Yes";
            this.Yes_radiobtn.Text = "달성함";
            this.Yes_radiobtn.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(385, 309);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 58);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(688, 309);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(134, 58);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(531, 309);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(151, 58);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.월별계획달성여부체크ToolStripMenuItem,
            this.closeXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "File(F)";
            // 
            // 월별계획달성여부체크ToolStripMenuItem
            // 
            this.월별계획달성여부체크ToolStripMenuItem.Name = "월별계획달성여부체크ToolStripMenuItem";
            this.월별계획달성여부체크ToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.월별계획달성여부체크ToolStripMenuItem.Text = "월별 계획 달성 여부 체크";
            this.월별계획달성여부체크ToolStripMenuItem.Click += new System.EventHandler(this.월별계획달성여부체크ToolStripMenuItem_Click);
            // 
            // closeXToolStripMenuItem
            // 
            this.closeXToolStripMenuItem.Name = "closeXToolStripMenuItem";
            this.closeXToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.closeXToolStripMenuItem.Text = "닫기(X)";
            this.closeXToolStripMenuItem.Click += new System.EventHandler(this.closeXToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDailyManagerToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(H)";
            // 
            // aboutDailyManagerToolStripMenuItem
            // 
            this.aboutDailyManagerToolStripMenuItem.Name = "aboutDailyManagerToolStripMenuItem";
            this.aboutDailyManagerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.aboutDailyManagerToolStripMenuItem.Text = "About DailyManager";
            this.aboutDailyManagerToolStripMenuItem.Click += new System.EventHandler(this.aboutDailyManagerToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "This is not Copyrighted.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Modify_radiobtn);
            this.groupBox2.Controls.Add(this.Read_radiobtn);
            this.groupBox2.Location = new System.Drawing.Point(37, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 62);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "읽기/수정 모드 선택";
            // 
            // Modify_radiobtn
            // 
            this.Modify_radiobtn.AutoSize = true;
            this.Modify_radiobtn.Checked = true;
            this.Modify_radiobtn.Location = new System.Drawing.Point(125, 22);
            this.Modify_radiobtn.Name = "Modify_radiobtn";
            this.Modify_radiobtn.Size = new System.Drawing.Size(77, 19);
            this.Modify_radiobtn.TabIndex = 1;
            this.Modify_radiobtn.TabStop = true;
            this.Modify_radiobtn.Tag = "Modify";
            this.Modify_radiobtn.Text = "수정 모드";
            this.Modify_radiobtn.UseVisualStyleBackColor = true;
            // 
            // Read_radiobtn
            // 
            this.Read_radiobtn.AutoSize = true;
            this.Read_radiobtn.Location = new System.Drawing.Point(29, 24);
            this.Read_radiobtn.Name = "Read_radiobtn";
            this.Read_radiobtn.Size = new System.Drawing.Size(77, 19);
            this.Read_radiobtn.TabIndex = 0;
            this.Read_radiobtn.Tag = "Read";
            this.Read_radiobtn.Text = "읽기 모드";
            this.Read_radiobtn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(508, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(315, 23);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(508, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(315, 23);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "등록 날짜:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "수정 날짜:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Your Operating System: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 412);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DailyManager 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton No_radiobtn;
        private RadioButton Yes_radiobtn;
        private Button btn_Save;
        private Button btn_Close;
        private Button btn_Delete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileFToolStripMenuItem;
        private ToolStripMenuItem closeXToolStripMenuItem;
        private ToolStripMenuItem helpHToolStripMenuItem;
        private ToolStripMenuItem aboutDailyManagerToolStripMenuItem;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton Modify_radiobtn;
        private RadioButton Read_radiobtn;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolStripMenuItem 월별계획달성여부체크ToolStripMenuItem;
    }
}