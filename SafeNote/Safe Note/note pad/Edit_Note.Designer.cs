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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Note));
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
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.DeleteBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBTN.Image")));
            this.DeleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBTN.Location = new System.Drawing.Point(118, 6);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(171, 62);
            this.DeleteBTN.TabIndex = 0;
            this.DeleteBTN.Text = "Delete And Quit";
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Image = ((System.Drawing.Image)(resources.GetObject("SaveBTN.Image")));
            this.SaveBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBTN.Location = new System.Drawing.Point(3, 6);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(110, 62);
            this.SaveBTN.TabIndex = 1;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(109)))));
            this.panel1.Controls.Add(this.DataTB);
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 337);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DataTB
            // 
            this.DataTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(109)))));
            this.DataTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.DataTB.Location = new System.Drawing.Point(32, 50);
            this.DataTB.Multiline = true;
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(655, 253);
            this.DataTB.TabIndex = 2;
            this.DataTB.TextChanged += new System.EventHandler(this.DataTB_TextChanged);
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(129)))), ((int)(((byte)(109)))));
            this.NameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.NameTB.Location = new System.Drawing.Point(111, 19);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(576, 22);
            this.NameTB.TabIndex = 1;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QuitBTN);
            this.panel2.Controls.Add(this.SaveBTN);
            this.panel2.Controls.Add(this.DeleteBTN);
            this.panel2.Location = new System.Drawing.Point(189, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 71);
            this.panel2.TabIndex = 3;
            // 
            // QuitBTN
            // 
            this.QuitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.QuitBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBTN.Image = ((System.Drawing.Image)(resources.GetObject("QuitBTN.Image")));
            this.QuitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuitBTN.Location = new System.Drawing.Point(295, 6);
            this.QuitBTN.Name = "QuitBTN";
            this.QuitBTN.Size = new System.Drawing.Size(100, 62);
            this.QuitBTN.TabIndex = 2;
            this.QuitBTN.Text = "Quit";
            this.QuitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuitBTN.UseVisualStyleBackColor = false;
            this.QuitBTN.Click += new System.EventHandler(this.QuitBTN_Click);
            // 
            // Edit_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Edit_Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit the note";
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