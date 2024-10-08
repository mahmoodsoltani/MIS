namespace CS_Component
{
    partial class AttachDatabase
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
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDbname = new System.Windows.Forms.TextBox();
            this.TxtLdf = new System.Windows.Forms.TextBox();
            this.TxtMdf = new System.Windows.Forms.TextBox();
            this.btn_AttachDb = new System.Windows.Forms.Button();
            this.btn_SelectLdfFile = new System.Windows.Forms.Button();
            this.btn_SelectMdfFile = new System.Windows.Forms.Button();
            this.grpLoginInfo = new System.Windows.Forms.GroupBox();
            this.chk_Trusted = new System.Windows.Forms.CheckBox();
            this.cmb_ServerName = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.lblPWD = new System.Windows.Forms.Label();
            this.Gp_FileAdress = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grpLoginInfo.SuspendLayout();
            this.Gp_FileAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "نام بانک";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "فایل LDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "فایل MDF";
            // 
            // TxtDbname
            // 
            this.TxtDbname.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDbname.Enabled = false;
            this.TxtDbname.Location = new System.Drawing.Point(60, 72);
            this.TxtDbname.Name = "TxtDbname";
            this.TxtDbname.ReadOnly = true;
            this.TxtDbname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtDbname.Size = new System.Drawing.Size(178, 21);
            this.TxtDbname.TabIndex = 4;
            // 
            // TxtLdf
            // 
            this.TxtLdf.BackColor = System.Drawing.SystemColors.Info;
            this.TxtLdf.Enabled = false;
            this.TxtLdf.Location = new System.Drawing.Point(60, 43);
            this.TxtLdf.Name = "TxtLdf";
            this.TxtLdf.ReadOnly = true;
            this.TxtLdf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtLdf.Size = new System.Drawing.Size(351, 21);
            this.TxtLdf.TabIndex = 2;
            // 
            // TxtMdf
            // 
            this.TxtMdf.BackColor = System.Drawing.SystemColors.Info;
            this.TxtMdf.Enabled = false;
            this.TxtMdf.Location = new System.Drawing.Point(60, 17);
            this.TxtMdf.Name = "TxtMdf";
            this.TxtMdf.ReadOnly = true;
            this.TxtMdf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtMdf.Size = new System.Drawing.Size(351, 21);
            this.TxtMdf.TabIndex = 0;
            // 
            // btn_AttachDb
            // 
            this.btn_AttachDb.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AttachDb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_AttachDb.Location = new System.Drawing.Point(265, 75);
            this.btn_AttachDb.Name = "btn_AttachDb";
            this.btn_AttachDb.Size = new System.Drawing.Size(82, 22);
            this.btn_AttachDb.TabIndex = 1;
            this.btn_AttachDb.Text = "افزودن بانک";
            this.btn_AttachDb.UseVisualStyleBackColor = false;
            this.btn_AttachDb.Click += new System.EventHandler(this.btn_AttachDb_Click);
            // 
            // btn_SelectLdfFile
            // 
            this.btn_SelectLdfFile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SelectLdfFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SelectLdfFile.Location = new System.Drawing.Point(419, 43);
            this.btn_SelectLdfFile.Name = "btn_SelectLdfFile";
            this.btn_SelectLdfFile.Size = new System.Drawing.Size(82, 22);
            this.btn_SelectLdfFile.TabIndex = 3;
            this.btn_SelectLdfFile.Text = "معرفی فایل";
            this.btn_SelectLdfFile.UseVisualStyleBackColor = false;
            this.btn_SelectLdfFile.Click += new System.EventHandler(this.btn_SelectLdfFile_Click);
            // 
            // btn_SelectMdfFile
            // 
            this.btn_SelectMdfFile.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SelectMdfFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SelectMdfFile.Location = new System.Drawing.Point(419, 17);
            this.btn_SelectMdfFile.Name = "btn_SelectMdfFile";
            this.btn_SelectMdfFile.Size = new System.Drawing.Size(82, 22);
            this.btn_SelectMdfFile.TabIndex = 0;
            this.btn_SelectMdfFile.Text = "معرفی فایل";
            this.btn_SelectMdfFile.UseVisualStyleBackColor = false;
            this.btn_SelectMdfFile.Click += new System.EventHandler(this.btn_SelectMdfFile_Click);
            // 
            // grpLoginInfo
            // 
            this.grpLoginInfo.Controls.Add(this.chk_Trusted);
            this.grpLoginInfo.Controls.Add(this.cmb_ServerName);
            this.grpLoginInfo.Controls.Add(this.btnConnect);
            this.grpLoginInfo.Controls.Add(this.lblServer);
            this.grpLoginInfo.Controls.Add(this.txtUID);
            this.grpLoginInfo.Controls.Add(this.lblUID);
            this.grpLoginInfo.Controls.Add(this.txtPWD);
            this.grpLoginInfo.Controls.Add(this.lblPWD);
            this.grpLoginInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpLoginInfo.Location = new System.Drawing.Point(12, 12);
            this.grpLoginInfo.Name = "grpLoginInfo";
            this.grpLoginInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpLoginInfo.Size = new System.Drawing.Size(208, 167);
            this.grpLoginInfo.TabIndex = 0;
            this.grpLoginInfo.TabStop = false;
            this.grpLoginInfo.Text = "SQL Connection Information";
            // 
            // chk_Trusted
            // 
            this.chk_Trusted.AutoSize = true;
            this.chk_Trusted.Location = new System.Drawing.Point(85, 54);
            this.chk_Trusted.Name = "chk_Trusted";
            this.chk_Trusted.Size = new System.Drawing.Size(120, 17);
            this.chk_Trusted.TabIndex = 22;
            this.chk_Trusted.Text = "Trusted Connection";
            this.chk_Trusted.UseVisualStyleBackColor = true;
            this.chk_Trusted.CheckedChanged += new System.EventHandler(this.chk_Trusted_CheckedChanged);
            // 
            // cmb_ServerName
            // 
            this.cmb_ServerName.FormattingEnabled = true;
            this.cmb_ServerName.Items.AddRange(new object[] {
            "(local)",
            ".",
            ".\\SQLEXPRESS"});
            this.cmb_ServerName.Location = new System.Drawing.Point(85, 24);
            this.cmb_ServerName.Name = "cmb_ServerName";
            this.cmb_ServerName.Size = new System.Drawing.Size(113, 21);
            this.cmb_ServerName.TabIndex = 24;
            this.cmb_ServerName.Text = ".\\SQLEXPRESS";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Location = new System.Drawing.Point(65, 138);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(6, 24);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(73, 13);
            this.lblServer.TabIndex = 23;
            this.lblServer.Text = "Server Name:";
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(85, 80);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(113, 21);
            this.txtUID.TabIndex = 1;
            this.txtUID.Text = "sa";
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(32, 80);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(47, 13);
            this.lblUID.TabIndex = 21;
            this.lblUID.Text = "User ID:";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(85, 104);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(113, 21);
            this.txtPWD.TabIndex = 2;
            this.txtPWD.Tag = "";
            this.txtPWD.Text = "1234";
            // 
            // lblPWD
            // 
            this.lblPWD.AutoSize = true;
            this.lblPWD.Location = new System.Drawing.Point(22, 104);
            this.lblPWD.Name = "lblPWD";
            this.lblPWD.Size = new System.Drawing.Size(57, 13);
            this.lblPWD.TabIndex = 19;
            this.lblPWD.Text = "Password:";
            // 
            // Gp_FileAdress
            // 
            this.Gp_FileAdress.Controls.Add(this.TxtDbname);
            this.Gp_FileAdress.Controls.Add(this.TxtMdf);
            this.Gp_FileAdress.Controls.Add(this.btn_AttachDb);
            this.Gp_FileAdress.Controls.Add(this.label3);
            this.Gp_FileAdress.Controls.Add(this.TxtLdf);
            this.Gp_FileAdress.Controls.Add(this.label2);
            this.Gp_FileAdress.Controls.Add(this.btn_SelectLdfFile);
            this.Gp_FileAdress.Controls.Add(this.btn_SelectMdfFile);
            this.Gp_FileAdress.Controls.Add(this.label1);
            this.Gp_FileAdress.Enabled = false;
            this.Gp_FileAdress.Location = new System.Drawing.Point(228, 12);
            this.Gp_FileAdress.Name = "Gp_FileAdress";
            this.Gp_FileAdress.Size = new System.Drawing.Size(507, 104);
            this.Gp_FileAdress.TabIndex = 1;
            this.Gp_FileAdress.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancel.Location = new System.Drawing.Point(653, 150);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 22);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AttachDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 191);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.Gp_FileAdress);
            this.Controls.Add(this.grpLoginInfo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachDatabase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت بانک اطلاعاتی";
            this.Load += new System.EventHandler(this.AttachDatabase_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AttachDatabase_KeyDown);
            this.grpLoginInfo.ResumeLayout(false);
            this.grpLoginInfo.PerformLayout();
            this.Gp_FileAdress.ResumeLayout(false);
            this.Gp_FileAdress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog DlgSave;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDbname;
        private System.Windows.Forms.TextBox TxtLdf;
        private System.Windows.Forms.TextBox TxtMdf;
        private System.Windows.Forms.Button btn_AttachDb;
        private System.Windows.Forms.Button btn_SelectLdfFile;
        private System.Windows.Forms.Button btn_SelectMdfFile;
        private System.Windows.Forms.GroupBox grpLoginInfo;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label lblPWD;
        private System.Windows.Forms.GroupBox Gp_FileAdress;
        private System.Windows.Forms.ComboBox cmb_ServerName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox chk_Trusted;

    }
}