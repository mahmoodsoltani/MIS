
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using System.ComponentModel;

namespace CS_Component
{
    public enum TypeOfValues { PersianText, EnglishText, Number, StringNumber, Currency, Date, FloatNumber, CarNumber }

    public class TextBox : System.Windows.Forms.TextBox
    {
        #region Constructor and Destructor

        public TextBox()
        {
            this.TypeOfValueChanged += new EventHandler(ITPTextBox_TypeOfValueChanged);
            this.KeyDown += new KeyEventHandler(ITPTextBox_KeyDown);
            this.Enter += new EventHandler(ITPTextBox_Enter);
            this.KeyPress += new KeyPressEventHandler(ITPTextBox_KeyPress);
            this.TextChanged += new EventHandler(ITPTextBox_TextChanged);
            this.Validating += new System.ComponentModel.CancelEventHandler(ITPTextBox_Validating);
            this.Validated += new EventHandler(ITPTextBox_Validated);
            this.Click += new EventHandler(ITPTextBox_Click);
            //this.BackColorChanged += new EventHandler(ITPTextBox_BackColorChanged);
        }

        #endregion

        #region Member Fields
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private TextBox txt_Day;
        private TextBox txt_Month;
        private TextBox txt_Year;

        private TextBox txt_Num1;
        private TextBox txt_Letter;
        private TextBox txt_Num2;
        private TextBox txt_City;

        private System.Windows.Forms.Button btn_SelectDate;
        private Control ctrl_Spell;
        private InputLanguage _DefaultLanguage;
        private TypeOfValues _Type;
        private object obj_Value;
        private string str_CurrencyUnit = "ریال";
        private int int_MaxDecimalLength = 2;
        private bool bol_IsNecessary = false;
        private string str_Title;
        private bool bol_UseForData = true;
        private bool bol_CheckExistValueInDb = false;
        private bool bol_ValidateCheckExistOnEdit = false;
        private bool bol_FillWithMaxInDb = false;
        private Color bol_cololOnFocus = Color.Yellow ;
        private string String_DefaultValue = "";

        #endregion

        #region Events
        public event EventHandler TypeOfValueChanged;

        public event EventHandler ValueChanged;
        #endregion

        #region Properties
        [Category("Nama")]
        public string DefaultValue
        {
            get { return String_DefaultValue; }
            set { String_DefaultValue = value; }
        }

        [Category("Nama")]
        public Color ColorOnFocus
        {
            get { return bol_cololOnFocus; }
            set { bol_cololOnFocus = value; }
        }

        [Category("Nama")]
        public bool UseForData
        {
            get { return bol_UseForData; }
            set { bol_UseForData = value; }
        }

        [Category("Nama")]
        public bool CheckExistValueInDb
        {
            get { return bol_CheckExistValueInDb; }
            set { bol_CheckExistValueInDb = value; }
        }

        [Category("Nama")]
        public bool ValidateCheckExistOnEdit
        {
            get { return bol_ValidateCheckExistOnEdit; }
            set { bol_ValidateCheckExistOnEdit = value; }
        }

        [Category("Nama")]
        public bool FillWithMaxInDb
        {
            get { return bol_FillWithMaxInDb; }
            set { bol_FillWithMaxInDb = value; }
        }

        [Category("Nama")]
        public bool IsRequired
        {
            get { return bol_IsNecessary; }
            set { bol_IsNecessary = value; }
        }

        [Category("Nama")]
        public int MaxDecimalLength
        {
            get { return int_MaxDecimalLength; }
            set
            {
                int_MaxDecimalLength = value;
                if (this.Text.IndexOf('.') < 0) return;
                try
                {
                    this.Text = this.Text.Remove(this.Text.IndexOf('.') + int_MaxDecimalLength + 1);
                }
                catch
                { }
            }
        }

        [Category("Nama")]
        public string CurrencyUnit
        {
            get { return str_CurrencyUnit; }
            set { str_CurrencyUnit = value; }
        }

        [Category("Nama")]
        public TypeOfValues TypeOfContains
        {
            get { return _Type; }
            set
            {
                _Type = value;
                if (TypeOfValueChanged != null)
                    TypeOfValueChanged(this, new EventArgs());
            }
        }

        [Category("Nama")]
        public Control SpellControl
        {
            get { return ctrl_Spell; }
            set
            {
                ctrl_Spell = value;
                if (ctrl_Spell != null)
                    try
                    {
                        SetTextOfSpellControl();
                    }
                    catch { }
            }
        }

        [Category("Nama")]
        public string Title
        {
            get { return str_Title; }
            set
            {
                str_Title = value;
            }
        }

