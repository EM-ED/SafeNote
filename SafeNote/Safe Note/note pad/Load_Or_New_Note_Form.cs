using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_pad
{
    public partial class Load_Or_New_Note_Form : Form
    {
        public Load_Or_New_Note_Form()
        {
            InitializeComponent();
        }
        public static string Password;
        public static string UserName;

        public void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            New_Note_Form.Password = Password;
            New_Note_Form.UserName = UserName;
            New_Note_Form NNF = new New_Note_Form();
            NNF.Show();
            this.Hide();

        }

        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("New note");
            Load_Note_Form.Password = Password;
            Load_Note_Form.UserName = UserName;
            Load_Note_Form LNF = new Load_Note_Form();
            LNF.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer1_Panel1_MouseClick(sender, e);
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer1_Panel2_MouseClick(sender, e);
        }

        private void Load_Or_New_Note_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
