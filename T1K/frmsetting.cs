using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entity;
using BusinessLogic;
using T1K.ViewModels;

namespace T1K
{
    public partial class frmsetting : Form
    {
        public frmsetting()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmsetting_Load(object sender, EventArgs e)
        {
            ChangeTem();
            dataGridView.AutoGenerateColumns = false;
            FillDataGrid();
            cu = "u";
            t = "hide";
            m = "hide";
            s = "hide";
            panel.Size = new Size(0, 0);
            panel.Location = new Point(162, 24);
            tols.Size = new Size(467, 0);
            tols.Location = new Point(173, 13);
            spanel.Size = new Size(409, 0);
            spanel.Location = new Point(206, 33);
            pnladmins.Size = new Size(46, 0);
            pnladmins.Location = new Point(168, 67);            
            pnldata.Size = new Size(46, 0);
            pnldata.Location = new Point(221, 67);
            id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            EtcTem();
            ChangeAdminCod();
            btndelete.Enabled = false;
            btndelete.BackgroundImage = T1K.Properties.Resources.turchoff;
            btnsave.Enabled = false;
            btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            dataGridView.Select();
        }
        private void frmsetting_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        updataed uhistory = new updataed();
        BLbook BL = new BLbook();
        //KetabkhoneEntities a = new KetabkhoneEntities();
        string m;
        string t;
        string s;
        string cu;
        string amd;
        int id;
        //public static int op;
        public static string msg;
        public static string tem;

        int pa1 = 0;
        int pa2 = 0;
        int pd1 = 0;
        int pd2 = 0;





