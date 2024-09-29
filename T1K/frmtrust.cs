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
//using System.Globalization;
using BehComponents;

namespace T1K
{
    public partial class frmtrust : Form
    {
        public frmtrust()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmtrust_Load(object sender, EventArgs e)
        {
            ChangeTem();
            d = DateTime.Now;
            FillDataGrid();
            t = "hide";
            m = "hide";
            s = "hide";
            dataGridView.AutoGenerateColumns = false;
            panel.Size = new Size(0, 0);
            panel.Location = new Point(148, 24);
            tols.Size = new Size(1006, 0);
            tols.Location = new Point(335,11);
            spanel.Size = new Size(550, 0);
            spanel.Location = new Point(776, 25);
            id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            btnsave.Enabled = false;
            btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            dataGridView.Select();
        }
        private void frmtrust_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        DateTime d;
        //KetabkhoneEntities a = new KetabkhoneEntities();
        BLbook BL = new BLbook();
        public static string msg;
        public static string mpg;
        public static string tem;
        int id;
        string m;
        string t;
        string s;

        string bo;
        string mo;
        string nm;
        string nb;





        public void TchangeAGO()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            int now;
            int aid;
            foreach (var i in a.trusts)
            {
                aid = i.trust_id;
                now = (int)((i.trust_timeend.Value.Date - DateTime.Now.Date).Days);
                BL.TchangeAGO(now, aid);
            }

        }
        public void ebm()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            List<string> km = new List<string>();
            List<string> kb = new List<string>();

            foreach (var ti in a.trusts)
            {
                if (ti.trust_id == id)
                {
                    km.Add(ti.moshtarekin.moshtarekin_name.ToString() + " " + ti.moshtarekin.moshtarekin_family.ToString());
                    mo = ti.moshtarekin.moshtarekin_name.ToString() + " " + ti.moshtarekin.moshtarekin_family.ToString();
                }

                if (ti.trust_id == id)
                {
                    kb.Add(ti.Book.book_name.ToString());
                    bo = ti.Book.book_name.ToString();
                }
            }
            foreach (var mi in a.moshtarekins)
            {
                if (mi.moshtarekin_b_id == null)
                {
                    km.Add(mi.moshtarekin_name.ToString() + " " + mi.moshtarekin_family.ToString());
                }
            }
            foreach (var bi in a.Books)
            {
                if (bi.book_m_id == null)
                {
                    kb.Add(bi.book_name.ToString());
                }
            }

            //foreach (var mi in a.moshtarekins)
            //{
            //    if (mi.moshtarekin_id != ti1)
            //    {
            //        km.Add(mi.moshtarekin_name.ToString() + " " + mi.moshtarekin_family.ToString());
            //    }
            //}

            //foreach (var bi in a.Books)
            //{
            //    if (bi.book_id != ti2)
            //    {
            //        kb.Add(bi.book_name.ToString());
            //    }
            //}

