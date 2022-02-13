using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace note_pad
{
    public partial class Edit_Note : Form
    {
        public Edit_Note()
        {
            InitializeComponent();
        }
        public static string UserName;
        public static string Password;
        public static string FileName;
        public static string FilePath;
        bool UnsavedChnage = false;
        private void Edit_Note_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Checking if user should be redirected to load_Note or Load_Or_new_note
            List<string> files = Directory.GetFiles(@"accounts\" + UserName + @"\").ToList();
            if(files.Count > 1)//its "> 1" because the password file is always present
            {
                Load_Note_Form LNF = new Load_Note_Form();
                Load_Note_Form.UserName = UserName;
                Load_Note_Form.Password = Password;
                LNF.Show();
            }
            else
            {
                Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
                Load_Or_New_Note_Form.UserName=UserName;
                Load_Or_New_Note_Form.Password=Password;
                LONNF.Show();
            }

        }

        private void Edit_Note_Load(object sender, EventArgs e)
        {
            Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
            NameTB.Text = FileName;
            DataTB.Text = Security.LoadAndDecrypt(FileName, UserName, Password);
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (DataTB.Text != String.Empty && NameTB.Text != string.Empty)
            {
                if (NameTB.Text == FileName)
                {
                    FileName = NameTB.Text;
                    FilePath = @"accounts\" + UserName + @"\" + NameTB.Text + ".Encrypted";
                    File.Delete(FilePath);
                    Security.SaveAndEncrypt(FileName, DataTB.Text, UserName, Password);
                    UnsavedChnage = false;
                    MessageBox.Show("Your Changes were Saved successfully");
                }
                else
                {
                    if (File.Exists(@"accounts\" + UserName + @"\" + NameTB.Text + ".Encrypted"))
                    {
                        string message = "This file already exist. do you want to overwrite it?";
                        string Title = "Do you want to overwrite?";
                        DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            FileName = NameTB.Text;
                            FilePath = @"accounts\" + UserName + @"\" + NameTB.Text + ".Encrypted";
                            File.Delete(FilePath);
                            Security.SaveAndEncrypt(FileName, DataTB.Text, UserName, Password);
                            UnsavedChnage = false;
                            MessageBox.Show("Your Changes were Saved successfully");
                        }
                        else
                        {
                            MessageBox.Show("No Action Was Taken");
                        }
                    }
                    else
                    {
                        File.Delete(FilePath);
                        FileName = NameTB.Text;
                        FilePath = @"accounts\" + UserName + @"\" + NameTB.Text + ".Encrypted";
                        Security.SaveAndEncrypt(FileName, DataTB.Text, UserName, Password);
                        UnsavedChnage = false;
                        MessageBox.Show("Your Changes were Saved successfully");

                    }
                }
            }
            else { MessageBox.Show("Please choose a name for the note and don't leave the note empty"); }



        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you want to delete this file?";
            string Title = "Do you want to delete?";
            DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Delete(FilePath);
                this.Close();
            }

        }

        private void QuitBTN_Click(object sender, EventArgs e)
        {

            if (UnsavedChnage == true)
            {
                string message = "You have some unsaved progress. would you like to save them first and then quit";
                string Title = "Do you want to save?";
                DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveBTN_Click(sender, e);
                }
            }

            this.Close();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            UnsavedChnage = true;
        }

        private void DataTB_TextChanged(object sender, EventArgs e)
        {
            UnsavedChnage = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
