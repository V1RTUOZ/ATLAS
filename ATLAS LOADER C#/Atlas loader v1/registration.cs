using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Atlas_loader_v1
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        
        void Register(string user,string pass,string hwid)
        {
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.Proxy = null;//Anti-fiddler etc
                    var response = wc.DownloadString($"{Program.URL}register/{user}/{pass}/{hwid}");//Dont change this
                    //MessageBox.Show(response);
                    var obj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(response);//JSON Parse without libraries                   
                    switch (obj["response"])
                    {
                        case "4"://Logged
                            Erro("User registred");
                            break;
                        case "407"://User already exists
                            Erro("You have entered an existing username");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Erro(ex.Message);
            }
        }
        #region UI and things
        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        void Erro(string erro)
        {
            error.Text = erro;
        }
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_Enter(object sender, EventArgs e)
        {           
            bar_user.BackColor = Color.FromArgb(241, 88, 34);
        }

        private void username_Leave(object sender, EventArgs e)
        {
            bar_user.BackColor = Color.White;
        }

        private void password_Enter(object sender, EventArgs e)
        {
            bar_pass.BackColor = Color.FromArgb(241, 88, 34);
        }

        private void password_Leave(object sender, EventArgs e)
        {
            bar_pass.BackColor = Color.White;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                move.ReleaseCapture();
                move.SendMessage(Handle, move.WM_NCLBUTTONDOWN, move.HT_CAPTION, 0);
            }
        }
        bool EmptyFields()
        {
            if (username.Text == "" || password.Text == "")
                return false;

            return true;
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            if(!EmptyFields())
            {
                Erro("Empty username or password");
            }
            else
            {
                Register(username.Text, password.Text, Program.GetMachineGuid());
            }
 
        }  
        private void error_SizeChanged(object sender, EventArgs e)
        {
            error.Left = (this.body.Width - error.Size.Width) / 2;
        }
        

        private void register_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
        #endregion
    }
}
