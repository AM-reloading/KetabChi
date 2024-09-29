
namespace T1K
{
    partial class frmsetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsetting));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.admin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsetting = new System.Windows.Forms.Label();
            this.tols = new System.Windows.Forms.Panel();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.spanel = new System.Windows.Forms.Panel();
            this.btncancles = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.namaieshy = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.btndata = new System.Windows.Forms.Button();
            this.btnadmins = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.lblcod = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnladmins = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.pnldata = new System.Windows.Forms.Panel();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDeleteDatabase = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btntem4 = new System.Windows.Forms.Button();
            this.btntem3 = new System.Windows.Forms.Button();
            this.btntem2 = new System.Windows.Forms.Button();
            this.btntem1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tols.SuspendLayout();
            this.spanel.SuspendLayout();
            this.panel.SuspendLayout();
            this.pnladmins.SuspendLayout();
            this.pnldata.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admin_id,
            this.admin_user});
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
            this.dataGridView.Location = new System.Drawing.Point(11, 93);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
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
            this.dataGridView.Size = new System.Drawing.Size(688, 533);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.TabStop = false;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // admin_id
            // 
            this.admin_id.DataPropertyName = "admin_id";
            this.admin_id.HeaderText = "asmin_id";
            this.admin_id.Name = "admin_id";
            this.admin_id.ReadOnly = true;
            this.admin_id.Visible = false;
            // 
            // admin_user
            // 
            this.admin_user.DataPropertyName = "admin_user";
            this.admin_user.HeaderText = "کد های ورودی";
            this.admin_user.Name = "admin_user";
            this.admin_user.ReadOnly = true;
            // 
            // lblsetting
            // 
            this.lblsetting.AutoSize = true;
            this.lblsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsetting.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsetting.Location = new System.Drawing.Point(-4, 0);
            this.lblsetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsetting.Name = "lblsetting";
            this.lblsetting.Size = new System.Drawing.Size(108, 37);
            this.lblsetting.TabIndex = 4;
            this.lblsetting.Text = "تنظیمات";
            this.lblsetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tols
            // 
            this.tols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.tols.Controls.Add(this.txtcod);
            this.tols.Controls.Add(this.label4);
            this.tols.Controls.Add(this.btncancle);
            this.tols.Controls.Add(this.btnsave);
            this.tols.Location = new System.Drawing.Point(161, 467);
            this.tols.Name = "tols";
            this.tols.Size = new System.Drawing.Size(467, 66);
            this.tols.TabIndex = 4;
            // 
            // txtcod
            // 
            this.txtcod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcod.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.White;
            this.txtcod.Location = new System.Drawing.Point(45, 21);
            this.txtcod.MaxLength = 50;
            this.txtcod.Name = "txtcod";
            this.txtcod.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcod.Size = new System.Drawing.Size(377, 36);
            this.txtcod.TabIndex = 0;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            this.txtcod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyDown);
            this.txtcod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "کد ورود";
            // 
            // btncancle
            // 
            this.btncancle.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Location = new System.Drawing.Point(8, 20);
            this.btncancle.Margin = new System.Windows.Forms.Padding(2);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(34, 37);
            this.btncancle.TabIndex = 2;
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
            this.btnsave.Location = new System.Drawing.Point(428, 21);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(34, 37);
            this.btnsave.TabIndex = 1;
            this.btnsave.TabStop = false;
            this.toolTip.SetToolTip(this.btnsave, "ثبت");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // spanel
            // 
            this.spanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spanel.Controls.Add(this.btncancles);
            this.spanel.Controls.Add(this.txtsearch);
            this.spanel.Controls.Add(this.namaieshy);
            this.spanel.Location = new System.Drawing.Point(214, 359);
            this.spanel.Name = "spanel";
            this.spanel.Size = new System.Drawing.Size(409, 55);
            this.spanel.TabIndex = 8;
            // 
            // btncancles
            // 
            this.btncancles.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancles.FlatAppearance.BorderSize = 0;
            this.btncancles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancles.Location = new System.Drawing.Point(4, 7);
            this.btncancles.Margin = new System.Windows.Forms.Padding(2);
            this.btncancles.Name = "btncancles";
            this.btncancles.Size = new System.Drawing.Size(34, 37);
            this.btncancles.TabIndex = 2;
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
            this.txtsearch.Location = new System.Drawing.Point(44, 10);
            this.txtsearch.MaxLength = 60;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(316, 36);
            this.txtsearch.TabIndex = 5;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // namaieshy
            // 
            this.namaieshy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.namaieshy.BackgroundImage = global::T1K.Properties.Resources.search;
            this.namaieshy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.namaieshy.Enabled = false;
            this.namaieshy.FlatAppearance.BorderSize = 0;
            this.namaieshy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namaieshy.Location = new System.Drawing.Point(362, 1);
            this.namaieshy.Margin = new System.Windows.Forms.Padding(2);
            this.namaieshy.Name = "namaieshy";
            this.namaieshy.Size = new System.Drawing.Size(40, 43);
            this.namaieshy.TabIndex = 2;
            this.namaieshy.TabStop = false;
            this.namaieshy.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btndata);
            this.panel.Controls.Add(this.btnadmins);
            this.panel.Controls.Add(this.btnsearch);
            this.panel.Location = new System.Drawing.Point(162, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel.Size = new System.Drawing.Size(160, 49);
            this.panel.TabIndex = 2;
            // 
            // btndata
            // 
            this.btndata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.btndata.BackgroundImage = global::T1K.Properties.Resources.bstor;
            this.btndata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndata.FlatAppearance.BorderSize = 0;
            this.btndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndata.Location = new System.Drawing.Point(59, 2);
            this.btndata.Margin = new System.Windows.Forms.Padding(2);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(45, 46);
            this.btndata.TabIndex = 2;
            this.btndata.UseVisualStyleBackColor = false;
            this.btndata.MouseEnter += new System.EventHandler(this.btndata_MouseEnter);
            this.btndata.MouseLeave += new System.EventHandler(this.btndata_MouseLeave);
            // 
            // btnadmins
            // 
            this.btnadmins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.btnadmins.BackgroundImage = global::T1K.Properties.Resources.outline_manage_accounts_black_48dp;
            this.btnadmins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmins.FlatAppearance.BorderSize = 0;
            this.btnadmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmins.Location = new System.Drawing.Point(7, 2);
            this.btnadmins.Margin = new System.Windows.Forms.Padding(2);
            this.btnadmins.Name = "btnadmins";
            this.btnadmins.Size = new System.Drawing.Size(45, 46);
            this.btnadmins.TabIndex = 1;
            this.btnadmins.UseVisualStyleBackColor = false;
            this.btnadmins.MouseEnter += new System.EventHandler(this.btnadmins_MouseEnter);
            this.btnadmins.MouseLeave += new System.EventHandler(this.btnadmins_MouseLeave);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.BackgroundImage = global::T1K.Properties.Resources.search;
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Location = new System.Drawing.Point(114, 3);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(38, 41);
            this.btnsearch.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnsearch, "جست و جو");
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            this.btnshowall.Location = new System.Drawing.Point(624, 70);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 3;
            this.btnshowall.Text = "نمایش همه";
            this.btnshowall.UseVisualStyleBackColor = false;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // lblcod
            // 
            this.lblcod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.Location = new System.Drawing.Point(40, 643);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(243, 78);
            this.lblcod.TabIndex = 12;
            this.lblcod.Text = "admin_cod";
            this.lblcod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lblcod, "کد ورودی ادمین");
            // 
            // pnladmins
            // 
            this.pnladmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            this.pnladmins.Controls.Add(this.btnadd);
            this.pnladmins.Controls.Add(this.btndelete);
            this.pnladmins.Controls.Add(this.btnedit);
            this.pnladmins.Location = new System.Drawing.Point(168, 67);
            this.pnladmins.Name = "pnladmins";
            this.pnladmins.Size = new System.Drawing.Size(46, 150);
            this.pnladmins.TabIndex = 5;
            this.pnladmins.MouseEnter += new System.EventHandler(this.pnladmins_MouseEnter);
            this.pnladmins.MouseLeave += new System.EventHandler(this.pnladmins_MouseLeave);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.BackgroundImage = global::T1K.Properties.Resources.Group_1;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(6, 9);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(34, 37);
            this.btnadd.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnadd, "جدید");
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            this.btnadd.MouseEnter += new System.EventHandler(this.btnadd_MouseEnter);
            this.btnadd.MouseLeave += new System.EventHandler(this.btnadd_MouseLeave);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackgroundImage = global::T1K.Properties.Resources.turch;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(3, 104);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(38, 41);
            this.btndelete.TabIndex = 2;
            this.toolTip.SetToolTip(this.btndelete, "حذف");
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.MouseEnter += new System.EventHandler(this.btndelete_MouseEnter);
            this.btndelete.MouseLeave += new System.EventHandler(this.btndelete_MouseLeave);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackgroundImage = global::T1K.Properties.Resources.edit;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Location = new System.Drawing.Point(3, 57);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(38, 41);
            this.btnedit.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnedit, "ویرایش");
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            this.btnedit.MouseEnter += new System.EventHandler(this.btnedit_MouseEnter);
            this.btnedit.MouseLeave += new System.EventHandler(this.btnedit_MouseLeave);
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            this.pnldata.Controls.Add(this.btnRestore);
            this.pnldata.Controls.Add(this.btnDeleteDatabase);
            this.pnldata.Controls.Add(this.btnBackup);
            this.pnldata.Location = new System.Drawing.Point(221, 67);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(46, 150);
            this.pnldata.TabIndex = 6;
            this.pnldata.MouseEnter += new System.EventHandler(this.pnldata_MouseEnter);
            this.pnldata.MouseLeave += new System.EventHandler(this.pnldata_MouseLeave);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.BackgroundImage = global::T1K.Properties.Resources.bincloud;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Location = new System.Drawing.Point(3, 5);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(40, 42);
            this.btnRestore.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnRestore, "بازیابی فایل پک آپ");
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.btnRestore.MouseEnter += new System.EventHandler(this.btnRestore_MouseEnter);
            this.btnRestore.MouseLeave += new System.EventHandler(this.btnRestore_MouseLeave);
            // 
            // btnDeleteDatabase
            // 
            this.btnDeleteDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDatabase.BackgroundImage = global::T1K.Properties.Resources.outline_cloud_off_black_48dp;
            this.btnDeleteDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDatabase.FlatAppearance.BorderSize = 0;
            this.btnDeleteDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDatabase.Location = new System.Drawing.Point(3, 102);
            this.btnDeleteDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteDatabase.Name = "btnDeleteDatabase";
            this.btnDeleteDatabase.Size = new System.Drawing.Size(40, 42);
            this.btnDeleteDatabase.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnDeleteDatabase, "پاکسازی کامل دیتابیس");
            this.btnDeleteDatabase.UseVisualStyleBackColor = true;
            this.btnDeleteDatabase.Click += new System.EventHandler(this.btnDeleteDatabase_Click);
            this.btnDeleteDatabase.MouseEnter += new System.EventHandler(this.btnDeleteDatabase_MouseEnter);
            this.btnDeleteDatabase.MouseLeave += new System.EventHandler(this.btnDeleteDatabase_MouseLeave);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackgroundImage = global::T1K.Properties.Resources.bup;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(3, 54);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(40, 42);
            this.btnBackup.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnBackup, "ذخیره بک آپ");
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            this.btnBackup.MouseEnter += new System.EventHandler(this.btnBackup_MouseEnter);
            this.btnBackup.MouseLeave += new System.EventHandler(this.btnBackup_MouseLeave);
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = global::T1K.Properties.Resources.flipedshow;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(96, 11);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(68, 73);
            this.btnshow.TabIndex = 1;
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btntem4
            // 
            this.btntem4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntem4.BackgroundImage = global::T1K.Properties.Resources._4_2;
            this.btntem4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntem4.FlatAppearance.BorderSize = 0;
            this.btntem4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntem4.Location = new System.Drawing.Point(584, 643);
            this.btntem4.Name = "btntem4";
            this.btntem4.Size = new System.Drawing.Size(78, 78);
            this.btntem4.TabIndex = 10;
            this.toolTip.SetToolTip(this.btntem4, "بنفش تاریک");
            this.btntem4.UseVisualStyleBackColor = true;
            this.btntem4.Click += new System.EventHandler(this.btntem4_Click);
            // 
            // btntem3
            // 
            this.btntem3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntem3.BackgroundImage = global::T1K.Properties.Resources._3_2;
            this.btntem3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntem3.FlatAppearance.BorderSize = 0;
            this.btntem3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntem3.Location = new System.Drawing.Point(490, 643);
            this.btntem3.Name = "btntem3";
            this.btntem3.Size = new System.Drawing.Size(78, 78);
            this.btntem3.TabIndex = 9;
            this.toolTip.SetToolTip(this.btntem3, "آبی روشن");
            this.btntem3.UseVisualStyleBackColor = true;
            this.btntem3.Click += new System.EventHandler(this.btntem3_Click);
            // 
            // btntem2
            // 
            this.btntem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntem2.BackgroundImage = global::T1K.Properties.Resources._2_2;
            this.btntem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntem2.FlatAppearance.BorderSize = 0;
            this.btntem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntem2.Location = new System.Drawing.Point(396, 643);
            this.btntem2.Name = "btntem2";
            this.btntem2.Size = new System.Drawing.Size(78, 78);
            this.btntem2.TabIndex = 8;
            this.toolTip.SetToolTip(this.btntem2, "قهوه ای تاریک");
            this.btntem2.UseVisualStyleBackColor = true;
            this.btntem2.Click += new System.EventHandler(this.btntem2_Click);
            // 
            // btntem1
            // 
            this.btntem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntem1.BackgroundImage = global::T1K.Properties.Resources._1_2;
            this.btntem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntem1.FlatAppearance.BorderSize = 0;
            this.btntem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntem1.Location = new System.Drawing.Point(302, 643);
            this.btntem1.Name = "btntem1";
            this.btntem1.Size = new System.Drawing.Size(78, 78);
            this.btntem1.TabIndex = 7;
            this.toolTip.SetToolTip(this.btntem1, "تم اصلی برنامه");
            this.btntem1.UseVisualStyleBackColor = true;
            this.btntem1.Click += new System.EventHandler(this.btntem1_Click_1);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(675, -2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 37);
            this.btnclose.TabIndex = 6;
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
            this.btnmini.Location = new System.Drawing.Point(648, 3);
            this.btnmini.Margin = new System.Windows.Forms.Padding(2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(26, 28);
            this.btnmini.TabIndex = 5;
            this.btnmini.TabStop = false;
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            this.btnmini.MouseEnter += new System.EventHandler(this.btnmini_MouseEnter);
            this.btnmini.MouseLeave += new System.EventHandler(this.btnmini_MouseLeave);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 1000;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 1000;
            this.toolTip.ReshowDelay = 200;
            // 
            // frmsetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(710, 733);
            this.Controls.Add(this.pnldata);
            this.Controls.Add(this.pnladmins);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.tols);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.btntem4);
            this.Controls.Add(this.btntem3);
            this.Controls.Add(this.btntem2);
            this.Controls.Add(this.btntem1);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.spanel);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnmini);
            this.Controls.Add(this.lblsetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(726, 772);
            this.Name = "frmsetting";
            this.Text = "frmsetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmsetting_FormClosing);
            this.Load += new System.EventHandler(this.frmsetting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmsetting_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tols.ResumeLayout(false);
            this.tols.PerformLayout();
            this.spanel.ResumeLayout(false);
            this.spanel.PerformLayout();
            this.panel.ResumeLayout(false);
            this.pnladmins.ResumeLayout(false);
            this.pnldata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin_user;
        public System.Windows.Forms.Button btnshow;
        public System.Windows.Forms.Label lblsetting;
        public System.Windows.Forms.Button btnmini;
        public System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel tols;
        public System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btncancle;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.Panel spanel;
        public System.Windows.Forms.Button btncancles;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.Button namaieshy;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Panel panel;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btntem1;
        private System.Windows.Forms.Button btntem2;
        private System.Windows.Forms.Button btntem3;
        private System.Windows.Forms.Button btntem4;
        private System.Windows.Forms.Label lblcod;
        public System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.Button btnadmins;
        private System.Windows.Forms.Panel pnladmins;
        public System.Windows.Forms.Button btndata;
        private System.Windows.Forms.Panel pnldata;
        public System.Windows.Forms.Button btnBackup;
        public System.Windows.Forms.Button btnRestore;
        public System.Windows.Forms.Button btnDeleteDatabase;
        private System.Windows.Forms.ToolTip toolTip;
    }
}