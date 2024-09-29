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
    public partial class loginform : Form
    {
        
        public loginform()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_Load(object sender, EventArgs e)
        {
            fa();
            ChangeTem();
            button1.Size = new Size(0, 0);
            timer.Start();

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        public int userid;
        public static string tem;
        //KetabkhoneEntities a = new KetabkhoneEntities();
        public void login ()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            foreach (var i in a.admins)
            {
                if (textBox1.Text == i.admin_user)
                {
                    menu.userid = userid;
                    menu.start = "start";

                    if (menu.bookrun == "runing")
                        ((frmbooks)Application.OpenForms["frmbooks"]).Hide();
                    if (menu.moshtarekinrun == "runing")
                        ((frmmoshtarekin)Application.OpenForms["frmmoshtarekin"]).Hide();
                    if (menu.trustrun == "runing")
                        ((frmtrust)Application.OpenForms["frmtrust"]).Show();
                    if (menu.addrun == "runing")
                        ((frmadd)Application.OpenForms["frmadd"]).Show();
                    if (menu.settingrun == "runing")
                        ((frmsetting)Application.OpenForms["frmsetting"]).Show();

                    this.Close();
                }
            }
        }
        public void ChangeTem()
        {
            if(tem == "brown")
            {
                this.BackColor = Color.FromArgb(238, 222, 201);

                textBox1.BackColor = Color.FromArgb(156, 90, 14);
                textBox1.ForeColor = Color.White;

                button1.BackColor = Color.FromArgb(255, 194, 0);
                button1.ForeColor = Color.Black;
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(49, 29, 6);

                textBox1.BackColor = Color.FromArgb(145, 110, 0);
                textBox1.ForeColor = Color.Black;

                button1.BackColor = Color.FromArgb(107, 80, 44);
                button1.ForeColor = Color.White;
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(201, 238, 234);

                textBox1.BackColor = Color.FromArgb(81, 53, 229);
                textBox1.ForeColor = Color.White;

                button1.BackColor = Color.FromArgb(41, 217, 169);
                button1.ForeColor = Color.Black;
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(40, 0, 101);

                textBox1.BackColor = Color.FromArgb(206, 0, 255);
                textBox1.ForeColor = Color.Black;

                button1.BackColor = Color.FromArgb(122, 0, 214);
                button1.ForeColor = Color.White;
            }
        }
        public void fa()
        {
            KetabkhoneEntities a = new KetabkhoneEntities();
            //admin root = new admin();
            //root.admin_id = 1;
            //root.tem = "dark blue";
            //root.admin_user = "5555";
            //a.admins.Add(root);
            foreach (var i in a.admins)
            {
                if (i.admin_user == textBox1.Text)
                {
                    tem = i.tem;
                    userid = i.admin_id;
                }
            }

            //tem = root.tem;
            //userid = root.admin_id;


        }






        private void button2_Click(object sender, EventArgs e)
        {
            menu.start = "close";
            this.Close();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = false;
            button2.BackColor = Color.FromArgb(255, Color.Red);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.UseVisualStyleBackColor = true;
            button2.BackColor = Color.Maroon;
        }





        private void timer_Tick(object sender, EventArgs e)
        {
            Opacity += 0.04;
            if (Opacity == 1)
            {
                if (button1.Size != new Size(200, 100))
                {
                    
                    button1.Size = new Size(200, button1.Size.Height + 4);

                }
                else
                {
                    timer.Stop();
                }
            }
            

        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
             textBox1.Select();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                textBox1.Clear();
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



        public void button1_Click(object sender, EventArgs e)
        {
            login();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fa();
            ChangeTem();
        }
    }
}
