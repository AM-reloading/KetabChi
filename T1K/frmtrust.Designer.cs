
namespace T1K
{
    partial class frmtrust
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtrust));
            this.cmobook = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.trust_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trust_mokhatabin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trust_book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trust_timestart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trust_timeend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trust_later = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblbooks = new System.Windows.Forms.Label();
            this.tols = new System.Windows.Forms.Panel();
            this.days = new BehComponents.DateTimePickerX();
            this.cmomoshtarekin = new System.Windows.Forms.ComboBox();
            this.txtlater = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.spanel = new System.Windows.Forms.Panel();
            this.btncancles = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.namaieshy = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tols.SuspendLayout();
            this.spanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmobook
            // 
            this.cmobook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmobook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.cmobook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmobook.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmobook.ForeColor = System.Drawing.Color.White;
            this.cmobook.FormattingEnabled = true;
            this.cmobook.Location = new System.Drawing.Point(373, 20);
            this.cmobook.Name = "cmobook";
            this.cmobook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmobook.Size = new System.Drawing.Size(236, 39);
            this.cmobook.TabIndex = 1;
            this.cmobook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmobook_KeyDown);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trust_id,
            this.trust_mokhatabin_id,
            this.trust_book_id,
            this.trust_timestart,
            this.trust_timeend,
            this.trust_later});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.Red;
            this.dataGridView.Location = new System.Drawing.Point(11, 85);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(211)))), ((int)(((byte)(121)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.RowTemplate.ReadOnly = true;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(1470, 661);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // trust_id
            // 
            this.trust_id.DataPropertyName = "trust_id";
            this.trust_id.HeaderText = "trust_id";
            this.trust_id.Name = "trust_id";
            this.trust_id.ReadOnly = true;
            this.trust_id.Visible = false;
            // 
            // trust_mokhatabin_id
            // 
            this.trust_mokhatabin_id.DataPropertyName = "trust_moshtarekin";
            this.trust_mokhatabin_id.FillWeight = 115F;
            this.trust_mokhatabin_id.HeaderText = "مشترکین";
            this.trust_mokhatabin_id.Name = "trust_mokhatabin_id";
            this.trust_mokhatabin_id.ReadOnly = true;
            // 
            // trust_book_id
            // 
            this.trust_book_id.DataPropertyName = "trust_books";
            this.trust_book_id.FillWeight = 90F;
            this.trust_book_id.HeaderText = "کتاب ها";
            this.trust_book_id.Name = "trust_book_id";
            this.trust_book_id.ReadOnly = true;
            // 
            // trust_timestart
            // 
            this.trust_timestart.DataPropertyName = "trust_timestart";
            this.trust_timestart.FillWeight = 90F;
            this.trust_timestart.HeaderText = "زمان تحویل";
            this.trust_timestart.Name = "trust_timestart";
            this.trust_timestart.ReadOnly = true;
            // 
            // trust_timeend
            // 
            this.trust_timeend.DataPropertyName = "trust_timeend";
            this.trust_timeend.FillWeight = 90F;
            this.trust_timeend.HeaderText = "زمان دریافت";
            this.trust_timeend.Name = "trust_timeend";
            this.trust_timeend.ReadOnly = true;
            // 
            // trust_later
            // 
            this.trust_later.DataPropertyName = "trust_later";
            this.trust_later.FillWeight = 70F;
            this.trust_later.HeaderText = "مهلت باقی مانده";
            this.trust_later.Name = "trust_later";
            this.trust_later.ReadOnly = true;
            // 
            // lblbooks
            // 
            this.lblbooks.AutoSize = true;
            this.lblbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbooks.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblbooks.Location = new System.Drawing.Point(-2, 3);
            this.lblbooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbooks.Name = "lblbooks";
            this.lblbooks.Size = new System.Drawing.Size(81, 37);
            this.lblbooks.TabIndex = 16;
            this.lblbooks.Text = "امانات";
            this.lblbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tols
            // 
            this.tols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.tols.Controls.Add(this.days);
            this.tols.Controls.Add(this.cmomoshtarekin);
            this.tols.Controls.Add(this.cmobook);
            this.tols.Controls.Add(this.txtlater);
            this.tols.Controls.Add(this.label4);
            this.tols.Controls.Add(this.label1);
            this.tols.Controls.Add(this.label2);
            this.tols.Controls.Add(this.label3);
            this.tols.Controls.Add(this.btncancle);
            this.tols.Controls.Add(this.btnsave);
            this.tols.Location = new System.Drawing.Point(259, 512);
            this.tols.Name = "tols";
            this.tols.Size = new System.Drawing.Size(1006, 66);
            this.tols.TabIndex = 3;
            // 
            // days
            // 
            this.days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.days.AnchorSize = new System.Drawing.Size(224, 38);
            this.days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.days.CalendarBoldedDayForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.days.CalendarBorderColor = System.Drawing.Color.Black;
            this.days.CalendarDayRectTickness = 2F;
            this.days.CalendarDaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.days.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.CalendarDaysForeColor = System.Drawing.Color.White;
            this.days.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.days.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.days.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.days.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.days.CalendarHolidayForeColor = System.Drawing.Color.DimGray;
            this.days.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.days.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.days.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.days.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.days.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.days.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.days.CalendarShowToday = true;
            this.days.CalendarShowTodayRect = true;
            this.days.CalendarShowToolTips = false;
            this.days.CalendarShowTrailing = true;
            this.days.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.days.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.System;
            this.days.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.System;
            this.days.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.days.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.days.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.System;
            this.days.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.days.CalendarTitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.days.CalendarTodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.days.CalendarTodayFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.days.CalendarTodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.days.CalendarTodayRectTickness = 3F;
            this.days.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.days.CalendarType = BehComponents.CalendarTypes.English;
            this.days.CalendarWeekDaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.days.CalendarWeekDaysFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.CalendarWeekDaysForeColor = System.Drawing.Color.Black;
            this.days.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.days.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.days.ClearButtonBackColor = System.Drawing.Color.Magenta;
            this.days.ClearButtonForeColor = System.Drawing.Color.Aqua;
            this.days.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("days.ClearButtonImage")));
            this.days.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.days.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.days.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Stretch;
            this.days.ClearButtonText = "";
            this.days.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.days.ClearButtonToolTip = "";
            this.days.ClearButtonWidth = 17;
            this.days.ClearDateTimeWhenDownDeleteKey = true;
            this.days.CustomFormat = "";
            this.days.DockSide = BehComponents.DropDownEmpty.Alignments.Right;
            this.days.DropDownClosedWhenClickOnDays = false;
            this.days.DropDownClosedWhenSelectedDateChanged = false;
            this.days.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.ForeColor = System.Drawing.Color.Black;
            this.days.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.days.Format4Binding = "yyyy/MM/dd";
            this.days.Location = new System.Drawing.Point(142, 20);
            this.days.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.days.Name = "days";
            this.days.RightToLeftLayout = true;
            this.days.ShowClearButton = false;
            this.days.Size = new System.Drawing.Size(224, 38);
            this.days.TabIndex = 2;
            this.days.TabStop = false;
            this.days.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.days.TextWhenClearButtonClicked = "";
            this.days.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.days_SelectedDateChanged);
            this.days.KeyDown += new System.Windows.Forms.KeyEventHandler(this.days_KeyDown);
            // 
            // cmomoshtarekin
            // 
            this.cmomoshtarekin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmomoshtarekin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.cmomoshtarekin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmomoshtarekin.Font = new System.Drawing.Font("Calibri", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmomoshtarekin.ForeColor = System.Drawing.Color.White;
            this.cmomoshtarekin.FormattingEnabled = true;
            this.cmomoshtarekin.Location = new System.Drawing.Point(616, 20);
            this.cmomoshtarekin.Name = "cmomoshtarekin";
            this.cmomoshtarekin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmomoshtarekin.Size = new System.Drawing.Size(346, 39);
            this.cmomoshtarekin.TabIndex = 0;
            this.cmomoshtarekin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmomoshtarekin_KeyDown);
            // 
            // txtlater
            // 
            this.txtlater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txtlater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlater.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlater.ForeColor = System.Drawing.Color.Black;
            this.txtlater.Location = new System.Drawing.Point(48, 21);
            this.txtlater.MaxLength = 10;
            this.txtlater.Name = "txtlater";
            this.txtlater.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtlater.Size = new System.Drawing.Size(85, 36);
            this.txtlater.TabIndex = 3;
            this.txtlater.TextChanged += new System.EventHandler(this.txtlater_TextChanged);
            this.txtlater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtlater_KeyDown);
            this.txtlater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlater_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(904, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "مشترک";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "مهلت";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "زمان تحویل";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "کتاب";
            // 
            // btncancle
            // 
            this.btncancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancle.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Location = new System.Drawing.Point(7, 20);
            this.btncancle.Margin = new System.Windows.Forms.Padding(2);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(34, 37);
            this.btncancle.TabIndex = 5;
            this.btncancle.TabStop = false;
            this.toolTip1.SetToolTip(this.btncancle, "بستن");
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.BackgroundImage = global::T1K.Properties.Resources.save;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(967, 21);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(34, 37);
            this.btnsave.TabIndex = 4;
            this.btnsave.TabStop = false;
            this.toolTip1.SetToolTip(this.btnsave, "ثبت");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // spanel
            // 
            this.spanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spanel.Controls.Add(this.btncancles);
            this.spanel.Controls.Add(this.txtsearch);
            this.spanel.Controls.Add(this.namaieshy);
            this.spanel.Location = new System.Drawing.Point(844, 24);
            this.spanel.Name = "spanel";
            this.spanel.Size = new System.Drawing.Size(550, 55);
            this.spanel.TabIndex = 4;
            // 
            // btncancles
            // 
            this.btncancles.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancles.FlatAppearance.BorderSize = 0;
            this.btncancles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancles.Location = new System.Drawing.Point(13, 5);
            this.btncancles.Margin = new System.Windows.Forms.Padding(2);
            this.btncancles.Name = "btncancles";
            this.btncancles.Size = new System.Drawing.Size(34, 37);
            this.btncancles.TabIndex = 1;
            this.btncancles.TabStop = false;
            this.btncancles.UseVisualStyleBackColor = true;
            this.btncancles.Click += new System.EventHandler(this.btncancles_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.White;
            this.txtsearch.Location = new System.Drawing.Point(49, 7);
            this.txtsearch.MaxLength = 600;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(455, 36);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            this.txtsearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyUp);
            // 
            // namaieshy
            // 
            this.namaieshy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namaieshy.BackgroundImage = global::T1K.Properties.Resources.search;
            this.namaieshy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.namaieshy.Enabled = false;
            this.namaieshy.FlatAppearance.BorderSize = 0;
            this.namaieshy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namaieshy.Location = new System.Drawing.Point(504, 0);
            this.namaieshy.Margin = new System.Windows.Forms.Padding(2);
            this.namaieshy.Name = "namaieshy";
            this.namaieshy.Size = new System.Drawing.Size(40, 43);
            this.namaieshy.TabIndex = 2;
            this.namaieshy.TabStop = false;
            this.toolTip1.SetToolTip(this.namaieshy, "عبارت مورد نظر خود را در جست و جو کنید");
            this.namaieshy.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnadd);
            this.panel.Controls.Add(this.btnedit);
            this.panel.Controls.Add(this.btndelete);
            this.panel.Controls.Add(this.btnsearch);
            this.panel.Location = new System.Drawing.Point(594, 352);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel.Size = new System.Drawing.Size(184, 49);
            this.panel.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.BackgroundImage = global::T1K.Properties.Resources.Group_1;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(8, 6);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(34, 37);
            this.btnadd.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnadd, "جدید");
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackgroundImage = global::T1K.Properties.Resources.edit;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Location = new System.Drawing.Point(51, 3);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(38, 41);
            this.btnedit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnedit, "ویرایش");
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackgroundImage = global::T1K.Properties.Resources.turch;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(97, 2);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(38, 41);
            this.btndelete.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btndelete, "حذف");
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.BackgroundImage = global::T1K.Properties.Resources.search;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Location = new System.Drawing.Point(140, 3);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(38, 41);
            this.btnsearch.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnsearch, "جست و جو");
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // btnshowall
            // 
            this.btnshowall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshowall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.btnshowall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshowall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.btnshowall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.btnshowall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.btnshowall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnshowall.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.Location = new System.Drawing.Point(1406, 62);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 5;
            this.btnshowall.Text = "نمایش همه";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = global::T1K.Properties.Resources.flipedshow;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(83, 11);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(68, 73);
            this.btnshow.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnshow, "ابزار ها");
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.BackgroundImage = global::T1K.Properties.Resources.Ellipse_7;
            this.btnmini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.Location = new System.Drawing.Point(1430, 8);
            this.btnmini.Margin = new System.Windows.Forms.Padding(2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(26, 28);
            this.btnmini.TabIndex = 15;
            this.btnmini.TabStop = false;
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            this.btnmini.MouseEnter += new System.EventHandler(this.btnmini_MouseEnter);
            this.btnmini.MouseLeave += new System.EventHandler(this.btnmini_MouseLeave);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(1457, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 37);
            this.btnclose.TabIndex = 14;
            this.btnclose.TabStop = false;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.ReshowDelay = 200;
            // 
            // frmtrust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1492, 757);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.spanel);
            this.Controls.Add(this.tols);
            this.Controls.Add(this.lblbooks);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1270, 200);
            this.Name = "frmtrust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmtrust";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmtrust_FormClosing);
            this.Load += new System.EventHandler(this.frmtrust_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmtrust_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tols.ResumeLayout(false);
            this.tols.PerformLayout();
            this.spanel.ResumeLayout(false);
            this.spanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmobook;
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Button btnmini;
        public System.Windows.Forms.Label lblbooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_mokhatabin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_timestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_timeend;
        private System.Windows.Forms.DataGridViewTextBoxColumn trust_later;
        public System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Panel tols;
        public System.Windows.Forms.TextBox txtlater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btncancle;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Panel spanel;
        public System.Windows.Forms.Button btncancles;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.Button namaieshy;
        public System.Windows.Forms.ComboBox cmomoshtarekin;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnsearch;
        public System.Windows.Forms.Timer timer;
        public BehComponents.DateTimePickerX days;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}