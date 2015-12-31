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
    public partial class Gudang : Form
    {
        //input
        private static string user;
        //output
        public string id;
        public Gudang(string loggedInUser)
        {
            InitializeComponent();
            user = loggedInUser;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Gudang_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Akun yang login sekarang: " + user);
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            id = "[INI ID BARANG]";
            this.DialogResult = DialogResult.OK;
        }
    }
}
