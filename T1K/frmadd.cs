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
    public partial class frmadd : Form
    {
        public frmadd()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmadd_Load(object sender, EventArgs e)
        {
            ChangeTem();
            nextlevel = 1;
            level = 1;
            d = DateTime.Now;

            foreach (var i in this.Controls)
            {
                if (i is DataGridView)
                {
                    ((DataGridView)i).AutoGenerateColumns = false;
                    ((DataGridView)i).Location = new Point(11, 72);
                    ((DataGridView)i).Size = new Size(981, 637);
                }
            }
            day.Location = new Point(11, 72);
            day.Size = new Size(981, 620);

            fdg1();

            levelup();           
            id = (int)(dgv1.SelectedRows[0].Cells[0].Value);
            dgv1.Select();          
        }

        private void frmadd_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmadd_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.addrun = "closed";
            menu.fo = "fo";
        }




        BLbook BL = new BLbook();
        DateTime d;
        int id;
        int level;
        public static string msg;
        public static string msg2;
        public static string msg3;
        public static string msg4;
        public static string tem;
        int nextlevel;
        string sh1 = "";
        string sh2 = "";
        //int ti1;
        //int ti2;
        //int sti1;
        //int sti2;




        public void txtclear()
        {
            foreach (var i in this.Controls)
            {
                if (i is TextBox)
                {
                    ((TextBox)i).Clear();
                }
            }
        }
        public void fdg4()
        {
            try
            {
                List<trust> listModel = new List<trust>();
                listModel.Add(new trust()
                {
                    trust_timeend = d.AddDays(int.Parse(txtnext.Text)),
                });
                dgv4.DataSource = listModel;
            }
            catch
            {
                dgv4.DataSource = null;
            }
        }
        public void fdg2()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            List<BookViewModel> listModel = new List<BookViewModel>();
            //foreach (var i in a.trusts)
            //{
            //    ti2 = (int)i.trust_book_id;
            //}
            foreach (var bi in a.Books)
            {
                if (bi.book_m_id == null)
                {
                    listModel.Add(new BookViewModel()
                    {
                        book_id = bi.book_id,
                        book_molaf = bi.book_molaf = bi.book_molaf,
                        book_mozo = bi.book_mozo == null ? "" : bi.book_mozo,
                        book_name = bi.book_name == null ? "" : bi.book_name,
                        book_radeseni = bi.book_radeseni == null ? "" : bi.book_radeseni,
                    });
                }
            }
            dgv2.DataSource = listModel;
        }
        public void fdg1()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            List<MoshtarekinViewModel> listModel = new List<MoshtarekinViewModel>();           
            //foreach (var i in a.trusts)
            //{
            //    ti1 = (int)i.trust_mokhatabin_id;
            //}
            foreach (var mi in a.moshtarekins)
            {
                if (mi.moshtarekin_b_id == null)
                {
                    listModel.Add(new MoshtarekinViewModel()
                    {
                        moshtarekin_id = mi.moshtarekin_id,
                        moshtarekin_name = mi.moshtarekin_name + " " + mi.moshtarekin_family,
                        moshtarekin_number = mi.moshtarekin_number == null ? "" : mi.moshtarekin_number,
                        moshtarekin_age = mi.moshtarekin_age,
                        moshtarekin_codmeli = mi.moshtarekin_codmeli == null ? "" : mi.moshtarekin_codmeli,
                    });
                }
            }
            dgv1.DataSource = listModel;
        }
        public void levelup()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();

            if (level == 1)
            {
                try
                {
                    txtsearch.Enabled = true;            
                    namaieshy.BackgroundImage = T1K.Properties.Resources.search;
                    searchChangeTem();

                    dgv1.Show();
                    dgv2.Hide();
                    day.Hide();
                    dgv4.Hide();

                    dgv1.Enabled = true;
                    dgv2.Enabled = false;
                    day.Enabled = false;
                    dgv4.Enabled = false;
                   
                    id = (int)(dgv1.SelectedRows[0].Cells[0].Value);

                    foreach (var i in a.moshtarekins)
                    {
                        if (i.moshtarekin_id == id)
                        {
                            txtnext.Text = i.moshtarekin_name + " " + i.moshtarekin_family;
                        }
                    }
                }
                catch { }
            }
            else if (level == 2)
            {
                try
                {
                    txtsearch.Enabled = true;
                    searchChangeTem();
                    namaieshy.BackgroundImage = T1K.Properties.Resources.search;

                    dgv1.Hide();
                    dgv2.Show();
                    day.Hide();
                    dgv4.Hide();

                    dgv1.Enabled = false;
                    dgv2.Enabled = true;
                    day.Enabled = false;
                    dgv4.Enabled = false;

                    id = (int)(dgv2.SelectedRows[0].Cells[0].Value);

                    foreach (var i in a.Books)
                    {
                        if (i.book_id == id)
                        {
                            txtnext.Text = i.book_name;
                        }
                    }
                }
                catch { }
            }
            else if (level == 3)
            {
                txtsearch.Enabled = false;
                txtsearch.BackColor = Color.FromArgb(165, 165, 165);
                namaieshy.BackgroundImage = T1K.Properties.Resources.searchoff;
                txtsearch.Clear();

                dgv1.Hide();
                dgv2.Hide();
                day.Show();
                dgv4.Hide();

                dgv1.Enabled = false;
                dgv2.Enabled = false;
                day.Enabled = true;
                dgv4.Enabled = false;

                day.Focus();
                txtnext.Text = d.ToShortDateString();
            }
            else if (level == 4)
            {
                txtsearch.Enabled = false;
                txtsearch.BackColor = Color.FromArgb(165, 165, 165);
                namaieshy.BackgroundImage = T1K.Properties.Resources.searchoff;
                txtsearch.Clear();

                dgv1.Hide();
                dgv2.Hide();
                day.Hide();
                dgv4.Show();

                dgv1.Enabled = false;
                dgv2.Enabled = false;
                day.Enabled = false;
                dgv4.Enabled = true;

                txtnext.Focus();
                txtnext.Clear();
            }
        }
        public void sfg()
        {
            if (level == 1)
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                List<MoshtarekinViewModel> listModel = new List<MoshtarekinViewModel>();
                //foreach (var i in a.trusts)
                //{
                //    sti1 = (int)i.trust_mokhatabin_id;
                //}
                foreach (var mi in a.moshtarekins)
                {
                    if (mi.moshtarekin_b_id == null)
                    {
                        if (mi.moshtarekin_name.Contains(txtsearch.Text) || mi.moshtarekin_family.Contains(txtsearch.Text) || mi.moshtarekin_codmeli.Contains(txtsearch.Text) || (mi.moshtarekin_name.ToString() + " " + mi.moshtarekin_family.ToString()).Contains(txtsearch.Text))
                        {
                            listModel.Add(new MoshtarekinViewModel()
                            {
                                moshtarekin_id = mi.moshtarekin_id,
                                moshtarekin_name = mi.moshtarekin_name + " " + mi.moshtarekin_family,
                                moshtarekin_number = mi.moshtarekin_number == null ? "" : mi.moshtarekin_number,
                                moshtarekin_age = mi.moshtarekin_age,
                                moshtarekin_codmeli = mi.moshtarekin_codmeli == null ? "" : mi.moshtarekin_codmeli,
                            });
                        }
                    }
                }
                dgv1.DataSource = listModel;

                levelup();
                if (listModel.Count() == 0)
                {
                    dgv1.DataSource = null;
                    txtnext.Clear();
                }
                sh1 = txtsearch.Text;
            }
            else if (level == 2)
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                List<BookViewModel> listModel = new List<BookViewModel>();
                //foreach (var i in a.trusts)
                //{
                //    sti2 = (int)i.trust_book_id;
                //}
                foreach (var bi in a.Books)
                {
                    if (bi.book_m_id == null)
                    {
                        if (bi.book_name.Contains(txtsearch.Text))
                        {
                            listModel.Add(new BookViewModel()
                            {
                                book_id = bi.book_id,
                                book_molaf = bi.book_molaf = bi.book_molaf,
                                book_mozo = bi.book_mozo == null ? "" : bi.book_mozo,
                                book_name = bi.book_name == null ? "" : bi.book_name,
                                book_radeseni = bi.book_radeseni == null ? "" : bi.book_radeseni,
                            });
                        }
                    }
                }
                dgv2.DataSource = listModel;

                levelup();
                if (listModel.Count() == 0)
                {
                    dgv2.DataSource = null;
                    txtnext.Clear();
                }
                sh2 = txtsearch.Text;
            }
        }
        public void ChangeTem()
        {
            //form
            if (tem == "brown")
            {
                this.BackColor = Color.FromArgb(225, 194, 163);
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(201, 238, 234);
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(40, 0, 101);
            }
            //texts
            foreach (var i in this.Controls)
            {
                if (i is TextBox)
                {
                    if (tem == "brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(156, 90, 14);
                    }
                    if (tem == "dark brown")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(145, 110, 0);
                    }
                    if (tem == "blue")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(81, 53, 229);
                    }
                    if (tem == "dark blue")
                    {
                        ((TextBox)i).BackColor = Color.FromArgb(206, 0, 255);
                    }
                    if (tem == "brown" || tem == "blue")
                    {
                        ((TextBox)i).ForeColor = Color.White;
                    }
                    else if (tem == "dark brown" || tem == "dark blue")
                    {
                        ((TextBox)i).ForeColor = Color.Black;
                    }
                }
            }
            //datagridview
            foreach (var i in this.Controls)
            {
                if (i is DataGridView)
                {
                    if (tem == "brown")
                    {
                        ((DataGridView)i).BackgroundColor = Color.FromArgb(255, 194, 0);
                        //dataGridView.ForeColor = Color.Black;

                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(181, 116, 10);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(181, 116, 10);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                        ((DataGridView)i).RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(245, 211, 121);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 90, 14);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (tem == "dark brown")
                    {
                        ((DataGridView)i).BackgroundColor = Color.FromArgb(145, 110, 0);
                        //dataGridView.ForeColor = Color.Black;

                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(107, 80, 44);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 80, 44);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                        ((DataGridView)i).RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(121, 89, 2);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 80, 44);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.ForeColor = Color.White;
                    }
                    if (tem == "blue")
                    {
                        ((DataGridView)i).BackgroundColor = Color.FromArgb(81, 53, 229);
                        //dataGridView.ForeColor = Color.White;

                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 176, 184);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 176, 184);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                        ((DataGridView)i).RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(118, 109, 231);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 217, 169);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.ForeColor = Color.White;
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
                    }
                    if (tem == "dark blue")
                    {
                        ((DataGridView)i).BackgroundColor = Color.FromArgb(206, 0, 255);
                        //dataGridView.ForeColor = Color.White;

                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(147, 0, 226);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 0, 226);
                        ((DataGridView)i).ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                        ((DataGridView)i).RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(140, 0, 193);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(122, 0, 214);
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
                        ((DataGridView)i).RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
                    }
                }
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
            //days
            if (tem == "brown")
            {
                day.BackColor = Color.FromArgb(156, 90, 14);
                day.TodayBackColor = Color.FromArgb(156, 90, 14);
                day.TodayRectColor = Color.FromArgb(156, 90, 14);
                day.WeekDaysBackColor = Color.FromArgb(156, 90, 14);

                day.BorderColor = Color.FromArgb(255, 194, 0);
                day.DaysBackColor = Color.FromArgb(255, 194, 0);
                day.TitleBackColor = Color.FromArgb(255, 194, 0);
            }
            if (tem == "dark brown")
            {
                day.BackColor = Color.FromArgb(145, 110, 0);
                day.TodayBackColor = Color.FromArgb(145, 110, 0);
                day.TodayRectColor = Color.FromArgb(145, 110, 0);
                day.WeekDaysBackColor = Color.FromArgb(145, 110, 0);

                day.BorderColor = Color.FromArgb(107, 80, 44);
                day.DaysBackColor = Color.FromArgb(107, 80, 44);
                day.TitleBackColor = Color.FromArgb(107, 80, 44);
            }
            if (tem == "blue")
            {
                day.BackColor = Color.FromArgb(81, 53, 229);
                day.TodayBackColor = Color.FromArgb(81, 53, 229);
                day.TodayRectColor = Color.FromArgb(81, 53, 229);
                day.WeekDaysBackColor = Color.FromArgb(81, 53, 229);

                day.BorderColor = Color.FromArgb(41, 217, 169);
                day.DaysBackColor = Color.FromArgb(41, 217, 169);
                day.TitleBackColor = Color.FromArgb(41, 217, 169);
            }
            if (tem == "dark blue")
            {
                day.BackColor = Color.FromArgb(206, 0, 255);
                day.TodayBackColor = Color.FromArgb(206, 0, 255);
                day.TodayRectColor = Color.FromArgb(206, 0, 255);
                day.WeekDaysBackColor = Color.FromArgb(206, 0, 255);

                day.BorderColor = Color.FromArgb(122, 0, 214);
                day.DaysBackColor = Color.FromArgb(122, 0, 214);
                day.TitleBackColor = Color.FromArgb(122, 0, 214);
            }
            //forcolors
            if (tem == "brown" || tem == "blue")
            {
                day.ForeColor = Color.Black;
                day.BoldedDayForeColor = Color.White;

                day.DaysForeColor = Color.Black;
                day.LineWeekColor = Color.White;
                day.TitleForeColor = Color.Black;
                day.TodayForeColor = Color.Black;
                day.WeekDaysForeColor = Color.Black;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                day.ForeColor = Color.White;
                day.BoldedDayForeColor = Color.Black;

                day.DaysForeColor = Color.White;
                day.LineWeekColor = Color.Black;
                day.TitleForeColor = Color.Black;
                day.TodayForeColor = Color.Black;
                day.WeekDaysForeColor = Color.Black;
            }
        }
        public void searchChangeTem()
        {
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
        }

        #region Keys Void
        public void SaveClick()
        {
            if (level == 1)
            {
                txtlevel1.Text = txtnext.Text;              
            }
            if (level == 2)
            {
                txtlevel2.Text = txtnext.Text;
            }
            if (level == 3)
            {
                txtlevel3.Text = txtnext.Text;
            }
            if (level == 4)
            {
                txtlevel4.Text = txtnext.Text;
            }

            if (nextlevel == 1)
            {
                level = 2;
                fdg2();
                levelup();
                txtsearch.Clear();
                dgv2.Select();
            }
            else if (nextlevel == 2)
            {
                level = 3;
                levelup();
                txtsearch.Clear();
            }
            else if (nextlevel == 3)
            {
                level = 4;
                levelup();
            }
            else if (nextlevel == 4)
            {
                frmdelete.mfg = "add";
                msg = txtlevel1.Text;
                msg2 = txtlevel2.Text;
                msg3 = txtlevel3.Text;
                msg4 = txtlevel4.Text;
                frmdelete g = new frmdelete();
                g.ShowDialog();
                if (msg == "yes")
                {
                    KetabkhoneEntities a = new KetabkhoneEntities();
                    trust c = new trust();
                    foreach (var i in a.moshtarekins)
                    {
                        if (i.moshtarekin_name.ToString() + " " + i.moshtarekin_family.ToString() == txtlevel1.Text)
                        {
                            c.trust_mokhatabin_id = i.moshtarekin_id;
                        }
                    }
                    foreach (var i in a.Books)
                    {
                        if (i.book_name == txtlevel2.Text)
                        {
                            c.trust_book_id = i.book_id;
                        }
                    }
                    c.trust_timestart = d;
                    c.trust_later = int.Parse(txtlevel4.Text);
                    c.trust_timeend = d.AddDays(int.Parse(txtlevel4.Text));

                    BL.tcreate(c);
                    txtclear();
                    nextlevel = 1;
                    level = 1;
                    fdg1();
                    levelup();
                }
                else
                {

                }
            }
        }
        public void ShowAllClick()
        {
            if (level == 1)
            {
                fdg1();
                levelup();
            }
            else if (level == 2)
            {
                fdg2();
                levelup();
            }
            else if (level == 3)
            {
                day.Focus();
                levelup();
            }
            else if (level == 4)
            {
                fdg4();
                levelup();
            }
        }
        public void mudvg1()
        {
            try
            {
                int index = dgv1.Rows.IndexOf(this.dgv1.CurrentRow);
                this.dgv1.Rows[index].Selected = true;
                //this.dgv1.Rows[index].Selected = true;
                dgv1.Focus();
                id = (int)(dgv1.SelectedRows[0].Cells[0].Value);
                levelup();
            }
            catch { }
        }
        public void mudvg2()
        {
            try
            {
                int index = dgv2.Rows.IndexOf(this.dgv2.CurrentRow);
                this.dgv2.Rows[index].Selected = true;
                //this.dgv2.Rows[index]. = true;
                dgv2.Focus();
                id = (int)(dgv2.SelectedRows[0].Cells[0].Value);
                levelup();
            }
            catch { }
        }

        public void keypro(KeyEventArgs e)
        {
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

            if (e.KeyData.ToString() == "R, Control")
            {
                ShowAllClick();
            }

            if (e.KeyData.ToString() == "D1, Control" || e.KeyData.ToString() == "NumPad1, Control")
            {
                Level1Click();
            }
            else if (e.KeyData.ToString() == "D2, Control" || e.KeyData.ToString() == "NumPad2, Control")
            {
                Level2Click();
            }
            else if (e.KeyData.ToString() == "D3, Control" || e.KeyData.ToString() == "NumPad3, Control")
            {
                Level3Click();
            }
            else if (e.KeyData.ToString() == "D4, Control" || e.KeyData.ToString() == "NumPad4, Control")
            {
                Level4Click();
            }
            //MessageBox.Show(e.KeyData.ToString() + " "+"data");
            //MessageBox.Show(e.KeyCode.ToString() + " "+"code");
            //MessageBox.Show(e.KeyValue.ToString() + " "+"value");
        }

        public void Level1Click()
        {
            if (txtlevel1.Text != "")
            {
                level = 1;
                levelup();
                txtsearch.Text = sh1;
                //fdg1();              
            }
        }
        public void Level2Click()
        {
            if (txtlevel2.Text != "")
            {
                level = 2;
                levelup();
                txtsearch.Text = sh2;
            }
        }
        public void Level3Click()
        {
            if (txtlevel3.Text != "")
            {
                level = 3;
                levelup();
            }
        }
        public void Level4Click()
        {
            if (txtlevel4.Text != "")
            {
                level = 4;
                levelup();
                txtnext.Text = txtlevel4.Text;
            }
        }
        #endregion




        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                if (level == 1)
                {
                    fdg1();
                    levelup();
                }
                if (level == 2)
                {
                    fdg2();
                    levelup();
                }
            }
            else
            {
                sfg();
            }
        }

        private void txtnext_TextChanged(object sender, EventArgs e)
        {
            if (txtnext.Text == "")
            {
                btnsave.Enabled = false;
                btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            }
            else
            {
                btnsave.Enabled = true;
                btnsave.BackgroundImage = T1K.Properties.Resources.save;
            }

            if (level != 4)
            {
                levelup();
            }
            else
            {
                fdg4();
            }

            if (level == 4)
            {
                txtnext.MaxLength = 3;
            }
            else
            {
                txtnext.MaxLength = 300;
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

        private void day_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            d = selectedDateTime;
            txtnext.Text = d.Date.ToShortDateString();
        }



        private void dgv1_MouseUp(object sender, MouseEventArgs e)
        {
            mudvg1();
        }
        private void dgv2_MouseUp(object sender, MouseEventArgs e)
        {
            mudvg2();
        }
        private void txtlevel1_Enter(object sender, EventArgs e)
        {
            txtnext.Focus();
        }

        private void txtlevel1_Click(object sender, EventArgs e)
        {
            Level1Click();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }

        private void txtlevel1_TextChanged(object sender, EventArgs e)
        {
            if (txtlevel1.Text != "")
            {
                if (nextlevel < 2)
                {
                    nextlevel = 1;
                }
            }
        }

        private void txtlevel2_TextChanged(object sender, EventArgs e)
        {
            if (txtlevel2.Text != "")
            {
                if (nextlevel < 3)
                {
                    nextlevel = 2;
                }
            }
        }

        private void txtlevel3_TextChanged(object sender, EventArgs e)
        {
            if (txtlevel3.Text != "")
            {
                if (nextlevel < 4)
                {
                    nextlevel = 3;
                }
            }
        }

        private void txtlevel2_Click(object sender, EventArgs e)
        {
            Level2Click();
        }

        private void txtlevel3_Click(object sender, EventArgs e)
        {
            Level3Click();
        }

        private void txtlevel4_Click(object sender, EventArgs e)
        {
            Level4Click();
        }

        private void txtlevel4_TextChanged(object sender, EventArgs e)
        {
            if (txtlevel4.Text != "")
            {
                nextlevel = 4; 
            }
        }

        private void txtnext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (level == 4)
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
        }

        private void txtnext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveClick();
            }
            keypro(e);
        }

        private void dgv1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                mudvg1();
            }
        }

        private void dgv2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                mudvg2();
            }         
        }

        private void dgv4_Enter(object sender, EventArgs e)
        {
            txtnext.Focus();
        }

        private void dgv1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SaveClick();
            }
            keypro(e);
        }

        private void dgv2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SaveClick();
            }
            keypro(e);
        }

        private void day_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveClick();
            }
            keypro(e);
        }
    }

}
