﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DeviceSelect
    Inherits BaseForm_View

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DeviceSelect))
        Me.Tree_Vw1 = New VB_Component.Tree_Vw
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.اضافهکردنبرنامهPMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.کپیToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.چسباندنToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.حذفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.جدیدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.تجهیزاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.رلهToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ترانسقدرتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.برقگیرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.بریکرToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.بریکرToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ترانسولتاژToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ترانسجریانToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.کابلوسرکابلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ویرایشToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.اضافهکردنفایلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 643)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 55)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(14, 22)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(347, 23)
        Me.btn_Delete.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(441, 23)
        Me.btn_Edit.Visible = False
        '
        'btn_New
        '
        Me.btn_New.HeaderText = "انتخاب"
        Me.btn_New.Location = New System.Drawing.Point(535, 23)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Tree_Vw1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(632, 601)
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tree_Vw1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(3, 19)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(626, 579)
        Me.Tree_Vw1.TabIndex = 3
        Me.Tree_Vw1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافهکردنبرنامهPMToolStripMenuItem, Me.کپیToolStripMenuItem, Me.چسباندنToolStripMenuItem, Me.حذفToolStripMenuItem, Me.جدیدToolStripMenuItem, Me.ویرایشToolStripMenuItem, Me.اضافهکردنفایلToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 158)
        '
        'اضافهکردنبرنامهPMToolStripMenuItem
        '
        Me.اضافهکردنبرنامهPMToolStripMenuItem.Name = "اضافهکردنبرنامهPMToolStripMenuItem"
        Me.اضافهکردنبرنامهPMToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.اضافهکردنبرنامهPMToolStripMenuItem.Text = "اضافه کردن برنامه PM"
        '
        'کپیToolStripMenuItem
        '
        Me.کپیToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.file_copy
        Me.کپیToolStripMenuItem.Name = "کپیToolStripMenuItem"
        Me.کپیToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.کپیToolStripMenuItem.Text = "کپی"
        '
        'چسباندنToolStripMenuItem
        '
        Me.چسباندنToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.paste
        Me.چسباندنToolStripMenuItem.Name = "چسباندنToolStripMenuItem"
        Me.چسباندنToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.چسباندنToolStripMenuItem.Text = "اضافه کردن"
        '
        'حذفToolStripMenuItem
        '
        Me.حذفToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.delete_01
        Me.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem"
        Me.حذفToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.حذفToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.حذفToolStripMenuItem.Text = "حذف"
        '
        'جدیدToolStripMenuItem
        '
        Me.جدیدToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.تجهیزاتToolStripMenuItem, Me.رلهToolStripMenuItem, Me.ترانسقدرتToolStripMenuItem, Me.برقگیرToolStripMenuItem, Me.بریکرToolStripMenuItem, Me.بریکرToolStripMenuItem1, Me.ترانسولتاژToolStripMenuItem, Me.ترانسجریانToolStripMenuItem, Me.کابلوسرکابلToolStripMenuItem})
        Me.جدیدToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.plus
        Me.جدیدToolStripMenuItem.Name = "جدیدToolStripMenuItem"
        Me.جدیدToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.جدیدToolStripMenuItem.Text = "جدید"
        '
        'تجهیزاتToolStripMenuItem
        '
        Me.تجهیزاتToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.advancedsettings
        Me.تجهیزاتToolStripMenuItem.Name = "تجهیزاتToolStripMenuItem"
        Me.تجهیزاتToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.تجهیزاتToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.تجهیزاتToolStripMenuItem.Text = "تجهیزات"
        '
        'رلهToolStripMenuItem
        '
        Me.رلهToolStripMenuItem.Image = CType(resources.GetObject("رلهToolStripMenuItem.Image"), System.Drawing.Image)
        Me.رلهToolStripMenuItem.Name = "رلهToolStripMenuItem"
        Me.رلهToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.رلهToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.رلهToolStripMenuItem.Text = "رله"
        '
        'ترانسقدرتToolStripMenuItem
        '
        Me.ترانسقدرتToolStripMenuItem.Image = CType(resources.GetObject("ترانسقدرتToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ترانسقدرتToolStripMenuItem.Name = "ترانسقدرتToolStripMenuItem"
        Me.ترانسقدرتToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ترانسقدرتToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ترانسقدرتToolStripMenuItem.Text = "ترانس قدرت"
        '
        'برقگیرToolStripMenuItem
        '
        Me.برقگیرToolStripMenuItem.Image = CType(resources.GetObject("برقگیرToolStripMenuItem.Image"), System.Drawing.Image)
        Me.برقگیرToolStripMenuItem.Name = "برقگیرToolStripMenuItem"
        Me.برقگیرToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.برقگیرToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.برقگیرToolStripMenuItem.Text = "برقگیر"
        '
        'بریکرToolStripMenuItem
        '
        Me.بریکرToolStripMenuItem.Image = CType(resources.GetObject("بریکرToolStripMenuItem.Image"), System.Drawing.Image)
        Me.بریکرToolStripMenuItem.Name = "بریکرToolStripMenuItem"
        Me.بریکرToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.بریکرToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.بریکرToolStripMenuItem.Text = "سکسیونر"
        '
        'بریکرToolStripMenuItem1
        '
        Me.بریکرToolStripMenuItem1.Image = CType(resources.GetObject("بریکرToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.بریکرToolStripMenuItem1.Name = "بریکرToolStripMenuItem1"
        Me.بریکرToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.بریکرToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.بریکرToolStripMenuItem1.Text = "بریکر"
        '
        'ترانسولتاژToolStripMenuItem
        '
        Me.ترانسولتاژToolStripMenuItem.Image = CType(resources.GetObject("ترانسولتاژToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ترانسولتاژToolStripMenuItem.Name = "ترانسولتاژToolStripMenuItem"
        Me.ترانسولتاژToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.ترانسولتاژToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ترانسولتاژToolStripMenuItem.Text = "ترانس ولتاژ"
        '
        'ترانسجریانToolStripMenuItem
        '
        Me.ترانسجریانToolStripMenuItem.Image = CType(resources.GetObject("ترانسجریانToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ترانسجریانToolStripMenuItem.Name = "ترانسجریانToolStripMenuItem"
        Me.ترانسجریانToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ترانسجریانToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ترانسجریانToolStripMenuItem.Text = "ترانس جریان"
        '
        'کابلوسرکابلToolStripMenuItem
        '
        Me.کابلوسرکابلToolStripMenuItem.Image = CType(resources.GetObject("کابلوسرکابلToolStripMenuItem.Image"), System.Drawing.Image)
        Me.کابلوسرکابلToolStripMenuItem.Name = "کابلوسرکابلToolStripMenuItem"
        Me.کابلوسرکابلToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.کابلوسرکابلToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.کابلوسرکابلToolStripMenuItem.Text = "کابل و سر کابل"
        '
        'ویرایشToolStripMenuItem
        '
        Me.ویرایشToolStripMenuItem.Image = Global.Nama_PM.My.Resources.Resources.write
        Me.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem"
        Me.ویرایشToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ویرایشToolStripMenuItem.Text = "ویرایش"
        '
        'اضافهکردنفایلToolStripMenuItem
        '
        Me.اضافهکردنفایلToolStripMenuItem.Name = "اضافهکردنفایلToolStripMenuItem"
        Me.اضافهکردنفایلToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.اضافهکردنفایلToolStripMenuItem.Text = "اضافه کردن فایل"
        '
        'Ds_Hadese
        '
        Me.Ds_Hadese.DataSetName = "Ds_Hadese"
        Me.Ds_Hadese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmHadeseKhesaratDeviceBindingSource
        '
        Me.PmHadeseKhesaratDeviceBindingSource.DataMember = "Pm_Hadese_KhesaratDevice"
        Me.PmHadeseKhesaratDeviceBindingSource.DataSource = Me.Ds_Hadese
        '
        'Pm_Hadese_KhesaratDeviceTableAdapter
        '
        Me.Pm_Hadese_KhesaratDeviceTableAdapter.ClearBeforeFill = True
        '
        'PmPostBindingSource
        '
        Me.PmPostBindingSource.DataMember = "Pm_Post"
        Me.PmPostBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Frm_DeviceSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 730)
        Me.GoOnUpDown = False
        Me.Name = "Frm_DeviceSelect"
        Me.TableName = "Pm_Hadese_KhesaratDevice"
        Me.Text = "انتخاب تجهیزات"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbx_DataGridView, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents اضافهکردنبرنامهPMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents کپیToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents چسباندنToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents حذفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents جدیدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تجهیزاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents رلهToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ترانسقدرتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents برقگیرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents بریکرToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents بریکرToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ترانسولتاژToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ترانسجریانToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents کابلوسرکابلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ویرایشToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافهکردنفایلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
