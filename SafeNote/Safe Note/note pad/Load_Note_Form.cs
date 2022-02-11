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
using LBFML;

namespace note_pad
{
    public partial class Load_Note_Form : Form
    {
        public Load_Note_Form()
        {
            InitializeComponent();
        }
        public static string UserName;
        public static string Password;
        bool ShouldOpenChoiceForm = true;
        private void Load_Note_Form_Load(object sender, EventArgs e)
        {
            //Data DataFolder = new Data(@"accounts\" + UserName);
            List<string> files = Directory.GetFiles(@"accounts\" + UserName +@"\").ToList();


            files.Remove(@"accounts\" + UserName + @"\" + "Password.pass");

            
            if (files.Count > 0)
            {
                foreach (string file in files)
                {
                    
                    string name = (file.Remove(0, (@"accounts\" + UserName + @"\").Length));
                    char[] tempname = name.ToArray();
                    Array.Reverse(tempname);
                    name = new string(tempname);
                    name = name.Remove(0, ".Encrypted".Length);
                    char[] tempname2 = name.Reverse().ToArray();
                    name = new string(tempname2);
                    NotesListCB.Items.Add(name);

                }
                NotesListCB.SelectedIndex = 0;
            }
            else
            {
                NotesListCB.Text = "No note found";
                NotesListCB.Enabled = false;
                DialogResult result = MessageBox.Show("Your account does not hold any notes. would you like to close this tab?", "Close page", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                    quit();
                }

            }
            
        }
        private void quit()
        {
            Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
            Load_Or_New_Note_Form.UserName=UserName;
            Load_Or_New_Note_Form.Password=Password;
            LONNF.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(NotesListCB.Items.Count > 0)
            {
                File.Delete(@"accounts\" + UserName + @"\" + NotesListCB.SelectedItem.ToString()+ ".Encrypted");
                NotesListCB.Items.Remove(NotesListCB.SelectedItem);
                if(NotesListCB.Items.Count == 0)
                {
                    NotesListCB.Enabled=false;
                    NotesListCB.Text = "Your account does not hold any notes.";
                }
                else NotesListCB.SelectedIndex = 0;
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NotesListCB.Items.Count > 0)
            {
                #region removing .Encrypted From string

                string file = NotesListCB.SelectedItem.ToString();

                #endregion
                Edit_Note.UserName = UserName;
                Edit_Note.Password = Password;
                Edit_Note.FileName = file;
                Edit_Note.FilePath = @"accounts\" + UserName + @"\" + file + ".Encrypted";
                Edit_Note EN = new Edit_Note();
                ShouldOpenChoiceForm = false;
                EN.Show();
                this.Close();


            }
        }

        private void Load_Note_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Load_Or_New_Note_Form.UserName = UserName;
            Load_Or_New_Note_Form.Password = Password;
            Load_Or_New_Note_Form LONNF = new Load_Or_New_Note_Form();
            Edit_Note EN = new Edit_Note();
            if(ShouldOpenChoiceForm) LONNF.Show();



        }

        private void NotesListCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
