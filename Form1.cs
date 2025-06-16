using Sha_and_RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sha_and_RSA
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Form activeForm;
        private RsaToolkitForm rsaForm;

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenChilForm(new RsaToolkitForm(), sender);
        }
        bool menuExpend = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpend == false)
            {
                menuConteiner.Height += 10;
                if (menuConteiner.Height >= 352)
                {
                    menuTransition.Stop();
                    menuExpend = true;
                }
            }
            else 
            {  
                menuConteiner.Height -= 10;
                if(menuConteiner.Height <=53)
                {
                    menuTransition.Stop();
                    menuExpend = true;
                }
            }
        }
        
        private void OpenChilForm(Form childForm , object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.Dock = DockStyle.Fill;
            this.panel.Controls.Add(childForm);
            this.panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void buttonRsaMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            OpenChilForm(new RsaToolkitForm(), sender);
            // Kontrolü her zaman NESNE (değişken) üzerinden yapmalısın.
            if (rsaForm == null || rsaForm.IsDisposed)
            {
                // Yeni bir NESNE oluşturup değişkene atıyorsun.
                rsaForm = new RsaToolkitForm();
                OpenChilForm(rsaForm, sender);
            }
            else
            {
                rsaForm.BringToFront();
            }
            
        }

        private void buttonSha_Click(object sender, EventArgs e)
        {
            OpenChilForm(new Sha256Form() , sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (rsaForm != null && !rsaForm.IsDisposed)
            {
                // ve NESNE'nin metodunu çağır.
                rsaForm.SelectTab(4);
            }
        }

        private void menuConteiner_Paint(object sender, PaintEventArgs e)
        {

        }
        //mouse ile taşıma
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKeygenerator_Click(object sender, EventArgs e)
        {
            if (rsaForm != null && !rsaForm.IsDisposed)
            {
                // ve NESNE'nin metodunu çağır.
                rsaForm.SelectTab(0);
            }
        }

        private void btnSignMessage_Click(object sender, EventArgs e)
        {
            if (rsaForm != null && !rsaForm.IsDisposed)
            {
                // ve NESNE'nin metodunu çağır.
                rsaForm.SelectTab(3);
            }
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            if (rsaForm != null && !rsaForm.IsDisposed)
            {
                // ve NESNE'nin metodunu çağır.
                rsaForm.SelectTab(2);
            }
        }

        private void btnEncryption_Click(object sender, EventArgs e)
        {
            if (rsaForm != null && !rsaForm.IsDisposed)
            {
                // ve NESNE'nin metodunu çağır.
                rsaForm.SelectTab(1);
            }
        }

        private void btnVerifySignature_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
