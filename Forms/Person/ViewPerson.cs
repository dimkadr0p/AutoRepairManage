using System;
using AdminAPP.Models;
using System.Windows.Forms;

namespace AdminAPP.Forms
{
    public partial class ViewPerson : Form
    {

        public Client Client = new Client();
        public ViewPerson(Client client)
        {
            InitializeComponent();
            Client = client;
        }

        private void ViewPerson_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Client.Name;
            textBoxLastName.Text = Client.LastName;
            textBoxSecondName.Text = Client.SecondName;
            textBoxPhone.Text = Client.Phone;
            textBox1.Text = Client.Email;
        }
    }
}
