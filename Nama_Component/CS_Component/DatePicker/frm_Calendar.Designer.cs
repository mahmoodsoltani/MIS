namespace System.Windows.Forms
{
    partial class frm_Calendar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Calendar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Today = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.calendar1 = new System.Windows.Forms.Calendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.btn_PreviousMonth = new System.Windows.Forms.Button();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.cld_MonthCalendar = new System.Windows.Forms.Calendar();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.calendar1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cld_MonthCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.calendar1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.cld_MonthCalendar);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 214);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_Today);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 28);
            this.panel4.TabIndex = 2;
            // 
            // lbl_Today
            // 
            this.lbl_Today.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Today.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Today.Location = new System.Drawing.Point(130, 6);
            this.lbl_Today.Name = "lbl_Today";
            this.lbl_Today.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Today.Size = new System.Drawing.Size(86, 12);
            this.lbl_Today.TabIndex = 4;
            this.lbl_Today.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbl_Today, "تاریخ امروز انتخاب میشود");
            this.lbl_Today.Click += new System.EventHandler(this.lbl_Today_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 5);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "تاریخ امروز :";
            // 
            // calendar1
            // 
            this.calendar1.Columns = 7;
            this.calendar1.Controls.Add(this.label7);
            this.calendar1.Controls.Add(this.label1);
            this.calendar1.Controls.Add(this.label6);
            this.calendar1.Controls.Add(this.label2);
            this.calendar1.Controls.Add(this.label5);
            this.calendar1.Controls.Add(this.label3);
            this.calendar1.Controls.Add(this.label4);
            this.calendar1.DrawHeader = true;
            this.calendar1.Location = new System.Drawing.Point(0, 28);
            this.calendar1.Name = "calendar1";
            this.calendar1.Rows = 7;
            this.calendar1.Size = new System.Drawing.Size(288, 156);
            this.calendar1.TabIndex = 1;
            this.calendar1.Text = "calendar1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LemonChiffon;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "جمعه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(251, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "شنبه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LemonChiffon;
            this.label6.Location = new System.Drawing.Point(42, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "۵شنبه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(208, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "۱شنبه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LemonChiffon;
            this.label5.Location = new System.Drawing.Point(84, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "۴شنبه";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(166, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "۲شنبه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(126, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "۳شنبه";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Year);
            this.panel3.Controls.Add(this.btn_NextMonth);
            this.panel3.Controls.Add(this.btn_PreviousMonth);
            this.panel3.Controls.Add(this.lbl_Month);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 28);
            this.panel3.TabIndex = 0;
            // 
            // lbl_Year
            // 
            this.lbl_Year.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Year.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Year.Location = new System.Drawing.Point(47, 1);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(96, 23);
            this.lbl_Year.TabIndex = 3;
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Year.Click += new System.EventHandler(this.lbl_Year_Click);
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.FlatAppearance.BorderSize = 0;
            this.btn_NextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_NextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_NextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextMonth.Image = ((System.Drawing.Image)(resources.GetObject("btn_NextMonth.Image")));
            this.btn_NextMonth.Location = new System.Drawing.Point(2, 1);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new System.Drawing.Size(19, 23);
            this.btn_NextMonth.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_NextMonth, "ماه بعد");
            this.btn_NextMonth.UseVisualStyleBackColor = true;
            this.btn_NextMonth.Click += new System.EventHandler(this.btn_NextMonth_Click);
            // 
            // btn_PreviousMonth
            // 
            this.btn_PreviousMonth.FlatAppearance.BorderSize = 0;
            this.btn_PreviousMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_PreviousMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_PreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("btn_PreviousMonth.Image")));
            this.btn_PreviousMonth.Location = new System.Drawing.Point(265, 1);
            this.btn_PreviousMonth.Name = "btn_PreviousMonth";
            this.btn_PreviousMonth.Size = new System.Drawing.Size(18, 23);
            this.btn_PreviousMonth.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_PreviousMonth, "ماه قبل");
            this.btn_PreviousMonth.UseVisualStyleBackColor = true;
            this.btn_PreviousMonth.Click += new System.EventHandler(this.btn_PreviousMonth_Click);
            // 
            // lbl_Month
            // 
            this.lbl_Month.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Month.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Month.Location = new System.Drawing.Point(149, 1);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(96, 23);
            this.lbl_Month.TabIndex = 0;
            this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Month.Click += new System.EventHandler(this.lbl_Month_Click);
            // 
            // cld_MonthCalendar
            // 
            this.cld_MonthCalendar.Columns = 3;
            this.cld_MonthCalendar.Controls.Add(this.label20);
            this.cld_MonthCalendar.Controls.Add(this.label19);
            this.cld_MonthCalendar.Controls.Add(this.label18);
            this.cld_MonthCalendar.Controls.Add(this.label17);
            this.cld_MonthCalendar.Controls.Add(this.label16);
            this.cld_MonthCalendar.Controls.Add(this.label15);
            this.cld_MonthCalendar.Controls.Add(this.label14);
            this.cld_MonthCalendar.Controls.Add(this.label13);
            this.cld_MonthCalendar.Controls.Add(this.label12);
            this.cld_MonthCalendar.Controls.Add(this.label11);
            this.cld_MonthCalendar.Controls.Add(this.label10);
            this.cld_MonthCalendar.Controls.Add(this.label9);
            this.cld_MonthCalendar.DrawHeader = false;
            this.cld_MonthCalendar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cld_MonthCalendar.Location = new System.Drawing.Point(0, 28);
            this.cld_MonthCalendar.Name = "cld_MonthCalendar";
            this.cld_MonthCalendar.Rows = 4;
            this.cld_MonthCalendar.Size = new System.Drawing.Size(288, 156);
            this.cld_MonthCalendar.TabIndex = 6;
            this.cld_MonthCalendar.Text = "calendar2";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(3, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 35);
            this.label20.TabIndex = 17;
            this.label20.Tag = "12";
            this.label20.Text = "اسفند";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(99, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 35);
            this.label19.TabIndex = 16;
            this.label19.Tag = "11";
            this.label19.Text = "بهمن";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(194, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 35);
            this.label18.TabIndex = 15;
            this.label18.Tag = "10";
            this.label18.Text = "دی";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(3, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 35);
            this.label17.TabIndex = 14;
            this.label17.Tag = "9";
            this.label17.Text = "آذر";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(99, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 35);
            this.label16.TabIndex = 13;
            this.label16.Tag = "8";
            this.label16.Text = "آبــان";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(194, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 35);
            this.label15.TabIndex = 12;
            this.label15.Tag = "7";
            this.label15.Text = "مــهـر";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(3, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 35);
            this.label14.TabIndex = 11;
            this.label14.Tag = "6";
            this.label14.Text = "شهـریور";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(99, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 35);
            this.label13.TabIndex = 10;
            this.label13.Tag = "5";
            this.label13.Text = "مــرداد";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(194, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 35);
            this.label12.TabIndex = 9;
            this.label12.Tag = "4";
            this.label12.Text = "تـیـر";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 35);
            this.label11.TabIndex = 9;
            this.label11.Tag = "3";
            this.label11.Text = "خـــرداد";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(99, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 35);
            this.label10.TabIndex = 8;
            this.label10.Tag = "2";
            this.label10.Text = "اردیبهشت";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(194, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 35);
            this.label9.TabIndex = 7;
            this.label9.Tag = "1";
            this.label9.Text = "فروردین";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.MonthLabel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 214);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Calendar";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Calendar";
            this.Load += new System.EventHandler(this.frm_Calendar_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.calendar1.ResumeLayout(false);
            this.calendar1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.cld_MonthCalendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Today;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Calendar calendar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Button btn_NextMonth;
        private System.Windows.Forms.Button btn_PreviousMonth;
        private System.Windows.Forms.Label lbl_Month;
        private ToolTip toolTip1;
        private Timer timer1;
        private Calendar cld_MonthCalendar;
        private Label label9;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}