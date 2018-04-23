using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsList
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            LblnameInput.Text = txtName.Text;
            LbllastnameInput.Text = txtLastName.Text;
            LblphoneInput.Text = txtPhone.Text;
            Lblemailinput.Text = txtemail.Text;
            Lblcityinput.Text = txtCity.Text;
            LbladdressInput.Text = txtAddress.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }
    }
}
