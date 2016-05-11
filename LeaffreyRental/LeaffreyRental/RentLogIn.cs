using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeaffreyRental
{
    public partial class RentLogIn : Form
    {
        public RentLogIn()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "Jeff")
                if (PasswordTextBox.Text == "password")
                { Close(); }
                else
                { InfoLabel.Text = "Incorrect Password"; }
            else
            { InfoLabel.Text = "No Such User"; }
        }

        private void RentLogIn_Load(object sender, EventArgs e)
        {
            InfoLabel.Text = "";
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
}
