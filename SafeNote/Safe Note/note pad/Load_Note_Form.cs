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
                    NotesListCB.Items.Add(file.Remove(0, (@"accounts\" + UserName + @"\").Length));
                }
                NotesListCB.SelectedIndex = 0;
            }
            else
            {
                NotesListCB.Text = "No note found";
                NotesListCB.Enabled = false;
                MessageBox.Show("Your account does not hold any notes.");
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
                File.Delete(@"accounts\" + UserName + @"\" + NotesListCB.SelectedItem.ToString());
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
                char[] tempfilearray = file.ToCharArray();
                Array.Reverse(tempfilearray);
                file = new string(tempfilearray);
                file = file.Remove(0, ".Encrypted".Length);
                char[] tempfilearray2 = file.ToCharArray();
                Array.Reverse(tempfilearray2);
                file = new string(tempfilearray2);

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
    }
}
