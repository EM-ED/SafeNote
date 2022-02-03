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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.QuitBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.NameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DataTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 349);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "__________________________________";
            // 
            // DataTB
            // 
            this.DataTB.BackColor = System.Drawing.Color.Wheat;
            this.DataTB.Location = new System.Drawing.Point(14, 83);
            this.DataTB.Multiline = true;
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(746, 247);
            this.DataTB.TabIndex = 2;
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.Moccasin;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(104, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(354, 45);
            this.NameTB.TabIndex = 1;
            this.NameTB.Text = "New Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(5, 371);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(83, 31);
            this.SaveBTN.TabIndex = 1;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(94, 371);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(120, 31);
            this.DeleteBTN.TabIndex = 2;
            this.DeleteBTN.Text = "Delete And Quit";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // QuitBTN
            // 
            this.QuitBTN.Location = new System.Drawing.Point(696, 371);
            this.QuitBTN.Name = "QuitBTN";
            this.QuitBTN.Size = new System.Drawing.Size(83, 31);
            this.QuitBTN.TabIndex = 3;
            this.QuitBTN.Text = "Quit";
            this.QuitBTN.UseVisualStyleBackColor = true;
            this.QuitBTN.Click += new System.EventHandler(this.QuitBTN_Click);
            // 
            // New_Note_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.QuitBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.panel1);
            this.Name = "New_Note_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Note_Form_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.New_Note_Form_FormClosed);
            this.Load += new System.EventHandler(this.New_Note_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}