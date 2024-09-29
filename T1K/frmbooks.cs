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
    public partial class frmbooks : Form
    {
        public frmbooks()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void books_Load(object sender, EventArgs e)
        {          
            ChangeTem();
            //this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.Size = new Size(1258, 670);
            cu = "u";
            t = "hide";
            m = "hide";
            s = "hide";
            //setdatabase();
            dataGridView.AutoGenerateColumns = false;
            FillDataGrid();
            panel.Size = new Size(0, 0);
            panel.Location = new Point(165, 14);
            tols.Size = new Size(1006, 0);
            tols.Location = new Point(160, 4);
            spanel.Size = new Size(550, 0);
            spanel.Location = new Point(559, 15);
            id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            //MessageBox.Show(spanel.Size.ToString());
            btnsave.Enabled = false;
            btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            dataGridView.Select();
        }
        private void books_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.bookrun = "closed";
            menu.fo = "fo";
        }
        private void books_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        BLbook BL = new BLbook();
        //KetabkhoneEntities a = new KetabkhoneEntities();
        string p;
        string m;
        string t;
        string s;
        string cu;
        public static string tem;
        int id;
        updataed uhistory = new updataed();
        public static string msg;
        string bok;
        public static int op;

        


        public void bc ()
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
            txtclear();
            dataGridView.Select();
        }
        public void FillDataGrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            //var list = a.Books.ToList();
            List<BookViewModel> listModel = new List<BookViewModel>();
            foreach (var bi in a.Books)
            {
                //foreach (var i in a.trusts)
                //{
                //    if (i.Book.book_id == bi.book_id)
                //    {
                //        p = i.moshtarekin.moshtarekin_name + " " + i.moshtarekin.moshtarekin_family;
                //    }
                //    else
                //    {
                //        p = null;
                //    }
                //}
                //listModel.Add(new BookViewModel()
                //{
                //    book_id = bi.book_id,
                //    book_molaf = bi.book_molaf = bi.book_molaf,
                //    book_mozo = bi.book_mozo == null ? "" : bi.book_mozo,
                //    book_name = bi.book_name == null ? "" : bi.book_name,
                //    book_radeseni = bi.book_radeseni == null ? "" : bi.book_radeseni,

                //    moshtarkin_name = p,
                //});
                try
                {
                    listModel.Add(new BookViewModel()
                    {
                        book_id = bi.book_id,
                        book_molaf = bi.book_molaf = bi.book_molaf,
                        book_mozo = bi.book_mozo == null ? "" : bi.book_mozo,
                        book_name = bi.book_name == null ? "" : bi.book_name,
                        book_radeseni = bi.book_radeseni == null ? "" : bi.book_radeseni,
                        moshtarkin_name = bi.moshtarekin.moshtarekin_name + " " + bi.moshtarekin.moshtarekin_family,
                    });
                }
                catch
                {
                    listModel.Add(new BookViewModel()
                    {
                        book_id = bi.book_id,
                        book_molaf = bi.book_molaf = bi.book_molaf,
                        book_mozo = bi.book_mozo == null ? "" : bi.book_mozo,
                        book_name = bi.book_name == null ? "" : bi.book_name,
                        book_radeseni = bi.book_radeseni == null ? "" : bi.book_radeseni,
                        moshtarkin_name = "",
                    });
                }
            }
            dataGridView.DataSource = listModel;
            MousUpDateGridView();
        }
        public void sdatagrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = from i in a.Books where i.book_name.Contains(txtsearch.Text) || i.book_molaf.Contains(txtsearch.Text) select i;
            List<BookViewModel> listModel = new List<BookViewModel>();
            foreach (var si in ss)
            {
                foreach (var i in a.trusts)
                {
                    if (i.Book.book_id == si.book_id)
                    {
                        p = i.moshtarekin.moshtarekin_name + " " + i.moshtarekin.moshtarekin_family;
                    }
                    else
                    {
                        p = null;
                    }
                }
                listModel.Add(new BookViewModel()
                {
                    book_id = si.book_id,
                    book_molaf = si.book_molaf = si.book_molaf,
                    book_mozo = si.book_mozo == null ? "" : si.book_mozo,
                    book_name = si.book_name == null ? "" : si.book_name,
                    book_radeseni = si.book_radeseni == null ? "" : si.book_radeseni,
                    
                    moshtarkin_name = p == null? "" : p,
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
        public void txtclear()
        {
            txtagezone.Clear();
            txtmolaf.Clear();
            txtmozo.Clear();
            txtname.Clear();
        }
        public void eu()
        {
            if (cu == "u") 
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                foreach (var i in a.Books)
                {
                    if (i.book_id == id)
                    {
                        txtname.Text = i.book_name;
                        txtmozo.Text = i.book_mozo;
                        txtmolaf.Text = i.book_molaf;
                        txtagezone.Text = i.book_radeseni;

                        uhistory.updataed_book_id = i.book_id;
                        uhistory.updataed_book_name = i.book_name;
                        uhistory.updataed_book_mozo = i.book_mozo;
                        uhistory.updataed_book_molaf = i.book_molaf;
                        uhistory.updataed_book_radeseni = i.book_radeseni;

                        bok = i.book_name;
                    }
                }
            }
        }
        public void onoff()
        {
            if (txtname.Text != "")
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                if (cu == "c")
                {
                    var o = a.Books.Where(i => i.book_name == txtname.Text);
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
                    var o = a.Books.Where(l => l.book_name == txtname.Text && l.book_name != bok);
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
            //texts
            if (tem == "brown")
            {
                txtname.BackColor = Color.FromArgb(156, 90, 14);
                txtmolaf.BackColor = Color.FromArgb(156, 90, 14);
                txtmozo.BackColor = Color.FromArgb(156, 90, 14);
                txtagezone.BackColor = Color.FromArgb(156, 90, 14);
                txtsearch.BackColor = Color.FromArgb(156, 90, 14);
            }
            if (tem == "dark brown")
            {
                txtname.BackColor = Color.FromArgb(145, 110, 0);
                txtmolaf.BackColor = Color.FromArgb(145, 110, 0);
                txtmozo.BackColor = Color.FromArgb(145, 110, 0);
                txtagezone.BackColor = Color.FromArgb(145, 110, 0);
                txtsearch.BackColor = Color.FromArgb(145, 110, 0);
            }
            if (tem == "blue")
            {
                txtname.BackColor = Color.FromArgb(81, 53, 229);
                txtmolaf.BackColor = Color.FromArgb(81, 53, 229);
                txtmozo.BackColor = Color.FromArgb(81, 53, 229);
                txtagezone.BackColor = Color.FromArgb(81, 53, 229);
                txtsearch.BackColor = Color.FromArgb(81, 53, 229);
            }
            if (tem == "dark blue")
            {
                txtname.BackColor = Color.FromArgb(206, 0, 255);
                txtmolaf.BackColor = Color.FromArgb(206, 0, 255);
                txtmozo.BackColor = Color.FromArgb(206, 0, 255);
                txtagezone.BackColor = Color.FromArgb(206, 0, 255);
                txtsearch.BackColor = Color.FromArgb(206, 0, 255);
            }
            if (tem == "brown" || tem == "blue")
            {
                txtname.ForeColor = Color.White;
                txtmolaf.ForeColor = Color.White;
                txtmozo.ForeColor = Color.White;
                txtagezone.ForeColor = Color.White;
                txtsearch.ForeColor = Color.White;
            }
            else if(tem == "dark brown" || tem == "dark blue")
            {
                txtname.ForeColor = Color.Black;
                txtmolaf.ForeColor = Color.Black;
                txtmozo.ForeColor = Color.Black;
                txtagezone.ForeColor = Color.Black;
                txtsearch.ForeColor = Color.Black;
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
        }

        #region Keys Void
        public void SaveClick()
        {
            if (cu == "c")
            {
                Book c = new Book();
                c.book_name = txtname.Text;
                c.book_mozo = txtmozo.Text;
                c.book_radeseni = txtagezone.Text;
                c.book_molaf = txtmolaf.Text;
                BL.create(c);
                FillDataGrid();
                txtclear();
                txtsearch.Clear();

                txtname.Focus();
                //dataGridView.Focus();
                //MousUpDateGridView();
            }
            else if (cu == "u")
            {
                Book u = new Book();
                u.book_name = txtname.Text;
                u.book_mozo = txtmozo.Text;
                u.book_radeseni = txtagezone.Text;
                u.book_molaf = txtmolaf.Text;
                BL.updata(id, u, uhistory);
                FillDataGrid();
                bc();
                txtsearch.Clear();
                //MousUpDateGridView();
            }
        }
        public void DeleteClick()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            deleted d = new deleted();
            foreach (var i in a.Books)
            {
                if (i.book_id == id)
                {
                    //MessageBox.Show("آیا میخواهید کتاب" + i.book_name + "حذف شود؟");
                    frmdelete.mfg = "books";
                    msg = i.book_name;
                    frmdelete g = new frmdelete();
                    g.ShowDialog();
                    if (msg == "yes")
                    {
                        d.deleted_book_id = i.book_id;
                        d.deleted_book_name = i.book_name;
                        d.deleted_book_mozo = i.book_mozo;
                        d.deleted_book_molaf = i.book_molaf;
                        d.deleted_book_radeseni = i.book_radeseni;
                        BL.delete(id, d);
                        FillDataGrid();

                        //MousUpDateGridView();
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
            KetabkhoneEntities a = new KetabkhoneEntities();
            s = "hide";
            txtclear();
            bc();
            cu = "u";
            eu();

            var ss = a.Books.Where(i => i.book_name.Contains(txtsearch.Text) || i.book_molaf.Contains(txtsearch.Text));
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
        public void EditClick()
        {
            MousUpDateGridView();
            txtclear();
            cu = "u";
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            eu();
            onoff();
            txtname.Focus();
        }
        public void AddClick()
        {
            txtclear();
            cu = "c";
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            txtname.Focus();
        }
        public void ShowAllClick()
        {
            txtsearch.Clear();
            dataGridView.DataSource = null;
            FillDataGrid();

            dataGridView.Select();
            //MousUpDateGridView();
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
                onoff();
            }
            catch { }
        }
        #endregion



        private void timer_Tick(object sender, EventArgs e)
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

                    tols.Size = new Size(tols.Size.Width, tols.Size.Height +2);

                }
            }
            else if (t == "hide")
            {
                if (tols.Size != new Size(tols.Size.Width, 0))
                {

                    tols.Size = new Size(tols.Size.Width, tols.Size.Height -2);

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



        private void btnshow_Click(object sender, EventArgs e)
        {
            timer.Start();
            bshow();
        }
        private void btnmini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            txtsearch.Focus();
        }
        private void btncancles_Click(object sender, EventArgs e)
        {
            sCancleClick();
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            ShowAllClick();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }
        private void btncancle_Click(object sender, EventArgs e)
        {
            bc();
            cu = "u";
        }



        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //sd = txtsearch.Text;
            if (txtsearch.Text == "")
            {
                FillDataGrid();
            }
            else
            {
                sdatagrid();
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            onoff();
        }



        private void dataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            MousUpDateGridView();
        }



        #region keys
        private void txtname_KeyDown(object sender, KeyEventArgs e)
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
        private void txtmolaf_KeyDown(object sender, KeyEventArgs e)
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
        private void txtagezone_KeyDown(object sender, KeyEventArgs e)
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
        private void txtmozo_KeyDown(object sender, KeyEventArgs e)
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

            //else if (...)
            //{
            //    //////////////////////////////////////////// سرچ سریع
            //}
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
