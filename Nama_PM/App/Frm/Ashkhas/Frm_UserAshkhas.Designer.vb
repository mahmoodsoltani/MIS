<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_UserAshkhas
    Inherits VB_Component.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_UserAshkhas))
        Me.lk_Ashkhas = New VB_Component.LookUpButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New VB_Component.ComboBox
        Me.SecUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Security = New Nama_PM.Ds_Security
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Ok = New CS_Component.Btn
        Me.btn_Cancel = New CS_Component.Btn
        Me.Sec_UserTableAdapter = New Nama_PM.Ds_SecurityTableAdapters.sec_UserTableAdapter
        CType(Me.SecUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Security, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lk_Ashkhas
        '
        Me.lk_Ashkhas.BackColor = System.Drawing.Color.White
        Me.lk_Ashkhas.CodeSize = 110
        Me.lk_Ashkhas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lk_Ashkhas.LoadingBySerial = True
        Me.lk_Ashkhas.Location = New System.Drawing.Point(7, 20)
        Me.lk_Ashkhas.Name = "lk_Ashkhas"
        Me.lk_Ashkhas.RiseCodeChange = False
        Me.lk_Ashkhas.ShowCodeTextBox = False
        Me.lk_Ashkhas.Size = New System.Drawing.Size(447, 22)
        Me.lk_Ashkhas.TabIndex = 4
        Me.lk_Ashkhas.TabStop = False
        Me.lk_Ashkhas.Tag = "Srl_Acc_Ashkhas"
        Me.lk_Ashkhas.ValidateValue = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "کد شخص :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "کاربر :"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.SecUserBindingSource
        Me.ComboBox1.DisplayMember = "نام کاربر"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(446, 26)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.ValueMember = "Srl"
        '
        'SecUserBindingSource
        '
        Me.SecUserBindingSource.DataMember = "sec_User"
        Me.SecUserBindingSource.DataSource = Me.Ds_Security
        '
        'Ds_Security
        '
        Me.Ds_Security.DataSetName = "Ds_Security"
        Me.Ds_Security.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.lk_Ashkhas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 96)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btn_Ok
        '
        Me.btn_Ok.BackColor = System.Drawing.Color.Transparent
        Me.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Ok.HeaderText = "تایید"
        Me.btn_Ok.Image = CType(resources.GetObject("btn_Ok.Image"), System.Drawing.Bitmap)
        Me.btn_Ok.ImageScalingSize = New System.Drawing.Size(16, 16)
        Me.btn_Ok.Location = New System.Drawing.Point(475, 147)
        Me.btn_Ok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(86, 29)
        Me.btn_Ok.TabIndex = 9
        '
        'btn_Cancel
        '
        Me.btn_Cancel.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Cancel.HeaderText = "انصراف"
        Me.btn_Cancel.Image = CType(resources.GetObject("btn_Cancel.Image"), System.Drawing.Bitmap)
        Me.btn_Cancel.ImageScalingSize = New System.Drawing.Size(16, 16)
        Me.btn_Cancel.Location = New System.Drawing.Point(15, 147)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(86, 29)
        Me.btn_Cancel.TabIndex = 10
        '
        'Sec_UserTableAdapter
        '
        Me.Sec_UserTableAdapter.ClearBeforeFill = True
        '
        'Frm_UserAshkhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(581, 220)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_UserAshkhas"
        Me.Text = "تعیین ارتباط کاربران با اشخاص"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btn_Ok, 0)
        Me.Controls.SetChildIndex(Me.btn_Cancel, 0)
        CType(Me.SecUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Security, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lk_Ashkhas As VB_Component.LookUpButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Ok As CS_Component.Btn
    Friend WithEvents btn_Cancel As CS_Component.Btn
    Friend WithEvents Ds_Security As Nama_PM.Ds_Security
    Friend WithEvents SecUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sec_UserTableAdapter As Nama_PM.Ds_SecurityTableAdapters.sec_UserTableAdapter
End Class
