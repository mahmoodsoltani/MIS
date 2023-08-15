<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Con_StatusStatementMazad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Con_StatusStatementMazad))
        Me.DataGridView1 = New CS_Component.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.قیمتکلDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConfirmAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConfirmPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CalcpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsholidayDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IscancleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsnightDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.IsbeforeCancleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlcontractDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlsourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn
        Me.PmconstatusStatementItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Con = New Nama_PM.Ds_Con
        Me.PmconstatusStatementItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_code = New VB_Component.ComboBox
        Me.PmConContractItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmb_title = New VB_Component.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_Amount = New CS_Component.TextBox
        Me.btn_Add = New System.Windows.Forms.Button
        Me.btn_Before = New System.Windows.Forms.PictureBox
        Me.btn_Next = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txt_Description = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lb_amount = New System.Windows.Forms.Label
        Me.Rb_WorkForm = New System.Windows.Forms.RadioButton
        Me.Pl_WorkForm = New System.Windows.Forms.Panel
        Me.btn_SearchWorkForm = New System.Windows.Forms.PictureBox
        Me.txt_unit = New CS_Component.TextBox
        Me.lb_number = New System.Windows.Forms.Label
        Me.txt_Number = New CS_Component.TextBox
        Me.txt_post = New CS_Component.TextBox
        Me.PostOrKhat = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lb_omoor = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Date = New CS_Component.TextBox
        Me.txt_Group = New CS_Component.TextBox
        Me.PmLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Pm = New Nama_PM.Ds_Pm
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rb_NoWorkForm = New System.Windows.Forms.RadioButton
        Me.Pm_con_statusStatementTableAdapter = New Nama_PM.Ds_ConTableAdapters.pm_con_statusStatementItemTableAdapter
        Me.Pm_con_WorkformTableAdapter = New Nama_PM.Ds_ConTableAdapters.pm_con_WorkformTableAdapter
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_StatusStatementTableAdapter1 = New Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTableAdapter
        Me.Pm_VahedTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
        Me.Pm_GroupTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
        Me.Pm_PostTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
        Me.Pm_LineTableAdapter = New Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
        Me.Pm_Con_ContractItemsTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
        Me.lb_Holiday = New System.Windows.Forms.Label
        Me.txt_all = New CS_Component.TextBox
        Me.WorkFormMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkForm_MasterTableAdapter = New Nama_PM.Ds_PmTableAdapters.WorkForm_MasterTableAdapter
        Me.btn_AddSS = New System.Windows.Forms.Button
        Me.PmConUsedItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_UsedItemTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_UsedItemTableAdapter
        Me.Label15 = New System.Windows.Forms.Label
        Me.chk_all = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmb_source = New VB_Component.ComboBox
        Me.PmConSourceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pm_Con_SourceTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
        Me.btn_EditSS = New System.Windows.Forms.Button
        Me.cmb_Contract = New VB_Component.ComboBox
        Me.PmConContractBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.Pm_Con_ContractTableAdapter = New Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
        Me.txt_FactorPrice = New CS_Component.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_AllConfirm = New CS_Component.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_SSPM = New CS_Component.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmconstatusStatementItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmconstatusStatementItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Pl_WorkForm.SuspendLayout()
        CType(Me.btn_SearchWorkForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkFormMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConUsedItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(3410, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(3657, 17)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        Me.btn_new.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(3533, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Controls.Add(Me.Label5)
        Me.gbx_GridViewList.Controls.Add(Me.Label9)
        Me.gbx_GridViewList.Controls.Add(Me.Label15)
        Me.gbx_GridViewList.Controls.Add(Me.txt_FactorPrice)
        Me.gbx_GridViewList.Controls.Add(Me.txt_AllConfirm)
        Me.gbx_GridViewList.Controls.Add(Me.txt_all)
        Me.gbx_GridViewList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_GridViewList.Location = New System.Drawing.Point(6, 57)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(888, 594)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controls.Controls.Add(Me.cmb_Contract)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.btn_EditSS)
        Me.gbx_Controls.Controls.Add(Me.chk_all)
        Me.gbx_Controls.Controls.Add(Me.Label12)
        Me.gbx_Controls.Controls.Add(Me.btn_AddSS)
        Me.gbx_Controls.Controls.Add(Me.txt_SSPM)
        Me.gbx_Controls.Controls.Add(Me.Rb_NoWorkForm)
        Me.gbx_Controls.Controls.Add(Me.Panel1)
        Me.gbx_Controls.Controls.Add(Me.Pl_WorkForm)
        Me.gbx_Controls.Controls.Add(Me.cmb_source)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.Rb_WorkForm)
        Me.gbx_Controls.Controls.Add(Me.lb_Holiday)
        Me.gbx_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbx_Controls.Location = New System.Drawing.Point(6, 57)
        Me.gbx_Controls.Size = New System.Drawing.Size(888, 241)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Btn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Btn.Location = New System.Drawing.Point(6, 600)
        Me.gbx_Btn.Size = New System.Drawing.Size(888, 51)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.قیمتکلDataGridViewTextBoxColumn, Me.ConfirmAmountDataGridViewTextBoxColumn, Me.ConfirmPriceDataGridViewTextBoxColumn, Me.CalcpriceDataGridViewTextBoxColumn, Me.IsholidayDataGridViewCheckBoxColumn, Me.DataGridViewCheckBoxColumn1, Me.IscancleDataGridViewCheckBoxColumn, Me.IsnightDataGridViewCheckBoxColumn, Me.IsbeforeCancleDataGridViewCheckBoxColumn, Me.SrlcontractDataGridViewTextBoxColumn, Me.SrlsourceDataGridViewTextBoxColumn, Me.Column2, Me.Column1, Me.Column3})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.PmconstatusStatementItemBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 247)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(879, 258)
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "کد"
        Me.DataGridViewTextBoxColumn2.HeaderText = "کد"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "عنوان"
        Me.DataGridViewTextBoxColumn3.HeaderText = "عنوان"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "تعداد"
        Me.DataGridViewTextBoxColumn4.HeaderText = "تعداد"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 55
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "قیمت"
        Me.DataGridViewTextBoxColumn5.HeaderText = "جزء"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'قیمتکلDataGridViewTextBoxColumn
        '
        Me.قیمتکلDataGridViewTextBoxColumn.DataPropertyName = "قیمت کل"
        Me.قیمتکلDataGridViewTextBoxColumn.HeaderText = "مبلغ"
        Me.قیمتکلDataGridViewTextBoxColumn.Name = "قیمتکلDataGridViewTextBoxColumn"
        Me.قیمتکلDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConfirmAmountDataGridViewTextBoxColumn
        '
        Me.ConfirmAmountDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Amount"
        Me.ConfirmAmountDataGridViewTextBoxColumn.HeaderText = "تعداد*"
        Me.ConfirmAmountDataGridViewTextBoxColumn.Name = "ConfirmAmountDataGridViewTextBoxColumn"
        Me.ConfirmAmountDataGridViewTextBoxColumn.Width = 55
        '
        'ConfirmPriceDataGridViewTextBoxColumn
        '
        Me.ConfirmPriceDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Price"
        Me.ConfirmPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ*"
        Me.ConfirmPriceDataGridViewTextBoxColumn.Name = "ConfirmPriceDataGridViewTextBoxColumn"
        '
        'CalcpriceDataGridViewTextBoxColumn
        '
        Me.CalcpriceDataGridViewTextBoxColumn.DataPropertyName = "calcprice"
        Me.CalcpriceDataGridViewTextBoxColumn.HeaderText = "calcprice"
        Me.CalcpriceDataGridViewTextBoxColumn.Name = "CalcpriceDataGridViewTextBoxColumn"
        Me.CalcpriceDataGridViewTextBoxColumn.Visible = False
        '
        'IsholidayDataGridViewCheckBoxColumn
        '
        Me.IsholidayDataGridViewCheckBoxColumn.DataPropertyName = "Is_holiday"
        Me.IsholidayDataGridViewCheckBoxColumn.HeaderText = "Is_holiday"
        Me.IsholidayDataGridViewCheckBoxColumn.Name = "IsholidayDataGridViewCheckBoxColumn"
        Me.IsholidayDataGridViewCheckBoxColumn.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "تائید"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "تائید"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'IscancleDataGridViewCheckBoxColumn
        '
        Me.IscancleDataGridViewCheckBoxColumn.DataPropertyName = "is_cancle"
        Me.IscancleDataGridViewCheckBoxColumn.HeaderText = "is_cancle"
        Me.IscancleDataGridViewCheckBoxColumn.Name = "IscancleDataGridViewCheckBoxColumn"
        Me.IscancleDataGridViewCheckBoxColumn.Visible = False
        '
        'IsnightDataGridViewCheckBoxColumn
        '
        Me.IsnightDataGridViewCheckBoxColumn.DataPropertyName = "is_night"
        Me.IsnightDataGridViewCheckBoxColumn.HeaderText = "is_night"
        Me.IsnightDataGridViewCheckBoxColumn.Name = "IsnightDataGridViewCheckBoxColumn"
        Me.IsnightDataGridViewCheckBoxColumn.Visible = False
        '
        'IsbeforeCancleDataGridViewCheckBoxColumn
        '
        Me.IsbeforeCancleDataGridViewCheckBoxColumn.DataPropertyName = "is_beforeCancle"
        Me.IsbeforeCancleDataGridViewCheckBoxColumn.HeaderText = "is_beforeCancle"
        Me.IsbeforeCancleDataGridViewCheckBoxColumn.Name = "IsbeforeCancleDataGridViewCheckBoxColumn"
        Me.IsbeforeCancleDataGridViewCheckBoxColumn.Visible = False
        '
        'SrlcontractDataGridViewTextBoxColumn
        '
        Me.SrlcontractDataGridViewTextBoxColumn.DataPropertyName = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.HeaderText = "srl_contract"
        Me.SrlcontractDataGridViewTextBoxColumn.Name = "SrlcontractDataGridViewTextBoxColumn"
        Me.SrlcontractDataGridViewTextBoxColumn.Visible = False
        '
        'SrlsourceDataGridViewTextBoxColumn
        '
        Me.SrlsourceDataGridViewTextBoxColumn.DataPropertyName = "srl_source"
        Me.SrlsourceDataGridViewTextBoxColumn.HeaderText = "srl_source"
        Me.SrlsourceDataGridViewTextBoxColumn.Name = "SrlsourceDataGridViewTextBoxColumn"
        Me.SrlsourceDataGridViewTextBoxColumn.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Image = Global.Nama_PM.My.Resources.Resources.plus_4_16
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 25
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Image = Global.Nama_PM.My.Resources.Resources.minus_8_16
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.ToolTipText = "حذف"
        Me.Column1.Width = 25
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Image = Global.Nama_PM.My.Resources.Resources.WhatsApp_Image_2022_07_17_at_2_501
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 25
        '
        'PmconstatusStatementItemBindingSource1
        '
        Me.PmconstatusStatementItemBindingSource1.DataMember = "pm_con_statusStatementItem"
        Me.PmconstatusStatementItemBindingSource1.DataSource = Me.Ds_Con
        '
        'Ds_Con
        '
        Me.Ds_Con.DataSetName = "Ds_Con"
        Me.Ds_Con.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmconstatusStatementItemBindingSource
        '
        Me.PmconstatusStatementItemBindingSource.DataMember = "pm_con_statusStatementItem"
        Me.PmconstatusStatementItemBindingSource.DataSource = Me.Ds_Con
        '
        'cmb_code
        '
        Me.cmb_code.AutoComplete = True
        Me.cmb_code.DataSource = Me.PmConContractItemsBindingSource
        Me.cmb_code.DisplayMember = "کد"
        Me.cmb_code.EnterStop = True
        Me.cmb_code.FormattingEnabled = True
        Me.cmb_code.IsRequired = False
        Me.cmb_code.LimitedToList = True
        Me.cmb_code.Location = New System.Drawing.Point(735, 13)
        Me.cmb_code.Name = "cmb_code"
        Me.cmb_code.OpenOnFoucus = False
        Me.cmb_code.Size = New System.Drawing.Size(93, 26)
        Me.cmb_code.TabIndex = 0
        Me.cmb_code.ValueMember = "Srl"
        '
        'PmConContractItemsBindingSource
        '
        Me.PmConContractItemsBindingSource.DataMember = "Pm_Con_ContractItems"
        Me.PmConContractItemsBindingSource.DataSource = Me.Ds_Con
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "pm_con_ContractItemsTarikh"
        Me.BindingSource4.DataSource = Me.Ds_Con
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(834, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 18)
        Me.Label8.TabIndex = 186
        Me.Label8.Text = "کد"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(686, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 186
        Me.Label6.Text = "عنوان"
        '
        'cmb_title
        '
        Me.cmb_title.AutoComplete = True
        Me.cmb_title.DataSource = Me.PmConContractItemsBindingSource
        Me.cmb_title.DisplayMember = "عنوان"
        Me.cmb_title.EnterStop = True
        Me.cmb_title.FormattingEnabled = True
        Me.cmb_title.IsRequired = False
        Me.cmb_title.LimitedToList = True
        Me.cmb_title.Location = New System.Drawing.Point(342, 13)
        Me.cmb_title.Name = "cmb_title"
        Me.cmb_title.OpenOnFoucus = False
        Me.cmb_title.Size = New System.Drawing.Size(338, 26)
        Me.cmb_title.TabIndex = 1
        Me.cmb_title.ValueMember = "Srl"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "تعداد"
        '
        'txt_Amount
        '
        Me.txt_Amount.CheckExistValueInDb = True
        Me.txt_Amount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Amount.CurrencyUnit = "ریال"
        Me.txt_Amount.DefaultValue = ""
        Me.txt_Amount.FillWithMaxInDb = False
        Me.txt_Amount.IsRequired = True
        Me.txt_Amount.Location = New System.Drawing.Point(256, 14)
        Me.txt_Amount.MaxDecimalLength = 2
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Amount.Size = New System.Drawing.Size(38, 26)
        Me.txt_Amount.SpellControl = Nothing
        Me.txt_Amount.TabIndex = 2
        Me.txt_Amount.Tag = "title"
        Me.txt_Amount.Text = "1"
        Me.txt_Amount.Title = Nothing
        Me.txt_Amount.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Amount.UseForData = True
        Me.txt_Amount.ValidateCheckExistOnEdit = False
        Me.txt_Amount.Value = 1.0!
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(4, 9)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(58, 29)
        Me.btn_Add.TabIndex = 3
        Me.btn_Add.Text = "افزودن"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_Before
        '
        Me.btn_Before.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Before.Image = CType(resources.GetObject("btn_Before.Image"), System.Drawing.Image)
        Me.btn_Before.Location = New System.Drawing.Point(601, 2)
        Me.btn_Before.Name = "btn_Before"
        Me.btn_Before.Size = New System.Drawing.Size(30, 31)
        Me.btn_Before.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Before.TabIndex = 133
        Me.btn_Before.TabStop = False
        '
        'btn_Next
        '
        Me.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Next.Image = CType(resources.GetObject("btn_Next.Image"), System.Drawing.Image)
        Me.btn_Next.Location = New System.Drawing.Point(563, 2)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(32, 30)
        Me.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Next.TabIndex = 132
        Me.btn_Next.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.Controls.Add(Me.cmb_title)
        Me.Panel1.Controls.Add(Me.btn_Add)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_Description)
        Me.Panel1.Controls.Add(Me.txt_Amount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmb_code)
        Me.Panel1.Controls.Add(Me.lb_amount)
        Me.Panel1.Location = New System.Drawing.Point(6, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 84)
        Me.Panel1.TabIndex = 1009
        '
        'txt_Description
        '
        Me.txt_Description.CheckExistValueInDb = True
        Me.txt_Description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Description.CurrencyUnit = "ریال"
        Me.txt_Description.DefaultValue = ""
        Me.txt_Description.FillWithMaxInDb = False
        Me.txt_Description.IsRequired = True
        Me.txt_Description.Location = New System.Drawing.Point(256, 45)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Description.Size = New System.Drawing.Size(532, 26)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 2
        Me.txt_Description.Tag = "title"
        Me.txt_Description.Title = Nothing
        Me.txt_Description.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Description.UseForData = True
        Me.txt_Description.ValidateCheckExistOnEdit = False
        Me.txt_Description.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(795, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "توضیحات"
        '
        'lb_amount
        '
        Me.lb_amount.ForeColor = System.Drawing.Color.Green
        Me.lb_amount.Location = New System.Drawing.Point(175, 16)
        Me.lb_amount.Name = "lb_amount"
        Me.lb_amount.Size = New System.Drawing.Size(75, 18)
        Me.lb_amount.TabIndex = 127
        '
        'Rb_WorkForm
        '
        Me.Rb_WorkForm.AutoSize = True
        Me.Rb_WorkForm.Location = New System.Drawing.Point(743, 16)
        Me.Rb_WorkForm.Name = "Rb_WorkForm"
        Me.Rb_WorkForm.Size = New System.Drawing.Size(129, 22)
        Me.Rb_WorkForm.TabIndex = 0
        Me.Rb_WorkForm.Text = "بر اساس فرم کار"
        Me.Rb_WorkForm.UseVisualStyleBackColor = True
        '
        'Pl_WorkForm
        '
        Me.Pl_WorkForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pl_WorkForm.Controls.Add(Me.btn_SearchWorkForm)
        Me.Pl_WorkForm.Controls.Add(Me.btn_Before)
        Me.Pl_WorkForm.Controls.Add(Me.btn_Next)
        Me.Pl_WorkForm.Controls.Add(Me.txt_unit)
        Me.Pl_WorkForm.Controls.Add(Me.lb_number)
        Me.Pl_WorkForm.Controls.Add(Me.txt_Number)
        Me.Pl_WorkForm.Controls.Add(Me.txt_post)
        Me.Pl_WorkForm.Controls.Add(Me.PostOrKhat)
        Me.Pl_WorkForm.Controls.Add(Me.Label3)
        Me.Pl_WorkForm.Controls.Add(Me.Label4)
        Me.Pl_WorkForm.Controls.Add(Me.lb_omoor)
        Me.Pl_WorkForm.Controls.Add(Me.Label2)
        Me.Pl_WorkForm.Controls.Add(Me.txt_Date)
        Me.Pl_WorkForm.Controls.Add(Me.txt_Group)
        Me.Pl_WorkForm.Location = New System.Drawing.Point(6, 46)
        Me.Pl_WorkForm.Name = "Pl_WorkForm"
        Me.Pl_WorkForm.Size = New System.Drawing.Size(872, 67)
        Me.Pl_WorkForm.TabIndex = 0
        '
        'btn_SearchWorkForm
        '
        Me.btn_SearchWorkForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SearchWorkForm.Image = CType(resources.GetObject("btn_SearchWorkForm.Image"), System.Drawing.Image)
        Me.btn_SearchWorkForm.Location = New System.Drawing.Point(641, 4)
        Me.btn_SearchWorkForm.Name = "btn_SearchWorkForm"
        Me.btn_SearchWorkForm.Size = New System.Drawing.Size(32, 30)
        Me.btn_SearchWorkForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_SearchWorkForm.TabIndex = 134
        Me.btn_SearchWorkForm.TabStop = False
        '
        'txt_unit
        '
        Me.txt_unit.CheckExistValueInDb = True
        Me.txt_unit.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_unit.CurrencyUnit = "ریال"
        Me.txt_unit.DefaultValue = ""
        Me.txt_unit.Enabled = False
        Me.txt_unit.FillWithMaxInDb = False
        Me.txt_unit.IsRequired = True
        Me.txt_unit.Location = New System.Drawing.Point(503, 37)
        Me.txt_unit.MaxDecimalLength = 2
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_unit.Size = New System.Drawing.Size(295, 26)
        Me.txt_unit.SpellControl = Nothing
        Me.txt_unit.TabIndex = 2
        Me.txt_unit.Tag = ""
        Me.txt_unit.Title = Nothing
        Me.txt_unit.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_unit.UseForData = True
        Me.txt_unit.ValidateCheckExistOnEdit = False
        Me.txt_unit.Value = ""
        '
        'lb_number
        '
        Me.lb_number.AutoSize = True
        Me.lb_number.Location = New System.Drawing.Point(804, 7)
        Me.lb_number.Name = "lb_number"
        Me.lb_number.Size = New System.Drawing.Size(48, 18)
        Me.lb_number.TabIndex = 129
        Me.lb_number.Text = "شماره"
        Me.lb_number.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Number
        '
        Me.txt_Number.CheckExistValueInDb = True
        Me.txt_Number.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Number.CurrencyUnit = "ریال"
        Me.txt_Number.DefaultValue = ""
        Me.txt_Number.FillWithMaxInDb = False
        Me.txt_Number.IsRequired = True
        Me.txt_Number.Location = New System.Drawing.Point(691, 4)
        Me.txt_Number.MaxDecimalLength = 2
        Me.txt_Number.Name = "txt_Number"
        Me.txt_Number.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Number.Size = New System.Drawing.Size(107, 26)
        Me.txt_Number.SpellControl = Nothing
        Me.txt_Number.TabIndex = 0
        Me.txt_Number.Tag = ""
        Me.txt_Number.Title = Nothing
        Me.txt_Number.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Number.UseForData = True
        Me.txt_Number.ValidateCheckExistOnEdit = False
        Me.txt_Number.Value = ""
        '
        'txt_post
        '
        Me.txt_post.CheckExistValueInDb = True
        Me.txt_post.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_post.CurrencyUnit = "ریال"
        Me.txt_post.DefaultValue = ""
        Me.txt_post.Enabled = False
        Me.txt_post.FillWithMaxInDb = False
        Me.txt_post.IsRequired = True
        Me.txt_post.Location = New System.Drawing.Point(234, 35)
        Me.txt_post.MaxDecimalLength = 2
        Me.txt_post.Name = "txt_post"
        Me.txt_post.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_post.Size = New System.Drawing.Size(215, 26)
        Me.txt_post.SpellControl = Nothing
        Me.txt_post.TabIndex = 4
        Me.txt_post.Tag = ""
        Me.txt_post.Title = Nothing
        Me.txt_post.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_post.UseForData = True
        Me.txt_post.ValidateCheckExistOnEdit = False
        Me.txt_post.Value = ""
        '
        'PostOrKhat
        '
        Me.PostOrKhat.AutoSize = True
        Me.PostOrKhat.Location = New System.Drawing.Point(455, 39)
        Me.PostOrKhat.Name = "PostOrKhat"
        Me.PostOrKhat.Size = New System.Drawing.Size(42, 18)
        Me.PostOrKhat.TabIndex = 128
        Me.PostOrKhat.Text = "پست"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(804, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "واحد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "تاریخ"
        '
        'lb_omoor
        '
        Me.lb_omoor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_omoor.ForeColor = System.Drawing.Color.Green
        Me.lb_omoor.Location = New System.Drawing.Point(23, 73)
        Me.lb_omoor.Name = "lb_omoor"
        Me.lb_omoor.Size = New System.Drawing.Size(144, 18)
        Me.lb_omoor.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 18)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "گروه"
        '
        'txt_Date
        '
        Me.txt_Date.CheckExistValueInDb = False
        Me.txt_Date.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Date.CurrencyUnit = "ریال"
        Me.txt_Date.DefaultValue = ""
        Me.txt_Date.Enabled = False
        Me.txt_Date.FillWithMaxInDb = False
        Me.txt_Date.IsRequired = True
        Me.txt_Date.Location = New System.Drawing.Point(23, 2)
        Me.txt_Date.MaxDecimalLength = 2
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Date.Size = New System.Drawing.Size(132, 26)
        Me.txt_Date.SpellControl = Nothing
        Me.txt_Date.TabIndex = 1
        Me.txt_Date.TabStop = False
        Me.txt_Date.Tag = "StartDate"
        Me.txt_Date.Title = Nothing
        Me.txt_Date.TypeOfContains = CS_Component.TypeOfValues.[Date]
        Me.txt_Date.UseForData = True
        Me.txt_Date.ValidateCheckExistOnEdit = False
        Me.txt_Date.Value = ""
        '
        'txt_Group
        '
        Me.txt_Group.CheckExistValueInDb = True
        Me.txt_Group.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Group.CurrencyUnit = "ریال"
        Me.txt_Group.DefaultValue = ""
        Me.txt_Group.Enabled = False
        Me.txt_Group.FillWithMaxInDb = False
        Me.txt_Group.IsRequired = True
        Me.txt_Group.Location = New System.Drawing.Point(22, 36)
        Me.txt_Group.MaxDecimalLength = 2
        Me.txt_Group.Name = "txt_Group"
        Me.txt_Group.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Group.Size = New System.Drawing.Size(164, 26)
        Me.txt_Group.SpellControl = Nothing
        Me.txt_Group.TabIndex = 3
        Me.txt_Group.Tag = ""
        Me.txt_Group.Title = Nothing
        Me.txt_Group.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_Group.UseForData = True
        Me.txt_Group.ValidateCheckExistOnEdit = False
        Me.txt_Group.Value = ""
        '
        'PmLineBindingSource
        '
        Me.PmLineBindingSource.DataMember = "Pm_Line"
        Me.PmLineBindingSource.DataSource = Me.Ds_Pm
        '
        'Ds_Pm
        '
        Me.Ds_Pm.DataSetName = "Ds_Pm"
        Me.Ds_Pm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Pm_Vahed"
        Me.BindingSource2.DataSource = Me.Ds_Pm
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "Pm_Group"
        Me.BindingSource3.DataSource = Me.Ds_Pm
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "Pm_Post"
        Me.BindingSource5.DataSource = Me.Ds_Pm
        '
        'Rb_NoWorkForm
        '
        Me.Rb_NoWorkForm.AutoSize = True
        Me.Rb_NoWorkForm.Location = New System.Drawing.Point(542, 16)
        Me.Rb_NoWorkForm.Name = "Rb_NoWorkForm"
        Me.Rb_NoWorkForm.Size = New System.Drawing.Size(142, 22)
        Me.Rb_NoWorkForm.TabIndex = 1
        Me.Rb_NoWorkForm.Text = "بر اساس اطلاعات "
        Me.Rb_NoWorkForm.UseVisualStyleBackColor = True
        '
        'Pm_con_statusStatementTableAdapter
        '
        Me.Pm_con_statusStatementTableAdapter.ClearBeforeFill = True
        '
        'Pm_con_WorkformTableAdapter
        '
        Me.Pm_con_WorkformTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Pm_Con_StatusStatement"
        Me.BindingSource1.DataSource = Me.Ds_Con
        '
        'Pm_Con_StatusStatementTableAdapter1
        '
        Me.Pm_Con_StatusStatementTableAdapter1.ClearBeforeFill = True
        '
        'Pm_VahedTableAdapter
        '
        Me.Pm_VahedTableAdapter.ClearBeforeFill = True
        '
        'Pm_GroupTableAdapter
        '
        Me.Pm_GroupTableAdapter.ClearBeforeFill = True
        '
        'Pm_PostTableAdapter
        '
        Me.Pm_PostTableAdapter.ClearBeforeFill = True
        '
        'Pm_LineTableAdapter
        '
        Me.Pm_LineTableAdapter.ClearBeforeFill = True
        '
        'Pm_Con_ContractItemsTableAdapter
        '
        Me.Pm_Con_ContractItemsTableAdapter.ClearBeforeFill = True
        '
        'lb_Holiday
        '
        Me.lb_Holiday.AutoSize = True
        Me.lb_Holiday.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_Holiday.ForeColor = System.Drawing.Color.Red
        Me.lb_Holiday.Location = New System.Drawing.Point(47, 15)
        Me.lb_Holiday.Name = "lb_Holiday"
        Me.lb_Holiday.Size = New System.Drawing.Size(0, 18)
        Me.lb_Holiday.TabIndex = 129
        '
        'txt_all
        '
        Me.txt_all.CheckExistValueInDb = True
        Me.txt_all.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_all.CurrencyUnit = "ریال"
        Me.txt_all.DefaultValue = ""
        Me.txt_all.Enabled = False
        Me.txt_all.FillWithMaxInDb = False
        Me.txt_all.IsRequired = True
        Me.txt_all.Location = New System.Drawing.Point(321, 517)
        Me.txt_all.MaxDecimalLength = 2
        Me.txt_all.Name = "txt_all"
        Me.txt_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_all.Size = New System.Drawing.Size(114, 26)
        Me.txt_all.SpellControl = Nothing
        Me.txt_all.TabIndex = 2
        Me.txt_all.Tag = "title"
        Me.txt_all.Text = "1"
        Me.txt_all.Title = Nothing
        Me.txt_all.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_all.UseForData = True
        Me.txt_all.ValidateCheckExistOnEdit = False
        Me.txt_all.Value = 1
        '
        'WorkFormMasterBindingSource
        '
        Me.WorkFormMasterBindingSource.DataMember = "WorkForm_Master"
        Me.WorkFormMasterBindingSource.DataSource = Me.Ds_Pm
        '
        'WorkForm_MasterTableAdapter
        '
        Me.WorkForm_MasterTableAdapter.ClearBeforeFill = True
        '
        'btn_AddSS
        '
        Me.btn_AddSS.Location = New System.Drawing.Point(480, 14)
        Me.btn_AddSS.Name = "btn_AddSS"
        Me.btn_AddSS.Size = New System.Drawing.Size(62, 29)
        Me.btn_AddSS.TabIndex = 3
        Me.btn_AddSS.Text = "جدید"
        Me.btn_AddSS.UseVisualStyleBackColor = True
        '
        'PmConUsedItemBindingSource
        '
        Me.PmConUsedItemBindingSource.DataMember = "Pm_Con_UsedItem"
        Me.PmConUsedItemBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_UsedItemTableAdapter
        '
        Me.Pm_Con_UsedItemTableAdapter.ClearBeforeFill = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(437, 520)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "جمع نهایی:"
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.Location = New System.Drawing.Point(692, 120)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(186, 22)
        Me.chk_all.TabIndex = 187
        Me.chk_all.Text = "نمایش همه کدهای هزینه"
        Me.chk_all.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 18)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "منبع"
        '
        'cmb_source
        '
        Me.cmb_source.AutoComplete = True
        Me.cmb_source.DataSource = Me.PmConSourceBindingSource
        Me.cmb_source.DisplayMember = "عنوان"
        Me.cmb_source.EnterStop = True
        Me.cmb_source.FormattingEnabled = True
        Me.cmb_source.IsRequired = False
        Me.cmb_source.LimitedToList = True
        Me.cmb_source.Location = New System.Drawing.Point(29, 120)
        Me.cmb_source.Name = "cmb_source"
        Me.cmb_source.OpenOnFoucus = False
        Me.cmb_source.Size = New System.Drawing.Size(215, 26)
        Me.cmb_source.TabIndex = 0
        Me.cmb_source.ValueMember = "Srl"
        '
        'PmConSourceBindingSource
        '
        Me.PmConSourceBindingSource.DataMember = "Pm_Con_Source"
        Me.PmConSourceBindingSource.DataSource = Me.Ds_Con
        '
        'Pm_Con_SourceTableAdapter
        '
        Me.Pm_Con_SourceTableAdapter.ClearBeforeFill = True
        '
        'btn_EditSS
        '
        Me.btn_EditSS.Location = New System.Drawing.Point(412, 15)
        Me.btn_EditSS.Name = "btn_EditSS"
        Me.btn_EditSS.Size = New System.Drawing.Size(62, 27)
        Me.btn_EditSS.TabIndex = 1010
        Me.btn_EditSS.Text = "ویرایش"
        Me.btn_EditSS.UseVisualStyleBackColor = True
        '
        'cmb_Contract
        '
        Me.cmb_Contract.AutoComplete = True
        Me.cmb_Contract.DataSource = Me.PmConContractBindingSource
        Me.cmb_Contract.DisplayMember = "عنوان"
        Me.cmb_Contract.EnterStop = True
        Me.cmb_Contract.FormattingEnabled = True
        Me.cmb_Contract.IsRequired = False
        Me.cmb_Contract.LimitedToList = True
        Me.cmb_Contract.Location = New System.Drawing.Point(30, 14)
        Me.cmb_Contract.Name = "cmb_Contract"
        Me.cmb_Contract.OpenOnFoucus = False
        Me.cmb_Contract.Size = New System.Drawing.Size(215, 26)
        Me.cmb_Contract.TabIndex = 1011
        Me.cmb_Contract.ValueMember = "Srl"
        '
        'PmConContractBindingSource
        '
        Me.PmConContractBindingSource.DataMember = "Pm_Con_Contract"
        Me.PmConContractBindingSource.DataSource = Me.Ds_Con
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(251, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 1012
        Me.Label11.Text = "قرارداد"
        '
        'Pm_Con_ContractTableAdapter
        '
        Me.Pm_Con_ContractTableAdapter.ClearBeforeFill = True
        '
        'txt_FactorPrice
        '
        Me.txt_FactorPrice.CheckExistValueInDb = True
        Me.txt_FactorPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FactorPrice.CurrencyUnit = "ریال"
        Me.txt_FactorPrice.DefaultValue = ""
        Me.txt_FactorPrice.FillWithMaxInDb = False
        Me.txt_FactorPrice.IsRequired = True
        Me.txt_FactorPrice.Location = New System.Drawing.Point(542, 514)
        Me.txt_FactorPrice.MaxDecimalLength = 2
        Me.txt_FactorPrice.Name = "txt_FactorPrice"
        Me.txt_FactorPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_FactorPrice.Size = New System.Drawing.Size(114, 26)
        Me.txt_FactorPrice.SpellControl = Nothing
        Me.txt_FactorPrice.TabIndex = 2
        Me.txt_FactorPrice.Tag = "title"
        Me.txt_FactorPrice.Text = "0"
        Me.txt_FactorPrice.Title = Nothing
        Me.txt_FactorPrice.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_FactorPrice.UseForData = True
        Me.txt_FactorPrice.ValidateCheckExistOnEdit = False
        Me.txt_FactorPrice.Value = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(658, 517)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "هزینه فاکتوری:"
        '
        'txt_AllConfirm
        '
        Me.txt_AllConfirm.CheckExistValueInDb = True
        Me.txt_AllConfirm.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_AllConfirm.CurrencyUnit = "ریال"
        Me.txt_AllConfirm.DefaultValue = ""
        Me.txt_AllConfirm.Enabled = False
        Me.txt_AllConfirm.FillWithMaxInDb = False
        Me.txt_AllConfirm.IsRequired = True
        Me.txt_AllConfirm.Location = New System.Drawing.Point(57, 517)
        Me.txt_AllConfirm.MaxDecimalLength = 2
        Me.txt_AllConfirm.Name = "txt_AllConfirm"
        Me.txt_AllConfirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_AllConfirm.Size = New System.Drawing.Size(114, 26)
        Me.txt_AllConfirm.SpellControl = Nothing
        Me.txt_AllConfirm.TabIndex = 2
        Me.txt_AllConfirm.Tag = "title"
        Me.txt_AllConfirm.Text = "1"
        Me.txt_AllConfirm.Title = Nothing
        Me.txt_AllConfirm.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_AllConfirm.UseForData = True
        Me.txt_AllConfirm.ValidateCheckExistOnEdit = False
        Me.txt_AllConfirm.Value = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(173, 520)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "جمع تائید شده ها:"
        '
        'txt_SSPM
        '
        Me.txt_SSPM.CheckExistValueInDb = True
        Me.txt_SSPM.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_SSPM.CurrencyUnit = "ریال"
        Me.txt_SSPM.DefaultValue = ""
        Me.txt_SSPM.FillWithMaxInDb = False
        Me.txt_SSPM.IsRequired = True
        Me.txt_SSPM.Location = New System.Drawing.Point(292, 120)
        Me.txt_SSPM.MaxDecimalLength = 2
        Me.txt_SSPM.Name = "txt_SSPM"
        Me.txt_SSPM.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_SSPM.Size = New System.Drawing.Size(107, 26)
        Me.txt_SSPM.SpellControl = Nothing
        Me.txt_SSPM.TabIndex = 0
        Me.txt_SSPM.Tag = ""
        Me.txt_SSPM.Title = Nothing
        Me.txt_SSPM.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_SSPM.UseForData = True
        Me.txt_SSPM.ValidateCheckExistOnEdit = False
        Me.txt_SSPM.Value = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(405, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "SSPM"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_Con_StatusStatementMazad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(901, 680)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Con_StatusStatementMazad"
        Me.TableName = "pm_Con_statusstatement"
        Me.Text = "فرم ثبت صورت وضعیت کار مازاد"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmconstatusStatementItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Con, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmconstatusStatementItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Before, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Next, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Pl_WorkForm.ResumeLayout(False)
        Me.Pl_WorkForm.PerformLayout()
        CType(Me.btn_SearchWorkForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Pm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkFormMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConUsedItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConSourceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmConContractBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents cmb_title As VB_Component.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_code As VB_Component.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Amount As CS_Component.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Ds_Con As Nama_PM.Ds_Con
    Friend WithEvents PmconstatusStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_con_statusStatementTableAdapter As Nama_PM.Ds_ConTableAdapters.pm_con_statusStatementItemTableAdapter
    Friend WithEvents PmconContractItemsTarikhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmconWorkformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_con_WorkformTableAdapter As Nama_PM.Ds_ConTableAdapters.pm_con_WorkformTableAdapter
    Friend WithEvents btn_Add As System.Windows.Forms.Button
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents عنوانDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تائیدDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Rb_WorkForm As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_NoWorkForm As System.Windows.Forms.RadioButton
    Friend WithEvents Pl_WorkForm As System.Windows.Forms.Panel
    Friend WithEvents btn_Before As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Next As System.Windows.Forms.PictureBox
    Friend WithEvents txt_unit As CS_Component.TextBox
    Friend WithEvents lb_number As System.Windows.Forms.Label
    Public WithEvents txt_Number As CS_Component.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Date As CS_Component.TextBox
    Friend WithEvents PostOrKhat As System.Windows.Forms.Label
    Friend WithEvents txt_post As CS_Component.TextBox
    Friend WithEvents txt_Group As CS_Component.TextBox
    Friend WithEvents Ds_Pm As Nama_PM.Ds_Pm
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_VahedTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_VahedTableAdapter
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_GroupTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_GroupTableAdapter
    Friend WithEvents PmPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_PostTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_PostTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_StatusStatementTableAdapter1 As Nama_PM.Ds_ConTableAdapters.Pm_Con_StatusStatementTableAdapter
    Friend WithEvents PmLineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_LineTableAdapter As Nama_PM.Ds_PmTableAdapters.Pm_LineTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PmConContractItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractItemsTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractItemsTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents btn_SearchWorkForm As System.Windows.Forms.PictureBox
    Friend WithEvents lb_Holiday As System.Windows.Forms.Label
    Friend WithEvents txt_all As CS_Component.TextBox
    Friend WithEvents WorkFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WorkForm_MasterTableAdapter As Nama_PM.Ds_PmTableAdapters.WorkForm_MasterTableAdapter
    Friend WithEvents btn_AddSS As System.Windows.Forms.Button
    Friend WithEvents lb_omoor As System.Windows.Forms.Label
    Friend WithEvents lb_amount As System.Windows.Forms.Label
    Friend WithEvents PmConUsedItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_UsedItemTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_UsedItemTableAdapter
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_source As VB_Component.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PmConSourceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_SourceTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_SourceTableAdapter
    Friend WithEvents btn_EditSS As System.Windows.Forms.Button
    Friend WithEvents cmb_Contract As VB_Component.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PmConContractBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pm_Con_ContractTableAdapter As Nama_PM.Ds_ConTableAdapters.Pm_Con_ContractTableAdapter
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PmconstatusStatementItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_FactorPrice As CS_Component.TextBox
    Friend WithEvents PmconstatusStatementItemBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_AllConfirm As CS_Component.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txt_SSPM As CS_Component.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents قیمتکلDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfirmAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConfirmPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CalcpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsholidayDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IscancleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsnightDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IsbeforeCancleDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlcontractDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlsourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewImageColumn
End Class
