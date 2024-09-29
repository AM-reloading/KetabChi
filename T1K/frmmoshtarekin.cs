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

namespace T1K
{
    public partial class frmmoshtarekin : Form
    {
        public frmmoshtarekin()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmmoshtarekin_Load(object sender, EventArgs e)
        {
            ChangeTem();
            FillDataGrid();
            dataGridView.AutoGenerateColumns = false;
            id = (int)(dataGridView.SelectedRows[0].Cells[0].Value);
            cu = "u";
            t = "hide";
            m = "hide";
            s = "hide";
            vload();
            panel.Size = new Size(0, 0);
            panel.Location = new Point(170, 20);
            tols.Size = new Size(1161, 0);
            tols.Location = new Point(184, 11);
            spanel.Size = new Size(550, 0);
            spanel.Location = new Point(669, 24);
            btnsave.Enabled = false;
            btnsave.BackgroundImage = T1K.Properties.Resources.saveoff;
            dataGridView.Select();
        }
        private void frmmoshtarekin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmmoshtarekin_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.moshtarekinrun = "closed";
            menu.fo = "fo";
        }





        //KetabkhoneEntities a = new KetabkhoneEntities();
        updataed uhistory = new updataed();
        BLbook BL = new BLbook();
        DateTime d;
        public static string msg;
        //string p;
        string cu;
        string m;
        string t;
        string s;
        string num;
        string cod;
        string fam;
        string nam;
        public static string tem;
        int id;
        int ago;
        DateTime ah;





