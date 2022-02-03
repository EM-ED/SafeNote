namespace note_pad
{
    partial class Edit_Note
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
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.QuitBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(131, 6);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(121, 27);
            this.DeleteBTN.TabIndex = 0;
            this.DeleteBTN.Text = "Delete And Quit";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(3, 6);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(121, 27);
            this.SaveBTN.TabIndex = 1;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.DataTB);
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 337);
            this.panel1.TabIndex = 2;
            // 
            // DataTB
            // 
            this.DataTB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DataTB.Location = new System.Drawing.Point(32, 50);
            this.DataTB.Multiline = true;
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(655, 253);
            this.DataTB.TabIndex = 2;
            this.DataTB.TextChanged += new System.EventHandler(this.DataTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.SystemColors.Control;
            this.NameTB.Location = new System.Drawing.Point(82, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(219, 22);
            this.NameTB.TabIndex = 1;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QuitBTN);
            this.panel2.Controls.Add(this.SaveBTN);
            this.panel2.Controls.Add(this.DeleteBTN);
            this.panel2.Location = new System.Drawing.Point(271, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 45);
            this.panel2.TabIndex = 3;
            // 
            // QuitBTN
            // 
            this.QuitBTN.Location = new System.Drawing.Point(258, 6);
            this.QuitBTN.Name = "QuitBTN";
            this.QuitBTN.Size = new System.Drawing.Size(121, 27);
            this.QuitBTN.TabIndex = 2;
            this.QuitBTN.Text = "Quit";
            this.QuitBTN.UseVisualStyleBackColor = true;
            this.QuitBTN.Click += new System.EventHandler(this.QuitBTN_Click);
            // 
            // Edit_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_Note";
            this.Text = "Edit_Note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_Note_FormClosed);
            this.Load += new System.EventHandler(this.Edit_Note_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DataTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button QuitBTN;
    }
}