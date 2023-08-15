<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Device
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Device))
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_Post = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Btn_EibForm = New CS_Component.Btn
        Me.Btn_WorkForm = New CS_Component.Btn
        Me.Btn_pishnahad = New CS_Component.Btn
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_Sazande = New CS_Component.TextBox
        Me.txt_Model = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_DeviceName = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Lbl_DEviceNAme = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_Type = New System.Windows.Forms.Label
        Me.rb_rele = New System.Windows.Forms.RadioButton
        Me.Rb_Cable = New System.Windows.Forms.RadioButton
        Me.Rb_TGhodrat = New System.Windows.Forms.RadioButton
        Me.Rb_Barghgir = New System.Windows.Forms.RadioButton
        Me.Rb_Sexioner = New System.Windows.Forms.RadioButton
        Me.Rb_Breaker = New System.Windows.Forms.RadioButton
        Me.Rb_TVotaje = New System.Windows.Forms.RadioButton
        Me.Rb_TJaryan = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_rele)
        Me.GroupBox1.Controls.Add(Me.Rb_Barghgir)
        Me.GroupBox1.Controls.Add(Me.Rb_Sexioner)
        Me.GroupBox1.Controls.Add(Me.Rb_Breaker)
        Me.GroupBox1.Controls.Add(Me.Rb_TGhodrat)
        Me.GroupBox1.Controls.Add(Me.Rb_TVotaje)
        Me.GroupBox1.Controls.Add(Me.Rb_TJaryan)
        Me.GroupBox1.Controls.Add(Me.Rb_Cable)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 618)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 76)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_Cable, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_TJaryan, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_TVotaje, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_TGhodrat, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_Breaker, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_Sexioner, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.Rb_Barghgir, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.rb_rele, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_New, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Cancel, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(14, 43)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(347, 44)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(441, 44)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(535, 44)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.cmb_Post)
        Me.gbx_DataGridView.Controls.Add(Me.lb_Type)
        Me.gbx_DataGridView.Controls.Add(Me.Label1)
        Me.gbx_DataGridView.Controls.Add(Me.Tree_Vw1)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(632, 409)
        '
        'Tree_Vw1
        '
        Me.Tree_Vw1.BackColor = System.Drawing.Color.White
        Me.Tree_Vw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tree_Vw1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Tree_Vw1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Tree_Vw1.Location = New System.Drawing.Point(8, 54)
        Me.Tree_Vw1.Name = "Tree_Vw1"
        Me.Tree_Vw1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Tree_Vw1.Size = New System.Drawing.Size(616, 342)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(423, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "نمایش تجهیزات مربوط به پست :"
        '
        'cmb_Post
        '
        Me.cmb_Post.AutoComplete = True
        Me.cmb_Post.DataSource = Me.PmPostBindingSource
        Me.cmb_Post.DisplayMember = "نام پست"
        Me.cmb_Post.EnterStop = True
        Me.cmb_Post.FormattingEnabled = True
        Me.cmb_Post.IsRequired = False
        Me.cmb_Post.LimitedToList = True
        Me.cmb_Post.Location = New System.Drawing.Point(169, 18)
        Me.cmb_Post.Name = "cmb_Post"
        Me.cmb_Post.OpenOnFoucus = False
        Me.cmb_Post.Size = New System.Drawing.Size(248, 24)
        Me.cmb_Post.TabIndex = 5
        Me.cmb_Post.ValueMember = "Srl"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_EibForm)
        Me.GroupBox2.Controls.Add(Me.Btn_WorkForm)
        Me.GroupBox2.Controls.Add(Me.Btn_pishnahad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_Sazande)
        Me.GroupBox2.Controls.Add(Me.txt_Model)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_DeviceName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Lbl_DEviceNAme)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 447)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 171)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اطلاعات تجهیز انتخاب شده"
        '
        'Btn_EibForm
        '
        Me.Btn_EibForm.BackColor = System.Drawing.Color.Transparent
        Me.Btn_EibForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EibForm.HeaderText = "فرم نقص های پست"
        Me.Btn_EibForm.Location = New System.Drawing.Point(13, 125)
        Me.Btn_EibForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_EibForm.Name = "Btn_EibForm"
        Me.Btn_EibForm.Size = New System.Drawing.Size(135, 26)
        Me.Btn_EibForm.TabIndex = 14
        '
        'Btn_WorkForm
        '
        Me.Btn_WorkForm.BackColor = System.Drawing.Color.Transparent
        Me.Btn_WorkForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_WorkForm.HeaderText = "فرم کارهای پست"
        Me.Btn_WorkForm.Location = New System.Drawing.Point(13, 80)
        Me.Btn_WorkForm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_WorkForm.Name = "Btn_WorkForm"
        Me.Btn_WorkForm.Size = New System.Drawing.Size(135, 26)
        Me.Btn_WorkForm.TabIndex = 13
        '
        'Btn_pishnahad
        '
        Me.Btn_pishnahad.BackColor = System.Drawing.Color.Transparent
        Me.Btn_pishnahad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_pishnahad.HeaderText = "پیشنهادات پست"
        Me.Btn_pishnahad.Location = New System.Drawing.Point(13, 35)
        Me.Btn_pishnahad.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_pishnahad.Name = "Btn_pishnahad"
        Me.Btn_pishnahad.Size = New System.Drawing.Size(135, 26)
        Me.Btn_pishnahad.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(334, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "سازنده / مدل"
        '
        'txt_Sazande
        '
        Me.txt_Sazande.CheckExistValueInDb = False
        Me.txt_Sazande.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Sazande.CurrencyUnit = "ریال"
        Me.txt_Sazande.DefaultValue = ""
        Me.txt_Sazande.Enabled = False
        Me.txt_Sazande.FillWithMaxInDb = False
        Me.txt_Sazande.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_Sazande.IsRequired = False
        Me.txt_Sazande.Location = New System.Drawing.Point(211, 142)
        Me.txt_Sazande.MaxDecimalLength = 2
        Me.txt_Sazande.Name = "txt_Sazande"
        Me.txt_Sazande.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Sazande.Size = New System.Drawing.Size(115, 23)
        Me.txt_Sazande.SpellControl = Nothing
        Me.txt_Sazande.TabIndex = 7
        Me.txt_Sazande.Tag = ""
        Me.txt_Sazande.Title = Nothing
        Me.txt_Sazande.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Sazande.UseForData = True
        Me.txt_Sazande.ValidateCheckExistOnEdit = False
        Me.txt_Sazande.Value = ""
        '
        'txt_Model
        '
        Me.txt_Model.CheckExistValueInDb = False
        Me.txt_Model.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Model.CurrencyUnit = "ریال"
        Me.txt_Model.DefaultValue = ""
        Me.txt_Model.Enabled = False
        Me.txt_Model.FillWithMaxInDb = False
        Me.txt_Model.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_Model.IsRequired = False
        Me.txt_Model.Location = New System.Drawing.Point(423, 142)
        Me.txt_Model.MaxDecimalLength = 2
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Model.Size = New System.Drawing.Size(115, 23)
        Me.txt_Model.SpellControl = Nothing
        Me.txt_Model.TabIndex = 7
        Me.txt_Model.Tag = "Model"
        Me.txt_Model.Title = Nothing
        Me.txt_Model.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Model.UseForData = True
        Me.txt_Model.ValidateCheckExistOnEdit = False
        Me.txt_Model.Value = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = " مدل"
        '
        'txt_DeviceName
        '
        Me.txt_DeviceName.CheckExistValueInDb = False
        Me.txt_DeviceName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceName.CurrencyUnit = "ریال"
        Me.txt_DeviceName.DefaultValue = ""
        Me.txt_DeviceName.Enabled = False
        Me.txt_DeviceName.FillWithMaxInDb = False
        Me.txt_DeviceName.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_DeviceName.IsRequired = False
        Me.txt_DeviceName.Location = New System.Drawing.Point(211, 109)
        Me.txt_DeviceName.MaxDecimalLength = 2
        Me.txt_DeviceName.Name = "txt_DeviceName"
        Me.txt_DeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceName.Size = New System.Drawing.Size(327, 23)
        Me.txt_DeviceName.SpellControl = Nothing
        Me.txt_DeviceName.TabIndex = 5
        Me.txt_DeviceName.Tag = ""
        Me.txt_DeviceName.Title = Nothing
        Me.txt_DeviceName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceName.UseForData = True
        Me.txt_DeviceName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceName.Value = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(473, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "آدرس تجهیز در این پست:"
        '
        'Lbl_DEviceNAme
        '
        Me.Lbl_DEviceNAme.ForeColor = System.Drawing.Color.Brown
        Me.Lbl_DEviceNAme.Location = New System.Drawing.Point(134, 25)
        Me.Lbl_DEviceNAme.Name = "Lbl_DEviceNAme"
        Me.Lbl_DEviceNAme.Size = New System.Drawing.Size(333, 19)
        Me.Lbl_DEviceNAme.TabIndex = 4
        Me.Lbl_DEviceNAme.Text = "نام دستگاه"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(551, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "نام دستگاه"
        '
        'lb_Type
        '
        Me.lb_Type.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_Type.ForeColor = System.Drawing.Color.ForestGreen
        Me.lb_Type.Location = New System.Drawing.Point(14, 21)
        Me.lb_Type.Name = "lb_Type"
        Me.lb_Type.Size = New System.Drawing.Size(138, 16)
        Me.lb_Type.TabIndex = 4
        Me.lb_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rb_rele
        '
        Me.rb_rele.AutoSize = True
        Me.rb_rele.Location = New System.Drawing.Point(584, 13)
        Me.rb_rele.Name = "rb_rele"
        Me.rb_rele.Size = New System.Drawing.Size(42, 20)
        Me.rb_rele.TabIndex = 4
        Me.rb_rele.TabStop = True
        Me.rb_rele.Text = "رله"
        Me.rb_rele.UseVisualStyleBackColor = True
        '
        'Rb_Cable
        '
        Me.Rb_Cable.AutoSize = True
        Me.Rb_Cable.Location = New System.Drawing.Point(14, 14)
        Me.Rb_Cable.Name = "Rb_Cable"
        Me.Rb_Cable.Size = New System.Drawing.Size(103, 20)
        Me.Rb_Cable.TabIndex = 4
        Me.Rb_Cable.TabStop = True
        Me.Rb_Cable.Text = "کابل و سرکابل"
        Me.Rb_Cable.UseVisualStyleBackColor = True
        '
        'Rb_TGhodrat
        '
        Me.Rb_TGhodrat.AutoSize = True
        Me.Rb_TGhodrat.Location = New System.Drawing.Point(494, 13)
        Me.Rb_TGhodrat.Name = "Rb_TGhodrat"
        Me.Rb_TGhodrat.Size = New System.Drawing.Size(91, 20)
        Me.Rb_TGhodrat.TabIndex = 4
        Me.Rb_TGhodrat.TabStop = True
        Me.Rb_TGhodrat.Text = "ترانس قدرت"
        Me.Rb_TGhodrat.UseVisualStyleBackColor = True
        '
        'Rb_Barghgir
        '
        Me.Rb_Barghgir.AutoSize = True
        Me.Rb_Barghgir.Location = New System.Drawing.Point(439, 13)
        Me.Rb_Barghgir.Name = "Rb_Barghgir"
        Me.Rb_Barghgir.Size = New System.Drawing.Size(57, 20)
        Me.Rb_Barghgir.TabIndex = 4
        Me.Rb_Barghgir.TabStop = True
        Me.Rb_Barghgir.Text = "برقگیر"
        Me.Rb_Barghgir.UseVisualStyleBackColor = True
        '
        'Rb_Sexioner
        '
        Me.Rb_Sexioner.AutoSize = True
        Me.Rb_Sexioner.Location = New System.Drawing.Point(357, 14)
        Me.Rb_Sexioner.Name = "Rb_Sexioner"
        Me.Rb_Sexioner.Size = New System.Drawing.Size(80, 20)
        Me.Rb_Sexioner.TabIndex = 4
        Me.Rb_Sexioner.TabStop = True
        Me.Rb_Sexioner.Text = "سکسیونر"
        Me.Rb_Sexioner.UseVisualStyleBackColor = True
        '
        'Rb_Breaker
        '
        Me.Rb_Breaker.AutoSize = True
        Me.Rb_Breaker.Location = New System.Drawing.Point(306, 13)
        Me.Rb_Breaker.Name = "Rb_Breaker"
        Me.Rb_Breaker.Size = New System.Drawing.Size(51, 20)
        Me.Rb_Breaker.TabIndex = 4
        Me.Rb_Breaker.TabStop = True
        Me.Rb_Breaker.Text = "بریکر"
        Me.Rb_Breaker.UseVisualStyleBackColor = True
        '
        'Rb_TVotaje
        '
        Me.Rb_TVotaje.AutoSize = True
        Me.Rb_TVotaje.Location = New System.Drawing.Point(217, 14)
        Me.Rb_TVotaje.Name = "Rb_TVotaje"
        Me.Rb_TVotaje.Size = New System.Drawing.Size(86, 20)
        Me.Rb_TVotaje.TabIndex = 4
        Me.Rb_TVotaje.TabStop = True
        Me.Rb_TVotaje.Text = "ترانس ولتاژ"
        Me.Rb_TVotaje.UseVisualStyleBackColor = True
        '
        'Rb_TJaryan
        '
        Me.Rb_TJaryan.AutoSize = True
        Me.Rb_TJaryan.Location = New System.Drawing.Point(120, 13)
        Me.Rb_TJaryan.Name = "Rb_TJaryan"
        Me.Rb_TJaryan.Size = New System.Drawing.Size(94, 20)
        Me.Rb_TJaryan.TabIndex = 4
        Me.Rb_TJaryan.TabStop = True
        Me.Rb_TJaryan.Text = "ترانس جریان"
        Me.Rb_TJaryan.UseVisualStyleBackColor = True
        '
        'Frm_Device
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.GoOnUpDown = False
        Me.Name = "Frm_Device"
        Me.TableName = "Pm_Hadese_KhesaratDevice"
        Me.Text = "نمایش تجهیزات مربوط به پست"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.gbx_DataGridView, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tree_Vw1 As VB_Component.Tree_Vw
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents cmb_Post As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Model As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_DeviceName As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Sazande As CS_Component.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DEviceNAme As System.Windows.Forms.Label
    Friend WithEvents Btn_EibForm As CS_Component.Btn
    Friend WithEvents Btn_WorkForm As CS_Component.Btn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents اضافهکردنبرنامهPMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lb_Type As System.Windows.Forms.Label
    Friend WithEvents rb_rele As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Cable As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Barghgir As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_TGhodrat As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Sexioner As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Breaker As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_TVotaje As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_TJaryan As System.Windows.Forms.RadioButton
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
    Friend WithEvents Btn_pishnahad As CS_Component.Btn
    Friend WithEvents اضافهکردنفایلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
