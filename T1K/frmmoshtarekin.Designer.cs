
namespace T1K
{
    partial class frmmoshtarekin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmoshtarekin));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.moshtarekin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_codmeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_timeend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarekin_timeago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblbooks = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.spanel = new System.Windows.Forms.Panel();
            this.btncancles = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.namaieshy = new System.Windows.Forms.Button();
            this.tols = new System.Windows.Forms.Panel();
            this.cmoago = new System.Windows.Forms.ComboBox();
            this.days = new BehComponents.DateTimePickerX();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodemeli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfamily = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.day = new BehComponents.MonthCalendarX();
            this.btnshowall = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.spanel.SuspendLayout();
            this.tols.SuspendLayout();
            this.SuspendLayout();
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
            this.moshtarekin_id,
            this.moshtarekin_name,
            this.moshtarekin_family,
            this.moshtarekin_number,
            this.moshtarekin_age,
            this.moshtarekin_codmeli,
            this.moshtarekin_start,
            this.moshtarekin_timeend,
            this.moshtarekin_timeago,
            this.book_name});
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
            this.dataGridView.Location = new System.Drawing.Point(9, 83);
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
            this.dataGridView.Size = new System.Drawing.Size(1400, 560);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // moshtarekin_id
            // 
            this.moshtarekin_id.DataPropertyName = "moshtarekin_id";
            this.moshtarekin_id.HeaderText = "moshtarekin_id";
            this.moshtarekin_id.MinimumWidth = 6;
            this.moshtarekin_id.Name = "moshtarekin_id";
            this.moshtarekin_id.ReadOnly = true;
            this.moshtarekin_id.Visible = false;
            // 
            // moshtarekin_name
            // 
            this.moshtarekin_name.DataPropertyName = "moshtarekin_name";
            this.moshtarekin_name.FillWeight = 14F;
            this.moshtarekin_name.HeaderText = "نام";
            this.moshtarekin_name.MinimumWidth = 6;
            this.moshtarekin_name.Name = "moshtarekin_name";
            this.moshtarekin_name.ReadOnly = true;
            // 
            // moshtarekin_family
            // 
            this.moshtarekin_family.DataPropertyName = "moshtarekin_family";
            this.moshtarekin_family.FillWeight = 18F;
            this.moshtarekin_family.HeaderText = "فامیل";
            this.moshtarekin_family.MinimumWidth = 6;
            this.moshtarekin_family.Name = "moshtarekin_family";
            this.moshtarekin_family.ReadOnly = true;
            // 
            // moshtarekin_number
            // 
            this.moshtarekin_number.DataPropertyName = "moshtarekin_number";
            this.moshtarekin_number.FillWeight = 19F;
            this.moshtarekin_number.HeaderText = "شماره موبایل";
            this.moshtarekin_number.MinimumWidth = 6;
            this.moshtarekin_number.Name = "moshtarekin_number";
            this.moshtarekin_number.ReadOnly = true;
            // 
            // moshtarekin_age
            // 
            this.moshtarekin_age.DataPropertyName = "moshtarekin_age";
            this.moshtarekin_age.FillWeight = 7F;
            this.moshtarekin_age.HeaderText = "سن";
            this.moshtarekin_age.MinimumWidth = 6;
            this.moshtarekin_age.Name = "moshtarekin_age";
            this.moshtarekin_age.ReadOnly = true;
            // 
            // moshtarekin_codmeli
            // 
            this.moshtarekin_codmeli.DataPropertyName = "moshtarekin_codmeli";
            this.moshtarekin_codmeli.FillWeight = 16F;
            this.moshtarekin_codmeli.HeaderText = "کد ملی";
            this.moshtarekin_codmeli.MinimumWidth = 6;
            this.moshtarekin_codmeli.Name = "moshtarekin_codmeli";
            this.moshtarekin_codmeli.ReadOnly = true;
            // 
            // moshtarekin_start
            // 
            this.moshtarekin_start.DataPropertyName = "moshtarekin_start";
            this.moshtarekin_start.FillWeight = 18F;
            this.moshtarekin_start.HeaderText = "زمان شروع اشتراک";
            this.moshtarekin_start.MinimumWidth = 6;
            this.moshtarekin_start.Name = "moshtarekin_start";
            this.moshtarekin_start.ReadOnly = true;
            // 
            // moshtarekin_timeend
            // 
            this.moshtarekin_timeend.DataPropertyName = "moshtarekin_timeend";
            this.moshtarekin_timeend.FillWeight = 18F;
            this.moshtarekin_timeend.HeaderText = "زمان پایان اشتراک";
            this.moshtarekin_timeend.Name = "moshtarekin_timeend";
            this.moshtarekin_timeend.ReadOnly = true;
            // 
            // moshtarekin_timeago
            // 
            this.moshtarekin_timeago.DataPropertyName = "moshtarekin_timeago";
            this.moshtarekin_timeago.FillWeight = 6F;
            this.moshtarekin_timeago.HeaderText = "روز";
            this.moshtarekin_timeago.MinimumWidth = 6;
            this.moshtarekin_timeago.Name = "moshtarekin_timeago";
            this.moshtarekin_timeago.ReadOnly = true;
            // 
            // book_name
            // 
            this.book_name.DataPropertyName = "book_name";
            this.book_name.FillWeight = 16F;
            this.book_name.HeaderText = "کتاب";
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            // 
            // lblbooks
            // 
            this.lblbooks.AutoSize = true;
            this.lblbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbooks.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblbooks.Location = new System.Drawing.Point(-2, 3);
            this.lblbooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbooks.Name = "lblbooks";
            this.lblbooks.Size = new System.Drawing.Size(103, 37);
            this.lblbooks.TabIndex = 4;
            this.lblbooks.Text = "مشترکین";
            this.lblbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(1383, 1);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 37);
            this.btnclose.TabIndex = 5;
            this.btnclose.TabStop = false;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            this.btnclose.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            // 
            // btnmini
            // 
            this.btnmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmini.BackgroundImage = global::T1K.Properties.Resources.Ellipse_7;
            this.btnmini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmini.FlatAppearance.BorderSize = 0;
            this.btnmini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmini.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmini.Location = new System.Drawing.Point(1356, 6);
            this.btnmini.Margin = new System.Windows.Forms.Padding(2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(26, 28);
            this.btnmini.TabIndex = 6;
            this.btnmini.TabStop = false;
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            this.btnmini.MouseEnter += new System.EventHandler(this.btnmini_MouseEnter);
            this.btnmini.MouseLeave += new System.EventHandler(this.btnmini_MouseLeave);
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = global::T1K.Properties.Resources.flipedshow;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(104, 6);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(68, 73);
            this.btnshow.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnshow, "ابزار ها");
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnadd);
            this.panel.Controls.Add(this.btnedit);
            this.panel.Controls.Add(this.btndelete);
            this.panel.Controls.Add(this.btnsearch);
            this.panel.Location = new System.Drawing.Point(215, 433);
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
            this.toolTip.SetToolTip(this.btnadd, "جدید");
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
            this.toolTip.SetToolTip(this.btnedit, "ویرایش");
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
            this.toolTip.SetToolTip(this.btndelete, "حذف");
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
            this.toolTip.SetToolTip(this.btnsearch, "جست و جو");
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // spanel
            // 
            this.spanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spanel.Controls.Add(this.btncancles);
            this.spanel.Controls.Add(this.txtsearch);
            this.spanel.Controls.Add(this.namaieshy);
            this.spanel.Location = new System.Drawing.Point(788, 281);
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
            this.txtsearch.MaxLength = 30;
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
            this.namaieshy.UseVisualStyleBackColor = true;
            // 
            // tols
            // 
            this.tols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.tols.Controls.Add(this.cmoago);
            this.tols.Controls.Add(this.days);
            this.tols.Controls.Add(this.label6);
            this.tols.Controls.Add(this.txtcodemeli);
            this.tols.Controls.Add(this.label5);
            this.tols.Controls.Add(this.txtname);
            this.tols.Controls.Add(this.txtage);
            this.tols.Controls.Add(this.txtfamily);
            this.tols.Controls.Add(this.txtnumber);
            this.tols.Controls.Add(this.label4);
            this.tols.Controls.Add(this.label7);
            this.tols.Controls.Add(this.label1);
            this.tols.Controls.Add(this.label2);
            this.tols.Controls.Add(this.label3);
            this.tols.Controls.Add(this.btncancle);
            this.tols.Controls.Add(this.btnsave);
            this.tols.Location = new System.Drawing.Point(184, 11);
            this.tols.Name = "tols";
            this.tols.Size = new System.Drawing.Size(1161, 66);
            this.tols.TabIndex = 3;
            // 
            // cmoago
            // 
            this.cmoago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmoago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.cmoago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoago.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmoago.ForeColor = System.Drawing.Color.Black;
            this.cmoago.FormattingEnabled = true;
            this.cmoago.Items.AddRange(new object[] {
            "۱ماهه",
            "۲ماهه",
            "۳ماهه"});
            this.cmoago.Location = new System.Drawing.Point(44, 20);
            this.cmoago.Name = "cmoago";
            this.cmoago.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmoago.Size = new System.Drawing.Size(150, 37);
            this.cmoago.TabIndex = 6;
            this.cmoago.SelectedIndexChanged += new System.EventHandler(this.cmoago_SelectedIndexChanged);
            this.cmoago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmoago_KeyDown);
            // 
            // days
            // 
            this.days.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.days.AnchorSize = new System.Drawing.Size(147, 36);
            this.days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
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
            this.days.ForeColor = System.Drawing.Color.White;
            this.days.Format = BehComponents.DateTimePickerX.FormatDate.Short;
            this.days.Format4Binding = "yyyy/MM/dd";
            this.days.Location = new System.Drawing.Point(200, 21);
            this.days.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.days.Name = "days";
            this.days.RightToLeftLayout = true;
            this.days.ShowClearButton = false;
            this.days.Size = new System.Drawing.Size(147, 36);
            this.days.TabIndex = 5;
            this.days.TabStop = false;
            this.days.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.days.TextWhenClearButtonClicked = "";
            this.days.SelectedDateChanged += new BehComponents.DateTimePickerX.OnSelectedDateChanged(this.days_SelectedDateChanged);
            this.days.KeyDown += new System.Windows.Forms.KeyEventHandler(this.days_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "زمان شروع اشتراک";
            // 
            // txtcodemeli
            // 
            this.txtcodemeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcodemeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtcodemeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodemeli.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodemeli.ForeColor = System.Drawing.Color.White;
            this.txtcodemeli.Location = new System.Drawing.Point(353, 21);
            this.txtcodemeli.MaxLength = 10;
            this.txtcodemeli.Name = "txtcodemeli";
            this.txtcodemeli.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcodemeli.Size = new System.Drawing.Size(166, 36);
            this.txtcodemeli.TabIndex = 4;
            this.txtcodemeli.TextChanged += new System.EventHandler(this.txtcodemeli_TextChanged);
            this.txtcodemeli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodemeli_KeyDown);
            this.txtcodemeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodemeli_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "کد ملی";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(981, 21);
            this.txtname.MaxLength = 100;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(138, 36);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // txtage
            // 
            this.txtage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtage.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.Color.White;
            this.txtage.Location = new System.Drawing.Point(526, 21);
            this.txtage.MaxLength = 3;
            this.txtage.Name = "txtage";
            this.txtage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtage.Size = new System.Drawing.Size(72, 36);
            this.txtage.TabIndex = 3;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            this.txtage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtage_KeyDown);
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            // 
            // txtfamily
            // 
            this.txtfamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtfamily.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtfamily.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfamily.ForeColor = System.Drawing.Color.White;
            this.txtfamily.Location = new System.Drawing.Point(804, 21);
            this.txtfamily.MaxLength = 150;
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfamily.Size = new System.Drawing.Size(170, 36);
            this.txtfamily.TabIndex = 1;
            this.txtfamily.TextChanged += new System.EventHandler(this.txtfamily_TextChanged);
            this.txtfamily.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfamily_KeyDown);
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnumber.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumber.ForeColor = System.Drawing.Color.White;
            this.txtnumber.Location = new System.Drawing.Point(605, 21);
            this.txtnumber.MaxLength = 14;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnumber.Size = new System.Drawing.Size(192, 36);
            this.txtnumber.TabIndex = 2;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            this.txtnumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnumber_KeyDown);
            this.txtnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumber_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1076, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 1);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "اشتراک";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(557, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "سن";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(710, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "شماره موبایل";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(917, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "فامیل";
            // 
            // btncancle
            // 
            this.btncancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancle.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Location = new System.Drawing.Point(5, 15);
            this.btncancle.Margin = new System.Windows.Forms.Padding(2);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(34, 37);
            this.btncancle.TabIndex = 8;
            this.btncancle.TabStop = false;
            this.toolTip.SetToolTip(this.btncancle, "بستن");
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
            this.btnsave.Location = new System.Drawing.Point(1122, 13);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(34, 37);
            this.btnsave.TabIndex = 7;
            this.btnsave.TabStop = false;
            this.toolTip.SetToolTip(this.btnsave, "ثبت");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // day
            // 
            this.day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.day.BoldedDayForeColor = System.Drawing.Color.White;
            this.day.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(53)))), ((int)(((byte)(229)))));
            this.day.CalendarType = BehComponents.CalendarTypes.Persian;
            this.day.DayRectTickness = 2F;
            this.day.DaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(53)))), ((int)(((byte)(229)))));
            this.day.DaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.DaysForeColor = System.Drawing.Color.White;
            this.day.EnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.day.EnglishBoldedDates = new System.DateTime[0];
            this.day.EnglishHolidayDates = new System.DateTime[0];
            this.day.EnglishMonthlyBoldedDates = new System.DateTime[0];
            this.day.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.HolidayForeColor = System.Drawing.Color.Snow;
            this.day.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.day.LineWeekColor = System.Drawing.Color.Black;
            this.day.Location = new System.Drawing.Point(515, 286);
            this.day.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.day.Name = "day";
            this.day.PersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.day.PersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.day.PersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.day.PersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.day.ShowToday = true;
            this.day.ShowTodayRect = true;
            this.day.ShowToolTips = false;
            this.day.ShowTrailing = true;
            this.day.Size = new System.Drawing.Size(201, 251);
            this.day.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.day.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.System;
            this.day.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.System;
            this.day.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.day.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.day.Style_YearButton = BehComponents.ButtonX.ButtonStyles.System;
            this.day.TabIndex = 15;
            this.day.TabStop = false;
            this.day.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(53)))), ((int)(((byte)(229)))));
            this.day.TitleFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.TitleForeColor = System.Drawing.Color.Black;
            this.day.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(238)))), ((int)(((byte)(234)))));
            this.day.TodayFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.TodayForeColor = System.Drawing.Color.Black;
            this.day.TodayRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(217)))), ((int)(((byte)(169)))));
            this.day.TodayRectTickness = 2F;
            this.day.TrailingForeColor = System.Drawing.Color.DimGray;
            this.day.WeekDaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(217)))), ((int)(((byte)(169)))));
            this.day.WeekDaysFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.WeekDaysForeColor = System.Drawing.Color.Black;
            this.day.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
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
            this.btnshowall.Location = new System.Drawing.Point(1334, 60);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 5;
            this.btnshowall.Text = "نمایش همه";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 200;
            // 
            // frmmoshtarekin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1420, 659);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.day);
            this.Controls.Add(this.tols);
            this.Controls.Add(this.spanel);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblbooks);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 200);
            this.Name = "frmmoshtarekin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmmoshtarekin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmoshtarekin_FormClosing);
            this.Load += new System.EventHandler(this.frmmoshtarekin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmmoshtarekin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.spanel.ResumeLayout(false);
            this.spanel.PerformLayout();
            this.tols.ResumeLayout(false);
            this.tols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Label lblbooks;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Button btnmini;
        public System.Windows.Forms.Button btnshow;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnsearch;
        public System.Windows.Forms.Panel spanel;
        public System.Windows.Forms.Button btncancles;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.Button namaieshy;
        private System.Windows.Forms.Panel tols;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtcodemeli;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtage;
        public System.Windows.Forms.TextBox txtfamily;
        public System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btncancle;
        public System.Windows.Forms.Button btnsave;
        private BehComponents.MonthCalendarX day;
        private System.Windows.Forms.Button btnshowall;
        public BehComponents.DateTimePickerX days;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_codmeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_timeend;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarekin_timeago;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.ComboBox cmoago;
        private System.Windows.Forms.ToolTip toolTip;
    }
}