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
            this.userTB.Location = new System.Drawing.Point(114, 48);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(190, 22);
            this.userTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(114, 76);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(190, 22);
            this.passwordTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // LoginBTN
            // 
            this.LoginBTN.Location = new System.Drawing.Point(217, 123);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(87, 44);
            this.LoginBTN.TabIndex = 5;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // SignUpBTN
            // 
            this.SignUpBTN.Location = new System.Drawing.Point(114, 123);
            this.SignUpBTN.Name = "SignUpBTN";
            this.SignUpBTN.Size = new System.Drawing.Size(87, 44);
            this.SignUpBTN.TabIndex = 6;
            this.SignUpBTN.Text = "Sign up";
            this.SignUpBTN.UseVisualStyleBackColor = true;
            this.SignUpBTN.Click += new System.EventHandler(this.SignUpBTN_Click);
            // 
            // UserNamesCB
            // 
            this.UserNamesCB.FormattingEnabled = true;
            this.UserNamesCB.Location = new System.Drawing.Point(310, 48);
            this.UserNamesCB.Name = "UserNamesCB";
            this.UserNamesCB.Size = new System.Drawing.Size(151, 24);
            this.UserNamesCB.TabIndex = 7;
            this.UserNamesCB.SelectedIndexChanged += new System.EventHandler(this.UserNamesCB_SelectedIndexChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 216);
            this.Controls.Add(this.UserNamesCB);
            this.Controls.Add(this.SignUpBTN);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userTB);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
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

