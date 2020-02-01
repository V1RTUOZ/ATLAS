namespace Atlas_loader_v1
{
    partial class registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.body = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.bar_user = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.bar_pass = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.tittle = new System.Windows.Forms.Label();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.body.Controls.Add(this.error);
            this.body.Controls.Add(this.register);
            this.body.Controls.Add(this.panel1);
            this.body.Controls.Add(this.login_btn);
            this.body.Controls.Add(this.bar_user);
            this.body.Controls.Add(this.username);
            this.body.Controls.Add(this.bar_pass);
            this.body.Controls.Add(this.password);
            this.body.Controls.Add(this.logo);
            this.body.Location = new System.Drawing.Point(12, 20);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(415, 482);
            this.body.TabIndex = 0;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.error.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.error.Location = new System.Drawing.Point(207, 387);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 11;
            this.error.SizeChanged += new System.EventHandler(this.error_SizeChanged);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(114, 428);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(187, 15);
            this.register.TabIndex = 4;
            this.register.Text = "You have an account ? Login here";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(12, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 2);
            this.panel1.TabIndex = 10;
            // 
            // login_btn
            // 
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.login_btn.Location = new System.Drawing.Point(122, 339);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(170, 31);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Register";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // bar_user
            // 
            this.bar_user.BackColor = System.Drawing.Color.White;
            this.bar_user.Location = new System.Drawing.Point(51, 222);
            this.bar_user.Name = "bar_user";
            this.bar_user.Size = new System.Drawing.Size(310, 3);
            this.bar_user.TabIndex = 8;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(51, 207);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(310, 16);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // bar_pass
            // 
            this.bar_pass.BackColor = System.Drawing.Color.White;
            this.bar_pass.Location = new System.Drawing.Point(51, 300);
            this.bar_pass.Name = "bar_pass";
            this.bar_pass.Size = new System.Drawing.Size(310, 3);
            this.bar_pass.TabIndex = 6;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(51, 285);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(310, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // logo
            // 
            this.logo.Image = global::Atlas_loader_v1.Properties.Resources.atlas_loader;
            this.logo.Location = new System.Drawing.Point(108, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(199, 175);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(423, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 13);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(404, -2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(13, 14);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tittle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.White;
            this.tittle.Location = new System.Drawing.Point(179, 3);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(81, 15);
            this.tittle.TabIndex = 3;
            this.tittle.Text = "ATLAS LOADER";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(438, 514);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLAS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Panel bar_user;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Panel bar_pass;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label error;
    }
}

