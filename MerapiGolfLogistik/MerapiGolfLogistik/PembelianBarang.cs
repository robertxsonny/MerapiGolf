using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerapiGolfLogistik.Classes;
using System.Globalization;

namespace MerapiGolfLogistik
{
    public partial class PembelianBarang : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedSupplierId;
        private Classes.PembelianBarang pembelian = new Classes.PembelianBarang();
        private List<TotalPembelian> listitems = new List<TotalPembelian>();
        public PembelianBarang()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.pilihSupplierBtn;
            statusLabel.Text = "Pilih supplier terlebih dahulu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.itemList.Columns[6].DefaultCellStyle.Format = "C";
            this.itemList.Columns[6].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
            CalculateTotalPrice();
        }

        private void SelectItem()
        {
            PilihBarang barangform = new PilihBarang();
            var result = barangform.ShowDialog();
            if (result == DialogResult.OK)
            {
                Guid idbarang = barangform.selectedId;
                var barang = dbContent.mg_barang.Where(p => p.id == idbarang).Single();
                TotalPembelian total = new TotalPembelian();
                total.nama_barang = barang.nama_barang;
                total.nama_kategori = barang.kategori.nama_kategori;
                total.satuan = barang.satuan;
                total.banyak_barang = barangform.jumlah;
                total.harga_satuan = barangform.hargasatuan;
                total.total_harga = total.banyak_barang * total.harga_satuan;
                total.no_nota = noNotaTb.Text;
                total.id = Guid.NewGuid();
                this.listitems.Add(total);
                itemList.DataSource = null;
                itemList.DataSource = this.listitems;
                tambahBarangBtn.Focus();
                CalculateTotalPrice();
            }
            else
            {
                MessageBox.Show("Gagal menambah barang. Silakan coba lagi.");
            }
        }

        private void SelectSupplier()
        {
            PilihSupplier supplierform = new PilihSupplier();
            var result = supplierform.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.selectedSupplierId = supplierform.selectedId;
                selectedSupplierTb.Text = dbContent.mg_supplier.Where(p => p.id == this.selectedSupplierId).Single().nama_supplier;
                statusLabel.Text = "Siap menambah jumlah stok barang";
                tambahBarangBtn.Focus();
            }
            else
            {
                this.selectedSupplierId = Guid.Empty;
                selectedSupplierTb.Text = "[Belum ada supplier dipilih]";
                statusLabel.Text = "Pilih supplier terlebih dahulu";
            }
        }

        private void CalculateTotalPrice()
        {
            int totalprice = 0;
            foreach (var item in listitems)
            {
                totalprice += item.total_harga.Value;
            }
            totalHargaText.Text = totalprice.ToString("C", new CultureInfo("id-ID"));
        }

        private void PembelianBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SelectSupplier();
            else if (e.KeyCode == Keys.F2)
                SelectItem();

        }

        private void pilihSupplierBtn_Click(object sender, EventArgs e)
        {
            SelectSupplier();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var dialog = MessageBox.Show("Yakin akan menghapus barang ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Guid id = Guid.Parse(itemList.Rows[e.RowIndex].Cells[1].Value.ToString());
                    this.listitems.Remove(this.listitems.Where(p => p.id == id).Single());
                    itemList.DataSource = null;
                    itemList.DataSource = this.listitems;
                    CalculateTotalPrice();
                }
            }
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            SelectItem();
        }


        private void buatSupplierBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
