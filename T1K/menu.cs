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

namespace T1K
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void menu_Load(object sender, EventArgs e)
        {
            fo = "fn";
            loginform login = new loginform();
            login.ShowDialog();
            ChangeUser();
            ChangeTem();
            timer1.Start();
        }
        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        public static string start;
        public static string bookrun;
        public static string moshtarekinrun;
        public static string trustrun;
        public static string addrun;
        public static string settingrun;
        public static string fo;
        public static string tem;
        public static int userid;





        private void timer1_Tick(object sender, EventArgs e)
        {
            if (start == "start")
            {
                if (Opacity != 1)
                {
                    Opacity += 0.035;
                }
                else
                {
                    // timer1.Stop();
                    start = "stop";
                }
            }
            else if (start == "close")
            {
                this.Close();
            }

            if (bookrun == "closed")
            {
                books.Enabled = true;
                bookrun = "ready for run";
            }

            if (moshtarekinrun == "closed")
            {
                moshtarekin.Enabled = true;
                moshtarekinrun = "ready for run";
            }

            if (trustrun == "closed")
            {
                trust.Enabled = true;
                trustrun = "ready for run";
            }

            if (settingrun == "closed")
            {
                setting.Enabled = true;
                settingrun = "ready for run";
            }

            if (addrun == "runing")
            {
                add.Enabled = false;
                add.BackgroundImage = T1K.Properties.Resources.addoff1;
            }
            else
            {
                add.Enabled = true;
                addrun = "ready for run";
                add.BackgroundImage = T1K.Properties.Resources.Picture2;
            }


            if (fo == "fo")
            {
                this.Focus();
                fo = "fn";
            }
        }



        public void ChangeTem()
        {
            //form
            if (tem == "brown")
            {
                this.BackColor = Color.FromArgb(255, 194, 0);
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(41, 217, 169);
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(40, 0, 101);
            }
            //btn
            foreach (var b in this.Controls)
            {
                if (b is Button)
                {
                    if (((Button)b).Name != btnclose.Name && ((Button)b).Name != btnback.Name)
                    {
                        if (tem == "brown")
                        {
                            ((Button)b).BackColor = Color.FromArgb(156, 90, 14);
                            ((Button)b).ForeColor = Color.Black;
                        }
                        if (tem == "dark brown")
                        {
                            ((Button)b).BackColor = Color.FromArgb(107, 80, 44);
                            ((Button)b).ForeColor = Color.White;
                        }
                        if (tem == "blue")
                        {
                            ((Button)b).BackColor = Color.FromArgb(81, 53, 229);
                            ((Button)b).ForeColor = Color.Black;
                        }
                        if (tem == "dark blue")
                        {
                            ((Button)b).BackColor = Color.FromArgb(122, 0, 214);
                            ((Button)b).ForeColor = Color.White;
                        }
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
        }
        public void ChangeUser()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            foreach (var i in a.admins)
            {
                if (i.admin_id == userid)
                {
                    tem = i.tem;
                }
            }
        }
        public void temforms()
        {
            loginform.tem = tem;
            frmbooks.tem = tem;
            frmmoshtarekin.tem = tem;
            frmtrust.tem = tem;
            frmsetting.tem = tem;
            frmadd.tem = tem;
            frmdelete.tem = tem;
        }





        private void btnclos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            if (bookrun == "runing")
                ((frmbooks)Application.OpenForms["frmbooks"]).Hide();
            if (moshtarekinrun == "runing")
                ((frmmoshtarekin)Application.OpenForms["frmmoshtarekin"]).Hide();
            if (addrun == "runing")
                ((frmadd)Application.OpenForms["frmadd"]).Hide();
            if (settingrun == "runing")
                ((frmsetting)Application.OpenForms["frmsetting"]).Hide();
            if (trustrun == "runing")
                ((frmtrust)Application.OpenForms["frmtrust"]).Hide();

            Opacity = 0;
            loginform login = new loginform();
            login.ShowDialog();
        }


        private void books_Click(object sender, EventArgs e)
        {
            frmbooks b = new frmbooks();
            b.Show();

            bookrun = "runing";
            books.Enabled = false;

        }
        private void moshtarekin_Click(object sender, EventArgs e)
        {
            frmmoshtarekin m = new frmmoshtarekin();
            m.Show();

            moshtarekinrun = "runing";
            moshtarekin.Enabled = false;
        }
        private void trust_Click(object sender, EventArgs e)
        {
            frmtrust t = new frmtrust();
            t.Show();

            trustrun = "runing";
            trust.Enabled = false;
        }




        private void btnback_MouseEnter(object sender, EventArgs e)
        {
            btnback.BackgroundImage = T1K.Properties.Resources.back2;
        }
        private void btnback_MouseLeave(object sender, EventArgs e)
        {
            btnback.BackgroundImage = T1K.Properties.Resources.back;
            
        }
        private void btnclose_MouseEnter(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle2;
        }
        private void btnclose_MouseLeave(object sender, EventArgs e)
        {
            btnclose.BackgroundImage = T1K.Properties.Resources.cancle;
        }

        private void add_Click(object sender, EventArgs e)
        {
            frmadd a = new frmadd();
            a.Show();

            addrun = "runing";
            add.Enabled = false;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            frmsetting s = new frmsetting();
            s.Show();

            settingrun = "runing";
            setting.Enabled = false;
        }

        private void menu_Activated(object sender, EventArgs e)
        {
            ChangeUser();
            ChangeTem();
            temforms();
        }







        //private void menu_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        if (WindowState == FormWindowState.Maximized)
        //        {
        //            WindowState = FormWindowState.Normal;
        //        }
        //        else if (WindowState == FormWindowState.Normal)
        //        {
        //            WindowState = FormWindowState.Maximized;
        //        }

        //    }

        //    if (e.KeyCode == Keys.Escape)
        //    {
        //        WindowState = FormWindowState.Minimized;
        //    }
        //}
    }
}
