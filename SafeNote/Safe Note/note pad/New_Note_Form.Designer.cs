namespace note_pad
{
    partial class New_Note_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Note_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.QuitBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Controls.Add(this.DataTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 349);
            this.panel1.TabIndex = 0;
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("B Titr", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.NameTB.Location = new System.Drawing.Point(124, 27);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(636, 32);
            this.NameTB.TabIndex = 1;
            this.NameTB.Text = "New note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(121, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "__________________________________";
            // 
            // DataTB
            // 
            this.DataTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.DataTB.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTB.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DataTB.Location = new System.Drawing.Point(14, 70);
            this.DataTB.Multiline = true;
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(746, 247);
            this.DataTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SaveBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.Image = ((System.Drawing.Image)(resources.GetObject("SaveBTN.Image")));
            this.SaveBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBTN.Location = new System.Drawing.Point(3, 6);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(114, 56);
            this.SaveBTN.TabIndex = 1;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.DeleteBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBTN.Image")));
            this.DeleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteBTN.Location = new System.Drawing.Point(123, 9);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(205, 53);
            this.DeleteBTN.TabIndex = 2;
            this.DeleteBTN.Text = "Delete and quit";
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // QuitBTN
            // 
            this.QuitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.QuitBTN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBTN.Image = ((System.Drawing.Image)(resources.GetObject("QuitBTN.Image")));
            this.QuitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuitBTN.Location = new System.Drawing.Point(334, 7);
            this.QuitBTN.Name = "QuitBTN";
            this.QuitBTN.Size = new System.Drawing.Size(109, 56);
            this.QuitBTN.TabIndex = 3;
            this.QuitBTN.Text = "quit";
            this.QuitBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuitBTN.UseVisualStyleBackColor = false;
            this.QuitBTN.Click += new System.EventHandler(this.QuitBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.QuitBTN);
            this.panel2.Controls.Add(this.SaveBTN);
            this.panel2.Controls.Add(this.DeleteBTN);
            this.panel2.Location = new System.Drawing.Point(167, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 66);
            this.panel2.TabIndex = 4;
            // 
            // New_Note_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "New_Note_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new note";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Note_Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.New_Note_Form_FormClosed);
            this.Load += new System.EventHandler(this.New_Note_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button QuitBTN;
        private System.Windows.Forms.Panel panel2;
    }
}