using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerapiGolfLogistik
{
    public partial class PilihBarang : Form
    {
        public Guid selectedId = Guid.Empty;
        public int hargasatuan;
        public int jumlah;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihBarang()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.barangList;
            barangList.DataSource = dbContent.mg_stok_barang_total.ToList();
            barangList.KeyDown += barangList_KeyDown;
        }

        private void barangList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.hargasatuan = 0;
                this.jumlah = 0;
                groupBox1.Visible = true;
                tambahBarangBtn.Visible = true;
                int rowindex = barangList.SelectedCells[0].RowIndex;
                this.selectedId = Guid.Parse
                    (barangList.Rows[rowindex].Cells[0].Value.ToString());
                var barang = dbContent.mg_barang.Where(p => p.id == this.selectedId).Single();
                namaBarangTb.Text = barang.nama_barang;
                satuanLabel.Text = barang.satuan;
                CalculatePrice();
                jumlahTb.Focus();
            }
            else if (e.KeyCode == Keys.F2)
                queryTb.Focus();
        }

        private void SearchSuppliers()
        {
            string query = queryTb.Text.ToLower();
            var items = dbContent.mg_stok_barang_total.Where(p => p.nama_barang.ToLower().Contains(query)).ToList();
            barangList.DataSource = items;
            barangList.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchSuppliers();
        }

        private void queryTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchSuppliers();
        }

        private void PilihSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                queryTb.Focus();
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void barangList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            tambahBarangBtn.Visible = true;
            this.hargasatuan = 0;
            this.jumlah = 0;
            this.selectedId = Guid.Parse(barangList.Rows[e.RowIndex].Cells[0].Value.ToString());
            //this.DialogResult = DialogResult.OK;
            var barang = dbContent.mg_barang.Where(p => p.id == this.selectedId).Single();
            namaBarangTb.Text = barang.nama_barang;
            satuanLabel.Text = barang.satuan;
            CalculatePrice();
            jumlahTb.Focus();
        }

        private void RestrictInputs(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalculatePrice()
        {

            //calculate
            int jumlah;
            int harga;
            int total;

            if (String.IsNullOrEmpty(jumlahTb.Text) ||
                String.IsNullOrEmpty(hargaSatuanTb.Text) ||
                !Int32.TryParse(jumlahTb.Text, out jumlah) ||
                !Int32.TryParse(hargaSatuanTb.Text, out harga))
            {
                total = 0;
                totalHargaLabel.Text = total.ToString("C", new CultureInfo("id-ID"));
                return;
            }
            this.jumlah = jumlah;
            this.hargasatuan = harga;
            total = jumlah * harga;

            //hargaSatuanTb.Text = this.hargasatuan.ToString("C", new CultureInfo("id-ID"));
            totalHargaLabel.Text = total.ToString("C", new CultureInfo("id-ID"));
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            if (this.selectedId != Guid.Empty && this.jumlah != 0 && this.hargasatuan != 0)
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Lengkapi semua field: pilih barang, harga satuan, dan jumlah pembelian sebelum menambahkan barang!");
        }

        private void jumlahTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInputs(sender, e);
        }

        private void hargaSatuanTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInputs(sender, e);
        }

        private void jumlahTb_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void hargaSatuanTb_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}
