using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_login
{
    public partial class Form1 : Form
    {
	public static class Globals
	{
		public static int Attempts = 5;
	}
        public Form1()
        {
            InitializeComponent();
        }
	
        private void btnLogIn_Click(object sender, EventArgs e)
        {

	    string Username = txtUsernameGuess.Text;
        string Password = txtPasswordGuess.Text;

            while (Globals.Attempts > 0)
            {
               

                if (Username == "Admin" && Password == "Ppa55word!")
                {
                        MessageBox.Show("Access Granted");
                        Globals.Attempts = 0;
                    
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                    Globals.Attempts -= 1;
                    return;
                   
                }
                
            }
        Application.Exit();

        }
    }
}
