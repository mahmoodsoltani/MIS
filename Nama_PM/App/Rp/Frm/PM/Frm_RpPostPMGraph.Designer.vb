<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RpPostPMGraph
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RpPostPMGraph))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Me.pl_Setting = New System.Windows.Forms.Panel
        Me.btn_Print_This = New CS_Component.Btn
        Me.btn_Print_All = New CS_Component.Btn
        Me.pl_Color2 = New System.Windows.Forms.Panel
        Me.Pl_Color3 = New System.Windows.Forms.Panel
        Me.pl_color_4 = New System.Windows.Forms.Panel
        Me.pl_Color1 = New System.Windows.Forms.Panel
        Me.txt_RowInterval = New CS_Component.TextBox
        Me.txt_ColumnN = New CS_Component.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.PmPostPmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Rp = New Nama_PM.Ds_Rp
        Me.Pm_PostPmTableAdapter = New Nama_PM.Ds_RpTableAdapters.Pm_PostPmTableAdapter
        Me.RpTajhizPmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rp_TajhizPmTableAdapter = New Nama_PM.Ds_RpTableAdapters.Rp_TajhizPmTableAdapter
        Me.pl_Setting.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmPostPmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RpTajhizPmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pl_Setting
        '
        Me.pl_Setting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pl_Setting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pl_Setting.Controls.Add(Me.btn_Print_This)
        Me.pl_Setting.Controls.Add(Me.btn_Print_All)
        Me.pl_Setting.Controls.Add(Me.pl_Color2)
        Me.pl_Setting.Controls.Add(Me.Pl_Color3)
        Me.pl_Setting.Controls.Add(Me.pl_color_4)
        Me.pl_Setting.Controls.Add(Me.pl_Color1)
        Me.pl_Setting.Controls.Add(Me.txt_RowInterval)
        Me.pl_Setting.Controls.Add(Me.txt_ColumnN)
        Me.pl_Setting.Controls.Add(Me.Label2)
        Me.pl_Setting.Controls.Add(Me.Label5)
        Me.pl_Setting.Controls.Add(Me.Label4)
        Me.pl_Setting.Controls.Add(Me.Label6)
        Me.pl_Setting.Controls.Add(Me.Label3)
        Me.pl_Setting.Controls.Add(Me.Label1)
        Me.pl_Setting.Location = New System.Drawing.Point(6, 382)
        Me.pl_Setting.Name = "pl_Setting"
        Me.pl_Setting.Size = New System.Drawing.Size(708, 112)
        Me.pl_Setting.TabIndex = 7
        '
        'btn_Print_This
        '
        Me.btn_Print_This.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Print_This.BackColor = System.Drawing.Color.Transparent
        Me.btn_Print_This.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Print_This.HeaderText = "چاپ صفحه جاری"
        Me.btn_Print_This.Image = CType(resources.GetObject("btn_Print_This.Image"), System.Drawing.Bitmap)
        Me.btn_Print_This.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.btn_Print_This.Location = New System.Drawing.Point(3, 58)
        Me.btn_Print_This.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Print_This.Name = "btn_Print_This"
        Me.btn_Print_This.Size = New System.Drawing.Size(163, 26)
        Me.btn_Print_This.TabIndex = 11
        '
        'btn_Print_All
        '
        Me.btn_Print_All.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Print_All.BackColor = System.Drawing.Color.Transparent
        Me.btn_Print_All.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Print_All.HeaderText = "چاپ همه صفحات"
        Me.btn_Print_All.Image = CType(resources.GetObject("btn_Print_All.Image"), System.Drawing.Bitmap)
        Me.btn_Print_All.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.btn_Print_All.Location = New System.Drawing.Point(3, 29)
        Me.btn_Print_All.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Print_All.Name = "btn_Print_All"
        Me.btn_Print_All.Size = New System.Drawing.Size(163, 26)
        Me.btn_Print_All.TabIndex = 10
        '
        'pl_Color2
        '
        Me.pl_Color2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pl_Color2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_Color2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pl_Color2.Location = New System.Drawing.Point(375, 60)
        Me.pl_Color2.Name = "pl_Color2"
        Me.pl_Color2.Size = New System.Drawing.Size(23, 20)
        Me.pl_Color2.TabIndex = 9
        '
        'Pl_Color3
        '
        Me.Pl_Color3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pl_Color3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pl_Color3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pl_Color3.Location = New System.Drawing.Point(375, 32)
        Me.Pl_Color3.Name = "Pl_Color3"
        Me.Pl_Color3.Size = New System.Drawing.Size(23, 19)
        Me.Pl_Color3.TabIndex = 9
        '
        'pl_color_4
        '
        Me.pl_color_4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pl_color_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_color_4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pl_color_4.Location = New System.Drawing.Point(220, 63)
        Me.pl_color_4.Name = "pl_color_4"
        Me.pl_color_4.Size = New System.Drawing.Size(23, 19)
        Me.pl_color_4.TabIndex = 9
        '
        'pl_Color1
        '
        Me.pl_Color1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pl_Color1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl_Color1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pl_Color1.Location = New System.Drawing.Point(220, 35)
        Me.pl_Color1.Name = "pl_Color1"
        Me.pl_Color1.Size = New System.Drawing.Size(23, 19)
        Me.pl_Color1.TabIndex = 9
        '
        'txt_RowInterval
        '
        Me.txt_RowInterval.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_RowInterval.CheckExistValueInDb = True
        Me.txt_RowInterval.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_RowInterval.CurrencyUnit = "ریال"
        Me.txt_RowInterval.DefaultValue = ""
        Me.txt_RowInterval.FillWithMaxInDb = False
        Me.txt_RowInterval.IsRequired = True
        Me.txt_RowInterval.Location = New System.Drawing.Point(547, 59)
        Me.txt_RowInterval.MaxDecimalLength = 2
        Me.txt_RowInterval.Name = "txt_RowInterval"
        Me.txt_RowInterval.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_RowInterval.Size = New System.Drawing.Size(47, 23)
        Me.txt_RowInterval.SpellControl = Nothing
        Me.txt_RowInterval.TabIndex = 8
        Me.txt_RowInterval.Tag = ""
        Me.txt_RowInterval.Text = "0"
        Me.txt_RowInterval.Title = Nothing
        Me.txt_RowInterval.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_RowInterval.UseForData = True
        Me.txt_RowInterval.ValidateCheckExistOnEdit = False
        Me.txt_RowInterval.Value = 0.0!
        '
        'txt_ColumnN
        '
        Me.txt_ColumnN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_ColumnN.CheckExistValueInDb = True
        Me.txt_ColumnN.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ColumnN.CurrencyUnit = "ریال"
        Me.txt_ColumnN.DefaultValue = ""
        Me.txt_ColumnN.FillWithMaxInDb = False
        Me.txt_ColumnN.IsRequired = True
        Me.txt_ColumnN.Location = New System.Drawing.Point(547, 32)
        Me.txt_ColumnN.MaxDecimalLength = 2
        Me.txt_ColumnN.Name = "txt_ColumnN"
        Me.txt_ColumnN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ColumnN.Size = New System.Drawing.Size(47, 23)
        Me.txt_ColumnN.SpellControl = Nothing
        Me.txt_ColumnN.TabIndex = 8
        Me.txt_ColumnN.Tag = ""
        Me.txt_ColumnN.Text = "0"
        Me.txt_ColumnN.Title = Nothing
        Me.txt_ColumnN.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_ColumnN.UseForData = True
        Me.txt_ColumnN.ValidateCheckExistOnEdit = False
        Me.txt_ColumnN.Value = 0.0!
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "فاصله سطر ها"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "رنگ ستون چهارم"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "رنگ ستون سوم"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(403, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "رنگ ستون اول"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(404, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "رنگ ستون دوم"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(600, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "تعداد ستون ها"
        '
        'PrintDocument1
        '
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.Area3DStyle.IsClustered = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Area3DStyle.Rotation = 10
        ChartArea1.Area3DStyle.WallWidth = 0
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("B Yekan", 8.0!)
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea1.AxisX.ScaleView.SmallScrollSize = 20
        ChartArea1.AxisX.ScrollBar.IsPositionedInside = False
        ChartArea1.AxisX.Title = "نام پست"
        ChartArea1.AxisX2.Crossing = -1.7976931348623157E+308
        ChartArea1.AxisX2.IsLabelAutoFit = False
        ChartArea1.AxisX2.LabelStyle.Angle = -90
        ChartArea1.AxisX2.LabelStyle.Font = New System.Drawing.Font("B Yekan", 8.25!)
        ChartArea1.AxisX2.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.ScrollBar.IsPositionedInside = False
        ChartArea1.AxisX2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("B Yekan", 8.0!)
        ChartArea1.AxisY.LabelStyle.Interval = 0
        ChartArea1.AxisY.LabelStyle.IntervalOffset = 0
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.Interval = 50
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea1.AxisY.Title = "تعداد برنامه پیشنهادی"
        ChartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea1.AxisY2.LabelStyle.Font = New System.Drawing.Font("B Yekan", 8.25!)
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.Name = "CA1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.PmPostPmBindingSource
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BorderColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Font = New System.Drawing.Font("B Yekan", 8.0!)
        Legend1.IsTextAutoFit = False
        Legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend1.Name = "Legend1"
        Legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DoubleLine
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 57)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "CA1"
        Series1.CustomProperties = "DrawingStyle=Cylinder"
        Series1.Font = New System.Drawing.Font("B Yekan", 8.0!)
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.LegendText = "کل"
        Series1.Name = "کل"
        Series1.XValueMember = "نام تجهیز"
        Series1.YValueMembers = "کل"
        Series2.ChartArea = "CA1"
        Series2.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Series2.CustomProperties = "DrawingStyle=Cylinder"
        Series2.Font = New System.Drawing.Font("B Yekan", 8.0!)
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.LegendText = "انجام شده"
        Series2.Name = "Series1"
        Series2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series2.XValueMember = "نام تجهیز"
        Series2.YValueMembers = "انجام شده"
        Series3.ChartArea = "CA1"
        Series3.Color = System.Drawing.Color.Red
        Series3.CustomProperties = "DrawingStyle=Cylinder"
        Series3.Font = New System.Drawing.Font("B Yekan", 8.25!)
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.LegendText = "کنسل شده"
        Series3.Name = "Series2"
        Series3.XValueMember = "نام تجهیز"
        Series3.YValueMembers = "کنسل شده"
        Series4.ChartArea = "CA1"
        Series4.Color = System.Drawing.Color.Yellow
        Series4.CustomProperties = "DrawingStyle=Cylinder"
        Series4.Font = New System.Drawing.Font("B Yekan", 8.25!)
        Series4.IsValueShownAsLabel = True
        Series4.Legend = "Legend1"
        Series4.LegendText = "انجام نشده"
        Series4.Name = "Series4"
        Series4.XValueMember = "نام تجهیز"
        Series4.YValueMembers = "انجام نشده"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(708, 326)
        Me.Chart1.TabIndex = 6
        Me.Chart1.Text = "Chart1"
        Title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft
        Title1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Title1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Right
        Title1.BackImageTransparentColor = System.Drawing.Color.White
        Title1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled
        Title1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Title1.Font = New System.Drawing.Font("B Yekan", 12.0!)
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        '
        'PmPostPmBindingSource
        '
        Me.PmPostPmBindingSource.DataMember = "Pm_PostPm"
        Me.PmPostPmBindingSource.DataSource = Me.Ds_Rp
        '
        'Ds_Rp
        '
        Me.Ds_Rp.DataSetName = "Ds_Rp"
        Me.Ds_Rp.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pm_PostPmTableAdapter
        '
        Me.Pm_PostPmTableAdapter.ClearBeforeFill = True
        '
        'RpTajhizPmBindingSource
        '
        Me.RpTajhizPmBindingSource.DataMember = "Rp_TajhizPm"
        Me.RpTajhizPmBindingSource.DataSource = Me.Ds_Rp
        '
        'Rp_TajhizPmTableAdapter
        '
        Me.Rp_TajhizPmTableAdapter.ClearBeforeFill = True
        '
        'Frm_RpPostPMGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 523)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.pl_Setting)
        Me.Name = "Frm_RpPostPMGraph"
        Me.Text = "گزارش نموداری برنامه پی ام"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.pl_Setting, 0)
        Me.Controls.SetChildIndex(Me.Chart1, 0)
        Me.pl_Setting.ResumeLayout(False)
        Me.pl_Setting.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmPostPmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Rp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RpTajhizPmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pl_Setting As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ColumnN As CS_Component.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txt_RowInterval As CS_Component.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pl_Color2 As System.Windows.Forms.Panel
    Friend WithEvents pl_Color1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents btn_Print_This As CS_Component.Btn
    Friend WithEvents btn_Print_All As CS_Component.Btn
    Friend WithEvents Pl_Color3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pl_color_4 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PmPostPmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_Rp As Nama_PM.Ds_Rp
    Friend WithEvents Pm_PostPmTableAdapter As Nama_PM.Ds_RpTableAdapters.Pm_PostPmTableAdapter
    Friend WithEvents RpTajhizPmBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Rp_TajhizPmTableAdapter As Nama_PM.Ds_RpTableAdapters.Rp_TajhizPmTableAdapter
End Class
