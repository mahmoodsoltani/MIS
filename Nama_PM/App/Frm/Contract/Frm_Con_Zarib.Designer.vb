<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_Zarib
    Inherits BaseForm_Layer

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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.cmb_TahvilePerson = New VB_Component.ComboBox
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Pm_Con_Contract1TableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_Contract1TableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Pm_con_ContratZaribTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_con_ContratZaribTableAdapter
        Me.txt_HolidayStatusStatement = New CS_Component.TextBox
        Me.TextBox1 = New CS_Component.TextBox
        Me.TextBox3 = New CS_Component.TextBox
        Me.TextBox4 = New CS_Component.TextBox
        Me.TextBox2 = New CS_Component.TextBox
        Me.TextBox5 = New CS_Component.TextBox
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(362, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(609, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(485, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(735, 175)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.TextBox5)
        Me.gbx_Controls.Controls.Add(Me.TextBox2)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.TextBox4)
        Me.gbx_Controls.Controls.Add(Me.TextBox3)
        Me.gbx_Controls.Controls.Add(Me.txt_HolidayStatusStatement)
        Me.gbx_Controls.Controls.Add(Me.RadioButton2)
        Me.gbx_Controls.Controls.Add(Me.RadioButton1)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.cmb_TahvilePerson)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 287)
        Me.gbx_Controls.Size = New System.Drawing.Size(732, 166)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 221)
        Me.gbx_Btn.Size = New System.Drawing.Size(732, 60)
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.BindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 22)
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
        Me.DataGridView1.Size = New System.Drawing.Size(729, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "قرارداد"
        Me.DataGridViewTextBoxColumn2.HeaderText = "قرارداد"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "تعطیل"
        Me.DataGridViewTextBoxColumn3.HeaderText = "تعطیل"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "شبانه"
        Me.DataGridViewTextBoxColumn4.HeaderText = "شبانه"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "کنسلی فرم"
        Me.DataGridViewTextBoxColumn5.HeaderText = "کنسلی فرم"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "روزقبل فرم"
        Me.DataGridViewTextBoxColumn6.HeaderText = "روزقبل فرم"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "کنسلی غیر فرم"
        Me.DataGridViewTextBoxColumn7.HeaderText = "کنسلی غیر فرم"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "روز قبل غیر فرم"
        Me.DataGridViewTextBoxColumn8.HeaderText = "روز قبل غیر فرم"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Pm_con_ContratZarib"
        Me.BindingSource1.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_TahvilePerson
        '
        Me.cmb_TahvilePerson.AutoComplete = True
        Me.cmb_TahvilePerson.DataSource = Me.BindingSource2
        Me.cmb_TahvilePerson.DisplayMember = "name"
        Me.cmb_TahvilePerson.EnterStop = True
        Me.cmb_TahvilePerson.FormattingEnabled = True
        Me.cmb_TahvilePerson.IsRequired = True
        Me.cmb_TahvilePerson.LimitedToList = True
        Me.cmb_TahvilePerson.Location = New System.Drawing.Point(198, 15)
        Me.cmb_TahvilePerson.Name = "cmb_TahvilePerson"
        Me.cmb_TahvilePerson.OpenOnFoucus = False
        Me.cmb_TahvilePerson.Size = New System.Drawing.Size(464, 26)
        Me.cmb_TahvilePerson.TabIndex = 0
        Me.cmb_TahvilePerson.Tag = "srl_contract"
        Me.cmb_TahvilePerson.ValueMember = "Srl"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Pm_Con_Contract1"
        Me.BindingSource2.DataSource = Me.Ds_Con
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(675, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "قرارداد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(551, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ضریب روز تعطیل"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(586, -365)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(46, 22)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.Text = "PM"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(505, -365)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 22)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "کار مازاد"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Pm_Con_Contract1TableAdapter
        '
        Me.Pm_Con_Contract1TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(263, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ضریب کار شبانه"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ضریب کنسلی فرم کار"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 18)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ضریب کنسلی فرم کار روز قبل"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(551, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ضریب کنسلی غیر فرم کار"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(263, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "ضریب کنسلی غیر فرم کار روز قبل"
        '
        'Pm_con_ContratZaribTableAdapter
        '
        Me.Pm_con_ContratZaribTableAdapter.ClearBeforeFill = True
        '
        'txt_HolidayStatusStatement
        '
        Me.txt_HolidayStatusStatement.BackColor = System.Drawing.SystemColors.Window
        Me.txt_HolidayStatusStatement.CheckExistValueInDb = False
        Me.txt_HolidayStatusStatement.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_HolidayStatusStatement.CurrencyUnit = "ریال"
        Me.txt_HolidayStatusStatement.DefaultValue = ""
        Me.txt_HolidayStatusStatement.FillWithMaxInDb = False
        Me.txt_HolidayStatusStatement.IsRequired = False
        Me.txt_HolidayStatusStatement.Location = New System.Drawing.Point(198, 54)
        Me.txt_HolidayStatusStatement.MaxDecimalLength = 2
        Me.txt_HolidayStatusStatement.Name = "txt_HolidayStatusStatement"
        Me.txt_HolidayStatusStatement.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_HolidayStatusStatement.Size = New System.Drawing.Size(59, 26)
        Me.txt_HolidayStatusStatement.SpellControl = Nothing
        Me.txt_HolidayStatusStatement.TabIndex = 26
        Me.txt_HolidayStatusStatement.Tag = "NightWork"
        Me.txt_HolidayStatusStatement.Text = "0"
        Me.txt_HolidayStatusStatement.Title = Nothing
        Me.txt_HolidayStatusStatement.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_HolidayStatusStatement.UseForData = True
        Me.txt_HolidayStatusStatement.ValidateCheckExistOnEdit = False
        Me.txt_HolidayStatusStatement.Value = 0.0!
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(480, 54)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(59, 26)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 26
        Me.TextBox1.Tag = "Holiday"
        Me.TextBox1.Text = "0"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = 0.0!
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.CheckExistValueInDb = False
        Me.TextBox3.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox3.CurrencyUnit = "ریال"
        Me.TextBox3.DefaultValue = ""
        Me.TextBox3.FillWithMaxInDb = False
        Me.TextBox3.IsRequired = False
        Me.TextBox3.Location = New System.Drawing.Point(198, 92)
        Me.TextBox3.MaxDecimalLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(59, 26)
        Me.TextBox3.SpellControl = Nothing
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Tag = "WorkForm_Cancle_BeforDay"
        Me.TextBox3.Text = "0"
        Me.TextBox3.Title = Nothing
        Me.TextBox3.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox3.UseForData = True
        Me.TextBox3.ValidateCheckExistOnEdit = False
        Me.TextBox3.Value = 0.0!
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox4.CheckExistValueInDb = False
        Me.TextBox4.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox4.CurrencyUnit = "ریال"
        Me.TextBox4.DefaultValue = ""
        Me.TextBox4.FillWithMaxInDb = False
        Me.TextBox4.IsRequired = False
        Me.TextBox4.Location = New System.Drawing.Point(198, 129)
        Me.TextBox4.MaxDecimalLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox4.Size = New System.Drawing.Size(59, 26)
        Me.TextBox4.SpellControl = Nothing
        Me.TextBox4.TabIndex = 26
        Me.TextBox4.Tag = "NonWorkForm_Cancle_BeforeDay"
        Me.TextBox4.Text = "0"
        Me.TextBox4.Title = Nothing
        Me.TextBox4.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox4.UseForData = True
        Me.TextBox4.ValidateCheckExistOnEdit = False
        Me.TextBox4.Value = 0.0!
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.CheckExistValueInDb = False
        Me.TextBox2.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox2.CurrencyUnit = "ریال"
        Me.TextBox2.DefaultValue = ""
        Me.TextBox2.FillWithMaxInDb = False
        Me.TextBox2.IsRequired = False
        Me.TextBox2.Location = New System.Drawing.Point(480, 92)
        Me.TextBox2.MaxDecimalLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(59, 26)
        Me.TextBox2.SpellControl = Nothing
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Tag = "WorkForm_Cancle"
        Me.TextBox2.Text = "0"
        Me.TextBox2.Title = Nothing
        Me.TextBox2.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox2.UseForData = True
        Me.TextBox2.ValidateCheckExistOnEdit = False
        Me.TextBox2.Value = 0.0!
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox5.CheckExistValueInDb = False
        Me.TextBox5.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox5.CurrencyUnit = "ریال"
        Me.TextBox5.DefaultValue = ""
        Me.TextBox5.FillWithMaxInDb = False
        Me.TextBox5.IsRequired = False
        Me.TextBox5.Location = New System.Drawing.Point(480, 129)
        Me.TextBox5.MaxDecimalLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox5.Size = New System.Drawing.Size(59, 26)
        Me.TextBox5.SpellControl = Nothing
        Me.TextBox5.TabIndex = 26
        Me.TextBox5.Tag = "NonWorkForm_Cancle"
        Me.TextBox5.Text = "0"
        Me.TextBox5.Title = Nothing
        Me.TextBox5.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.TextBox5.UseForData = True
        Me.TextBox5.ValidateCheckExistOnEdit = False
        Me.TextBox5.Value = 0.0!
        '
        'Frm_Con_Zarib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(760, 485)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_Zarib"
        Me.TableName = "pm_Con_contractzarib"
        Me.Text = "تعریف ضرایب صورت وضعیت "
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_TahvilePerson As VB_Component.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmConContract1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_Contract1TableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_Contract1TableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PmConContratZaribBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قراردادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعطیلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شبانهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کنسلیفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents روزقبلفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کنسلیغیرفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents روزقبلغیرفرمDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_con_ContratZaribTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_con_ContratZaribTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_HolidayStatusStatement As CS_Component.TextBox
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox5 As CS_Component.TextBox
    Friend WithEvents TextBox2 As CS_Component.TextBox
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents TextBox4 As CS_Component.TextBox
    Friend WithEvents TextBox3 As CS_Component.TextBox
End Class
