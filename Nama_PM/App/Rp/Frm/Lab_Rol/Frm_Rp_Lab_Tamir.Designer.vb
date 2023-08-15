<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rp_Lab_Tamir
    Inherits BaseForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.شمارهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامقطعهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.پستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحاهمیتDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.علتورودDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریختعمیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریختحویلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخورودDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازهتعمیرDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.بازهتحویلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PmLabRolTamiratViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Lab = New Nama_PM.Ds_Lab
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbl_Record = New System.Windows.Forms.Label
        Me.Btn_print = New CS_Component.Btn
        Me.Btn_Search = New CS_Component.Btn
        Me.Pm_Lab_Rol_TamiratViewTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
        Me.cmb_Device = New VB_Component.ComboBox
        Me.PmLabRolGhatatMasrafiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Srl_DeviceKhesarat = New CS_Component.TextBox
        Me.cmb_SatheaAhamiat = New VB_Component.ComboBox
        Me.PmLabRolSatheAhamniatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_No = New CS_Component.TextBox
        Me.txt_TarikhSabtFrom = New CS_Component.TextBox
        Me.txt_NafarSat = New CS_Component.TextBox
        Me.cmb_Elat = New VB_Component.ComboBox
        Me.PmLabRolElateVorodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_Tavasot = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Ashkhas = New Nama_PM.Ds_Ashkhas
        Me.txt_TarikhTahvilfrom = New CS_Component.TextBox
        Me.txt_TarikhTamirFrom = New CS_Component.TextBox
        Me.txt_TarikhVorodFrom = New CS_Component.TextBox
        Me.cmb_PmPost = New VB_Component.ComboBox
        Me.PmPostBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.btn_SelectDEvice = New System.Windows.Forms.Button
        Me.txt_DeviceKhesaratName = New CS_Component.TextBox
        Me.chk_NafarSat = New System.Windows.Forms.CheckBox
        Me.chk_DeviceKhesaratName = New System.Windows.Forms.CheckBox
        Me.chk_Device = New System.Windows.Forms.CheckBox
        Me.chk_SatheaAhamiat = New System.Windows.Forms.CheckBox
        Me.chk_TarikhSabt = New System.Windows.Forms.CheckBox
        Me.chk_TarikhVorod = New System.Windows.Forms.CheckBox
        Me.chk_No = New System.Windows.Forms.CheckBox
        Me.chk_PmPost = New System.Windows.Forms.CheckBox
        Me.chk_Tavasot = New System.Windows.Forms.CheckBox
        Me.chk_TarikhTamir = New System.Windows.Forms.CheckBox
        Me.chk_TarikhTahvil = New System.Windows.Forms.CheckBox
        Me.chk_Elat = New System.Windows.Forms.CheckBox
        Me.cmb_TahvilePerson = New VB_Component.ComboBox
        Me.AccAshkhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Dis = New CS_Component.TextBox
        Me.chk_Dis = New System.Windows.Forms.CheckBox
        Me.chk_TahvilePerson = New System.Windows.Forms.CheckBox
        Me.Ds_Hadese = New Nama_PM.Ds_Hadese
        Me.PmHadeseKhesaratDeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Hadese_KhesaratDeviceTableAdapter = New Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_SatheAhamniatTableAdapter
        Me.Pm_Lab_Rol_ElateVorodTableAdapter = New Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_ElateVorodTableAdapter
        Me.Acc_AshkhasTableAdapter = New Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.txt_TarikhTamirTo = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_TarikhTahvilTo = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_TarikhVorodTo = New CS_Component.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_TarikhSabtTo = New CS_Component.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolSatheAhamniatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLabRolElateVorodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.شمارهDataGridViewTextBoxColumn, Me.نامقطعهDataGridViewTextBoxColumn, Me.پستDataGridViewTextBoxColumn, Me.سطحاهمیتDataGridViewTextBoxColumn, Me.علتورودDataGridViewTextBoxColumn, Me.تاریختعمیرDataGridViewTextBoxColumn, Me.تاریختحویلDataGridViewTextBoxColumn, Me.تاریخورودDataGridViewTextBoxColumn, Me.بازهتعمیرDataGridViewTextBoxColumn, Me.بازهتحویلDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmLabRolTamiratViewBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1055, 302)
        Me.DataGridView1.TabIndex = 5
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'شمارهDataGridViewTextBoxColumn
        '
        Me.شمارهDataGridViewTextBoxColumn.DataPropertyName = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.شمارهDataGridViewTextBoxColumn.Name = "شمارهDataGridViewTextBoxColumn"
        Me.شمارهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'نامقطعهDataGridViewTextBoxColumn
        '
        Me.نامقطعهDataGridViewTextBoxColumn.DataPropertyName = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.HeaderText = "نام قطعه"
        Me.نامقطعهDataGridViewTextBoxColumn.Name = "نامقطعهDataGridViewTextBoxColumn"
        Me.نامقطعهDataGridViewTextBoxColumn.ReadOnly = True
        '
        'پستDataGridViewTextBoxColumn
        '
        Me.پستDataGridViewTextBoxColumn.DataPropertyName = "پست"
        Me.پستDataGridViewTextBoxColumn.HeaderText = "پست"
        Me.پستDataGridViewTextBoxColumn.Name = "پستDataGridViewTextBoxColumn"
        Me.پستDataGridViewTextBoxColumn.ReadOnly = True
        '
        'سطحاهمیتDataGridViewTextBoxColumn
        '
        Me.سطحاهمیتDataGridViewTextBoxColumn.DataPropertyName = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn.HeaderText = "سطح اهمیت"
        Me.سطحاهمیتDataGridViewTextBoxColumn.Name = "سطحاهمیتDataGridViewTextBoxColumn"
        Me.سطحاهمیتDataGridViewTextBoxColumn.ReadOnly = True
        '
        'علتورودDataGridViewTextBoxColumn
        '
        Me.علتورودDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.علتورودDataGridViewTextBoxColumn.DataPropertyName = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn.HeaderText = "علت ورود"
        Me.علتورودDataGridViewTextBoxColumn.Name = "علتورودDataGridViewTextBoxColumn"
        Me.علتورودDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریختعمیرDataGridViewTextBoxColumn
        '
        Me.تاریختعمیرDataGridViewTextBoxColumn.DataPropertyName = "تاریخ تعمیر"
        Me.تاریختعمیرDataGridViewTextBoxColumn.HeaderText = "تاریخ تعمیر"
        Me.تاریختعمیرDataGridViewTextBoxColumn.Name = "تاریختعمیرDataGridViewTextBoxColumn"
        Me.تاریختعمیرDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریختحویلDataGridViewTextBoxColumn
        '
        Me.تاریختحویلDataGridViewTextBoxColumn.DataPropertyName = "تاریخ تحویل"
        Me.تاریختحویلDataGridViewTextBoxColumn.HeaderText = "تاریخ تحویل"
        Me.تاریختحویلDataGridViewTextBoxColumn.Name = "تاریختحویلDataGridViewTextBoxColumn"
        Me.تاریختحویلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'تاریخورودDataGridViewTextBoxColumn
        '
        Me.تاریخورودDataGridViewTextBoxColumn.DataPropertyName = "تاریخ ورود"
        Me.تاریخورودDataGridViewTextBoxColumn.HeaderText = "تاریخ ورود"
        Me.تاریخورودDataGridViewTextBoxColumn.Name = "تاریخورودDataGridViewTextBoxColumn"
        Me.تاریخورودDataGridViewTextBoxColumn.ReadOnly = True
        '
        'بازهتعمیرDataGridViewTextBoxColumn
        '
        Me.بازهتعمیرDataGridViewTextBoxColumn.DataPropertyName = "بازه تعمیر"
        Me.بازهتعمیرDataGridViewTextBoxColumn.HeaderText = "بازه تعمیر"
        Me.بازهتعمیرDataGridViewTextBoxColumn.Name = "بازهتعمیرDataGridViewTextBoxColumn"
        Me.بازهتعمیرDataGridViewTextBoxColumn.ReadOnly = True
        '
        'بازهتحویلDataGridViewTextBoxColumn
        '
        Me.بازهتحویلDataGridViewTextBoxColumn.DataPropertyName = "بازه تحویل"
        Me.بازهتحویلDataGridViewTextBoxColumn.HeaderText = "بازه تحویل"
        Me.بازهتحویلDataGridViewTextBoxColumn.Name = "بازهتحویلDataGridViewTextBoxColumn"
        Me.بازهتحویلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmLabRolTamiratViewBindingSource
        '
        Me.PmLabRolTamiratViewBindingSource.DataMember = "Pm_Lab_Rol_TamiratView"
        Me.PmLabRolTamiratViewBindingSource.DataSource = Me.Ds_Lab
        '
        'Ds_Lab
        '
        Me.Ds_Lab.DataSetName = "Ds_Lab"
        Me.Ds_Lab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_Record)
        Me.Panel1.Controls.Add(Me.Btn_print)
        Me.Panel1.Controls.Add(Me.Btn_Search)
        Me.Panel1.Location = New System.Drawing.Point(11, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 36)
        Me.Panel1.TabIndex = 179
        '
        'lbl_Record
        '
        Me.lbl_Record.AutoSize = True
        Me.lbl_Record.Location = New System.Drawing.Point(99, 8)
        Me.lbl_Record.Name = "lbl_Record"
        Me.lbl_Record.Size = New System.Drawing.Size(74, 18)
        Me.lbl_Record.TabIndex = 161
        Me.lbl_Record.Text = "تعداد رکورد"
        '
        'Btn_print
        '
        Me.Btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_print.BackColor = System.Drawing.Color.Transparent
        Me.Btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print.HeaderText = "چاپ"
        Me.Btn_print.Location = New System.Drawing.Point(803, 4)
        Me.Btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(114, 26)
        Me.Btn_print.TabIndex = 160
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.HeaderText = "جستجو"
        Me.Btn_Search.Location = New System.Drawing.Point(938, 4)
        Me.Btn_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(93, 26)
        Me.Btn_Search.TabIndex = 0
        '
        'Pm_Lab_Rol_TamiratViewTableAdapter
        '
        Me.Pm_Lab_Rol_TamiratViewTableAdapter.ClearBeforeFill = True
        '
        'cmb_Device
        '
        Me.cmb_Device.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Device.AutoComplete = True
        Me.cmb_Device.DataSource = Me.PmLabRolGhatatMasrafiBindingSource
        Me.cmb_Device.DisplayMember = "قطعات مصرفی"
        Me.cmb_Device.EnterStop = True
        Me.cmb_Device.FormattingEnabled = True
        Me.cmb_Device.IsRequired = False
        Me.cmb_Device.LimitedToList = True
        Me.cmb_Device.Location = New System.Drawing.Point(717, 95)
        Me.cmb_Device.Name = "cmb_Device"
        Me.cmb_Device.OpenOnFoucus = True
        Me.cmb_Device.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Device.TabIndex = 180
        Me.cmb_Device.ValueMember = "Srl"
        '
        'PmLabRolGhatatMasrafiBindingSource
        '
        Me.PmLabRolGhatatMasrafiBindingSource.DataMember = "Pm_Lab_Rol_GhatatMasrafi"
        Me.PmLabRolGhatatMasrafiBindingSource.DataSource = Me.Ds_Lab
        '
        'txt_Srl_DeviceKhesarat
        '
        Me.txt_Srl_DeviceKhesarat.CheckExistValueInDb = False
        Me.txt_Srl_DeviceKhesarat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Srl_DeviceKhesarat.CurrencyUnit = "ریال"
        Me.txt_Srl_DeviceKhesarat.DefaultValue = ""
        Me.txt_Srl_DeviceKhesarat.FillWithMaxInDb = False
        Me.txt_Srl_DeviceKhesarat.IsRequired = True
        Me.txt_Srl_DeviceKhesarat.Location = New System.Drawing.Point(11, 36)
        Me.txt_Srl_DeviceKhesarat.MaxDecimalLength = 2
        Me.txt_Srl_DeviceKhesarat.Name = "txt_Srl_DeviceKhesarat"
        Me.txt_Srl_DeviceKhesarat.ReadOnly = True
        Me.txt_Srl_DeviceKhesarat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Srl_DeviceKhesarat.Size = New System.Drawing.Size(52, 26)
        Me.txt_Srl_DeviceKhesarat.SpellControl = Nothing
        Me.txt_Srl_DeviceKhesarat.TabIndex = 205
        Me.txt_Srl_DeviceKhesarat.Tag = ""
        Me.txt_Srl_DeviceKhesarat.Title = Nothing
        Me.txt_Srl_DeviceKhesarat.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Srl_DeviceKhesarat.UseForData = True
        Me.txt_Srl_DeviceKhesarat.ValidateCheckExistOnEdit = False
        Me.txt_Srl_DeviceKhesarat.Value = ""
        Me.txt_Srl_DeviceKhesarat.Visible = False
        '
        'cmb_SatheaAhamiat
        '
        Me.cmb_SatheaAhamiat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_SatheaAhamiat.AutoComplete = True
        Me.cmb_SatheaAhamiat.DataSource = Me.PmLabRolSatheAhamniatBindingSource
        Me.cmb_SatheaAhamiat.DisplayMember = "سطح اهمیت"
        Me.cmb_SatheaAhamiat.EnterStop = True
        Me.cmb_SatheaAhamiat.FormattingEnabled = True
        Me.cmb_SatheaAhamiat.IsRequired = False
        Me.cmb_SatheaAhamiat.LimitedToList = True
        Me.cmb_SatheaAhamiat.Location = New System.Drawing.Point(717, 127)
        Me.cmb_SatheaAhamiat.Name = "cmb_SatheaAhamiat"
        Me.cmb_SatheaAhamiat.OpenOnFoucus = True
        Me.cmb_SatheaAhamiat.Size = New System.Drawing.Size(194, 26)
        Me.cmb_SatheaAhamiat.TabIndex = 182
        Me.cmb_SatheaAhamiat.ValueMember = "Srl"
        '
        'PmLabRolSatheAhamniatBindingSource
        '
        Me.PmLabRolSatheAhamniatBindingSource.DataMember = "Pm_Lab_Rol_SatheAhamniat"
        Me.PmLabRolSatheAhamniatBindingSource.DataSource = Me.Ds_Lab
        '
        'txt_No
        '
        Me.txt_No.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_No.CheckExistValueInDb = False
        Me.txt_No.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_No.CurrencyUnit = "ریال"
        Me.txt_No.DefaultValue = ""
        Me.txt_No.FillWithMaxInDb = False
        Me.txt_No.IsRequired = True
        Me.txt_No.Location = New System.Drawing.Point(449, 63)
        Me.txt_No.MaxDecimalLength = 2
        Me.txt_No.Name = "txt_No"
        Me.txt_No.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_No.Size = New System.Drawing.Size(150, 26)
        Me.txt_No.SpellControl = Nothing
        Me.txt_No.TabIndex = 183
        Me.txt_No.Tag = ""
        Me.txt_No.Title = Nothing
        Me.txt_No.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_No.UseForData = True
        Me.txt_No.ValidateCheckExistOnEdit = False
        Me.txt_No.Value = ""
        '
        'txt_TarikhSabtFrom
        '
        Me.txt_TarikhSabtFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhSabtFrom.CheckExistValueInDb = False
        Me.txt_TarikhSabtFrom.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabtFrom.CurrencyUnit = "ریال"
        Me.txt_TarikhSabtFrom.DefaultValue = ""
        Me.txt_TarikhSabtFrom.FillWithMaxInDb = False
        Me.txt_TarikhSabtFrom.IsRequired = True
        Me.txt_TarikhSabtFrom.Location = New System.Drawing.Point(449, 223)
        Me.txt_TarikhSabtFrom.MaxDecimalLength = 2
        Me.txt_TarikhSabtFrom.Name = "txt_TarikhSabtFrom"
        Me.txt_TarikhSabtFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabtFrom.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhSabtFrom.SpellControl = Nothing
        Me.txt_TarikhSabtFrom.TabIndex = 184
        Me.txt_TarikhSabtFrom.TabStop = False
        Me.txt_TarikhSabtFrom.Tag = ""
        Me.txt_TarikhSabtFrom.Title = Nothing
        Me.txt_TarikhSabtFrom.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabtFrom.UseForData = True
        Me.txt_TarikhSabtFrom.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabtFrom.Value = ""
        '
        'txt_NafarSat
        '
        Me.txt_NafarSat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_NafarSat.CheckExistValueInDb = False
        Me.txt_NafarSat.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_NafarSat.CurrencyUnit = "ریال"
        Me.txt_NafarSat.DefaultValue = "0"
        Me.txt_NafarSat.FillWithMaxInDb = False
        Me.txt_NafarSat.IsRequired = True
        Me.txt_NafarSat.Location = New System.Drawing.Point(449, 93)
        Me.txt_NafarSat.MaxDecimalLength = 2
        Me.txt_NafarSat.Name = "txt_NafarSat"
        Me.txt_NafarSat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_NafarSat.Size = New System.Drawing.Size(150, 26)
        Me.txt_NafarSat.SpellControl = Nothing
        Me.txt_NafarSat.TabIndex = 193
        Me.txt_NafarSat.Tag = ""
        Me.txt_NafarSat.Text = "0"
        Me.txt_NafarSat.Title = Nothing
        Me.txt_NafarSat.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_NafarSat.UseForData = True
        Me.txt_NafarSat.ValidateCheckExistOnEdit = False
        Me.txt_NafarSat.Value = "0"
        '
        'cmb_Elat
        '
        Me.cmb_Elat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Elat.AutoComplete = True
        Me.cmb_Elat.DataSource = Me.PmLabRolElateVorodBindingSource
        Me.cmb_Elat.DisplayMember = "علت ورود"
        Me.cmb_Elat.EnterStop = True
        Me.cmb_Elat.FormattingEnabled = True
        Me.cmb_Elat.IsRequired = False
        Me.cmb_Elat.LimitedToList = True
        Me.cmb_Elat.Location = New System.Drawing.Point(717, 159)
        Me.cmb_Elat.Name = "cmb_Elat"
        Me.cmb_Elat.OpenOnFoucus = True
        Me.cmb_Elat.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Elat.TabIndex = 190
        Me.cmb_Elat.ValueMember = "Srl"
        '
        'PmLabRolElateVorodBindingSource
        '
        Me.PmLabRolElateVorodBindingSource.DataMember = "Pm_Lab_Rol_ElateVorod"
        Me.PmLabRolElateVorodBindingSource.DataSource = Me.Ds_Lab
        '
        'cmb_Tavasot
        '
        Me.cmb_Tavasot.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_Tavasot.AutoComplete = True
        Me.cmb_Tavasot.DataSource = Me.AccAshkhasBindingSource1
        Me.cmb_Tavasot.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_Tavasot.EnterStop = True
        Me.cmb_Tavasot.FormattingEnabled = True
        Me.cmb_Tavasot.IsRequired = False
        Me.cmb_Tavasot.LimitedToList = True
        Me.cmb_Tavasot.Location = New System.Drawing.Point(717, 255)
        Me.cmb_Tavasot.Name = "cmb_Tavasot"
        Me.cmb_Tavasot.OpenOnFoucus = True
        Me.cmb_Tavasot.Size = New System.Drawing.Size(194, 26)
        Me.cmb_Tavasot.TabIndex = 185
        Me.cmb_Tavasot.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource1
        '
        Me.AccAshkhasBindingSource1.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource1.DataSource = Me.Ds_Ashkhas
        '
        'Ds_Ashkhas
        '
        Me.Ds_Ashkhas.DataSetName = "Ds_Ashkhas"
        Me.Ds_Ashkhas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_TarikhTahvilfrom
        '
        Me.txt_TarikhTahvilfrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhTahvilfrom.CheckExistValueInDb = False
        Me.txt_TarikhTahvilfrom.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTahvilfrom.CurrencyUnit = "ریال"
        Me.txt_TarikhTahvilfrom.DefaultValue = ""
        Me.txt_TarikhTahvilfrom.FillWithMaxInDb = False
        Me.txt_TarikhTahvilfrom.IsRequired = True
        Me.txt_TarikhTahvilfrom.Location = New System.Drawing.Point(449, 157)
        Me.txt_TarikhTahvilfrom.MaxDecimalLength = 2
        Me.txt_TarikhTahvilfrom.Name = "txt_TarikhTahvilfrom"
        Me.txt_TarikhTahvilfrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTahvilfrom.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhTahvilfrom.SpellControl = Nothing
        Me.txt_TarikhTahvilfrom.TabIndex = 195
        Me.txt_TarikhTahvilfrom.TabStop = False
        Me.txt_TarikhTahvilfrom.Tag = ""
        Me.txt_TarikhTahvilfrom.Title = Nothing
        Me.txt_TarikhTahvilfrom.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTahvilfrom.UseForData = True
        Me.txt_TarikhTahvilfrom.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTahvilfrom.Value = ""
        '
        'txt_TarikhTamirFrom
        '
        Me.txt_TarikhTamirFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhTamirFrom.CheckExistValueInDb = False
        Me.txt_TarikhTamirFrom.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTamirFrom.CurrencyUnit = "ریال"
        Me.txt_TarikhTamirFrom.DefaultValue = ""
        Me.txt_TarikhTamirFrom.FillWithMaxInDb = False
        Me.txt_TarikhTamirFrom.IsRequired = True
        Me.txt_TarikhTamirFrom.Location = New System.Drawing.Point(449, 125)
        Me.txt_TarikhTamirFrom.MaxDecimalLength = 2
        Me.txt_TarikhTamirFrom.Name = "txt_TarikhTamirFrom"
        Me.txt_TarikhTamirFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTamirFrom.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhTamirFrom.SpellControl = Nothing
        Me.txt_TarikhTamirFrom.TabIndex = 191
        Me.txt_TarikhTamirFrom.TabStop = False
        Me.txt_TarikhTamirFrom.Tag = ""
        Me.txt_TarikhTamirFrom.Title = Nothing
        Me.txt_TarikhTamirFrom.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTamirFrom.UseForData = True
        Me.txt_TarikhTamirFrom.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTamirFrom.Value = ""
        '
        'txt_TarikhVorodFrom
        '
        Me.txt_TarikhVorodFrom.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhVorodFrom.CheckExistValueInDb = False
        Me.txt_TarikhVorodFrom.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhVorodFrom.CurrencyUnit = "ریال"
        Me.txt_TarikhVorodFrom.DefaultValue = ""
        Me.txt_TarikhVorodFrom.FillWithMaxInDb = False
        Me.txt_TarikhVorodFrom.IsRequired = True
        Me.txt_TarikhVorodFrom.Location = New System.Drawing.Point(449, 189)
        Me.txt_TarikhVorodFrom.MaxDecimalLength = 2
        Me.txt_TarikhVorodFrom.Name = "txt_TarikhVorodFrom"
        Me.txt_TarikhVorodFrom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhVorodFrom.Size = New System.Drawing.Size(150, 26)
        Me.txt_TarikhVorodFrom.SpellControl = Nothing
        Me.txt_TarikhVorodFrom.TabIndex = 186
        Me.txt_TarikhVorodFrom.TabStop = False
        Me.txt_TarikhVorodFrom.Tag = ""
        Me.txt_TarikhVorodFrom.Title = Nothing
        Me.txt_TarikhVorodFrom.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhVorodFrom.UseForData = True
        Me.txt_TarikhVorodFrom.ValidateCheckExistOnEdit = False
        Me.txt_TarikhVorodFrom.Value = ""
        '
        'cmb_PmPost
        '
        Me.cmb_PmPost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_PmPost.AutoComplete = True
        Me.cmb_PmPost.DataSource = Me.PmPostBindingSource
        Me.cmb_PmPost.DisplayMember = "نام پست"
        Me.cmb_PmPost.EnterStop = True
        Me.cmb_PmPost.FormattingEnabled = True
        Me.cmb_PmPost.IsRequired = False
        Me.cmb_PmPost.LimitedToList = True
        Me.cmb_PmPost.Location = New System.Drawing.Point(717, 223)
        Me.cmb_PmPost.Name = "cmb_PmPost"
        Me.cmb_PmPost.OpenOnFoucus = True
        Me.cmb_PmPost.Size = New System.Drawing.Size(194, 26)
        Me.cmb_PmPost.TabIndex = 206
        Me.cmb_PmPost.Tag = ""
        Me.cmb_PmPost.ValueMember = "Srl"
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
        'btn_SelectDEvice
        '
        Me.btn_SelectDEvice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_SelectDEvice.Location = New System.Drawing.Point(714, 64)
        Me.btn_SelectDEvice.Name = "btn_SelectDEvice"
        Me.btn_SelectDEvice.Size = New System.Drawing.Size(38, 25)
        Me.btn_SelectDEvice.TabIndex = 208
        Me.btn_SelectDEvice.Text = "..."
        Me.btn_SelectDEvice.UseVisualStyleBackColor = True
        '
        'txt_DeviceKhesaratName
        '
        Me.txt_DeviceKhesaratName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_DeviceKhesaratName.CheckExistValueInDb = False
        Me.txt_DeviceKhesaratName.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeviceKhesaratName.CurrencyUnit = "ریال"
        Me.txt_DeviceKhesaratName.DefaultValue = ""
        Me.txt_DeviceKhesaratName.Enabled = False
        Me.txt_DeviceKhesaratName.FillWithMaxInDb = False
        Me.txt_DeviceKhesaratName.ForeColor = System.Drawing.SystemColors.Info
        Me.txt_DeviceKhesaratName.IsRequired = True
        Me.txt_DeviceKhesaratName.Location = New System.Drawing.Point(753, 63)
        Me.txt_DeviceKhesaratName.MaxDecimalLength = 2
        Me.txt_DeviceKhesaratName.Name = "txt_DeviceKhesaratName"
        Me.txt_DeviceKhesaratName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_DeviceKhesaratName.Size = New System.Drawing.Size(158, 26)
        Me.txt_DeviceKhesaratName.SpellControl = Nothing
        Me.txt_DeviceKhesaratName.TabIndex = 207
        Me.txt_DeviceKhesaratName.Tag = ""
        Me.txt_DeviceKhesaratName.Title = Nothing
        Me.txt_DeviceKhesaratName.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_DeviceKhesaratName.UseForData = True
        Me.txt_DeviceKhesaratName.ValidateCheckExistOnEdit = False
        Me.txt_DeviceKhesaratName.Value = ""
        '
        'chk_NafarSat
        '
        Me.chk_NafarSat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_NafarSat.AutoSize = True
        Me.chk_NafarSat.Checked = True
        Me.chk_NafarSat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_NafarSat.Location = New System.Drawing.Point(608, 97)
        Me.chk_NafarSat.Name = "chk_NafarSat"
        Me.chk_NafarSat.Size = New System.Drawing.Size(92, 22)
        Me.chk_NafarSat.TabIndex = 211
        Me.chk_NafarSat.Text = "نفر ساعت"
        Me.chk_NafarSat.UseVisualStyleBackColor = True
        '
        'chk_DeviceKhesaratName
        '
        Me.chk_DeviceKhesaratName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_DeviceKhesaratName.AutoSize = True
        Me.chk_DeviceKhesaratName.Checked = True
        Me.chk_DeviceKhesaratName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_DeviceKhesaratName.Location = New System.Drawing.Point(917, 67)
        Me.chk_DeviceKhesaratName.Name = "chk_DeviceKhesaratName"
        Me.chk_DeviceKhesaratName.Size = New System.Drawing.Size(144, 22)
        Me.chk_DeviceKhesaratName.TabIndex = 211
        Me.chk_DeviceKhesaratName.Text = "دستگاه تعمیر شده"
        Me.chk_DeviceKhesaratName.UseVisualStyleBackColor = True
        '
        'chk_Device
        '
        Me.chk_Device.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Device.AutoSize = True
        Me.chk_Device.Checked = True
        Me.chk_Device.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Device.Location = New System.Drawing.Point(948, 95)
        Me.chk_Device.Name = "chk_Device"
        Me.chk_Device.Size = New System.Drawing.Size(113, 22)
        Me.chk_Device.TabIndex = 211
        Me.chk_Device.Text = "قطعه مصرفی"
        Me.chk_Device.UseVisualStyleBackColor = True
        '
        'chk_SatheaAhamiat
        '
        Me.chk_SatheaAhamiat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_SatheaAhamiat.AutoSize = True
        Me.chk_SatheaAhamiat.Checked = True
        Me.chk_SatheaAhamiat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_SatheaAhamiat.Location = New System.Drawing.Point(950, 129)
        Me.chk_SatheaAhamiat.Name = "chk_SatheaAhamiat"
        Me.chk_SatheaAhamiat.Size = New System.Drawing.Size(111, 22)
        Me.chk_SatheaAhamiat.TabIndex = 211
        Me.chk_SatheaAhamiat.Text = "سطح اهمیت"
        Me.chk_SatheaAhamiat.UseVisualStyleBackColor = True
        '
        'chk_TarikhSabt
        '
        Me.chk_TarikhSabt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TarikhSabt.AutoSize = True
        Me.chk_TarikhSabt.Checked = True
        Me.chk_TarikhSabt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TarikhSabt.Location = New System.Drawing.Point(617, 225)
        Me.chk_TarikhSabt.Name = "chk_TarikhSabt"
        Me.chk_TarikhSabt.Size = New System.Drawing.Size(83, 22)
        Me.chk_TarikhSabt.TabIndex = 211
        Me.chk_TarikhSabt.Text = "تاریخ ثبت"
        Me.chk_TarikhSabt.UseVisualStyleBackColor = True
        '
        'chk_TarikhVorod
        '
        Me.chk_TarikhVorod.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TarikhVorod.AutoSize = True
        Me.chk_TarikhVorod.Checked = True
        Me.chk_TarikhVorod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TarikhVorod.Location = New System.Drawing.Point(616, 193)
        Me.chk_TarikhVorod.Name = "chk_TarikhVorod"
        Me.chk_TarikhVorod.Size = New System.Drawing.Size(84, 22)
        Me.chk_TarikhVorod.TabIndex = 211
        Me.chk_TarikhVorod.Text = "تاریخ ورود"
        Me.chk_TarikhVorod.UseVisualStyleBackColor = True
        '
        'chk_No
        '
        Me.chk_No.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_No.AutoSize = True
        Me.chk_No.Checked = True
        Me.chk_No.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_No.Location = New System.Drawing.Point(633, 65)
        Me.chk_No.Name = "chk_No"
        Me.chk_No.Size = New System.Drawing.Size(67, 22)
        Me.chk_No.TabIndex = 211
        Me.chk_No.Text = "شماره"
        Me.chk_No.UseVisualStyleBackColor = True
        '
        'chk_PmPost
        '
        Me.chk_PmPost.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_PmPost.AutoSize = True
        Me.chk_PmPost.Checked = True
        Me.chk_PmPost.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_PmPost.Location = New System.Drawing.Point(1000, 227)
        Me.chk_PmPost.Name = "chk_PmPost"
        Me.chk_PmPost.Size = New System.Drawing.Size(61, 22)
        Me.chk_PmPost.TabIndex = 211
        Me.chk_PmPost.Text = "پست"
        Me.chk_PmPost.UseVisualStyleBackColor = True
        '
        'chk_Tavasot
        '
        Me.chk_Tavasot.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Tavasot.AutoSize = True
        Me.chk_Tavasot.Checked = True
        Me.chk_Tavasot.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Tavasot.Location = New System.Drawing.Point(997, 257)
        Me.chk_Tavasot.Name = "chk_Tavasot"
        Me.chk_Tavasot.Size = New System.Drawing.Size(64, 22)
        Me.chk_Tavasot.TabIndex = 211
        Me.chk_Tavasot.Text = "توسط"
        Me.chk_Tavasot.UseVisualStyleBackColor = True
        '
        'chk_TarikhTamir
        '
        Me.chk_TarikhTamir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TarikhTamir.AutoSize = True
        Me.chk_TarikhTamir.Checked = True
        Me.chk_TarikhTamir.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TarikhTamir.Location = New System.Drawing.Point(609, 129)
        Me.chk_TarikhTamir.Name = "chk_TarikhTamir"
        Me.chk_TarikhTamir.Size = New System.Drawing.Size(91, 22)
        Me.chk_TarikhTamir.TabIndex = 211
        Me.chk_TarikhTamir.Text = "تاریخ تعمیر"
        Me.chk_TarikhTamir.UseVisualStyleBackColor = True
        '
        'chk_TarikhTahvil
        '
        Me.chk_TarikhTahvil.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TarikhTahvil.AutoSize = True
        Me.chk_TarikhTahvil.Checked = True
        Me.chk_TarikhTahvil.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TarikhTahvil.Location = New System.Drawing.Point(604, 163)
        Me.chk_TarikhTahvil.Name = "chk_TarikhTahvil"
        Me.chk_TarikhTahvil.Size = New System.Drawing.Size(96, 22)
        Me.chk_TarikhTahvil.TabIndex = 211
        Me.chk_TarikhTahvil.Text = "تاریخ تحویل"
        Me.chk_TarikhTahvil.UseVisualStyleBackColor = True
        '
        'chk_Elat
        '
        Me.chk_Elat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Elat.AutoSize = True
        Me.chk_Elat.Checked = True
        Me.chk_Elat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Elat.Location = New System.Drawing.Point(977, 161)
        Me.chk_Elat.Name = "chk_Elat"
        Me.chk_Elat.Size = New System.Drawing.Size(84, 22)
        Me.chk_Elat.TabIndex = 211
        Me.chk_Elat.Text = "علت ورود"
        Me.chk_Elat.UseVisualStyleBackColor = True
        '
        'cmb_TahvilePerson
        '
        Me.cmb_TahvilePerson.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmb_TahvilePerson.AutoComplete = True
        Me.cmb_TahvilePerson.DataSource = Me.AccAshkhasBindingSource
        Me.cmb_TahvilePerson.DisplayMember = "نام و نام خانوادگی"
        Me.cmb_TahvilePerson.EnterStop = True
        Me.cmb_TahvilePerson.FormattingEnabled = True
        Me.cmb_TahvilePerson.IsRequired = False
        Me.cmb_TahvilePerson.LimitedToList = True
        Me.cmb_TahvilePerson.Location = New System.Drawing.Point(717, 191)
        Me.cmb_TahvilePerson.Name = "cmb_TahvilePerson"
        Me.cmb_TahvilePerson.OpenOnFoucus = True
        Me.cmb_TahvilePerson.Size = New System.Drawing.Size(194, 26)
        Me.cmb_TahvilePerson.TabIndex = 212
        Me.cmb_TahvilePerson.ValueMember = "Srl"
        '
        'AccAshkhasBindingSource
        '
        Me.AccAshkhasBindingSource.DataMember = "Acc_Ashkhas"
        Me.AccAshkhasBindingSource.DataSource = Me.Ds_Ashkhas
        '
        'txt_Dis
        '
        Me.txt_Dis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_Dis.CheckExistValueInDb = False
        Me.txt_Dis.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Dis.CurrencyUnit = "ریال"
        Me.txt_Dis.DefaultValue = ""
        Me.txt_Dis.FillWithMaxInDb = False
        Me.txt_Dis.IsRequired = True
        Me.txt_Dis.Location = New System.Drawing.Point(11, 255)
        Me.txt_Dis.MaxDecimalLength = 2
        Me.txt_Dis.Name = "txt_Dis"
        Me.txt_Dis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Dis.Size = New System.Drawing.Size(588, 26)
        Me.txt_Dis.SpellControl = Nothing
        Me.txt_Dis.TabIndex = 214
        Me.txt_Dis.Tag = ""
        Me.txt_Dis.Title = Nothing
        Me.txt_Dis.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Dis.UseForData = True
        Me.txt_Dis.ValidateCheckExistOnEdit = False
        Me.txt_Dis.Value = ""
        '
        'chk_Dis
        '
        Me.chk_Dis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_Dis.AutoSize = True
        Me.chk_Dis.Checked = True
        Me.chk_Dis.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Dis.Location = New System.Drawing.Point(619, 259)
        Me.chk_Dis.Name = "chk_Dis"
        Me.chk_Dis.Size = New System.Drawing.Size(81, 22)
        Me.chk_Dis.TabIndex = 211
        Me.chk_Dis.Text = "توضیحات"
        Me.chk_Dis.UseVisualStyleBackColor = True
        '
        'chk_TahvilePerson
        '
        Me.chk_TahvilePerson.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chk_TahvilePerson.AutoSize = True
        Me.chk_TahvilePerson.Checked = True
        Me.chk_TahvilePerson.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_TahvilePerson.Location = New System.Drawing.Point(945, 193)
        Me.chk_TahvilePerson.Name = "chk_TahvilePerson"
        Me.chk_TahvilePerson.Size = New System.Drawing.Size(116, 22)
        Me.chk_TahvilePerson.TabIndex = 211
        Me.chk_TahvilePerson.Text = "تحویل شده به"
        Me.chk_TahvilePerson.UseVisualStyleBackColor = True
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
        'Pm_Lab_Rol_GhatatMasrafiTableAdapter
        '
        Me.Pm_Lab_Rol_GhatatMasrafiTableAdapter.ClearBeforeFill = True
        '
        'Pm_Lab_Rol_SatheAhamniatTableAdapter
        '
        Me.Pm_Lab_Rol_SatheAhamniatTableAdapter.ClearBeforeFill = True
        '
        'Pm_Lab_Rol_ElateVorodTableAdapter
        '
        Me.Pm_Lab_Rol_ElateVorodTableAdapter.ClearBeforeFill = True
        '
        'Acc_AshkhasTableAdapter
        '
        Me.Acc_AshkhasTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'txt_TarikhTamirTo
        '
        Me.txt_TarikhTamirTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhTamirTo.CheckExistValueInDb = False
        Me.txt_TarikhTamirTo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTamirTo.CurrencyUnit = "ریال"
        Me.txt_TarikhTamirTo.DefaultValue = ""
        Me.txt_TarikhTamirTo.Enabled = False
        Me.txt_TarikhTamirTo.FillWithMaxInDb = False
        Me.txt_TarikhTamirTo.IsRequired = True
        Me.txt_TarikhTamirTo.Location = New System.Drawing.Point(266, 125)
        Me.txt_TarikhTamirTo.MaxDecimalLength = 2
        Me.txt_TarikhTamirTo.Name = "txt_TarikhTamirTo"
        Me.txt_TarikhTamirTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTamirTo.Size = New System.Drawing.Size(154, 26)
        Me.txt_TarikhTamirTo.SpellControl = Nothing
        Me.txt_TarikhTamirTo.TabIndex = 217
        Me.txt_TarikhTamirTo.TabStop = False
        Me.txt_TarikhTamirTo.Tag = ""
        Me.txt_TarikhTamirTo.Title = Nothing
        Me.txt_TarikhTamirTo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTamirTo.UseForData = True
        Me.txt_TarikhTamirTo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTamirTo.Value = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "تا"
        '
        'txt_TarikhTahvilTo
        '
        Me.txt_TarikhTahvilTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhTahvilTo.CheckExistValueInDb = False
        Me.txt_TarikhTahvilTo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhTahvilTo.CurrencyUnit = "ریال"
        Me.txt_TarikhTahvilTo.DefaultValue = ""
        Me.txt_TarikhTahvilTo.Enabled = False
        Me.txt_TarikhTahvilTo.FillWithMaxInDb = False
        Me.txt_TarikhTahvilTo.IsRequired = True
        Me.txt_TarikhTahvilTo.Location = New System.Drawing.Point(266, 159)
        Me.txt_TarikhTahvilTo.MaxDecimalLength = 2
        Me.txt_TarikhTahvilTo.Name = "txt_TarikhTahvilTo"
        Me.txt_TarikhTahvilTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhTahvilTo.Size = New System.Drawing.Size(154, 26)
        Me.txt_TarikhTahvilTo.SpellControl = Nothing
        Me.txt_TarikhTahvilTo.TabIndex = 219
        Me.txt_TarikhTahvilTo.TabStop = False
        Me.txt_TarikhTahvilTo.Tag = ""
        Me.txt_TarikhTahvilTo.Title = Nothing
        Me.txt_TarikhTahvilTo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhTahvilTo.UseForData = True
        Me.txt_TarikhTahvilTo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhTahvilTo.Value = ""
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "تا"
        '
        'txt_TarikhVorodTo
        '
        Me.txt_TarikhVorodTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhVorodTo.CheckExistValueInDb = False
        Me.txt_TarikhVorodTo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhVorodTo.CurrencyUnit = "ریال"
        Me.txt_TarikhVorodTo.DefaultValue = ""
        Me.txt_TarikhVorodTo.Enabled = False
        Me.txt_TarikhVorodTo.FillWithMaxInDb = False
        Me.txt_TarikhVorodTo.IsRequired = True
        Me.txt_TarikhVorodTo.Location = New System.Drawing.Point(266, 191)
        Me.txt_TarikhVorodTo.MaxDecimalLength = 2
        Me.txt_TarikhVorodTo.Name = "txt_TarikhVorodTo"
        Me.txt_TarikhVorodTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhVorodTo.Size = New System.Drawing.Size(154, 26)
        Me.txt_TarikhVorodTo.SpellControl = Nothing
        Me.txt_TarikhVorodTo.TabIndex = 221
        Me.txt_TarikhVorodTo.TabStop = False
        Me.txt_TarikhVorodTo.Tag = ""
        Me.txt_TarikhVorodTo.Title = Nothing
        Me.txt_TarikhVorodTo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhVorodTo.UseForData = True
        Me.txt_TarikhVorodTo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhVorodTo.Value = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 18)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "تا"
        '
        'txt_TarikhSabtTo
        '
        Me.txt_TarikhSabtTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_TarikhSabtTo.CheckExistValueInDb = False
        Me.txt_TarikhSabtTo.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_TarikhSabtTo.CurrencyUnit = "ریال"
        Me.txt_TarikhSabtTo.DefaultValue = ""
        Me.txt_TarikhSabtTo.Enabled = False
        Me.txt_TarikhSabtTo.FillWithMaxInDb = False
        Me.txt_TarikhSabtTo.IsRequired = True
        Me.txt_TarikhSabtTo.Location = New System.Drawing.Point(266, 223)
        Me.txt_TarikhSabtTo.MaxDecimalLength = 2
        Me.txt_TarikhSabtTo.Name = "txt_TarikhSabtTo"
        Me.txt_TarikhSabtTo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_TarikhSabtTo.Size = New System.Drawing.Size(154, 26)
        Me.txt_TarikhSabtTo.SpellControl = Nothing
        Me.txt_TarikhSabtTo.TabIndex = 223
        Me.txt_TarikhSabtTo.TabStop = False
        Me.txt_TarikhSabtTo.Tag = ""
        Me.txt_TarikhSabtTo.Title = Nothing
        Me.txt_TarikhSabtTo.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_TarikhSabtTo.UseForData = True
        Me.txt_TarikhSabtTo.ValidateCheckExistOnEdit = False
        Me.txt_TarikhSabtTo.Value = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "تا"
        '
        'Frm_Rp_Lab_Tamir
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1076, 665)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_TarikhSabtTo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_TarikhVorodTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_TarikhTahvilTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_TarikhTamirTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_Dis)
        Me.Controls.Add(Me.cmb_TahvilePerson)
        Me.Controls.Add(Me.chk_Device)
        Me.Controls.Add(Me.chk_DeviceKhesaratName)
        Me.Controls.Add(Me.chk_SatheaAhamiat)
        Me.Controls.Add(Me.chk_TarikhSabt)
        Me.Controls.Add(Me.chk_TarikhVorod)
        Me.Controls.Add(Me.chk_No)
        Me.Controls.Add(Me.chk_PmPost)
        Me.Controls.Add(Me.chk_Tavasot)
        Me.Controls.Add(Me.chk_TarikhTamir)
        Me.Controls.Add(Me.chk_TarikhTahvil)
        Me.Controls.Add(Me.chk_TahvilePerson)
        Me.Controls.Add(Me.chk_Elat)
        Me.Controls.Add(Me.chk_Dis)
        Me.Controls.Add(Me.chk_NafarSat)
        Me.Controls.Add(Me.cmb_PmPost)
        Me.Controls.Add(Me.btn_SelectDEvice)
        Me.Controls.Add(Me.txt_DeviceKhesaratName)
        Me.Controls.Add(Me.cmb_Device)
        Me.Controls.Add(Me.txt_Srl_DeviceKhesarat)
        Me.Controls.Add(Me.cmb_SatheaAhamiat)
        Me.Controls.Add(Me.txt_No)
        Me.Controls.Add(Me.txt_TarikhSabtFrom)
        Me.Controls.Add(Me.txt_NafarSat)
        Me.Controls.Add(Me.cmb_Elat)
        Me.Controls.Add(Me.cmb_Tavasot)
        Me.Controls.Add(Me.txt_TarikhTahvilfrom)
        Me.Controls.Add(Me.txt_TarikhTamirFrom)
        Me.Controls.Add(Me.txt_TarikhVorodFrom)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Rp_Lab_Tamir"
        Me.Text = "گزارش تعمیرات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhVorodFrom, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhTamirFrom, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhTahvilfrom, 0)
        Me.Controls.SetChildIndex(Me.cmb_Tavasot, 0)
        Me.Controls.SetChildIndex(Me.cmb_Elat, 0)
        Me.Controls.SetChildIndex(Me.txt_NafarSat, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhSabtFrom, 0)
        Me.Controls.SetChildIndex(Me.txt_No, 0)
        Me.Controls.SetChildIndex(Me.cmb_SatheaAhamiat, 0)
        Me.Controls.SetChildIndex(Me.txt_Srl_DeviceKhesarat, 0)
        Me.Controls.SetChildIndex(Me.cmb_Device, 0)
        Me.Controls.SetChildIndex(Me.txt_DeviceKhesaratName, 0)
        Me.Controls.SetChildIndex(Me.btn_SelectDEvice, 0)
        Me.Controls.SetChildIndex(Me.cmb_PmPost, 0)
        Me.Controls.SetChildIndex(Me.chk_NafarSat, 0)
        Me.Controls.SetChildIndex(Me.chk_Dis, 0)
        Me.Controls.SetChildIndex(Me.chk_Elat, 0)
        Me.Controls.SetChildIndex(Me.chk_TahvilePerson, 0)
        Me.Controls.SetChildIndex(Me.chk_TarikhTahvil, 0)
        Me.Controls.SetChildIndex(Me.chk_TarikhTamir, 0)
        Me.Controls.SetChildIndex(Me.chk_Tavasot, 0)
        Me.Controls.SetChildIndex(Me.chk_PmPost, 0)
        Me.Controls.SetChildIndex(Me.chk_No, 0)
        Me.Controls.SetChildIndex(Me.chk_TarikhVorod, 0)
        Me.Controls.SetChildIndex(Me.chk_TarikhSabt, 0)
        Me.Controls.SetChildIndex(Me.chk_SatheaAhamiat, 0)
        Me.Controls.SetChildIndex(Me.chk_DeviceKhesaratName, 0)
        Me.Controls.SetChildIndex(Me.chk_Device, 0)
        Me.Controls.SetChildIndex(Me.cmb_TahvilePerson, 0)
        Me.Controls.SetChildIndex(Me.txt_Dis, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhTamirTo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhTahvilTo, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhVorodTo, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txt_TarikhSabtTo, 0)
        Me.Controls.SetChildIndex(Me.DataGridView1, 0)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolTamiratViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Lab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PmLabRolGhatatMasrafiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolSatheAhamniatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLabRolElateVorodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Ashkhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccAshkhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Hadese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmHadeseKhesaratDeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Record As System.Windows.Forms.Label
    Friend WithEvents Btn_print As CS_Component.Btn
    Friend WithEvents Btn_Search As CS_Component.Btn
    Friend WithEvents Ds_Lab As Nama_PM.Ds_Lab
    Friend WithEvents PmLabRolTamiratViewBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_TamiratViewTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_TamiratViewTableAdapter
    Friend WithEvents cmb_Device As VB_Component.ComboBox
    Friend WithEvents txt_Srl_DeviceKhesarat As CS_Component.TextBox
    Friend WithEvents cmb_SatheaAhamiat As VB_Component.ComboBox
    Friend WithEvents txt_No As CS_Component.TextBox
    Friend WithEvents txt_TarikhSabtFrom As CS_Component.TextBox
    Friend WithEvents txt_NafarSat As CS_Component.TextBox
    Friend WithEvents cmb_Elat As VB_Component.ComboBox
    Friend WithEvents cmb_Tavasot As VB_Component.ComboBox
    Friend WithEvents txt_TarikhTahvilfrom As CS_Component.TextBox
    Friend WithEvents txt_TarikhTamirFrom As CS_Component.TextBox
    Friend WithEvents txt_TarikhVorodFrom As CS_Component.TextBox
    Friend WithEvents cmb_PmPost As VB_Component.ComboBox
    Friend WithEvents btn_SelectDEvice As System.Windows.Forms.Button
    Friend WithEvents txt_DeviceKhesaratName As CS_Component.TextBox
    Friend WithEvents chk_NafarSat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DeviceKhesaratName As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Device As System.Windows.Forms.CheckBox
    Friend WithEvents chk_SatheaAhamiat As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TarikhSabt As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TarikhVorod As System.Windows.Forms.CheckBox
    Friend WithEvents chk_No As System.Windows.Forms.CheckBox
    Friend WithEvents chk_PmPost As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Tavasot As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TarikhTamir As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TarikhTahvil As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Elat As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_TahvilePerson As VB_Component.ComboBox
    Friend WithEvents txt_Dis As CS_Component.TextBox
    Friend WithEvents chk_Dis As System.Windows.Forms.CheckBox
    Friend WithEvents chk_TahvilePerson As System.Windows.Forms.CheckBox
    Friend WithEvents Ds_Hadese As Nama_PM.Ds_Hadese
    Friend WithEvents PmHadeseKhesaratDeviceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Hadese_KhesaratDeviceTableAdapter As Nama_PM.Ds_HadeseTableAdapters.Pm_Hadese_KhesaratDeviceTableAdapter
    Friend WithEvents PmLabRolGhatatMasrafiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_GhatatMasrafiTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_GhatatMasrafiTableAdapter
    Friend WithEvents PmLabRolSatheAhamniatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_SatheAhamniatTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_SatheAhamniatTableAdapter
    Friend WithEvents PmLabRolElateVorodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Lab_Rol_ElateVorodTableAdapter As Nama_PM.Ds_LabTableAdapters.Pm_Lab_Rol_ElateVorodTableAdapter
    Friend WithEvents Ds_Ashkhas As Nama_PM.Ds_Ashkhas
    Friend WithEvents AccAshkhasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc_AshkhasTableAdapter As Nama_PM.Ds_AshkhasTableAdapters.Acc_AshkhasTableAdapter
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents AccAshkhasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txt_TarikhTamirTo As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhTahvilTo As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhVorodTo As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_TarikhSabtTo As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامقطعهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحاهمیتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents علتورودDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریختعمیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریختحویلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخورودDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازهتعمیرDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents بازهتحویلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
