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
    public partial class AdministratorReport : Form
    {
        public AdministratorReport()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Administrator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                OpenInventoryReport();
            else if (e.KeyCode == Keys.F2)
                OpenPerCategoryReport();
            else if (e.KeyCode == Keys.F3)
                OpenAktivaReport();
            else if (e.KeyCode == Keys.F4)
                OpenMovementReport();
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

        private static void OpenGetItems()
        {
            PengambilanBarang pengambilan = new PengambilanBarang();
            pengambilan.ShowDialog();
        }

        private static void OpenReturnItems()
        {
            PengembalianBarang pengembalian = new PengembalianBarang();
            pengembalian.ShowDialog();
        }

        private static void OpenInventoryReport()
        {
            LaporanGudang laporanform = new LaporanGudang();
            laporanform.ShowDialog();
        }

        private static void OpenAktivaReport()
        {
            LaporanAktiva laporanform = new LaporanAktiva();
            laporanform.ShowDialog();
        }

        private static void OpenPerCategoryReport()
        {
            LaporanKategori laporanform = new LaporanKategori();
            laporanform.ShowDialog();
        }

        private static void OpenMovementReport()
        {
            LaporanPergerakan laporanform = new LaporanPergerakan();
            laporanform.ShowDialog();
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            OpenAddItems();
        }

        private void tambahStokBtn_Click(object sender, EventArgs e)
        {
            OpenAddStockItems();
        }

        private void pengambilanBarangBtn_Click(object sender, EventArgs e)
        {
            OpenGetItems();
        }

        private void pengembalianBarangBtn_Click(object sender, EventArgs e)
        {
            OpenReturnItems();
        }

        private void laporanGudangBtn_Click(object sender, EventArgs e)
        {
            OpenInventoryReport();
        }

        private void laporanPerAktivaBtn_Click(object sender, EventArgs e)
        {
            OpenAktivaReport();
        }

        private void laporanPerKategoriBtn_Click(object sender, EventArgs e)
        {
            OpenPerCategoryReport();
        }

        private void reportMovementBtn_Click(object sender, EventArgs e)
        {
            OpenMovementReport();
        }
    }
}