        [Browsable(false)]
        public object Value
        {
            get
            {
                if (_Type == TypeOfValues.Number)
                {
                    long lng = 0;
                    long.TryParse(this.Text, out lng);
                    if (lng < int.MaxValue)
                    {
                        int it = Convert.ToInt32(lng);
                        return it;
                    }
                    else
                        return lng;
                }
                else if (_Type == TypeOfValues.Date)
                {
                    try
                    {
                        int int_O = 0;
                        int int_O1 = 0;
                        int int_O2 = 0;
                        string dt = txt_Year.Text + "/" + Convert.ToString((int)txt_Month.Value).PadLeft(2, '0') + "/" + Convert.ToString((int)txt_Day.Value).PadLeft(2, '0');
                        if (!int.TryParse(dt.Substring(0, 4), out int_O) || !int.TryParse(dt.Substring(5, 2), out int_O1) || !int.TryParse(dt.Substring(8, 2), out int_O2) || int_O == 0 || int_O1 == 0 || int_O2 == 0)
                            return "";
                        return dt;
                        //return GetGregorianDate(dt);
                    }
                    catch { return null; }
                }
                else if (_Type == TypeOfValues.Currency)
                {
                    double lng = 0;
                    double.TryParse(this.Text.Replace(",", ""), out lng);
                    return lng;
                }
                else if (_Type == TypeOfValues.FloatNumber)
                {
                    float tmp = 0;
                    float.TryParse(this.Text, out tmp);
                    return tmp;
                }
                else if (_Type == TypeOfValues.CarNumber)
                {
                    obj_Value = txt_Num1.Text + txt_Letter.Text + txt_Num2.Text + txt_City.Text;
                    return obj_Value;
                }
                obj_Value = this.Text.Trim();
                return obj_Value;
            }
            set
            {
                obj_Value = value;
                if (obj_Value == null)
                    return;
                if (_Type == TypeOfValues.Date)
                {
                    if (obj_Value != null && !(obj_Value is DBNull))
                    {
                        string str_Date = obj_Value.ToString();
                        //string str_Date = GetPersianDate((DateTime)obj_Value);
                        if (str_Date.Trim().Length != 0)
                        {
                            try
                            {
                                txt_Year.Text = str_Date.Substring(0, 4);
                                txt_Month.Text = str_Date.Substring(5, 2);
                                txt_Day.Text = str_Date.Substring(8, 2);
                            }
                            catch { txt_Year.Text = txt_Month.Text = txt_Day.Text = ""; }
                            txt_Day.Focus();
                        }
                    }
                    else
                    {
                        txt_Day.Text = txt_Month.Text = txt_Year.Text = "";
                    }
                }
                else if (_Type == TypeOfValues.CarNumber)
                {
                    if (obj_Value.ToString().Length < 8) return;
                    txt_Num1.Text = obj_Value.ToString().Substring(0, 2);
                    txt_Letter.Text = obj_Value.ToString().Substring(2, 1);
                    txt_Num2.Text = obj_Value.ToString().Substring(3, 3);
                    txt_City.Text = obj_Value.ToString().Substring(6, 2);
                }
                else
                {
                    Text = obj_Value.ToString();
                }
            }
        }


        #endregion

        #region Event Handlers

        #region Click

        void ITPTextBox_Click(object sender, EventArgs e)
        {
            if (_Type == TypeOfValues.Date)
                txt_Day.Focus();
        }

        #endregion

        #region Validated

        void ITPTextBox_Validated(object sender, EventArgs e)
        {
            if (ctrl_Spell != null)
                SetTextOfSpellControl();
        }

        void txt_Year_Validated(object sender, EventArgs e)
        {
            if ((int)txt_Year.Value == 0) return;
            int MaxDay = 0;
            if ((int)txt_Month.Value == 12)
            {
                if ((int)txt_Year.Value % 4 == 0)
                    MaxDay = 30;
                else
                    MaxDay = 29;
            }
            if ((int)txt_Day.Value > MaxDay && MaxDay != 0)
                txt_Day.Value = MaxDay;
        }

        void txt_Month_Validated(object sender, EventArgs e)
        {
            if ((int)txt_Month.Value == 0)
                txt_Month.Clear();
        }

        void txt_Day_Validated(object sender, EventArgs e)
        {
            if ((int)txt_Day.Value == 0)
                txt_Day.Clear();
        }

        #endregion

        #region Validating

