
namespace T1K
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblmenu = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.trust = new System.Windows.Forms.Button();
            this.moshtarekin = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblmenu
            // 
            this.lblmenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmenu.Location = new System.Drawing.Point(157, 7);
            this.lblmenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(56, 39);
            this.lblmenu.TabIndex = 6;
            this.lblmenu.Text = "منو";
            this.lblmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Image = global::T1K.Properties.Resources.seting;
            this.setting.Location = new System.Drawing.Point(9, 293);
            this.setting.Margin = new System.Windows.Forms.Padding(2);
            this.setting.Name = "setting";
            this.setting.Padding = new System.Windows.Forms.Padding(3, 0, 0, 11);
            this.setting.Size = new System.Drawing.Size(170, 184);
            this.setting.TabIndex = 3;
            this.toolTip.SetToolTip(this.setting, "تنظیمات");
            this.setting.UseVisualStyleBackColor = false;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.add.BackgroundImage = global::T1K.Properties.Resources.Picture2;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Location = new System.Drawing.Point(187, 293);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(170, 184);
            this.add.TabIndex = 4;
            this.toolTip.SetToolTip(this.add, "امانتی جدید");
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // trust
            // 
            this.trust.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.trust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trust.FlatAppearance.BorderSize = 0;
            this.trust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trust.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trust.Image = global::T1K.Properties.Resources.trusts;
            this.trust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trust.Location = new System.Drawing.Point(9, 221);
            this.trust.Margin = new System.Windows.Forms.Padding(2);
            this.trust.Name = "trust";
            this.trust.Size = new System.Drawing.Size(347, 62);
            this.trust.TabIndex = 2;
            this.trust.Text = "امانات";
            this.trust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trust.UseVisualStyleBackColor = false;
            this.trust.Click += new System.EventHandler(this.trust_Click);
            // 
            // moshtarekin
            // 
            this.moshtarekin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moshtarekin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.moshtarekin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moshtarekin.FlatAppearance.BorderSize = 0;
            this.moshtarekin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moshtarekin.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moshtarekin.Image = global::T1K.Properties.Resources.Path_4;
            this.moshtarekin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.moshtarekin.Location = new System.Drawing.Point(9, 149);
            this.moshtarekin.Margin = new System.Windows.Forms.Padding(2);
            this.moshtarekin.Name = "moshtarekin";
            this.moshtarekin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.moshtarekin.Size = new System.Drawing.Size(347, 62);
            this.moshtarekin.TabIndex = 1;
            this.moshtarekin.Text = "مشترکین";
            this.moshtarekin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.moshtarekin.UseVisualStyleBackColor = false;
            this.moshtarekin.Click += new System.EventHandler(this.moshtarekin_Click);
            // 
            // books
            // 
            this.books.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(90)))), ((int)(((byte)(14)))));
            this.books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.books.FlatAppearance.BorderSize = 0;
            this.books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.books.Image = global::T1K.Properties.Resources.books;
            this.books.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.books.Location = new System.Drawing.Point(9, 76);
            this.books.Margin = new System.Windows.Forms.Padding(2);
            this.books.Name = "books";
            this.books.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.books.Size = new System.Drawing.Size(347, 62);
            this.books.TabIndex = 0;
            this.books.Text = "کتاب ها";
            this.books.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.books.UseVisualStyleBackColor = false;
            this.books.Click += new System.EventHandler(this.books_Click);
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::T1K.Properties.Resources.back;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(2, -4);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(35, 57);
            this.btnback.TabIndex = 5;
            this.btnback.TabStop = false;
            this.toolTip.SetToolTip(this.btnback, "بازگشت");
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            this.btnback.MouseEnter += new System.EventHandler(this.btnback_MouseEnter);
            this.btnback.MouseLeave += new System.EventHandler(this.btnback_MouseLeave);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackgroundImage = global::T1K.Properties.Resources.cancle;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Location = new System.Drawing.Point(322, 2);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(41, 45);
            this.btnclose.TabIndex = 7;
            this.btnclose.TabStop = false;
            this.toolTip.SetToolTip(this.btnclose, "خروج");
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclos_Click);
            this.btnclose.MouseEnter += new System.EventHandler(this.btnclose_MouseEnter);
            this.btnclose.MouseLeave += new System.EventHandler(this.btnclose_MouseLeave);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 900;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.BackColor = System.Drawing.Color.White;
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            this.toolTip.InitialDelay = 900;
            this.toolTip.ReshowDelay = 180;
            // 
            // menu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(365, 548);
            this.Controls.Add(this.add);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.trust);
            this.Controls.Add(this.moshtarekin);
            this.Controls.Add(this.books);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(381, 587);
            this.Name = "menu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "menu";
            this.Activated += new System.EventHandler(this.menu_Activated);
            this.Load += new System.EventHandler(this.menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menu_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnclose;
        public System.Windows.Forms.Button btnback;
        public System.Windows.Forms.Label lblmenu;
        public System.Windows.Forms.Button books;
        public System.Windows.Forms.Button moshtarekin;
        public System.Windows.Forms.Button trust;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.ToolTip toolTip;
    }
}