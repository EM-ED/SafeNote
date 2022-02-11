namespace note_pad
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.userTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.SignUpBTN = new System.Windows.Forms.Button();
            this.UserNamesCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userTB
            // 
            this.userTB.BackColor = System.Drawing.Color.White;
            this.userTB.Location = new System.Drawing.Point(91, 29);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(295, 22);
            this.userTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(91, 96);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(295, 22);
            this.passwordTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.LoginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.Image = ((System.Drawing.Image)(resources.GetObject("LoginBTN.Image")));
            this.LoginBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginBTN.Location = new System.Drawing.Point(250, 131);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(136, 55);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // SignUpBTN
            // 
            this.SignUpBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SignUpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUpBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBTN.Image = ((System.Drawing.Image)(resources.GetObject("SignUpBTN.Image")));
            this.SignUpBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpBTN.Location = new System.Drawing.Point(91, 131);
            this.SignUpBTN.Name = "SignUpBTN";
            this.SignUpBTN.Size = new System.Drawing.Size(136, 55);
            this.SignUpBTN.TabIndex = 6;
            this.SignUpBTN.Text = "Sign up";
            this.SignUpBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpBTN.UseVisualStyleBackColor = false;
            this.SignUpBTN.Click += new System.EventHandler(this.SignUpBTN_Click);
            // 
            // UserNamesCB
            // 
            this.UserNamesCB.BackColor = System.Drawing.Color.White;
            this.UserNamesCB.FormattingEnabled = true;
            this.UserNamesCB.Location = new System.Drawing.Point(128, 57);
            this.UserNamesCB.Name = "UserNamesCB";
            this.UserNamesCB.Size = new System.Drawing.Size(220, 24);
            this.UserNamesCB.TabIndex = 7;
            this.UserNamesCB.SelectedIndexChanged += new System.EventHandler(this.UserNamesCB_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(405, 213);
            this.Controls.Add(this.UserNamesCB);
            this.Controls.Add(this.SignUpBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Button SignUpBTN;
        private System.Windows.Forms.ComboBox UserNamesCB;
    }
}

