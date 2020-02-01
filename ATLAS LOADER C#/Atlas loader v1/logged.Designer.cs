namespace Atlas_loader_v1
{
    partial class logged
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logged));
            this.body = new System.Windows.Forms.Panel();
            this.tittle = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.expiration = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.body.Controls.Add(this.login_btn);
            this.body.Controls.Add(this.expiration);
            this.body.Controls.Add(this.welcome);
            this.body.Controls.Add(this.logo);
            this.body.Location = new System.Drawing.Point(12, 20);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(527, 364);
            this.body.TabIndex = 1;
            this.body.Paint += new System.Windows.Forms.PaintEventHandler(this.body_Paint);
            // 
            // tittle
            // 
            this.tittle.AutoSize = true;
            this.tittle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tittle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.White;
            this.tittle.Location = new System.Drawing.Point(235, 5);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(81, 15);
            this.tittle.TabIndex = 6;
            this.tittle.Text = "ATLAS LOADER";
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(519, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(13, 14);
            this.minimize.TabIndex = 5;
            this.minimize.Text = "_";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(538, 2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(14, 13);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.welcome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(263, 198);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(0, 23);
            this.welcome.TabIndex = 7;
            this.welcome.SizeChanged += new System.EventHandler(this.welcome_SizeChanged);
            // 
            // expiration
            // 
            this.expiration.AutoSize = true;
            this.expiration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expiration.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiration.ForeColor = System.Drawing.Color.White;
            this.expiration.Location = new System.Drawing.Point(263, 233);
            this.expiration.Name = "expiration";
            this.expiration.Size = new System.Drawing.Size(0, 23);
            this.expiration.TabIndex = 8;
            this.expiration.SizeChanged += new System.EventHandler(this.expiration_SizeChanged);
            // 
            // login_btn
            // 
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(34)))));
            this.login_btn.Location = new System.Drawing.Point(103, 295);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(314, 24);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "INJECT";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Atlas_loader_v1.Properties.Resources.atlas_loader;
            this.logo.Location = new System.Drawing.Point(164, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(199, 175);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // logged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(551, 394);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Controls.Add(this.body);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLAS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logged_MouseDown);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel body;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label expiration;
        private System.Windows.Forms.Button login_btn;
    }
}