
namespace T1K
{
    partial class frmbooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbooks));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_moalef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_radeseni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moshtarkin_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblbooks = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtmozo = new System.Windows.Forms.TextBox();
            this.tols = new System.Windows.Forms.Panel();
            this.txtagezone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtmolaf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancle = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.namaieshy = new System.Windows.Forms.Button();
            this.spanel = new System.Windows.Forms.Panel();
            this.btncancles = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            this.tols.SuspendLayout();
            this.spanel.SuspendLayout();
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(116)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_name,
            this.book_moalef,
            this.book_radeseni,
            this.book_mozo,
            this.moshtarkin_name});
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
            this.dataGridView.Location = new System.Drawing.Point(9, 75);
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
            this.dataGridView.Size = new System.Drawing.Size(1222, 540);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_MouseUp);
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "book_id";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // book_name
            // 
            this.book_name.DataPropertyName = "book_name";
            this.book_name.HeaderText = "نام کتاب";
            this.book_name.MinimumWidth = 6;
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            // 
            // book_moalef
            // 
            this.book_moalef.DataPropertyName = "book_molaf";
            this.book_moalef.HeaderText = "مؤلف";
            this.book_moalef.MinimumWidth = 6;
            this.book_moalef.Name = "book_moalef";
            this.book_moalef.ReadOnly = true;
            // 
            // book_radeseni
            // 
            this.book_radeseni.DataPropertyName = "book_radeseni";
            this.book_radeseni.HeaderText = "رده سنی کتاب ";
            this.book_radeseni.MinimumWidth = 6;
            this.book_radeseni.Name = "book_radeseni";
            this.book_radeseni.ReadOnly = true;
            // 
            // book_mozo
            // 
            this.book_mozo.DataPropertyName = "book_mozo";
            this.book_mozo.HeaderText = "موضوع کتاب";
            this.book_mozo.MinimumWidth = 6;
            this.book_mozo.Name = "book_mozo";
            this.book_mozo.ReadOnly = true;
            // 
            // moshtarkin_name
            // 
            this.moshtarkin_name.DataPropertyName = "moshtarkin_name";
            this.moshtarkin_name.HeaderText = "مشترکین";
            this.moshtarkin_name.MinimumWidth = 6;
            this.moshtarkin_name.Name = "moshtarkin_name";
            this.moshtarkin_name.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblbooks
            // 
            this.lblbooks.AutoSize = true;
            this.lblbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblbooks.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblbooks.ForeColor = System.Drawing.Color.Black;
            this.lblbooks.Location = new System.Drawing.Point(-2, 5);
            this.lblbooks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbooks.Name = "lblbooks";
            this.lblbooks.Size = new System.Drawing.Size(102, 37);
            this.lblbooks.TabIndex = 3;
            this.lblbooks.Text = "کتاب ها";
            this.lblbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnadd);
            this.panel.Controls.Add(this.btnedit);
            this.panel.Controls.Add(this.btndelete);
            this.panel.Controls.Add(this.btnsearch);
            this.panel.Location = new System.Drawing.Point(1047, 493);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel.Size = new System.Drawing.Size(184, 49);
            this.panel.TabIndex = 4;
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
            this.btnadd.TabIndex = 2;
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
            this.btnedit.TabIndex = 2;
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
            this.btnsearch.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnsearch, "جست و جو");
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtmozo
            // 
            this.txtmozo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmozo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtmozo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmozo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmozo.ForeColor = System.Drawing.Color.White;
            this.txtmozo.Location = new System.Drawing.Point(47, 21);
            this.txtmozo.MaxLength = 700;
            this.txtmozo.Name = "txtmozo";
            this.txtmozo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmozo.Size = new System.Drawing.Size(224, 36);
            this.txtmozo.TabIndex = 3;
            this.txtmozo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmozo_KeyDown);
            // 
            // tols
            // 
            this.tols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tols.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.tols.Controls.Add(this.txtagezone);
            this.tols.Controls.Add(this.txtname);
            this.tols.Controls.Add(this.txtmozo);
            this.tols.Controls.Add(this.txtmolaf);
            this.tols.Controls.Add(this.label4);
            this.tols.Controls.Add(this.label1);
            this.tols.Controls.Add(this.label2);
            this.tols.Controls.Add(this.label3);
            this.tols.Controls.Add(this.btncancle);
            this.tols.Controls.Add(this.btnsave);
            this.tols.Location = new System.Drawing.Point(162, 331);
            this.tols.Name = "tols";
            this.tols.Size = new System.Drawing.Size(1006, 66);
            this.tols.TabIndex = 6;
            // 
            // txtagezone
            // 
            this.txtagezone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtagezone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtagezone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtagezone.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagezone.ForeColor = System.Drawing.Color.White;
            this.txtagezone.Location = new System.Drawing.Point(278, 21);
            this.txtagezone.MaxLength = 30;
            this.txtagezone.Name = "txtagezone";
            this.txtagezone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtagezone.Size = new System.Drawing.Size(224, 36);
            this.txtagezone.TabIndex = 2;
            this.txtagezone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtagezone_KeyDown);
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(740, 21);
            this.txtname.MaxLength = 200;
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(224, 36);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // txtmolaf
            // 
            this.txtmolaf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmolaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.txtmolaf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmolaf.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmolaf.ForeColor = System.Drawing.Color.White;
            this.txtmolaf.Location = new System.Drawing.Point(509, 21);
            this.txtmolaf.MaxLength = 150;
            this.txtmolaf.Name = "txtmolaf";
            this.txtmolaf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmolaf.Size = new System.Drawing.Size(224, 36);
            this.txtmolaf.TabIndex = 1;
            this.txtmolaf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmolaf_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(921, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "نام";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "موضوع";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "رده سنی";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lalezar", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "مؤلف";
            // 
            // btncancle
            // 
            this.btncancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancle.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btncancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancle.FlatAppearance.BorderSize = 0;
            this.btncancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancle.Location = new System.Drawing.Point(8, 20);
            this.btncancle.Margin = new System.Windows.Forms.Padding(2);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(34, 37);
            this.btncancle.TabIndex = 5;
            this.btncancle.TabStop = false;
            this.toolTip.SetToolTip(this.btncancle, "بستن");
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            this.btncancle.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btncancle.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
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
            this.toolTip.SetToolTip(this.btnsave, "ثبت");
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            // 
            // btnshow
            // 
            this.btnshow.BackgroundImage = global::T1K.Properties.Resources.flipedshow;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(98, 2);
            this.btnshow.Margin = new System.Windows.Forms.Padding(2);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(68, 73);
            this.btnshow.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnshow, "ابزار ها");
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(1206, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(34, 37);
            this.btnclose.TabIndex = 2;
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
            this.btnmini.Location = new System.Drawing.Point(1178, 7);
            this.btnmini.Margin = new System.Windows.Forms.Padding(2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(26, 28);
            this.btnmini.TabIndex = 1;
            this.btnmini.TabStop = false;
            this.btnmini.UseVisualStyleBackColor = true;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            this.btnmini.MouseEnter += new System.EventHandler(this.btnmini_MouseEnter);
            this.btnmini.MouseLeave += new System.EventHandler(this.btnmini_MouseLeave);
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
            this.txtsearch.TabIndex = 5;
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
            // spanel
            // 
            this.spanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spanel.Controls.Add(this.btncancles);
            this.spanel.Controls.Add(this.txtsearch);
            this.spanel.Controls.Add(this.namaieshy);
            this.spanel.Location = new System.Drawing.Point(559, 15);
            this.spanel.Name = "spanel";
            this.spanel.Size = new System.Drawing.Size(550, 55);
            this.spanel.TabIndex = 7;
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
            this.btncancles.TabIndex = 2;
            this.btncancles.TabStop = false;
            this.btncancles.UseVisualStyleBackColor = true;
            this.btncancles.Click += new System.EventHandler(this.btncancles_Click);
            this.btncancles.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btncancles.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
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
            this.btnshowall.Location = new System.Drawing.Point(1156, 52);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 8;
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
            // frmbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(194)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1242, 631);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.spanel);
            this.Controls.Add(this.tols);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblbooks);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnmini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 200);
            this.Name = "frmbooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "books";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.books_FormClosed);
            this.Load += new System.EventHandler(this.books_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.books_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.tols.ResumeLayout(false);
            this.tols.PerformLayout();
            this.spanel.ResumeLayout(false);
            this.spanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Button btnmini;
        public System.Windows.Forms.Button btnshow;
        public System.Windows.Forms.Label lblbooks;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_moalef;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_radeseni;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_mozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn moshtarkin_name;
        public System.Windows.Forms.Button btnsearch;
        public System.Windows.Forms.Button btnadd;
        public System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel tols;
        public System.Windows.Forms.TextBox txtmozo;
        public System.Windows.Forms.Button btncancle;
        public System.Windows.Forms.Button btnsave;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtmolaf;
        public System.Windows.Forms.TextBox txtagezone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtsearch;
        public System.Windows.Forms.Button namaieshy;
        public System.Windows.Forms.Button btncancles;
        public System.Windows.Forms.Panel spanel;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.ToolTip toolTip;
    }
}