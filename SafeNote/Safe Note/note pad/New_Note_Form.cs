using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
 

namespace note_pad
{
    public partial class New_Note_Form : Form
    {
        public New_Note_Form()
        {
            InitializeComponent();
        }
        public static string UserName;
        public static string Password;
        bool ChangesSaved = false;
        string[] tempPresentFiles = Directory.GetFiles(@"accounts\" + UserName + @"\");
        List<string> PresentFiles = new List<string>();
        private string savedFileName = string.Empty;

        private void New_Note_Form_Load(object sender, EventArgs e)
        {
            foreach (string file in tempPresentFiles)
            {
                PresentFiles.Add(file.Remove(0, (@"accounts\" + UserName + @"\").Length));
            }
            savedFileName = string.Empty;
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (DataTB.Text != string.Empty && NameTB.Text != string.Empty)
            {
                if (ChangesSaved) return;

                if (!PresentFiles.Contains(NameTB.Text + ".Encrypted"))//checks if file alaready exists
                {
                    // "if" statement below will delete the previous file if file name is changed
                    if(savedFileName != string.Empty && NameTB.Text + ".Encrypted" != savedFileName) File.Delete(@"accounts\" + UserName + @"\" + savedFileName);
                    Security.SaveAndEncrypt(NameTB.Text, DataTB.Text, UserName, Password);
                    ChangesSaved = true;


                    savedFileName = NameTB.Text + ".Encrypted";
                }
                else
                {
                    string message = "This File Already Exist Do You Want To OverWrite The Existing File?";
                    string Title = "Do you want to overwrite?";
                    DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(@"accounts\" + UserName + @"\" + NameTB.Text + ".Encrypted");
                        Security.SaveAndEncrypt(NameTB.Text, DataTB.Text, UserName, Password);
                        ChangesSaved = true;
                        PresentFiles.Remove(NameTB.Text + ".Encrypted");
                    }

                }



            }
            else MessageBox.Show("Please choose a Name for the note and Don't leave the note empty");
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (savedFileName == string.Empty)
            {
                MessageBox.Show("You haven't saved a file yet");
                return;
            }
            File.Delete(@"accounts\" + UserName + @"\" + savedFileName);
            savedFileName = string.Empty;
            ChangesSaved = true;// this is so the program doesn't ask you if you want to save your changes
            quit();

        }

        private void QuitBTN_Click(object sender, EventArgs e)
        {
            if (ChangesSaved)
            {

                quit();
            }
            else
            {
                string message = "You have Unsaved Chnages in your notes do you wish to save them and then exit?";
                string Title = "Do you want to save first?";
                DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveBTN_Click(sender, e);
                    quit();
                }
                else
                {
                    quit();
                }

            }


        }
        private void quit()
        {
            Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
            LONNF.Show();
            Load_Or_New_Note_Form.UserName = UserName;
            Load_Or_New_Note_Form.Password = Password;
            LONNF.Hide();
            this.Close();
        }

        private void New_Note_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Load_Or_New_Note_Form.UserName = UserName;
            Load_Or_New_Note_Form.Password = Password;
            Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
            LONNF.Show();
        }

        private void New_Note_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesSaved)
            {
            }
            else
            {
                string message = "You have Unsaved Chnages in your notes do you wish to save them and then exit?";
                string Title = "Do you want to save first?";
                DialogResult result = MessageBox.Show(message, Title, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveBTN_Click(sender, e);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            ChangesSaved = false;
        }

        private void DataTB_TextChanged(object sender, EventArgs e)
        {
            ChangesSaved = false;
        }
    }
}
