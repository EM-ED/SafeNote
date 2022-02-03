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
    public partial class LoginForm : Form
    {

        Load_Or_New_Note_Form f2 = new Load_Or_New_Note_Form();
         
        public LoginForm()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region adding the usernames to usernames list box
            #region Checking if It's not a first time lunch
            if (Directory.Exists(@"accounts\") && Directory.GetDirectories(@"accounts\").Count()>0)
            {
                #region Loading the usernames
                string[] UsernameList = Directory.GetDirectories(@"accounts\");
                foreach (string Username in UsernameList)
                {
                    UserNamesCB.Items.Add(Username.Substring(9));
                }
                #endregion
                UserNamesCB.Text = "Select Username";
            }
            else UserNamesCB.Hide();
            
            #endregion
            #endregion
        }
        private void LoginBTN_Click(object sender, EventArgs e)
        { 
            //making sure both TBs are filled
            if(passwordTB.Text != String.Empty && userTB.Text != String.Empty)
            {
                //making sure the username TB contains the allowed characters
                #region Checking for banned characters

                string username = userTB.Text;
                if (username.All(char.IsLetterOrDigit))
                {
                    #region Checking if user exists
                    if (Directory.Exists(@"accounts\" + userTB.Text))
                    {
                        Data LoginFolder = new Data(Directory_: @"accounts\" + userTB.Text);
                        #region Comparing the Hashes
                        string TempHash = LBFML.Data.MD5HashWithSalt(passwordTB.Text, userTB.Text);
                        string CorrectHash = LoginFolder.ReadFile("Password.pass");
                        if (CorrectHash == TempHash)
                        {
                            #region Passing the data to main form and opening it
                            Load_Or_New_Note_Form.UserName = username;
                            Load_Or_New_Note_Form.Password = passwordTB.Text;
                            f2.Show();
                            this.Hide();
                            #endregion
                        }
                        else MessageBox.Show("The password is incorrect");
                        #endregion
                    }
                    else
                    { MessageBox.Show("User does not exist"); }
                    #endregion

                }
                else MessageBox.Show("User Name can only contain letters and numbers");
                #endregion
            }
            else MessageBox.Show("Please Write and username and a password");


        }
        private void SignUpBTN_Click(object sender, EventArgs e)
        {
            //making sure both TBs are filled
            if (passwordTB.Text != String.Empty && userTB.Text != String.Empty)
            {
                #region Checking for banned characters
                //making sure the username TB contains the allowed characters
                string username = userTB.Text;
                if (username.All(char.IsLetterOrDigit))
                {
                    #region Checking if the account doesn't already exist
                    if (!Directory.Exists(@"accounts\" + userTB.Text))
                    {
                        #region Making The account
                        //makes a folder by the name of the username then saves the password using MD5 Hashing protc and the username as teh salt
                        Data LoginFolder = new Data(Directory_: @"accounts\" + userTB.Text);
                        LoginFolder.CreateFile("Password.pass");
                        LoginFolder.WriteToFile("Password.pass", LBFML.Data.MD5HashWithSalt(passwordTB.Text, userTB.Text));
                        #endregion
                        #region Login Process
                        LoginBTN_Click(sender, e);
                        #endregion
                    }
                    else MessageBox.Show("This Account already exist");
                    #endregion

                }
                else MessageBox.Show("User Name can only contain letters and numbers");
                #endregion


            }
            else MessageBox.Show("Please Write and username and a password");
        }

               

        private void UserNamesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTB.Text = UserNamesCB.SelectedItem.ToString();
        }
    }
}