            cmomoshtarekin.DataSource = km;
            cmobook.DataSource = kb;
        }
        public void eu()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            ebm();
            foreach (var ti in a.trusts)
            {
                if(ti.trust_id == id)
                {
                    cmomoshtarekin.Text = ti.moshtarekin.moshtarekin_name + " " + ti.moshtarekin.moshtarekin_family;
                    cmobook.Text = ti.Book.book_name;
                    days.Text = ti.trust_timestart.Value.Date.ToShortDateString();
                    txtlater.Text = ti.trust_later.ToString();
                }
            }
        }
        public void FillDataGrid()
        {
            TchangeAGO();
            KetabkhoneEntities a = new KetabkhoneEntities();
            //var tlist = a.trusts.ToList();
            List<TrustViewModel> listModel = new List<TrustViewModel>();
            foreach (var ti in a.trusts)
            {
                listModel.Add(new TrustViewModel()
                {
                    trust_id = ti.trust_id,
                    trust_moshtarekin = ti.moshtarekin.moshtarekin_name + " " + ti.moshtarekin.moshtarekin_family ,
                    trust_books = ti.Book.book_name,
                    trust_timestart = ti.trust_timestart.Value.Date.ToShortDateString(),
                    trust_timeend = ti.trust_timeend.Value.Date.ToShortDateString(),
                    trust_later = (int)ti.trust_later,
                });

            }
            dataGridView.DataSource = listModel;
            MousUpDateGridView();
        }
        public void sdatagrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = from i in a.trusts where i.moshtarekin.moshtarekin_name.Contains(txtsearch.Text) || i.moshtarekin.moshtarekin_family.Contains(txtsearch.Text) || i.Book.book_name.Contains(txtsearch.Text) || (i.moshtarekin.moshtarekin_name.ToString() + " " + i.moshtarekin.moshtarekin_family.ToString()).Contains(txtsearch.Text) select i;
            List<TrustViewModel> listModel = new List<TrustViewModel>();
            foreach (var i in ss)
            {
                listModel.Add(new TrustViewModel()
                {
                    trust_id = i.trust_id,
                    trust_moshtarekin = i.moshtarekin.moshtarekin_name + " " + i.moshtarekin.moshtarekin_family,
                    trust_books = i.Book.book_name,
                    trust_timestart = i.trust_timestart.Value.Date.ToShortDateString(),
                    trust_timeend = i.trust_timeend.Value.Date.ToShortDateString(),
                    trust_later = (int)i.trust_later,
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
            txtlater.Clear();
            dataGridView.Select();
        }
        public void eror()
        {
            try
            {
                int.Parse(txtlater.Text);
            }
            catch (System.OverflowException)
            {

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
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(49, 29, 6);
                tols.BackColor = Color.FromArgb(49, 29, 6);
                spanel.BackColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(201, 238, 234);
                tols.BackColor = Color.FromArgb(201, 238, 234);
                spanel.BackColor = Color.FromArgb(201, 238, 234);
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(40, 0, 101);
                tols.BackColor = Color.FromArgb(40, 0, 101);
                spanel.BackColor = Color.FromArgb(40, 0, 101);
            }
            //btn
            if (tem == "brown")
            {
                btnshowall.BackColor = Color.FromArgb(255, 194, 0);
                btnshowall.ForeColor = Color.Black;

                btnshow.BackgroundImage = T1K.Properties.Resources.flipedshow;
            }
            if (tem == "dark brown")
            {
                btnshowall.BackColor = Color.FromArgb(107, 80, 44);
                btnshowall.ForeColor = Color.White;

                btnshow.BackgroundImage = T1K.Properties.Resources.wflipedshow;
            }
            if (tem == "blue")
            {
                btnshowall.BackColor = Color.FromArgb(41, 217, 169);
                btnshowall.ForeColor = Color.Black;

                btnshow.BackgroundImage = T1K.Properties.Resources.flipedshow;
            }
            if (tem == "dark blue")
            {
                btnshowall.BackColor = Color.FromArgb(122, 0, 214);
                btnshowall.ForeColor = Color.White;

                btnshow.BackgroundImage = T1K.Properties.Resources.wflipedshow;
            }
            //datagridview
            if (tem == "brown")
            {
                dataGridView.BackgroundColor = Color.FromArgb(255, 194, 0);
                //dataGridView.ForeColor = Color.Black;

                //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(156, 90, 14);
                //dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 90, 14);

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
                dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
            if (tem == "dark blue")
            {
                dataGridView.BackgroundColor = Color.FromArgb(206, 0, 255);
                //dataGridView.ForeColor = Color.White;

                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 0, 226);
                dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 0, 226);
                dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(140, 0, 193);
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(122, 0, 214);
                dataGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
                dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
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
            //txt
            if (tem == "brown")
            {
                txtsearch.BackColor = Color.FromArgb(156, 90, 14);
            }
            if (tem == "dark brown")
            {
                txtsearch.BackColor = Color.FromArgb(145, 110, 0);
            }
            if (tem == "blue")
            {
                txtsearch.BackColor = Color.FromArgb(81, 53, 229);
            }
            if (tem == "dark blue")
            {
                txtsearch.BackColor = Color.FromArgb(206, 0, 255);
            }
            if (tem == "brown" || tem == "blue")
            {
                txtsearch.ForeColor = Color.White;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                txtsearch.ForeColor = Color.Black;
            }

            //combobox
            foreach (var i in this.tols.Controls)
            {
                if (i is ComboBox)
                {
                    if (tem == "brown")
                    {
                        ((ComboBox)i).BackColor = Color.FromArgb(156, 90, 14);
                    }
                    if (tem == "dark brown")
                    {
                        ((ComboBox)i).BackColor = Color.FromArgb(145, 110, 0);
                    }
                    if (tem == "blue")
                    {
                        ((ComboBox)i).BackColor = Color.FromArgb(81, 53, 229);
                    }
                    if (tem == "dark blue")
                    {
                        ((ComboBox)i).BackColor = Color.FromArgb(206, 0, 255);
                    }
                    if (tem == "brown" || tem == "dark blue")
                    {
                        ((ComboBox)i).ForeColor = Color.Black;
                    }
                    else if (tem == "dark brown" || tem == "blue")
                    {
                        ((ComboBox)i).ForeColor = Color.White;
                    }
                }
            }
            //days
            if (tem == "brown")
            {
                days.BackColor = Color.FromArgb(156, 90, 14);
                days.CalendarBoldedDayForeColor = Color.FromArgb(156, 90, 14);
                days.CalendarDaysBackColor = Color.FromArgb(156, 90, 14);
                days.CalendarTitleBackColor = Color.FromArgb(156, 90, 14);
                days.CalendarTrailingForeColor = Color.FromArgb(156, 90, 14);

                days.CalendarTodayRectColor = Color.FromArgb(255, 194, 0);
                days.CalendarWeekDaysBackColor = Color.FromArgb(255, 194, 0);

                days.CalendarTodayBackColor = Color.FromArgb(255, 194, 0);
            }
            if (tem == "dark brown")
            {
                days.BackColor = Color.FromArgb(145, 110, 0);
                days.CalendarBoldedDayForeColor = Color.FromArgb(145, 110, 0);
                days.CalendarDaysBackColor = Color.FromArgb(145, 110, 0);
                days.CalendarTitleBackColor = Color.FromArgb(145, 110, 0);
                days.CalendarTrailingForeColor = Color.FromArgb(145, 110, 0);

                days.CalendarTodayRectColor = Color.FromArgb(107, 80, 44);
                days.CalendarWeekDaysBackColor = Color.FromArgb(107, 80, 44);

                days.CalendarTodayBackColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                days.BackColor = Color.FromArgb(81, 53, 229);
                days.CalendarBoldedDayForeColor = Color.FromArgb(81, 53, 229);
                days.CalendarDaysBackColor = Color.FromArgb(81, 53, 229);
                days.CalendarTitleBackColor = Color.FromArgb(81, 53, 229);
                days.CalendarTrailingForeColor = Color.FromArgb(81, 53, 229);

                days.CalendarTodayRectColor = Color.FromArgb(41, 217, 169);
                days.CalendarWeekDaysBackColor = Color.FromArgb(41, 217, 169);

                days.CalendarTodayBackColor = Color.FromArgb(201, 238, 234);
            }
            if (tem == "dark blue")
            {
                days.BackColor = Color.FromArgb(206, 0, 255);
                days.CalendarBoldedDayForeColor = Color.FromArgb(206, 0, 255);
                days.CalendarDaysBackColor = Color.FromArgb(206, 0, 255);
                days.CalendarTitleBackColor = Color.FromArgb(206, 0, 255);
                days.CalendarTrailingForeColor = Color.FromArgb(206, 0, 255);

                days.CalendarTodayRectColor = Color.FromArgb(122, 0, 214);
                days.CalendarWeekDaysBackColor = Color.FromArgb(122, 0, 214);

                days.CalendarTodayBackColor = Color.FromArgb(40, 0, 101);
            }
            //forcolors
            if (tem == "brown" || tem == "blue")
            {
                days.ForeColor = Color.White;
                days.CalendarDaysForeColor = Color.White;

                days.CalendarBorderColor = Color.Black;
                days.CalendarLineWeekColor = Color.Black;
                days.CalendarTitleForeColor = Color.Black;
                days.CalendarTodayForeColor = Color.Black;
                days.CalendarWeekDaysForeColor = Color.Black;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                days.ForeColor = Color.Black;
                days.CalendarDaysForeColor = Color.Black;

                days.CalendarBorderColor = Color.White;
                days.CalendarLineWeekColor = Color.White;
                days.CalendarTitleForeColor = Color.White;
                days.CalendarTodayForeColor = Color.White;
                days.CalendarWeekDaysForeColor = Color.White;
            }
        }

        #region Keys Void
        public void SaveClick()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            trust u = new trust();
            foreach (var mi in a.moshtarekins)
            {
                if (mi.moshtarekin_name.ToString() + " " + mi.moshtarekin_family.ToString() == cmomoshtarekin.Text)
                {
                    u.trust_mokhatabin_id = mi.moshtarekin_id;
                    nm = cmomoshtarekin.Text;
                }
            }
            foreach (var bi in a.Books)
            {
                if (bi.book_name == cmobook.Text)
                {
                    u.trust_book_id = bi.book_id;
                    nb = cmobook.Text;
                }
            }
            u.trust_timestart = d;
            u.trust_later = int.Parse(txtlater.Text);
            u.trust_timeend = d.AddDays(int.Parse(txtlater.Text));

            BL.tupdata(id, bo, mo, nm,nb,u);
            FillDataGrid();
            txtsearch.Clear();
            bc();
        }
        public void sCancleClick()
        {
            s = "hide";
            bc();

            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = a.trusts.Where(i => i.moshtarekin.moshtarekin_name.Contains(txtsearch.Text) || i.moshtarekin.moshtarekin_family.Contains(txtsearch.Text) || i.Book.book_name.Contains(txtsearch.Text) || (i.moshtarekin.moshtarekin_name.ToString() + " " + i.moshtarekin.moshtarekin_family.ToString()).Contains(txtsearch.Text));
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

            dataGridView.Select();
        }
        public void DeleteClick()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            foreach (var i in a.trusts)
            {
                if (i.trust_id == id)
                {
                    frmdelete.mfg = "trust";
                    msg = i.moshtarekin.moshtarekin_name + " " + i.moshtarekin.moshtarekin_family;
                    mpg = i.Book.book_name;
                    frmdelete g = new frmdelete();
                    g.ShowDialog();
                    if (msg == "yes")
                    {
                        BL.tdelete(id);
                        FillDataGrid();
                    }
                    else
                    {

                    }
                    dataGridView.Select();
                }
            }
        }
        public void EditClick()
        {
            MousUpDateGridView();
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            eu();
        }
        public void AddClick()
        {
            frmadd g = new frmadd();
            g.Show();

            menu.addrun = "runing";
        }
        public void ShowAllClick()
        {
            txtsearch.Clear();
            dataGridView.DataSource = null;
            FillDataGrid();

            dataGridView.Select();
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
                eu();
            }
            catch { }
        }

        #endregion






        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (m == "show")
            {
                if (panel.Size != new Size(184, 49))
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



            if (menu.addrun == "runing")
            {
                btnadd.Enabled = false;
                btnadd.BackgroundImage = T1K.Properties.Resources.addoff1;
            }
            else 
            {
                btnadd.Enabled = true;
                btnadd.BackgroundImage = T1K.Properties.Resources.Group_1;
            }
        }





        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnmini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                FillDataGrid();
            }
            else
            {
                sdatagrid();
            }
        }

        private void btncancles_Click(object sender, EventArgs e)
        {
            sCancleClick();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            bc();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            timer.Start();
            bshow();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddClick();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            EditClick();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteClick();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            m = "hide";
            s = "show";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
        }



        private void days_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime e)
        {
            d = selectedDateTime;
        }

        private void txtlater_TextChanged(object sender, EventArgs e)
        {
            try
            {
                eror();
            }
            catch (System.FormatException)
            {
                txtlater.Clear();
            }

            if (txtlater.Text == "")
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

        private void txtlater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            MousUpDateGridView();
        }

        private void frmtrust_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.trustrun = "closed";
            menu.fo = "fo";
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            ShowAllClick();
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


        #region keys
        private void cmomoshtarekin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bc();
            }
        }
        private void cmobook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bc();
            }
        }
        private void days_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bc();
            }
        }
        private void txtlater_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnsave.Enabled == true)
            {
                SaveClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                bc();
            }
        }
        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsearch.SelectAll();
            }
        }
        private void txtsearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                sCancleClick();
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