        void ITPTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_Type == TypeOfValues.Date)
            {

                if ((int)txt_Year.Value <= 99 && (int)txt_Year.Value != 0)
                {
                    string S = GetPersianDate(DateTime.Now.Date);
                    int Y = 0;
                    int.TryParse(S.Substring(0, S.IndexOf('/')), out Y);
                    txt_Year.Text = Convert.ToString((int)txt_Year.Value + (Y / 100) * 100);
                }
            }
        }

        #endregion

        #region TypeOfValueChanged

        void ITPTextBox_TypeOfValueChanged(object sender, EventArgs e)
        {
            if (_Type == TypeOfValues.Date)
            {
                ConvertToDate();
            }
            else if (_Type == TypeOfValues.CarNumber)
            {
                ConvertToPelak();
            }
            else
            {
                ConvertToTextBox();
            }
            if (_Type == TypeOfValues.EnglishText || _Type == TypeOfValues.PersianText)
                foreach (InputLanguage IL in InputLanguage.InstalledInputLanguages)
                {
                    if (_Type == TypeOfValues.PersianText)
                    {
                        if (IL.Culture.EnglishName == "Persian (Iran)" ||IL.Culture.EnglishName.Contains("Persian") )
                        {
                            _DefaultLanguage = IL;
                            this.RightToLeft = RightToLeft.Yes;
                            break;
                        }
                    }
                    else
                    {
                        if (IL.Culture.EnglishName == "English (United States)"|| IL.Culture.EnglishName.Contains ("English"))
                        {
                            this.RightToLeft = RightToLeft.No;
                            _DefaultLanguage = IL;
                            break;
                        }
                    }
                }
        }

        #endregion

        #region KeyPress

        void ITPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Type == TypeOfValues.FloatNumber)
            {
                if (this.Text.Contains(".") && e.KeyChar == '.')
                {
                    e.KeyChar = '\0';
                    return;
                }
                float flt_Tmp = 0;
                float.TryParse(this.Text, out flt_Tmp);
                if ((e.KeyChar != '.' && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) || e.KeyChar == '0' && flt_Tmp == 0)
                    e.KeyChar = '\0';

                if (this.Text.IndexOf('.') > 0)
                    if (this.Text.Split('.')[1].Length >= int_MaxDecimalLength && e.KeyChar != (char)8)
                        e.KeyChar = '\0';
            }
            long lng_Tmp = 0;
            long.TryParse(this.Text.Replace(",", ""), out lng_Tmp);
            if (_Type == TypeOfValues.Currency && e.KeyChar == '.' && lng_Tmp != 0)
                this.Text += "000";

            if (_Type == TypeOfValues.Number || _Type == TypeOfValues.Currency)
            {
                if (this.Parent is TextBox)
                {
                    if (((TextBox)this.Parent).TypeOfContains == TypeOfValues.Date)
                        if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8))
                            e.KeyChar = '\0';
                }
                else
                    if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) || e.KeyChar == '0' && lng_Tmp == 0)
                        e.KeyChar = '\0';
            }

            if (_Type == TypeOfValues.StringNumber)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != '/' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '+')
                    e.KeyChar = '\0';
            }
            if (_Type == TypeOfValues.Currency)
            {
                lng_Tmp = 0;
                long.TryParse(this.Text.Replace(",", ""), out lng_Tmp);
                if (lng_Tmp == 0 && e.KeyChar == '0')
                    e.KeyChar = '\0';
            }
        }

        void txt_Letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
                e.KeyChar = '\0';
        }


        #endregion

        #region Enter

        void ITPTextBox_Enter(object sender, EventArgs e)
        {

            if (this.ReadOnly) return;
            if (this.TypeOfContains != TypeOfValues.Date && this.TypeOfContains != TypeOfValues.CarNumber)
                this.BackColor = bol_cololOnFocus;
            if (_Type == TypeOfValues.PersianText)
                InputLanguage.CurrentInputLanguage = _DefaultLanguage;
            else if (_Type == TypeOfValues.EnglishText)
                InputLanguage.CurrentInputLanguage = _DefaultLanguage;
            if (_Type == TypeOfValues.Date)
                txt_Day.Focus();
            if (_Type == TypeOfValues.CarNumber)
                txt_Num1.Focus();
            this.SelectAll();
        }

        protected override void OnLeave(EventArgs e)
        {
            if (this.ReadOnly) return;
            this.BackColor = SystemColors.Window;
            base.OnLeave(e);
        }

        #endregion

        #region KeyDown

        private DateTime Dt;
        private bool bol_Pressed;

        void ITPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (!bol_Pressed)
                {
                    Dt = DateTime.Now;
                    bol_Pressed = true;
                }
                else
                {
                    long lng_S = Dt.Millisecond + Dt.Second * 1000 + Dt.Minute * 60000 + Dt.Hour * 3600000;
                    long lng_E = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    if (lng_S + 800 >= lng_E)
                    {
                        this.Clear();
                    }
                    bol_Pressed = false;
                }
            }
            if (_Type == TypeOfValues.PersianText || _Type == TypeOfValues.EnglishText)
                return;

        }

        #endregion

        #region TextChanged

        void ITPTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_Type == TypeOfValues.Currency)
            {
                try
                {
                    if (this.Text.Contains("."))
                    {
                        string ns = this.Text.Remove(this.Text.IndexOf('.'), this.Text.Length - this.Text.IndexOf('.')).Replace(".", "").Replace(",","");
                        string ashar = this.Text.Substring(this.Text.IndexOf('.'), this.Text.Length - this.Text.IndexOf('.')).Replace(".", "").Replace(",","");

                        for (int i = ns.Length - 3; i > 0; i = i - 3)
                            ns = ns.Insert(i, ",");
                        SetTextOfSpellControl();
                        if (ns.EndsWith(","))
                            ns.Remove(ns.Length - 1, 1);
                        this.TextChanged -= new EventHandler(ITPTextBox_TextChanged);
                        this.Text = ns+"."+ashar;
                        this.TextChanged += new EventHandler(ITPTextBox_TextChanged);
                        this.SelectionStart = this.Text.Length;


                    }
                    else
                    {
                        string s = this.Text.Replace(",", "");
                        for (int i = s.Length - 3; i > 0; i = i - 3)
                            s = s.Insert(i, ",");
                        SetTextOfSpellControl();
                        if (s.EndsWith(","))
                            s.Remove(s.Length - 1, 1);
                        this.TextChanged -= new EventHandler(ITPTextBox_TextChanged);
                        this.Text = s;
                        this.TextChanged += new EventHandler(ITPTextBox_TextChanged);
                        this.SelectionStart = this.Text.Length;
                    }
                }
                catch
                {
                    // Ignore Design Time
                }
            }

            if (_Type == TypeOfValues.Number ||
                _Type == TypeOfValues.FloatNumber || _Type == TypeOfValues.Currency)
            {
                if (String_DefaultValue.Replace(" ", "") != "")
                    if (this.Text.Replace(" ", "") == "")
                    {
                        this.TextChanged -= new EventHandler(ITPTextBox_TextChanged);
                        this.Text = String_DefaultValue;
                        this.TextChanged += new EventHandler(ITPTextBox_TextChanged);
                        this.SelectAll();
                    }
            }
        }

        void txt_Day_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(sender, e);
            if (this.txt_Day.Text.Length == 2) txt_Month.Focus();
            int MaxDay = 5;
            if ((int)txt_Month.Value == 0)
                MaxDay = 31;
            else if ((int)txt_Month.Value <= 6 && (int)txt_Month.Value >= 1)
                MaxDay = 31;
            else if ((int)txt_Month.Value >= 7 && (int)txt_Month.Value <= 12)
                MaxDay = 30;
            //else if ((int)txt_Month.Value == 12 && (int)txt_Year.Value % 4 == 0)
              //  MaxDay = 30;
            //else
              //  MaxDay = 30;
            if ((int)txt_Day.Value > MaxDay)
                txt_Day.Value = MaxDay;
        }

        void txt_Month_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(sender, e);
            int MaxMonth = 12;
            if ((int)txt_Month.Value > MaxMonth)
                txt_Month.Clear();
            txt_Day_TextChanged(sender, e);
            if (txt_Month.Text.Length == 2) txt_Year.Focus();
        }

        void txt_City_TextChanged(object sender, EventArgs e)
        {

        }

        void txt_Num2_TextChanged(object sender, EventArgs e)
        {
            if ((int)txt_Num2.Value > 99) txt_City.Focus();
        }

        void txt_Letter_TextChanged(object sender, EventArgs e)
        {
            if (txt_Letter.Text.Trim().Length == 1) txt_Num2.Focus();
        }

        void txt_Num1_TextChanged(object sender, EventArgs e)
        {
            if ((int)txt_Num1.Value > 9) txt_Letter.Focus();
        }


        #endregion

        #region BackColorChanged

        //void ITPTextBox_BackColorChanged(object sender, EventArgs e)
        //{
        //    foreach (Control C in this.Controls)
        //        C.BackColor = this.BackColor;
        //}

        #endregion

        //protected override void OnBackColorChanged(EventArgs e)
        //{
        //    base.OnBackColorChanged(e);
        //    if (this.Controls.Count != 0)
        //    {
        //        foreach (Control c in this.Controls)
        //        {
        //            c.BackColor = this.BackColor;
        //        }
        //    }
        //}
        #endregion

        #region Methods

        void ConvertToTextBox()
        {
            this.TabStop = true;
            this.Controls.Clear();
        }

        void ConvertToDate()
        {
            this.Clear();
            this.TabStop = false;
            this.txt_Day = new TextBox();
            this.txt_Year = new TextBox();
            this.txt_Month = new TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            btn_SelectDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // btn_SelectDate
            //
            this.btn_SelectDate.Size = new Size(20, 23);
            this.btn_SelectDate.Dock = DockStyle.Right;
            this.btn_SelectDate.Click += new EventHandler(TextBox_Click);
            this.btn_SelectDate.Image = CS_Component.Properties.Resources.Down;
            this.btn_SelectDate.BackColor = Color.LightGray;
            this.btn_SelectDate.Cursor = Cursors.Hand;
            this.btn_SelectDate.TabStop = false;
            this.btn_SelectDate.FlatStyle = FlatStyle.Flat;
            this.btn_SelectDate.FlatAppearance.BorderSize = 0;
            // 
            // txt_Year
            // 
            this.txt_Year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Year.Location = new System.Drawing.Point(0, 2);
            this.txt_Year.MaxLength = 4;
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(35, 13);
            this.txt_Year.TextAlign = HorizontalAlignment.Right;
            this.txt_Year.Validated += new EventHandler(txt_Year_Validated);
            this.txt_Year.Validating += new CancelEventHandler(ITPTextBox_Validating);
            this.txt_Year.TextChanged += new EventHandler(txt_Year_TextChanged);
            this.txt_Year.TabIndex = 1003;
            this.txt_Year.TypeOfContains = TypeOfValues.Number;
            // 
            // txt_Month
            // 
            this.txt_Month.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Month.Location = new System.Drawing.Point(48, 2);
            this.txt_Month.MaxLength = 2;
            this.txt_Month.Name = "txt_Month";
            this.txt_Month.Size = new System.Drawing.Size(18, 13);
            this.txt_Month.TabIndex = 1002;
            this.txt_Month.TextAlign = HorizontalAlignment.Right;
            this.txt_Month.TypeOfContains = TypeOfValues.Number;
            this.txt_Month.TextChanged += new EventHandler(txt_Month_TextChanged);
            this.txt_Month.Validated += new EventHandler(txt_Month_Validated);
            // 
            // txt_Day
            // 
            this.txt_Day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Day.Location = new System.Drawing.Point(84, 2);
            this.txt_Day.MaxLength = 2;
            this.txt_Day.Name = "txt_Day";
            this.txt_Day.Size = new System.Drawing.Size(25, 13);
            this.txt_Day.TabIndex = 1001;
            this.txt_Day.TextChanged += new EventHandler(txt_Day_TextChanged);
            this.txt_Day.Validated += new EventHandler(txt_Day_Validated);
            this.txt_Day.TextAlign = HorizontalAlignment.Right;
            this.txt_Day.TypeOfContains = TypeOfValues.Number;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "/";
            label1.BackColor = Color.Transparent;
            this.label1.BringToFront();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            label2.BackColor = Color.Transparent;
            this.label2.BringToFront();
            // 
            // PanelDate
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txt_Day);
            this.Controls.Add(this.txt_Month);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SelectDate);
            this.TabStop = false;
            this.ResumeLayout(false);
            this.PerformLayout();

            this.txt_Day.BringToFront();
            this.txt_Month.BringToFront();
            label1.BringToFront();
            label2.BringToFront();

        }

        void txt_Year_TextChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(sender, e);
        }

        #region DatePicker

        Form frm_Dark;

        void TextBox_Click(object sender, EventArgs e)
        {
            frm_Dark = new Form();
            frm_Dark.FormBorderStyle = FormBorderStyle.None;
            frm_Dark.BackColor = Color.Black;
            frm_Dark.Opacity = 0;
            frm_Calendar frm = new frm_Calendar();
            frm.DateSelected += new frm_Calendar.SelectDateHandler(frm_DateSelected);
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            //frm.OpacityFulled += new EventHandler(frm_OpacityFulled);
            frm.TimerTick += new EventHandler(frm_TimerTick);
            frm.Date = this.Value.ToString();
            int_Left = 0;
            int_Top = 0;
            int_Left = this.Left;
            int_Top = this.Top + this.Height;
            Control p = this.Parent;
            while (p is Panel || p is GroupBox || p is TabControl)
            {
                int_Left += p.Left;
                int_Top += p.Top;
                p = p.Parent;
            }

            frm_Dark.Size = frm.Size;
            frm_Dark.Show();
            frm.Show();
            frm.BringToFront();

            if (this.FindForm().Top + int_Top > 500)
            {
                frm_Dark.Top =this.FindForm().Top +int_Top - frm.Size.Height;
                frm.Top = this.FindForm().Top +int_Top - frm.Size.Height;
            }
            else
            {
                frm_Dark.Top = int_Top + this.FindForm().Top + this.Height + 11;
                frm.Top = int_Top + this.FindForm().Top + this.Height + 8;
            }
            frm_Dark.Left = int_Left + this.FindForm().Left - this.Width - 28;
            frm.Left = int_Left + this.FindForm().Left - this.Width - 25;
        }

        void frm_TimerTick(object sender, EventArgs e)
        {
            frm_Dark.Opacity += .009;
        }

        void frm_OpacityFulled(object sender, EventArgs e)
        {
            frm_Dark.Opacity = .15;
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_Dark.Close();
        }

        int int_Top;

        int int_Left;

        private void CalculatePosition(Control C)
        {
            while (C.Parent != null)
            {
                int_Top += C.Top + C.Height;
                int_Left += C.Left;
                C = C.Parent;
                CalculatePosition(C);
            }

        }

        void frm_DateSelected(string Date)
        {
            this.Value = Date;
        }

        #endregion

        public string GetPersianDate(DateTime DT)
        {
            string str_Date;
            PersianCalendar Pc = new PersianCalendar();
            try
            {
                str_Date = Pc.GetYear(DT).ToString() + "/" + Convert.ToString(Pc.GetMonth(DT)).PadLeft(2, '0') + "/" + Convert.ToString(Pc.GetDayOfMonth(DT)).PadLeft(2, '0');
                return str_Date;
            }
            catch
            {
                return "";
            }
        }

        private DateTime GetGregorianDate(string str_PersianDate)
        {
            PersianCalendar pc = new PersianCalendar();
            int int_Year = int.Parse(str_PersianDate.Substring(0, 4));
            int int_Month = int.Parse(str_PersianDate.Substring(5, 2));
            int int_Day = int.Parse(str_PersianDate.Substring(8, 2));
            return pc.ToDateTime(int_Year, int_Month, int_Day, 0, 0, 0, 0);
        }

        public static string SpellDate(string Date)
        {
            string str_Date = Date;
            if (string.IsNullOrEmpty(str_Date.Trim()))
            {
               // if (ctrl_Spell != null)
                    return "";
            }
            string str_Year, str_Month, str_Day;
            string str_Spelled = "";

            str_Year = str_Date.Split('/')[0];
            str_Month = str_Date.Split('/')[1];
            str_Day = str_Date.Split('/')[2];

            switch (int.Parse(str_Day))
            {
                case 3:
                    {
                        str_Spelled += "سوم ";
                        break;
                    }
                case 30:
                    {
                        str_Spelled += "سی ام ";
                        break;
                    }
                default:
                    {
                        str_Spelled += SpellMoney(str_Day);
                        str_Spelled += "م ";
                        break;
                    }
            }


            switch (int.Parse(str_Month))
            {
                case 1:
                    {
                        str_Month = "فروردین";
                        break;
                    }
                case 2:
                    {
                        str_Month = "اردیبهشت";
                        break;
                    }
                case 3:
                    {
                        str_Month = "خرداد";
                        break;
                    }
                case 4:
                    {
                        str_Month = "تیر";
                        break;
                    }
                case 5:
                    {
                        str_Month = "مرداد";
                        break;
                    }
                case 6:
                    {
                        str_Month = "شهریور";
                        break;
                    }
                case 7:
                    {
                        str_Month = "مهر";
                        break;
                    }
                case 8:
                    {
                        str_Month = "آبان";
                        break;
                    }
                case 9:
                    {
                        str_Month = "آذر";
                        break;
                    }
                case 10:
                    {
                        str_Month = "دی";
                        break;
                    }
                case 11:
                    {
                        str_Month = "بهمن";
                        break;
                    }
                case 12:
                    {
                        str_Month = "اسفند";
                        break;
                    }

            }
            str_Spelled += str_Month;
            str_Spelled += " ماه ";

            str_Spelled += SpellMoney(str_Year);

            return str_Spelled;
        }

        private static string Spell(string Amnt)
        {
            string Spl = "";

            switch (Amnt[0])
            {
                case '1':
                    {
                        Spl = Spl + "یکصد";
                        break;
                    }
                case '2':
                    {
                        Spl = Spl + "دویست";
                        break;
                    }
                case '3':
                    {
                        Spl = Spl + "سیصد";
                        break;
                    }
                case '4':
                    {
                        Spl = Spl + "چهارصد";
                        break;
                    }
                case '5':
                    {
                        Spl = Spl + "پانصد";
                        break;
                    }
                case '6':
                    {
                        Spl = Spl + "ششصد";
                        break;
                    }
                case '7':
                    {
                        Spl = Spl + "هفتصد";
                        break;
                    }
                case '8':
                    {
                        Spl = Spl + "هشتصد";
                        break;
                    }
                case '9':
                    {
                        Spl = Spl + "نهصد";
                        break;
                    }
            }
            if (Spl.Length > 1 && Amnt[1] != '0') Spl = Spl + " و ";
            switch (Amnt[1])
            {
                case '1':
                    {
                        if (Amnt[2] == '0') Spl = Spl + "ده";
                        else
                        {
                            switch (Amnt[2])
                            {
                                case '1':
                                    {
                                        Spl = Spl + "یازده";
                                        break;
                                    }
                                case '2':
                                    {
                                        Spl = Spl + "دوازده";
                                        break;
                                    }
                                case '3':
                                    {
                                        Spl = Spl + "سیزده";
                                        break;
                                    }
                                case '4':
                                    {
                                        Spl = Spl + "چهارده";
                                        break;
                                    }
                                case '5':
                                    {
                                        Spl = Spl + "پانزده";
                                        break;
                                    }
                                case '6':
                                    {
                                        Spl = Spl + "شانزده";
                                        break;
                                    }
                                case '7':
                                    {
                                        Spl = Spl + "هفده";
                                        break;
                                    }
                                case '8':
                                    {
                                        Spl = Spl + "هجده";
                                        break;
                                    }
                                case '9':
                                    {
                                        Spl = Spl + "نوزده";
                                        break;
                                    }

                            }
                            return Spl;

                        }
                        break;
                    }
                case '2':
                    {
                        Spl = Spl + "بیست";
                        break;
                    }
                case '3':
                    {
                        Spl = Spl + "سی";
                        break;
                    }
                case '4':
                    {
                        Spl = Spl + "چهل";
                        break;
                    }
                case '5':
                    {
                        Spl = Spl + "پنجاه";
                        break;
                    }
                case '6':
                    {
                        Spl = Spl + "شصت";
                        break;
                    }
                case '7':
                    {
                        Spl = Spl + "هفتاد";
                        break;
                    }
                case '8':
                    {
                        Spl = Spl + "هشتاد";
                        break;
                    }
                case '9':
                    {
                        Spl = Spl + "نود";
                        break;
                    }
            }
            if ((Spl.Length >= 2) && (Amnt[2] != '0')) Spl = Spl + " و ";

            switch (Amnt[2])
            {
                case '1':
                    {
                        Spl = Spl + "یک";
                        break;
                    }
                case '2':
                    {
                        Spl = Spl + "دو";
                        break;
                    }
                case '3':
                    {
                        Spl = Spl + "سه";
                        break;
                    }
                case '4':
                    {
                        Spl = Spl + "چهار";
                        break;
                    }
                case '5':
                    {
                        Spl = Spl + "پنج";
                        break;
                    }
                case '6':
                    {
                        Spl = Spl + "شش";
                        break;
                    }
                case '7':
                    {
                        Spl = Spl + "هفت";
                        break;
                    }
                case '8':
                    {
                        Spl = Spl + "هشت";
                        break;
                    }
                case '9':
                    {
                        Spl = Spl + "نه";
                        break;
                    }
            }
            return Spl;

        }

        public static string SpellMoney(string Amnt)
        {
            if (string.IsNullOrEmpty(Amnt)) return "";
            string Spl = "";
            long lng_value = 0;
            if (!long.TryParse((Amnt).ToString(), out lng_value) || lng_value == 0)
                return "صفر";
            else
                Amnt = long.Parse(Amnt).ToString();

            int a = Amnt.Length % 3;
            while (a != 0)
            {
                Amnt = "0" + Amnt;
                a = Amnt.Length % 3;
            }
            String[] _Dec = new String[6] { "", "هزار", "میلیون", "میلیارد", "تریلیون", "تریلیارد" };
            String[] Dec = new String[6] { "", "", "", "", "", "" };

            switch (Amnt.Length / 3)
            {
                case 1:
                    {
                        Dec[0] = "";
                        break;
                    }
                case 2:
                    {
                        Dec[0] = "هزار";
                        Dec[1] = "";
                        break;
                    }
                case 3:
                    {
                        Dec[0] = "میلیون";
                        Dec[1] = "هزار";
                        Dec[2] = "";
                        break;
                    }
                case 4:
                    {
                        Dec[0] = "میلیارد";
                        Dec[1] = "میلیون";
                        Dec[2] = "هزار";
                        Dec[3] = "";
                        break;
                    }
                case 5:
                    {
                        Dec[0] = "تریلیون";
                        Dec[1] = "میلیارد";
                        Dec[2] = "میلیون";
                        Dec[3] = "هزار";
                        Dec[4] = "";
                        break;
                    }
                case 6:
                    {
                        Dec[0] = "تریلیارد";
                        Dec[1] = "تریلیون";
                        Dec[2] = "میلیارد";
                        Dec[3] = "میلیون";
                        Dec[4] = "هزار";
                        Dec[5] = "";
                        break;
                    }
            }

            int j = 0;
            for (int i = 0; i < Amnt.Length; i = i + 3)
            {
                Spl = Spl + Spell(Amnt.Substring(i, 3));

                if (Amnt.Substring(i, 3) != "000") Spl = Spl + " " + Dec[j];

                if (i + 3 != Amnt.Length && Amnt.Substring(i + 3, 3) != "000")
                    Spl = Spl + " و ";
                j++;
            }
            return Spl.Trim();
        }

        private void SetTextOfSpellControl()
        {
            if (ctrl_Spell == null) return;
            switch (_Type)
            {
                case TypeOfValues.Date:
                    if (Value != null)
                        ctrl_Spell.Text = SpellDate(Value.ToString());
                    break;
                case TypeOfValues.Currency:
                    if ((long)this.Value == 0)
                        ctrl_Spell.Text = "";
                    else
                        ctrl_Spell.Text = SpellMoney(this.Text.Replace(",", "")) + " " + str_CurrencyUnit;
                    break;
            }
        }

        public static string GetFarsiDate(DateTime DT)
        {
            string str_Date;
            PersianCalendar Pc = new PersianCalendar();
            try
            {
                str_Date = Pc.GetYear(DT).ToString() + "/" + Pc.GetMonth(DT).ToString().PadLeft(2, '0') + "/" + Pc.GetDayOfMonth(DT).ToString().PadLeft(2, '0');
                return str_Date;
            }
            catch
            {
                return "";
            }
        }

        public new void Clear()
        {
            base.Clear();
            if (_Type == TypeOfValues.Date)
            {
                try
                {
                    txt_Day.Text = txt_Month.Text = txt_Year.Text = "";
                }
                catch { }
            }
        }

        private void ConvertToPelak()
        {
            this.txt_Num1 = new TextBox();
            this.txt_Letter = new TextBox();
            this.txt_Letter.KeyPress += new KeyPressEventHandler(txt_Letter_KeyPress);
            this.txt_Num2 = new TextBox();
            this.txt_City = new TextBox();
            this.SuspendLayout();
            this.txt_Num1.BorderStyle = BorderStyle.None;
            this.txt_Num1.CurrencyUnit = "ریال";
            this.txt_Num1.IsRequired = false;
            this.txt_Num1.Location = new Point(0, 1);
            this.txt_Num1.Margin = new Padding(3, 4, 3, 4);
            this.txt_Num1.MaxDecimalLength = 2;
            this.txt_Num1.MaxLength = 2;
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.RightToLeft = RightToLeft.Yes;
            this.txt_Num1.Size = new Size(0x17, 0x10);
            this.txt_Num1.SpellControl = null;
            this.txt_Num1.TabIndex = 0;
            this.txt_Num1.TextAlign = HorizontalAlignment.Center;
            this.txt_Num1.Title = null;
            this.txt_Num1.TypeOfContains = TypeOfValues.Number;
            this.txt_Num1.UseForData = true;
            this.txt_Num1.Value = 0;
            this.txt_Num1.TextChanged += new EventHandler(txt_Num1_TextChanged);
            this.txt_Letter.BorderStyle = BorderStyle.None;
            this.txt_Letter.CurrencyUnit = "ریال";
            this.txt_Letter.IsRequired = false;
            this.txt_Letter.Location = new Point(0x17, 1);
            this.txt_Letter.Margin = new Padding(3, 4, 3, 4);
            this.txt_Letter.MaxDecimalLength = 2;
            this.txt_Letter.MaxLength = 1;
            this.txt_Letter.Name = "txt_Letter";
            this.txt_Letter.RightToLeft = RightToLeft.Yes;
            this.txt_Letter.Size = new Size(0x17, 0x10);
            this.txt_Letter.SpellControl = null;
            this.txt_Letter.TabIndex = 1;
            this.txt_Letter.TextAlign = HorizontalAlignment.Center;
            this.txt_Letter.Title = null;
            this.txt_Letter.TypeOfContains = TypeOfValues.PersianText;
            this.txt_Letter.UseForData = true;
            this.txt_Letter.Value = "";
            this.txt_Letter.TextChanged += new EventHandler(txt_Letter_TextChanged);
            this.txt_Num2.BorderStyle = BorderStyle.None;
            this.txt_Num2.CurrencyUnit = "ریال";
            this.txt_Num2.IsRequired = false;
            this.txt_Num2.Location = new Point(0x2e, 1);
            this.txt_Num2.Margin = new Padding(3, 4, 3, 4);
            this.txt_Num2.MaxDecimalLength = 3;
            this.txt_Num2.MaxLength = 3;
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.RightToLeft = RightToLeft.Yes;
            this.txt_Num2.Size = new Size(30, 0x10);
            this.txt_Num2.SpellControl = null;
            this.txt_Num2.TabIndex = 2;
            this.txt_Num2.TextAlign = HorizontalAlignment.Center;
            this.txt_Num2.Title = null;
            this.txt_Num2.TypeOfContains = TypeOfValues.Number;
            this.txt_Num2.UseForData = true;
            this.txt_Num2.Value = 0;
            this.txt_Num2.TextChanged += new EventHandler(txt_Num2_TextChanged);
            this.txt_City.BorderStyle = BorderStyle.None;
            this.txt_City.CurrencyUnit = "ریال";
            this.txt_City.IsRequired = false;
            this.txt_City.Location = new Point(0x4c, 1);
            this.txt_City.Margin = new Padding(3, 4, 3, 4);
            this.txt_City.MaxDecimalLength = 2;
            this.txt_City.MaxLength = 2;
            this.txt_City.Name = "txt_City";
            this.txt_City.RightToLeft = RightToLeft.Yes;
            this.txt_City.Size = new Size(0x13, 0x10);
            this.txt_City.SpellControl = null;
            this.txt_City.TabIndex = 3;
            this.txt_City.TextAlign = HorizontalAlignment.Center;
            this.txt_City.Title = null;
            this.txt_City.TypeOfContains = TypeOfValues.Number;
            this.txt_City.UseForData = true;
            this.txt_City.Value = 0;
            this.txt_City.TextChanged += new EventHandler(txt_City_TextChanged);
            this.BackColor = SystemColors.Window;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Letter);
            this.Controls.Add(this.txt_Num1);
            this.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xb2);
            this.Margin = new Padding(3, 4, 3, 4); ;
            this.Name = "PelakBox";
            this.ResumeLayout(false);
            this.PerformLayout();
        }



        #endregion
    }
}
