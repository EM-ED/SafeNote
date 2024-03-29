﻿using LBFML;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


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
            if (Directory.Exists(@"accounts\") && Directory.GetDirectories(@"accounts\").Count() > 0)
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
            if (passwordTB.Text != String.Empty && userTB.Text != String.Empty)
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
                        string TempHash = Security.SHA256HashWithSalt(passwordTB.Text, userTB.Text);
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
                        LoginFolder.WriteToFile("Password.pass", Security.SHA256HashWithSalt(passwordTB.Text, userTB.Text));
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
            else MessageBox.Show("Please Write an username and a password");
        }



        private void UserNamesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            userTB.Text = UserNamesCB.SelectedItem.ToString();
        }
        private void DeleteAccountBTN_Click(object sender, EventArgs e)
        {
            string username = userTB.Text;
            if (passwordTB.Text == String.Empty || userTB.Text == String.Empty)
            {
                MessageBox.Show("Please write an username and a password");
                return;
            }
            //making sure the username TB contains the allowed characters
            #region Checking for banned characters

            if (!username.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("UserName can only contain numbers and letters");
                return;
            }
            #endregion
            #region Checking if user exists
            if (!Directory.Exists(@"accounts\" + userTB.Text))
            {
                MessageBox.Show("User Does not exist");
                return;
            }
            #endregion
            Data LoginFolder = new Data(Directory_: @"accounts\" + userTB.Text);
            #region Comparing the Hashes
            string TempHash = Security.SHA256HashWithSalt(passwordTB.Text, userTB.Text);
            string CorrectHash = LoginFolder.ReadFile("Password.pass");
            if (CorrectHash == TempHash)
            {
            Directory.Delete(@"accounts\" + userTB.Text,true);
                UserNamesCB.Items.Remove(userTB.Text);
                if(UserNamesCB.Items.Count>0)
                {
                    UserNamesCB.SelectedIndex = 0;
                }
                else
                {
                    UserNamesCB.Text = "No User Found";
                    userTB.Text = "";
                    passwordTB.Text = "";
                }
            }
            else MessageBox.Show("The password is incorrect");
            #endregion


        }
    }
}