        public void FillDataGrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            List<AdminViewModel> listModel = new List<AdminViewModel>();
            foreach (var ai in a.admins)
            {
                listModel.Add(new AdminViewModel()
                {
                    admin_id = ai.admin_id,
                    admin_user = ai.admin_user == null ? "" : ai.admin_user,
                });
            }
            dataGridView.DataSource = listModel;
            MousUpDateGridView();
        }
        public void sdatagrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = from i in a.admins where i.admin_user.Contains(txtsearch.Text) select i;
            List<AdminViewModel> listModel = new List<AdminViewModel>();
            foreach (var ai in ss)
            {
                listModel.Add(new AdminViewModel()
                {
                    admin_id = ai.admin_id,
                    admin_user = ai.admin_user == null ? "" : ai.admin_user,
                });
            }
            dataGridView.DataSource = listModel;

        }
        public void bshow()
        {
            if (m == "hide")
            {
                if (tem == "brown" || tem == "blue")
                {
                    btnshow.BackgroundImage = T1K.Properties.Resources.outline_label_important_black_48dp;
                    
                    m = "show";

                }
                else if (tem == "dark brown" || tem == "dark blue")
                {
                    btnshow.BackgroundImage = T1K.Properties.Resources.outline_label_important_white_48dp;
               
                    m = "show";
                }      
                
            }
            else
            {
                if (tem == "brown" || tem == "blue")
                {
                    btnshow.BackgroundImage = T1K.Properties.Resources.flipedshow;
                    m = "hide";

                }
                else if (tem == "dark brown" || tem == "dark blue")
                {
                    btnshow.BackgroundImage = T1K.Properties.Resources.wflipedshow;
                    m = "hide";
                } 
            }
        }
        public void eu()
        {
            if (cu == "u")
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                foreach (var i in a.admins)
                {
                    if (i.admin_id == id)
                    {
                        txtcod.Text = i.admin_user;

                        uhistory.updataed_admin_id = i.admin_id;
                        uhistory.updataed_admin_user = i.admin_user;

                        amd = i.admin_user;
                    }
                }
            }
        }
        public void onoff()
        {
            if (txtcod.Text != "")
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                if (cu == "c")
                {
                    var o = a.admins.Where(i => i.admin_user == txtcod.Text);
                    if (o.Count() == 1)
                    {
                        btnsave.Enabled = false;
                        btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
                    }
                    else
                    {
                        btnsave.Enabled = true;
                        btnsave.BackgroundImage = T1K.Properties.Resources.save;
                    }
                }
                else if (cu == "u")
                {
                    var o = a.admins.Where(l => l.admin_user == txtcod.Text && l.admin_user != amd);
                    if (o.Count() == 1)
                    {
                        btnsave.Enabled = false;
                        btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
                    }
                    else
                    {
                        btnsave.Enabled = true;
                        btnsave.BackgroundImage = T1K.Properties.Resources.save;
                    }
                }
            }
            else
            {
                btnsave.Enabled = false;
                btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            }

        }
        public void bc()
        {
            if (tem == "brown" || tem == "blue")
            {
                btnshow.BackgroundImage = T1K.Properties.Resources.outline_label_important_black_48dp;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                btnshow.BackgroundImage = T1K.Properties.Resources.outline_label_important_white_48dp;
            }
            btnshow.Enabled = true;
            m = "show";
            t = "hide";
            txtcod.Clear();
            dataGridView.Select();
        }
        public void ChangeAdminCod()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            foreach (var i in a.admins)
            {
                if (i.admin_id == id)
                {
                    lblcod.Text = i.admin_user + " :";

                    if (i.tem == "brown")
                    {
                        btntem1.BackgroundImage = T1K.Properties.Resources._1_3;
                    }
                    if (i.tem == "dark brown")
                    {
                        btntem2.BackgroundImage = T1K.Properties.Resources._2_3;
                    }
                    if (i.tem == "blue")
                    {
                        btntem3.BackgroundImage = T1K.Properties.Resources._3_3;
                    }
                    if (i.tem == "dark blue")
                    {
                        btntem4.BackgroundImage = T1K.Properties.Resources._4_3;
                    }

                }
            }
        }
        public void ChangeTem()
        {
            //form
            if (tem == "brown")
            {
                this.BackColor = Color.FromArgb(225, 194, 163);
                tols.BackColor = Color.FromArgb(225, 194, 163);
                spanel.BackColor = Color.FromArgb(225, 194, 163);

                pnladmins.BackColor = Color.FromArgb(225, 194, 163);
                pnldata.BackColor = Color.FromArgb(225, 194, 163);
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(49, 29, 6);
                tols.BackColor = Color.FromArgb(49, 29, 6);
                spanel.BackColor = Color.FromArgb(49, 29, 6);

                pnladmins.BackColor = Color.FromArgb(49, 29, 6);
                pnldata.BackColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(201, 238, 234);
                tols.BackColor = Color.FromArgb(201, 238, 234);
                spanel.BackColor = Color.FromArgb(201, 238, 234);

                pnladmins.BackColor = Color.FromArgb(201, 238, 234);
                pnldata.BackColor = Color.FromArgb(201, 238, 234);
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(40, 0, 101);
                tols.BackColor = Color.FromArgb(40, 0, 101);
                spanel.BackColor = Color.FromArgb(40, 0, 101);

                pnladmins.BackColor = Color.FromArgb(40, 0, 101);
                pnldata.BackColor = Color.FromArgb(40, 0, 101);
            }
            //texts
            foreach (var i in this.spanel.Controls)
            {
                if (i is TextBox)
                {
                    if (tem == "brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(156, 90, 14);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "dark brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(145, 110, 0);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "blue")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(81, 53, 229);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "dark blue")
                    {
                        this.BackColor = Color.FromArgb(40, 0, 101);

                        ((TextBox)i).BackColor = Color.FromArgb(206, 0, 255);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                }
            }
            foreach (var i in this.tols.Controls)
            {
                if (i is TextBox)
                {
                    if (tem == "brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(156, 90, 14);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "dark brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(145, 110, 0);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "blue")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(81, 53, 229);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    if (tem == "dark blue")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(206, 0, 255);
                        ((TextBox)i).ForeColor = Color.White;
                    }
                }
            }
            //btn
            foreach (var i in this.pnldata.Controls)
            {
                if (i is Button)
                {
                    if (tem == "brown")
                    {
                        ((Button)i).BackColor = Color.FromArgb(225, 194, 163);
                    }
                    if (tem == "dark brown")
                    {
                        ((Button)i).BackColor = Color.FromArgb(49, 29, 6);
                    }
                    if (tem == "blue")
                    {
                        ((Button)i).BackColor = Color.FromArgb(201, 238, 234);
                    }
                    if (tem == "dark blue")
                    {
                        ((Button)i).BackColor = Color.FromArgb(40, 0, 101);
                    }
                }
            }
            if (tem == "brown")
            {
                btnshowall.BackColor = Color.FromArgb(255, 194, 0);
                btnshowall.ForeColor = Color.Black;

                btnshow.BackgroundImage = T1K.Properties.Resources.flipedshow;

                btnadmins.BackColor = Color.FromArgb(225, 194, 163);
                btnadmins.BackgroundImage = T1K.Properties.Resources.outline_manage_accounts_black_48dp;
                btndata.BackColor = Color.FromArgb(225, 194, 163);
                btndata.BackgroundImage = T1K.Properties.Resources.bstor;

                btnRestore.BackgroundImage = T1K.Properties.Resources.bincloud;
                btnBackup.BackgroundImage = T1K.Properties.Resources.bup;
                btnDeleteDatabase.BackgroundImage = T1K.Properties.Resources.outline_cloud_off_black_48dp;
            }
            if (tem == "dark brown")
            {
                btnshowall.BackColor = Color.FromArgb(107, 80, 44);
                btnshowall.ForeColor = Color.White;

                btnshow.BackgroundImage = T1K.Properties.Resources.wflipedshow;

                btnadmins.BackColor = Color.FromArgb(49, 29, 6);
                btnadmins.BackgroundImage = T1K.Properties.Resources.outline_manage_accounts_white_48dp_png;
                btndata.BackColor = Color.FromArgb(49, 29, 6);
                btndata.BackgroundImage = T1K.Properties.Resources.outline_storage_white_48dp;

                btnRestore.BackgroundImage = T1K.Properties.Resources.incloud;
                btnBackup.BackgroundImage = T1K.Properties.Resources.up;
                btnDeleteDatabase.BackgroundImage = T1K.Properties.Resources.outline_cloud_off_white_48dp;
            }
            if (tem == "blue")
            {
                btnshowall.BackColor = Color.FromArgb(41, 217, 169);
                btnshowall.ForeColor = Color.Black;

                btnshow.BackgroundImage = T1K.Properties.Resources.flipedshow;

                btnadmins.BackColor = Color.FromArgb(201, 238, 234);
                btnadmins.BackgroundImage = T1K.Properties.Resources.outline_manage_accounts_black_48dp;
                btndata.BackColor = Color.FromArgb(201, 238, 234);
                btndata.BackgroundImage = T1K.Properties.Resources.bstor;

                btnRestore.BackgroundImage = T1K.Properties.Resources.bincloud;
                btnBackup.BackgroundImage = T1K.Properties.Resources.bup;
                btnDeleteDatabase.BackgroundImage = T1K.Properties.Resources.outline_cloud_off_black_48dp;
            }
            if (tem == "dark blue")
            {
                btnshowall.BackColor = Color.FromArgb(122, 0, 214);
                btnshowall.ForeColor = Color.White;

                btnshow.BackgroundImage = T1K.Properties.Resources.wflipedshow;

                btnadmins.BackColor = Color.FromArgb(40, 0, 101);
                btnadmins.BackgroundImage = T1K.Properties.Resources.outline_manage_accounts_white_48dp_png;
                btndata.BackColor = Color.FromArgb(40, 0, 101);
                btndata.BackgroundImage = T1K.Properties.Resources.outline_storage_white_48dp;

                btnRestore.BackgroundImage = T1K.Properties.Resources.incloud;
                btnBackup.BackgroundImage = T1K.Properties.Resources.up;
                btnDeleteDatabase.BackgroundImage = T1K.Properties.Resources.outline_cloud_off_white_48dp;
            }
            //datagridview
            if (tem == "brown")
            {
                dataGridView.BackgroundColor = Color.FromArgb(255, 194, 0);
                //dataGridView.ForeColor = Color.Black;

                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(181, 116, 10);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(181, 116, 10);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(245, 211, 121);
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 90, 14);
                dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            }
            if (tem == "dark brown")
            {
                dataGridView.BackgroundColor = Color.FromArgb(145, 110, 0);
                //dataGridView.ForeColor = Color.Black;

                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(107, 80, 44);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 80, 44);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(121, 89, 2);
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 80, 44);
                dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            }
            if (tem == "blue")
            {
                dataGridView.BackgroundColor = Color.FromArgb(81, 53, 229);
                //dataGridView.ForeColor = Color.White;

                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 176, 184);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 176, 184);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(118, 109, 231);
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 217, 169);
                dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            }
            if (tem == "dark blue")
            {
                dataGridView.BackgroundColor = Color.FromArgb(206, 0, 255);
                //dataGridView.ForeColor = Color.White;

                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 0, 226);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 0, 226);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(140, 0, 193);
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(206, 0, 255);
                dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            }
            //ETC...
            foreach (var i in this.Controls)
            {
                if (i is Label)
                {
                    if (tem == "brown")
                    {
                        ((Label)i).ForeColor = Color.Black;
                    }
                    if (tem == "dark brown")
                    {
                        ((Label)i).ForeColor = Color.White;
                    }
                    if (tem == "blue")
                    {
                        ((Label)i).ForeColor = Color.Black;
                    }
                    if (tem == "dark blue")
                    {
                        ((Label)i).ForeColor = Color.White;
                    }
                }
            }
            foreach (var i in this.tols.Controls)
            {
                if (i is Label)
                {
                    if (tem == "brown")
                    {
                        ((Label)i).ForeColor = Color.Black;
                    }
                    if (tem == "dark brown")
                    {
                        ((Label)i).ForeColor = Color.White;
                    }
                    if (tem == "blue")
                    {
                        ((Label)i).ForeColor = Color.Black;
                    }
                    if (tem == "dark blue")
                    {
                        ((Label)i).ForeColor = Color.White;
                    }
                }
            }
        }
        public void EtcTem()
        {
            if (tem == "brown" || tem == "blue")
            {
                btntem1.BackgroundImage = T1K.Properties.Resources._1_2;
                btntem2.BackgroundImage = T1K.Properties.Resources._2_2;
                btntem3.BackgroundImage = T1K.Properties.Resources._3_2;
                btntem4.BackgroundImage = T1K.Properties.Resources._4_2;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                btntem1.BackgroundImage = T1K.Properties.Resources._1_1;
                btntem2.BackgroundImage = T1K.Properties.Resources._2_1;
                btntem3.BackgroundImage = T1K.Properties.Resources._3_1;
                btntem4.BackgroundImage = T1K.Properties.Resources._4_1;
            }
        }
        public void backup()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BackUp File|*.araDB";
            sfd.FileName = "BackUp_" + (DateTime.Now.ToShortDateString().Replace('/', '.'));
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BL.Backup(sfd.FileName);
                if (Entity.PBD.BR == "try")
                {
                    MessageBox.Show("فایل پشتیبان با موفقیت ذخیره شده", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Entity.PBD.BR = "ready";
                }
                else
                {
                    MessageBox.Show("لطفا فایل پشتیبان را در درایوی غیر از درایو ویندوز ذخیره کنید");
                    backup();
                }
            }
            else
            {
                Entity.PBD.BR = "ready";
            }
        }
        public void restore()
        {
            if (MessageBox.Show("ممکن است تمام اطلاعات حال حاظر بانک اطلاعاتی شما تغییر کند!!! \n اگر مشکلی با این مورد ندارید بله را انتخاب کنید", "DataBase ReStore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OpenFileDialog opfd = new OpenFileDialog();
                opfd.Filter = "BackUp File|*.araDB";
                if (opfd.ShowDialog() == DialogResult.OK)
                {
                    BL.Restore(opfd.FileName);
                    if (Entity.PBD.BR == "try")
                    {
                        MessageBox.Show("اطلاعات با موفقیت بازیابی شد", "Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Entity.PBD.BR = "ready";
                    }
                    else
                    {
                        MessageBox.Show(Entity.PBD.BE.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        backup();
                        Entity.PBD.BR = "ready";
                        Entity.PBD.BE = "";
                    }
                }
            }
        }

        #region Keys Void
        public void SaveClick()
        {
            if (cu == "c")
            {
                admin c = new admin();
                c.admin_user = txtcod.Text;
                c.tem = "brown";
                BL.acreate(c);
                FillDataGrid();
                txtcod.Clear();
                txtsearch.Clear();

                dataGridView.Select();
            }
            else if (cu == "u")
            {
                admin u = new admin();
                u.admin_user = txtcod.Text;
                BL.aupdata(id, u, uhistory);
                FillDataGrid();
                bc();
                txtsearch.Clear();
            }
        }
        public void DeleteClick()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            deleted d = new deleted();
            foreach (var i in a.admins)
            {
                if (i.admin_id == id && id != 1)
                {
                    frmdelete.mfg = "admin";
                    msg = i.admin_user;
                    frmdelete g = new frmdelete();
                    g.ShowDialog();
                    if (msg == "yes")
                    {
                        d.deleted_admin_id = i.admin_id;
                        d.deleted_admin_user = i.admin_user;
                        BL.adelete(id, d);
                        FillDataGrid();
                    }
                    else
                    {

                    }
                    dataGridView.Select();
                }
            }
        }
        public void sCancleClick()
        {
            bc();
            cu = "u";
            dataGridView.Select();
        }
        public void EditClick()
        {
            MousUpDateGridView();
            cu = "u";
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            eu();
            onoff();
            txtcod.Focus();
        }
        public void AddClick()
        {
            txtcod.Clear();
            cu = "c";
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            txtcod.Focus();
        }
        public void ShowAllClick()
        {
            txtsearch.Clear();
            dataGridView.DataSource = null;
            FillDataGrid();
        }
        public void MousUpDateGridView()
        {
            try
            {
                int index = dataGridView.Rows.IndexOf(this.dataGridView.CurrentRow);
                this.dataGridView.Rows[index].Selected = true;
                //this.dataGridView.Rows[index]. = true;
                dataGridView.Focus();
                id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
                EtcTem();
                ChangeAdminCod();
                eu();
                onoff();
                if (id == 1)
                {
                    btndelete.Enabled = false;
                    btndelete.BackgroundImage = T1K.Properties.Resources.turchoff;
                }
                else
                {
                    btndelete.Enabled = true;
                    btndelete.BackgroundImage = T1K.Properties.Resources.turch;
                }
            }
            catch { }
        }
        #endregion






        private void timer_Tick(object sender, EventArgs e)
        {
            if (m == "show")
            {
                if (panel.Size != new Size(160, 49))
                {

                    panel.Size = new Size(panel.Size.Width + 8, 49);

                }
            }
            else if (m == "hide")
            {
                if (panel.Size != new Size(0, 49))
                {

                    panel.Size = new Size(panel.Size.Width - 8, 49);

                }
            }

            if (t == "show")
            {
                if (tols.Size != new Size(tols.Size.Width, 66))
                {

                    tols.Size = new Size(tols.Size.Width, tols.Size.Height + 2);

                }
            }
            else if (t == "hide")
            {
                if (tols.Size != new Size(tols.Size.Width, 0))
                {

                    tols.Size = new Size(tols.Size.Width, tols.Size.Height - 2);

                }
            }

            if (s == "show")
            {
                if (spanel.Size != new Size(spanel.Size.Width, 56))
                {

                    spanel.Size = new Size(spanel.Size.Width, spanel.Size.Height + 2);

                }
            }
            else if (s == "hide")
            {
                if (spanel.Size != new Size(spanel.Size.Width, 0))
                {

                    spanel.Size = new Size(spanel.Size.Width, spanel.Size.Height - 2);

                }
            }



            if (m == "show")
            {
                if (pa1 == 1 || pa2 == 1)
                {
                    if (pnladmins.Size != new Size(46, 156))
                    {
                        pnladmins.Size = new Size(pnladmins.Size.Width, pnladmins.Size.Height + 6);
                    }
                }
                else if (pa1 == 0 || pa2 == 0)
                {
                    if (pnladmins.Size != new Size(46, 0))
                    {
                        pnladmins.Size = new Size(pnladmins.Size.Width, pnladmins.Size.Height - 6);
                    }
                }

                if (pd1 == 1 || pd2 == 1)
                {
                    if (pnldata.Size != new Size(46, 156))
                    {
                        pnldata.Size = new Size(pnldata.Size.Width, pnldata.Size.Height + 6);
                    }
                }
                else if (pd1 == 0 || pd2 == 0)
                {
                    if (pnldata.Size != new Size(46, 0))
                    {
                        pnldata.Size = new Size(pnldata.Size.Width, pnldata.Size.Height - 6);
                    }
                }
            }
            else
            {
                if (pnladmins.Size != new Size(46, 0))
                {
                    pnladmins.Size = new Size(pnladmins.Size.Width, pnladmins.Size.Height - 6);
                }

                if (pnldata.Size != new Size(46, 0))
                {
                    pnldata.Size = new Size(pnldata.Size.Width, pnldata.Size.Height - 6);
                }
            }
        }





        private void btnshow_Click(object sender, EventArgs e)
        {
            timer.Start();
            bshow();
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnmini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_MouseEnter(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle2;
        }
        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle;
        }

        private void btnmini_MouseEnter(object sender, EventArgs e)
        {
            btnmini.BackgroundImage = T1K.Properties.Resources.Ellipse_9;
        }
        private void btnmini_MouseLeave(object sender, EventArgs e)
        {
            btnmini.BackgroundImage = T1K.Properties.Resources.Ellipse_7;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            sCancleClick();
        }

        private void btncancles_Click(object sender, EventArgs e)
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            s = "hide";
            bc();
            cu = "u";
            eu();

            var ss = a.admins.Where(i => i.admin_user.Contains(txtsearch.Text));
            if (ss.Count() == 0)
            {
                txtsearch.Clear();
                FillDataGrid();
                id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            }
            if (id == 1)
            {
                btndelete.Enabled = false;
                btndelete.BackgroundImage = T1K.Properties.Resources.turchoff;
            }
            else
            {
                btndelete.Enabled = true;
                btndelete.BackgroundImage = T1K.Properties.Resources.turch;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            EditClick();
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            onoff();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            m = "hide";
            s = "show";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            txtcod.Focus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    FillDataGrid();
                    id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
                    EtcTem();
                    ChangeAdminCod();             
                }
                else
                {
                    sdatagrid();
                    id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
                    EtcTem();
                    ChangeAdminCod();
                    
                }
            }
            catch { }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteClick();
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            MousUpDateGridView();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            ShowAllClick();
        }

        private void btntem1_Click_1(object sender, EventArgs e)
        {
            int temid = id;
            string newtem = "brown";
            BL.atem(temid, newtem);


            EtcTem();
            ChangeAdminCod();
        }
        private void btntem2_Click(object sender, EventArgs e)
        {
            int temid = id;
            string newtem = "dark brown";
            BL.atem(temid, newtem);

            EtcTem();
            ChangeAdminCod();
        }
        private void btntem3_Click(object sender, EventArgs e)
        {
            int temid = id;
            string newtem = "blue";
            BL.atem(temid, newtem);

            EtcTem();
            ChangeAdminCod();
        }
        private void btntem4_Click(object sender, EventArgs e)
        {
            int temid = id;
            string newtem = "dark blue";
            BL.atem(temid, newtem);

            EtcTem();
            ChangeAdminCod();
        }

        private void frmsetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.settingrun = "closed";
            menu.fo = "fo";
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            backup();
        }
        private void btnDeleteDatabase_Click(object sender, EventArgs e)
        {
            BL.DeleteDatabase();
            if (PBD.DD == 1)
            {
                MessageBox.Show("پاکسازی انجام شد");
            }
            else
            {
                MessageBox.Show("نشد");
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            restore();
        }

        #region Sliders
        private void btnadmins_MouseEnter(object sender, EventArgs e)
        {
            pa1 = 1;
        }
        private void btnadmins_MouseLeave(object sender, EventArgs e)
        {
            pa1 = 0;
        }

        private void btnadd_MouseEnter(object sender, EventArgs e)
        {
            pa2 = 1;
        }
        private void btnadd_MouseLeave(object sender, EventArgs e)
        {
            pa2 = 0;
        }
        private void btnedit_MouseEnter(object sender, EventArgs e)
        {
            pa2 = 1;
        }
        private void btnedit_MouseLeave(object sender, EventArgs e)
        {
            pa2 = 0;
        }
        private void btndelete_MouseEnter(object sender, EventArgs e)
        {
            pa2 = 1;
        }
        private void btndelete_MouseLeave(object sender, EventArgs e)
        {
            pa2 = 0;
        }

        private void pnladmins_MouseEnter(object sender, EventArgs e)
        {
            pa2 = 1;
        }
        private void pnladmins_MouseLeave(object sender, EventArgs e)
        {
            pa2 = 0;
        }



        private void btndata_MouseEnter(object sender, EventArgs e)
        {
            pd1 = 1;
        }
        private void btndata_MouseLeave(object sender, EventArgs e)
        {
            pd1 = 0;
        }

        private void btnRestore_MouseEnter(object sender, EventArgs e)
        {
            pd2 = 1;
        }
        private void btnRestore_MouseLeave(object sender, EventArgs e)
        {
            pd2 = 0;
        }
        private void btnBackup_MouseEnter(object sender, EventArgs e)
        {
            pd2 = 1;
        }
        private void btnBackup_MouseLeave(object sender, EventArgs e)
        {
            pd2 = 0;
        }
        private void btnDeleteDatabase_MouseEnter(object sender, EventArgs e)
        {
            pd2 = 1;
        }
        private void btnDeleteDatabase_MouseLeave(object sender, EventArgs e)
        {
            pd2 = 0;
        }

        private void pnldata_MouseEnter(object sender, EventArgs e)
        {
            pd2 = 1;
        }
        private void pnldata_MouseLeave(object sender, EventArgs e)
        {
            pd2 = 0;
        }
        #endregion


        #region keys
        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            if (tols.Size == new Size(tols.Size.Width, 66) && s == "hide")
            {
                if (e.KeyCode == Keys.Enter && btnsave.Enabled == true)
                {
                    SaveClick();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    bc();
                    cu = "u";
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtsearch.SelectAll();
                }
            }
        }
        private void txtcod_KeyUp(object sender, KeyEventArgs e)
        {
            if (s == "show" && m == "hide")
            {
                if (e.KeyCode == Keys.Escape)
                {
                    sCancleClick();
                }
            }
        }
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteClick();
            }

            if (e.KeyData.ToString() == "Return, Control")
            {
                EditClick();
            }
            else if (e.KeyData.ToString() == "Return, Shift")
            {
                AddClick();
            }
            else if (e.KeyData.ToString() == "R, Control")
            {
                ShowAllClick();
            }

            if (e.KeyCode == Keys.F11)
            {

                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
        }
        private void dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                MousUpDateGridView();
            }
        }
        #endregion

    }
}
