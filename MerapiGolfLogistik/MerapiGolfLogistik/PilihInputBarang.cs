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
            this.KeyPreview = true;
        }

        private void PilihInputBarang_Load(object sender, EventArgs e)
        {
            namaUserTb.Text = this.user;
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            OpenAddItems();
        }

        private static void OpenAddItems()
        {
            InputBarang inputform = new InputBarang();
            inputform.ShowDialog();
        }

        private static void OpenAddStockItems()
        {
            PembelianBarang pembelianform = new PembelianBarang();
            pembelianform.ShowDialog();
        }

        private void tambahStokBtn_Click(object sender, EventArgs e)
        {
            OpenAddStockItems();
        }

        private void PilihInputBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void PilihInputBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                OpenAddItems();
            else if (e.KeyCode == Keys.F2)
                OpenAddStockItems();
        }
    }
}
