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

namespace T1K
{
    public partial class frmdelete : Form
    {
        public frmdelete()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = null;
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void delete_Load(object sender, EventArgs e)
        {
            ChangeTem();
            if (mfg == "books")
            {
                label1.Text = "میخواهید کتاب" + " ( " + frmbooks.msg + " ) " + "حذف شود ؟";
            }
            else if (mfg == "moshtarekin")
            {
                label1.Text = "میخواهید اشتراک" + " ( " + frmmoshtarekin.msg + " ) " + "حذف شود ؟";
            }
            else if (mfg == "trust")
            {
                label1.Text = "کتاب" + " ( " + frmtrust.mpg + " ) " + "از" + " ( " + frmtrust.msg + " ) " + "دریافت شد؟";
            }
            else if (mfg == "admin")
            {
                label1.Text = "میخواهید کد ورود" + " ( " + frmsetting.msg + " ) " + "حذف شود ؟";
            }
            else if (mfg == "add")
            {
                label1.Text = "کتاب" + " ( " + frmadd.msg2 + " ) " + "را به" + " ( " + frmadd.msg + " ) " + Environment.NewLine + "از تاریخ" + " ( " + frmadd.msg3 + " ) " + "به مدت" + " ( " + frmadd.msg4 + " ) " + "روز تحویل میدهید؟";
            }
            this.Size = new Size(label1.Size.Width + 24, 300);
            this.MaximumSize = new Size(label1.Size.Width + 26, 302);
            this.MinimumSize = new Size(label1.Size.Width + 22, 298);
        }
        private void frmdelete_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        public static string mfg;
        public static string tem;





        public void ChangeTem()
        {
            if (tem == "brown")
            {
                this.BackColor = Color.FromArgb(156, 90, 14);

                label1.ForeColor = Color.FromArgb(255, 194, 0);
            }
            if (tem == "dark brown")
            {
                this.BackColor = Color.FromArgb(145, 110, 0);

                label1.ForeColor = Color.FromArgb(49, 29, 6);
            }
            if (tem == "blue")
            {
                this.BackColor = Color.FromArgb(81, 53, 229);

                label1.ForeColor = Color.FromArgb(201, 238, 234);
            }
            if (tem == "dark blue")
            {
                this.BackColor = Color.FromArgb(206, 0, 255);

                label1.ForeColor = Color.FromArgb(40, 0, 101);
            }
        }
        public void SaveClick()
        {
            if (mfg == "books")
            {
                frmbooks.msg = "yes";

            }
            else if (mfg == "moshtarekin")
            {
                frmmoshtarekin.msg = "yes";
            }
            else if (mfg == "trust")
            {
                frmtrust.msg = "yes";
            }
            else if (mfg == "admin")
            {
                frmsetting.msg = "yes";
            }
            else if (mfg == "add")
            {
                frmadd.msg = "yes";
            }
            this.Close();
        }
        public void CancleClick()
        {
            if (mfg == "books")
            {
                frmbooks.msg = "no";
            }
            else if (mfg == "moshtarekin")
            {
                frmmoshtarekin.msg = "no";
            }
            else if (mfg == "trust")
            {
                frmtrust.msg = "no";
            }
            else if (mfg == "admin")
            {
                frmsetting.msg = "no";
            }
            this.Close();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            SaveClick();
        }
        private void btncancle_Click(object sender, EventArgs e)
        {
            CancleClick();
        }

        private void btnsave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                CancleClick();
            }
        }
    }
}
