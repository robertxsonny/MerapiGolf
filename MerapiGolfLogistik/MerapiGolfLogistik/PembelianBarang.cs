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
using MerapiGolfLogistik.Models;

namespace MerapiGolfLogistik
{
    public partial class PembelianBarang : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedSupplierId;
        private Classes.PembelianBarang pembelian = new Classes.PembelianBarang();
        private List<TotalPembelian> listitems = new List<TotalPembelian>();
        private string selectedPembelianId = string.Empty;
        public PembelianBarang()
        {
            InitializeComponent();
            if (Classes.Login.role != "admin")
                buatSupplierBtn.Visible = false;
            this.KeyPreview = true;
            this.ActiveControl = this.pilihSupplierBtn;
            statusLabel.Text = "Pilih supplier terlebih dahulu";
            this.tanggalDt.Value = DateTime.Today;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.itemList.Columns[6].DefaultCellStyle.Format = "C";
            this.itemList.Columns[6].DefaultCellStyle.FormatProvider = new CultureInfo("id-ID");
            CalculateTotalPrice();
            noNotaTb.Text = ReadNota();
        }

        private string ReadNota()
        {
            dbContent = new MerapiGolfLogistikEntities();
            var pembelians = dbContent.mg_pembelian.OrderByDescending(p => p.id).ToList();
            if (pembelians.Count != 0)
            {
                string lastnota = pembelians.First().id;
                string notanow = pembelian.GenerateNoNota(lastnota);
                return notanow;
            }
            else
            {
                return "A000001";
            }
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
                total.id = barang.id;
                if (this.listitems.Where(p => p.id == total.id).ToList().Count > 0)
                {
                    MessageBox.Show("Anda sudah menambah barang ini sebelumnya!");
                    return;
                }
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

        private async void PembelianBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SelectSupplier();
            else if (e.KeyCode == Keys.F2)
                SelectItem();
            else if (e.KeyCode == Keys.F5)
            {
                var msgbox = MessageBox.Show("Yakin akan mengulangi pembelian barang? Seluruh data yang sudah diisikan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
                if (msgbox == DialogResult.Yes)
                    ClearField();
            }
            else if (e.KeyCode == Keys.F3)
                await SaveData();
            else if (e.KeyCode == Keys.F4)
                await PrintData();
        }

        private void pilihSupplierBtn_Click(object sender, EventArgs e)
        {
            SelectSupplier();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //delete item
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
            TambahSupplier tambahsupplierform = new TambahSupplier();
            tambahsupplierform.ShowDialog();
        }

        private bool Validation()
        {
            return this.listitems.Count != 0 && this.selectedSupplierId != Guid.Empty;
        }

        private async void simpanBtn_Click(object sender, EventArgs e)
        {
            await SaveData();
        }

        private async Task<bool> SaveData()
        {
            bool valid = Validation();
            if (valid)
            {
                pembelian = new Classes.PembelianBarang();
                statusLabel.Text = "Menyimpan...";
                progressBar.Value = 50;
                progressBar.Visible = true;
                pembelian.AddPembelian(ReadNota(), tanggalDt.Value, keteranganTb.Text, Classes.Login.currentUser,
                    this.selectedSupplierId, namaTb.Text);
                foreach (DataGridViewRow item in itemList.Rows)
                {
                    Guid idbarang = Guid.Parse(item.Cells[1].Value.ToString());
                    string namabarang = item.Cells[2].Value.ToString();
                    int hargasatuan = Convert.ToInt32(item.Cells[3].Value.ToString(), new CultureInfo("id-ID"));
                    int jumlah = Convert.ToInt32(item.Cells[4].Value.ToString(), new CultureInfo("id-ID"));
                    pembelian.AddBarang(idbarang, hargasatuan, jumlah);
                }
                await pembelian.StorePembelian();
                ClearField();
               
            }
            else
                MessageBox.Show("Pastikan barang-barang sudah dimasukkan dan Anda sudah memilih supplier!");
            return valid;
        }

        private void ClearField()
        {
            this.selectedSupplierId = Guid.Empty;
            selectedSupplierTb.Text = "[Belum ada supplier dipilih]";
            namaTb.Text = string.Empty;
            tanggalDt.Value = DateTime.Today;
            keteranganTb.Text = string.Empty;
            this.listitems.Clear();
            itemList.DataSource = null;
            statusLabel.Text = "Pilih supplier terlebih dahulu";
            progressBar.Visible = false;
            selectedPembelianId = string.Empty;
            noNotaTb.Text = ReadNota();
            CalculateTotalPrice();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var msgbox = MessageBox.Show("Yakin akan mengulangi pembelian barang? Seluruh data yang sudah diisikan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
            if (msgbox == DialogResult.Yes)
                ClearField();
        }

        private async void printBtn_Click(object sender, EventArgs e)
        {
            await PrintData();
        }

        private async Task PrintData()
        {
            var msgbox = MessageBox.Show("Untuk dapat mencetak nota, Anda perlu menyimpan pembelian terlebih dahulu. Simpan sekarang?", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
            if (msgbox == DialogResult.Yes)
            {
                if (await SaveData())
                {
                    NotaPembelianDetail nota = pembelian.GetNotaPembelian();
                    PrintNotaPembelian print = new PrintNotaPembelian(nota);
                    print.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Pencetakan tidak dapat dilakukan karena data masih belum lengkap!");
                }
            }
        }

        private void bukaBtn_Click(object sender, EventArgs e)
        {
            BukaPembelian buka = new BukaPembelian();
            var res = buka.ShowDialog();
            if (res == DialogResult.OK)
            {
                string pembelianId = buka.selectedId;
                this.selectedPembelianId = pembelianId;
                var pembelian = dbContent.mg_pembelian.Where(p => p.id == this.selectedPembelianId).Single();

                this.selectedSupplierId = pembelian.supplier_id.Value;
                selectedSupplierTb.Text = pembelian.supplier.nama_supplier;
                noNotaTb.Text = pembelian.id;
                namaTb.Text = pembelian.nama_pembeli;
                tanggalDt.Value = pembelian.tanggal.HasValue ? pembelian.tanggal.Value : DateTime.Today;
                keteranganTb.Text = pembelian.keterangan;
                this.listitems = new List<TotalPembelian>();
                foreach (var item in pembelian.pembelian_item)
                {
                    TotalPembelian totalpemb = new TotalPembelian();
                    totalpemb.banyak_barang = Convert.ToInt32(item.banyak_barang);
                    totalpemb.harga_satuan = Convert.ToInt32(item.harga_satuan);
                    totalpemb.id = item.barang_id.Value;
                    totalpemb.id_barang = item.barang_id.Value;
                    totalpemb.nama_barang = item.barang.nama_barang;
                    totalpemb.no_nota = item.no_nota;
                    totalpemb.satuan = item.barang.satuan;
                    totalpemb.total_harga = Convert.ToInt32(item.banyak_barang * item.harga_satuan);
                    this.listitems.Add(totalpemb);
                }
                itemList.DataSource = null;
                itemList.DataSource = this.listitems;
                CalculateTotalPrice();
            }
        }

        private void itemList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid selectedId = Guid.Parse(itemList.Rows[e.RowIndex].Cells[1].Value.ToString());
            int hargasatuan = Convert.ToInt32(itemList.Rows[e.RowIndex].Cells[3].Value.ToString());
            int jumlah = Convert.ToInt32(itemList.Rows[e.RowIndex].Cells[4].Value.ToString());
            PilihBarang pilihform = new PilihBarang(selectedId, hargasatuan, jumlah);
            var dlgresult = pilihform.ShowDialog();
            if(dlgresult == DialogResult.OK)
            {
                //update list
                var item = this.listitems.Where(p => p.id_barang == selectedId).Single();
                item.harga_satuan = pilihform.hargasatuan;
                item.banyak_barang = pilihform.jumlah;
                item.total_harga = item.harga_satuan * item.banyak_barang;
                itemList.DataSource = null;
                itemList.DataSource = this.listitems;
                CalculateTotalPrice();
            }
           
        }

        private void itemList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int rowindex = itemList.SelectedCells[0].RowIndex;
                Guid selectedId = Guid.Parse(itemList.Rows[rowindex].Cells[1].Value.ToString());
                int hargasatuan = Convert.ToInt32(itemList.Rows[rowindex].Cells[3].Value.ToString());
                int jumlah = Convert.ToInt32(itemList.Rows[rowindex].Cells[4].Value.ToString());
                PilihBarang pilihform = new PilihBarang(selectedId, hargasatuan, jumlah);
                var dlgresult = pilihform.ShowDialog();
                if (dlgresult == DialogResult.OK)
                {
                    //update list
                    var item = this.listitems.Where(p => p.id_barang == selectedId).Single();
                    item.harga_satuan = pilihform.hargasatuan;
                    item.banyak_barang = pilihform.jumlah;
                    item.total_harga = item.harga_satuan * item.banyak_barang;
                    itemList.DataSource = null;
                    itemList.DataSource = this.listitems;
                    CalculateTotalPrice();
                }
            }
            
        }
    }
}
