<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Khat_Import
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
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.کدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامپستDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تجهیزDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تیپDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سطحولتاژDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.سالبهرهبرداریDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ترانسفورماتورDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.اتوماسیونDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.رلهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتMVADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ظرفیتتعدادDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامکاملDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostTipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SrlPmPostModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IsMission = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TarikhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.تاریخDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامواحدDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.نامگروهDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txt_unit = New CS_Component.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(162, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        Me.btn_Delete.TabIndex = 1
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "انتقال اطلاعاتF2"
        Me.btn_new.Location = New System.Drawing.Point(371, 18)
        Me.btn_new.Size = New System.Drawing.Size(155, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(286, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        Me.btn_Edit.TabIndex = 0
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_GridViewList.Controls.Add(Me.txt_unit)
        Me.gbx_GridViewList.Controls.Add(Me.Label3)
        Me.gbx_GridViewList.Controls.Add(Me.Label2)
        Me.gbx_GridViewList.Controls.Add(Me.Label1)
        Me.gbx_GridViewList.Controls.Add(Me.Button1)
        Me.gbx_GridViewList.Controls.Add(Me.ProgressBar1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 37)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(530, 173)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Location = New System.Drawing.Point(11, 252)
        Me.gbx_Controls.Size = New System.Drawing.Size(533, 10)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(11, 200)
        Me.gbx_Btn.Size = New System.Drawing.Size(533, 57)
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'کدDataGridViewTextBoxColumn
        '
        Me.کدDataGridViewTextBoxColumn.DataPropertyName = "کد"
        Me.کدDataGridViewTextBoxColumn.HeaderText = "کد"
        Me.کدDataGridViewTextBoxColumn.Name = "کدDataGridViewTextBoxColumn"
        Me.کدDataGridViewTextBoxColumn.Width = 50
        '
        'نامپستDataGridViewTextBoxColumn
        '
        Me.نامپستDataGridViewTextBoxColumn.DataPropertyName = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.HeaderText = "نام پست"
        Me.نامپستDataGridViewTextBoxColumn.Name = "نامپستDataGridViewTextBoxColumn"
        '
        'تجهیزDataGridViewTextBoxColumn
        '
        Me.تجهیزDataGridViewTextBoxColumn.DataPropertyName = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.HeaderText = "تجهیز"
        Me.تجهیزDataGridViewTextBoxColumn.Name = "تجهیزDataGridViewTextBoxColumn"
        '
        'تیپDataGridViewTextBoxColumn
        '
        Me.تیپDataGridViewTextBoxColumn.DataPropertyName = "تیپ"
        Me.تیپDataGridViewTextBoxColumn.HeaderText = "تیپ"
        Me.تیپDataGridViewTextBoxColumn.Name = "تیپDataGridViewTextBoxColumn"
        '
        'سطحولتاژDataGridViewTextBoxColumn
        '
        Me.سطحولتاژDataGridViewTextBoxColumn.DataPropertyName = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.HeaderText = "سطح ولتاژ"
        Me.سطحولتاژDataGridViewTextBoxColumn.Name = "سطحولتاژDataGridViewTextBoxColumn"
        '
        'سالبهرهبرداریDataGridViewTextBoxColumn
        '
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.DataPropertyName = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.HeaderText = "سال بهره برداری"
        Me.سالبهرهبرداریDataGridViewTextBoxColumn.Name = "سالبهرهبرداریDataGridViewTextBoxColumn"
        '
        'ترانسفورماتورDataGridViewTextBoxColumn
        '
        Me.ترانسفورماتورDataGridViewTextBoxColumn.DataPropertyName = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn.HeaderText = "ترانسفورماتور"
        Me.ترانسفورماتورDataGridViewTextBoxColumn.Name = "ترانسفورماتورDataGridViewTextBoxColumn"
        '
        'اتوماسیونDataGridViewTextBoxColumn
        '
        Me.اتوماسیونDataGridViewTextBoxColumn.DataPropertyName = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn.HeaderText = "اتوماسیون"
        Me.اتوماسیونDataGridViewTextBoxColumn.Name = "اتوماسیونDataGridViewTextBoxColumn"
        '
        'رلهDataGridViewTextBoxColumn
        '
        Me.رلهDataGridViewTextBoxColumn.DataPropertyName = "رله"
        Me.رلهDataGridViewTextBoxColumn.HeaderText = "رله"
        Me.رلهDataGridViewTextBoxColumn.Name = "رلهDataGridViewTextBoxColumn"
        '
        'ظرفیتMVADataGridViewTextBoxColumn
        '
        Me.ظرفیتMVADataGridViewTextBoxColumn.DataPropertyName = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn.HeaderText = "ظرفیت-MVA"
        Me.ظرفیتMVADataGridViewTextBoxColumn.Name = "ظرفیتMVADataGridViewTextBoxColumn"
        '
        'ظرفیتتعدادDataGridViewTextBoxColumn
        '
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.DataPropertyName = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.HeaderText = "ظرفیت-تعداد"
        Me.ظرفیتتعدادDataGridViewTextBoxColumn.Name = "ظرفیتتعدادDataGridViewTextBoxColumn"
        '
        'نامکاملDataGridViewTextBoxColumn
        '
        Me.نامکاملDataGridViewTextBoxColumn.DataPropertyName = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn.HeaderText = "نام کامل"
        Me.نامکاملDataGridViewTextBoxColumn.Name = "نامکاملDataGridViewTextBoxColumn"
        '
        'SrlPmPostTipDataGridViewTextBoxColumn
        '
        Me.SrlPmPostTipDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_PostTip"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.Name = "SrlPmPostTipDataGridViewTextBoxColumn"
        Me.SrlPmPostTipDataGridViewTextBoxColumn.Visible = False
        '
        'SrlPmPostModelDataGridViewTextBoxColumn
        '
        Me.SrlPmPostModelDataGridViewTextBoxColumn.DataPropertyName = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.HeaderText = "Srl_Pm_PostModel"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.Name = "SrlPmPostModelDataGridViewTextBoxColumn"
        Me.SrlPmPostModelDataGridViewTextBoxColumn.Visible = False
        '
        'IsMission
        '
        Me.IsMission.DataPropertyName = "IsMission"
        Me.IsMission.HeaderText = "مامورتی"
        Me.IsMission.Name = "IsMission"
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        '
        'NumberDataGridViewTextBoxColumn
        '
        Me.NumberDataGridViewTextBoxColumn.DataPropertyName = "Number"
        Me.NumberDataGridViewTextBoxColumn.HeaderText = "شماره"
        Me.NumberDataGridViewTextBoxColumn.Name = "NumberDataGridViewTextBoxColumn"
        '
        'TarikhDataGridViewTextBoxColumn
        '
        Me.TarikhDataGridViewTextBoxColumn.DataPropertyName = "Tarikh"
        Me.TarikhDataGridViewTextBoxColumn.HeaderText = "Tarikh"
        Me.TarikhDataGridViewTextBoxColumn.Name = "TarikhDataGridViewTextBoxColumn"
        Me.TarikhDataGridViewTextBoxColumn.Visible = False
        '
        'تاریخDataGridViewTextBoxColumn
        '
        Me.تاریخDataGridViewTextBoxColumn.DataPropertyName = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.HeaderText = "تاریخ"
        Me.تاریخDataGridViewTextBoxColumn.Name = "تاریخDataGridViewTextBoxColumn"
        '
        'نامواحدDataGridViewTextBoxColumn
        '
        Me.نامواحدDataGridViewTextBoxColumn.DataPropertyName = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.HeaderText = "نام واحد"
        Me.نامواحدDataGridViewTextBoxColumn.Name = "نامواحدDataGridViewTextBoxColumn"
        '
        'نامگروهDataGridViewTextBoxColumn
        '
        Me.نامگروهDataGridViewTextBoxColumn.DataPropertyName = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.HeaderText = "نام گروه"
        Me.نامگروهDataGridViewTextBoxColumn.Name = "نامگروهDataGridViewTextBoxColumn"
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
        Me.txt_unit.Location = New System.Drawing.Point(48, 44)
        Me.txt_unit.MaxDecimalLength = 2
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_unit.Size = New System.Drawing.Size(401, 25)
        Me.txt_unit.SpellControl = Nothing
        Me.txt_unit.TabIndex = 8
        Me.txt_unit.Tag = ""
        Me.txt_unit.Title = Nothing
        Me.txt_unit.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.txt_unit.UseForData = True
        Me.txt_unit.ValidateCheckExistOnEdit = False
        Me.txt_unit.Value = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(468, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "مسیر"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(18, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 27)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 134)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(480, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(334, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(41, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 18)
        Me.Label3.TabIndex = 7
        '
        'Frm_Khat_Import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 294)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Khat_Import"
        Me.TableName = "Pm_Con_StatusStatement"
        Me.Text = "تعریف صورت وضعیت"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامپستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تجهیزDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تیپDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سطحولتاژDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents سالبهرهبرداریDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ترانسفورماتورDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents اتوماسیونDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents رلهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتMVADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ظرفیتتعدادDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامکاملDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostTipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmPostModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsMission As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarikhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامواحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_unit As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
