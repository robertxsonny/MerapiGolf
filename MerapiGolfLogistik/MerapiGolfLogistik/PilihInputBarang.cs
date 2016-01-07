using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerapiGolfLogistik
{
    public partial class PilihInputBarang : Form
    {
        private string user;
        public PilihInputBarang(string loggedInUser)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.user = loggedInUser;
        }

        private void PilihInputBarang_Load(object sender, EventArgs e)
        {
            namaUserTb.Text = this.user;
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            InputBarang inputform = new InputBarang();
            inputform.ShowDialog();
        }

        private void tambahStokBtn_Click(object sender, EventArgs e)
        {

        }

        private void PilihInputBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
