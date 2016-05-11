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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            RentLogIn subForm = new RentLogIn();
            subForm.Show();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