        public void vload()
        {
            cmoago.Text = "۱ماهه";
            ago = 30;
            d = DateTime.Now;
            day.Hide();
        }
        public void FillDataGrid()
        {
            MchangeAGO();
            KetabkhoneEntities a = new KetabkhoneEntities();
            //var mlist = a.moshtarekins.ToList();
            List<MoshtarekinViewModel> listModel = new List<MoshtarekinViewModel>();
            foreach (var mi in a.moshtarekins)
            {
                try
                {
                    listModel.Add(new MoshtarekinViewModel()
                    {
                        moshtarekin_id = mi.moshtarekin_id,
                        moshtarekin_name = mi.moshtarekin_name = mi.moshtarekin_name,
                        moshtarekin_family = mi.moshtarekin_family == null ? "" : mi.moshtarekin_family,
                        moshtarekin_number = mi.moshtarekin_number == null ? "" : mi.moshtarekin_number,
                        moshtarekin_age = mi.moshtarekin_age,
                        moshtarekin_codmeli = mi.moshtarekin_codmeli == null ? "" : mi.moshtarekin_codmeli,
                        moshtarekin_start = mi.moshtarekin_start.Value.Date.ToShortDateString(),
                        moshtarekin_timeago = (int)mi.moshtarekin_timeago,
                        moshtarekin_timeend = mi.moshtarekin_timeend.Value.Date.ToShortDateString(),
                        book_name = mi.Book.book_name == null ? "" : mi.Book.book_name,
                    });
                }
                catch
                {
                    listModel.Add(new MoshtarekinViewModel()
                    {
                        moshtarekin_id = mi.moshtarekin_id,
                        moshtarekin_name = mi.moshtarekin_name = mi.moshtarekin_name,
                        moshtarekin_family = mi.moshtarekin_family == null ? "" : mi.moshtarekin_family,
                        moshtarekin_number = mi.moshtarekin_number == null ? "" : mi.moshtarekin_number,
                        moshtarekin_age = mi.moshtarekin_age,
                        moshtarekin_codmeli = mi.moshtarekin_codmeli == null ? "" : mi.moshtarekin_codmeli,
                        moshtarekin_start = mi.moshtarekin_start.Value.Date.ToShortDateString(),
                        moshtarekin_timeago = (int)mi.moshtarekin_timeago,
                        moshtarekin_timeend = mi.moshtarekin_timeend.Value.Date.ToShortDateString(),
                        book_name = "",
                    });
                }
            }
            dataGridView.DataSource = listModel;
            MousUpDateGridView();
        }
        public void sdatagrid()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = from i in a.moshtarekins where i.moshtarekin_name.Contains(txtsearch.Text) || i.moshtarekin_family.Contains(txtsearch.Text) || i.moshtarekin_codmeli.Contains(txtsearch.Text) || (i.moshtarekin_name.ToString() + " " + i.moshtarekin_family.ToString()).Contains(txtsearch.Text) select i;
            List<MoshtarekinViewModel> listModel = new List<MoshtarekinViewModel>();
            foreach (var item in ss)
            {
                //foreach (var i in a.trusts)
                //{
                //    if (i.moshtarekin.moshtarekin_id == item.moshtarekin_id)
                //    {
                //        p = i.Book.book_name;
                //    }
                //    else
                //    {
                //        p = null;
                //    }
                //}
                listModel.Add(new MoshtarekinViewModel()
                {
                    moshtarekin_id = item.moshtarekin_id,
                    moshtarekin_name = item.moshtarekin_name = item.moshtarekin_name,
                    moshtarekin_family = item.moshtarekin_family == null ? "" : item.moshtarekin_family,
                    moshtarekin_number = item.moshtarekin_number == null ? "" : item.moshtarekin_number,
                    moshtarekin_age = item.moshtarekin_age,
                    moshtarekin_codmeli = item.moshtarekin_codmeli == null ? "" : item.moshtarekin_codmeli,
                    moshtarekin_start = item.moshtarekin_start.Value.Date.ToShortDateString(),
                    moshtarekin_timeago = (int)item.moshtarekin_timeago,
                    moshtarekin_timeend = item.moshtarekin_timeend.Value.Date.ToShortDateString(),

                    //book_name = p == null ? "" : p,
                });
            }
            dataGridView.DataSource = listModel;
        }
        public void MchangeAGO()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            int now;
            int aid;
            foreach (var i in a.moshtarekins)
            {
                aid = i.moshtarekin_id;
                now = (int)((i.moshtarekin_timeend.Value.Date - DateTime.Now.Date).Days);
                BL.MchangeAGO(now, aid);
            }
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
            txtname.Clear();
            txtfamily.Clear();
            txtnumber.Clear();
            txtage.Clear();
            txtcodemeli.Clear();
            days.Text = d.ToShortDateString();
        }
        public void eu()
        {
            if (cu == "u") 
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                foreach (var i in a.moshtarekins)
                {
                    if (i.moshtarekin_id == id)
                    {
                        txtname.Text = i.moshtarekin_name;
                        txtfamily.Text = i.moshtarekin_family;
                        txtnumber.Text = i.moshtarekin_number;
                        txtage.Text = i.moshtarekin_age.ToString();
                        txtcodemeli.Text = i.moshtarekin_codmeli;
                        days.Text = i.moshtarekin_start.Value.ToShortDateString();



                        uhistory.updataed_moshtarekin_id = i.moshtarekin_id;
                        uhistory.updataed_moshtarekin_name = i.moshtarekin_name;
                        uhistory.updataed_moshtarekin_family = i.moshtarekin_family;
                        uhistory.updataed_moshtarekin_number = i.moshtarekin_number.ToString();
                        uhistory.updataed_moshtarekin_age = i.moshtarekin_age;
                        uhistory.updataed_moshtarekin_codmeli = i.moshtarekin_codmeli;
                        uhistory.updataed_moshtarekin_start = i.moshtarekin_start.ToString();
                        uhistory.updataed_moshtarekin_timeago = i.moshtarekin_timeago;

                        //ah = i.moshtarekin_start.Value.AddDays((int)i.moshtarekin_timeago);
                        ah = i.moshtarekin_timeend.Value;
                        num = i.moshtarekin_number;
                        cod = i.moshtarekin_codmeli;
                        nam = i.moshtarekin_name;
                        fam = i.moshtarekin_family;
                    }
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
            txtclear();
            dataGridView.Select();
        }
        public void onoff()
        {
            if (txtname.Text != "" && txtcodemeli.Text != "" && txtcodemeli.Text.Length == 10 && txtage.Text != "" && txtnumber.Text != "" && txtfamily.Text != "" )
            {
                KetabkhoneEntities a = new KetabkhoneEntities();
                if (cu == "c")
                {
                    var o = a.moshtarekins.Where(i => (i.moshtarekin_name == txtname.Text && i.moshtarekin_family == txtfamily.Text) || (i.moshtarekin_number == txtnumber.Text) || (i.moshtarekin_codmeli == txtcodemeli.Text));
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
                    var o = a.moshtarekins.Where(l => (l.moshtarekin_name == txtname.Text && l.moshtarekin_family == txtfamily.Text && l.moshtarekin_name != nam && l.moshtarekin_family != fam) || (l.moshtarekin_number == txtnumber.Text && l.moshtarekin_number != num) || (l.moshtarekin_codmeli == txtcodemeli.Text && l.moshtarekin_codmeli != cod));
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
        public void montoday()
        {
            if (cmoago.Text == "۱ماهه")
            {
                ago = 30;
            }
            else if (cmoago.Text == "۲ماهه")
            {
                ago = 60;
            }
            else if (cmoago.Text == "۳ماهه")
            {
                ago = 90;
            }
        }
        public void eror(int t)
        {
            try
            {
                if (t == 1)
                {
                    int.Parse(txtnumber.Text);
                }
                else if (t == 2)
                {
                    int.Parse(txtage.Text);
                }
                else if (t == 3)
                {
                    int.Parse(txtcodemeli.Text);
                }
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
            //texts
            if (tem == "brown")
            {
                txtname.BackColor = Color.FromArgb(156, 90, 14);
                txtfamily.BackColor = Color.FromArgb(156, 90, 14);
                txtnumber.BackColor = Color.FromArgb(156, 90, 14);
                txtage.BackColor = Color.FromArgb(156, 90, 14);
                txtcodemeli.BackColor = Color.FromArgb(156, 90, 14);
                txtsearch.BackColor = Color.FromArgb(156, 90, 14);
            }
            if (tem == "dark brown")
            {
                txtname.BackColor = Color.FromArgb(145, 110, 0);
                txtfamily.BackColor = Color.FromArgb(145, 110, 0);
                txtnumber.BackColor = Color.FromArgb(145, 110, 0);
                txtage.BackColor = Color.FromArgb(145, 110, 0);
                txtcodemeli.BackColor = Color.FromArgb(145, 110, 0);
                txtsearch.BackColor = Color.FromArgb(145, 110, 0);
            }
            if (tem == "blue")
            {
                txtname.BackColor = Color.FromArgb(81, 53, 229);
                txtfamily.BackColor = Color.FromArgb(81, 53, 229);
                txtnumber.BackColor = Color.FromArgb(81, 53, 229);
                txtage.BackColor = Color.FromArgb(81, 53, 229);
                txtcodemeli.BackColor = Color.FromArgb(81, 53, 229);
                txtsearch.BackColor = Color.FromArgb(81, 53, 229);
            }
            if (tem == "dark blue")
            {
                txtname.BackColor = Color.FromArgb(206, 0, 255);
                txtfamily.BackColor = Color.FromArgb(206, 0, 255);
                txtnumber.BackColor = Color.FromArgb(206, 0, 255);
                txtage.BackColor = Color.FromArgb(206, 0, 255);
                txtcodemeli.BackColor = Color.FromArgb(206, 0, 255);
                txtsearch.BackColor = Color.FromArgb(206, 0, 255);
            }
            if (tem == "brown" || tem == "blue")
            {
                txtname.ForeColor = Color.White;
                txtfamily.ForeColor = Color.White;
                txtnumber.ForeColor = Color.White;
                txtage.ForeColor = Color.White;
                txtcodemeli.ForeColor = Color.White;
                txtsearch.ForeColor = Color.White;
            }
            else if (tem == "dark brown" || tem == "dark blue")
            {
                txtname.ForeColor = Color.Black;
                txtfamily.ForeColor = Color.Black;
                txtnumber.ForeColor = Color.Black;
                txtage.ForeColor = Color.Black;
                txtcodemeli.ForeColor = Color.Black;
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
            if (cu == "c")
            {
                moshtarekin c = new moshtarekin();
                c.moshtarekin_name = txtname.Text;
                c.moshtarekin_family = txtfamily.Text;
                c.moshtarekin_number = txtnumber.Text;
                c.moshtarekin_age = int.Parse(txtage.Text);
                c.moshtarekin_codmeli = txtcodemeli.Text;
                c.moshtarekin_start = d;
                c.moshtarekin_timeago = ago;
                c.moshtarekin_timeend = d.AddDays(ago);

                BL.mcreate(c);
                FillDataGrid();
                txtclear();
                txtsearch.Clear();
                vload();

                dataGridView.Select();
            }
            else if (cu == "u")
            {
                moshtarekin u = new moshtarekin();
                u.moshtarekin_name = txtname.Text;
                u.moshtarekin_family = txtfamily.Text;
                u.moshtarekin_number = txtnumber.Text;
                u.moshtarekin_age = int.Parse(txtage.Text);
                u.moshtarekin_codmeli = txtcodemeli.Text;
                u.moshtarekin_start = d;
                u.moshtarekin_timeago = (ah.Date - DateTime.Now.Date).Days;
                //u.moshtarekin_timeend = خودش

                //string bookname = cmobook.Text;
                BL.mupdata(id, u, uhistory);
                MchangeAGO();
                FillDataGrid();
                txtclear();
                bc();
                txtsearch.Clear();
            }
        }
        public void sCancleClick()
        {
            s = "hide";
            txtclear();
            bc();
            cu = "u";
            eu();

            KetabkhoneEntities a = new KetabkhoneEntities();
            var ss = a.moshtarekins.Where(i => i.moshtarekin_name.Contains(txtsearch.Text) || i.moshtarekin_family.Contains(txtsearch.Text) || i.moshtarekin_codmeli.Contains(txtsearch.Text) || (i.moshtarekin_name.ToString() + " " + i.moshtarekin_family.ToString()).Contains(txtsearch.Text));
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
        public void AddClick()
        {
            cmoago.Enabled = true;
            txtclear();
            cu = "c";
            m = "hide";
            t = "show";
            s = "hide";
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            txtname.Focus();
        }
        public void EditClick()
        {
            MousUpDateGridView();
            cmoago.Enabled = false;
            btnshow.Enabled = false;
            btnshow.BackgroundImage = T1K.Properties.Resources.hide;
            cu = "u";
            m = "hide";
            t = "show";
            s = "hide";
            eu();
            onoff();
            txtname.Focus();
        }
        public void DeleteClick()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            deleted d = new deleted();
            foreach (var i in a.moshtarekins)
            {
                if (i.moshtarekin_id == id)
                {
                    //MessageBox.Show("آیا میخواهید کتاب" + i.book_name + "حذف شود؟");
                    frmdelete.mfg = "moshtarekin";
                    msg = i.moshtarekin_name + " " + i.moshtarekin_family;
                    frmdelete g = new frmdelete();
                    g.ShowDialog();
                    if (msg == "yes")
                    {
                        d.deleted_moshtarekin_id = i.moshtarekin_id;
                        d.deleted_moshtarekin_name = i.moshtarekin_name;
                        d.deleted_moshtarekin_family = i.moshtarekin_family;
                        d.deleted_moshtarekin_number = i.moshtarekin_number;
                        d.deleted_moshtarekin_age = i.moshtarekin_age;
                        d.deleted_moshtarekin_codmeli = i.moshtarekin_codmeli;
                        d.deleted_moshtarekin_start = i.moshtarekin_start.ToString();
                        d.deleted_moshtarekin_timeago = i.moshtarekin_timeago;
                        BL.mdelete(id, d);
                        FillDataGrid();
                    }
                    else
                    {

                    }
                    dataGridView.Select();
                }
            }
        }
        public void ShowAllClick()
        {
            txtsearch.Clear();
            MchangeAGO();
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
                onoff();
            }
            catch
            {

            }
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
        }





        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnmini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnmini_MouseEnter(object sender, EventArgs e)
        {
            btnmini.BackgroundImage = T1K.Properties.Resources.Ellipse_9;
        }
        private void btnmini_MouseLeave(object sender, EventArgs e)
        {
            btnmini.BackgroundImage = T1K.Properties.Resources.Ellipse_7;
        }

        private void btnclose_MouseEnter(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle2;
        }
        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle;
        }



        private void btnshow_Click(object sender, EventArgs e)
        {
            timer.Start();
            bshow();
        }
        private void btnshowall_Click(object sender, EventArgs e)
        {
            ShowAllClick();
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }
        private void btncancle_Click(object sender, EventArgs e)
        { 
            bc();
            txtclear();
            cu = "u";           
        }
        private void btncancles_Click(object sender, EventArgs e)
        {
            sCancleClick();
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
        private void txtage_TextChanged(object sender, EventArgs e)
        {
            onoff();
            try
            {
                eror(2);
            }
            catch
            {
                txtage.Clear();
            }
        }
        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            onoff();         
            try
            {
                eror(1);
            }
            catch
            {
                txtnumber.Clear();
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            onoff();
        }
        private void txtfamily_TextChanged(object sender, EventArgs e)
        {
            onoff();
        }
        private void txtcodemeli_TextChanged(object sender, EventArgs e)
        { 
            onoff();
            try
            {
                eror(3);
            }
            catch (System.FormatException)
            {
                txtcodemeli.Clear();
            }
        }
        private void txtstart_Click(object sender, EventArgs e)
        {
            day.Show();
            day.Select();
        }

        private void txtnumber_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtcodemeli_KeyPress(object sender, KeyPressEventArgs e)
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



        private void cmoago_SelectedIndexChanged(object sender, EventArgs e)
        {
            montoday();
        }



        private void days_SelectedDateChanged(DateTime selectedDateTime, BehComponents.PersianDateTime selectedPersianDateTime)
        {
            d = selectedDateTime;
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
        private void txtfamily_KeyDown(object sender, KeyEventArgs e)
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
        private void txtnumber_KeyDown(object sender, KeyEventArgs e)
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
        private void txtage_KeyDown(object sender, KeyEventArgs e)
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
        private void txtcodemeli_KeyDown(object sender, KeyEventArgs e)
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

        private void days_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                bc();
                cu = "u";
            }
        }
        private void cmoago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
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
