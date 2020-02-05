using ManualMapInjection.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlas_loader_v1
{
    public partial class logged : Form
    {
        
        public logged()
        {
            InitializeComponent();
        }

        void Inject()
        {
            try
            {
                var target = Process.GetProcessesByName("csgo").FirstOrDefault();
                if (target == null) return;

                //////////////////// INJECTION HERE ////////////////////
                ///
                using(WebClient wc = new WebClient())
                {
                    wc.Proxy = null;
                    //wc.Headers.Add("User-Agent", "custom user agent here");//If have .htaccess
                    var response = wc.DownloadData("");//Link of your DLL
                    var injector = new ManualMapInjector(target) { AsyncInjection = true }; 
                    var module = $"hmodule = 0x{injector.Inject(response).ToInt64():x8}";
                    MessageBox.Show("Injected !");
                    Environment.Exit(0);
                }
                ///
                ///////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region UI and things
        public static string Data = "";
        public static string Uid = "";
        public static string Username = "";
        public static string Days_left = "";
        private void welcome_SizeChanged(object sender, EventArgs e)
        {
            welcome.Left = (this.body.Width - welcome.Size.Width) / 2;
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {
            welcome.Text = $"Welcome, {Username} you have {Days_left} days left.";
            expiration.Text = $"Date expiration: {Data}";
        }

        private void expiration_SizeChanged(object sender, EventArgs e)
        {
            expiration.Left = (this.body.Width - expiration.Size.Width) / 2;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Inject();
        }       
        private void logged_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move.ReleaseCapture();
                move.SendMessage(Handle, move.WM_NCLBUTTONDOWN, move.HT_CAPTION, 0);
            }
        }
       

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
