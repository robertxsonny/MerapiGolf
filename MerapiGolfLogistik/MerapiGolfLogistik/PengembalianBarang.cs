using MerapiGolfLogistik.Models;
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
    public partial class PengembalianBarang : Form
    {
        private List<PengembalianItemExtended> listBarang;
        private MerapiGolfLogistikEntities dbContent;
        private Classes.PengembalianBarang pengembalian;
        private string selectedNotaPengambilan = "";
        public PengembalianBarang()
        {
            InitializeComponent();
            dbContent = new MerapiGolfLogistikEntities();
            pengembalian = new Classes.PengembalianBarang();
            this.listBarang = new List<PengembalianItemExtended>();
            this.KeyPreview = true;
            this.ActiveControl = this.pilihNotaBtn;
            statusLabel.Text = "Pilih nota terlebih dahulu";
            this.tanggalTb.Value = DateTime.Today;
            this.StartPosition = FormStartPosition.CenterScreen;
            GenerateNota();
        }

        private void pilihNotaBtn_Click(object sender, EventArgs e)
        {
            PilihNota notaform = new PilihNota();
            var result = notaform.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.selectedNotaPengambilan = notaform.selectedNo;
                selectedNotaTb.Text = selectedNotaPengambilan;
                statusLabel.Text = "Siap melakukan pengembalian barang";
                tambahBarangBtn.Focus();
            }
            else
            {
                this.selectedNotaPengambilan = "";
                selectedNotaTb.Text = "[Belum ada nota dipilih]";
                statusLabel.Text = "Pilih nota terlebih dahulu";
            }
        }

        private void GenerateNota()
        {
            dbContent = new MerapiGolfLogistikEntities();
            var pengembalians = dbContent.mg_pengembalian.ToList();
            string nonota = "";
            if (pengembalians.Count > 0)
            {
                pengembalians = pengembalians.OrderByDescending(p => p.id).ToList();
                Classes.PembelianBarang pembelianbarang = new Classes.PembelianBarang();
                nonota = pembelianbarang.GenerateNoNota(pengembalians.FirstOrDefault().id);
            }
            else
                nonota = "A000001";
            noNotaTb.Text = nonota;
        }

        private void AddItem()
        {
            PilihBarangDikembalikan barangform = new PilihBarangDikembalikan(selectedNotaPengambilan);
            var result = barangform.ShowDialog();
            if (result == DialogResult.OK)
            {
                Guid idbarang = barangform.selectedId;
                var barang = dbContent.mg_barang.Where(p => p.id == idbarang).Single();
                PengembalianItemExtended item = new PengembalianItemExtended();
                item.nama_barang = barang.nama_barang;
                item.satuan = barang.satuan;
                item.jumlah = barangform.jumlah;
                item.id = barang.id;
                if (this.listBarang.Where(p => p.id == item.id).ToList().Count > 0)
                {
                    MessageBox.Show("Anda sudah menambah barang ini sebelumnya!");
                    return;
                }
                this.listBarang.Add(item);
                itemView.DataSource = null;
                itemView.DataSource = this.listBarang;
                tambahBarangBtn.Focus();
            }
            else
            {
                MessageBox.Show("Gagal menambah barang. Silakan coba lagi.");
            }
        }

        private bool Validation()
        {
            return this.listBarang.Count != 0 && !string.IsNullOrEmpty(this.selectedNotaPengambilan);
        }

        private async Task SaveData()
        {
            if (Validation())
            {
                statusLabel.Text = "Menyimpan...";
                progressBar.Value = 50;
                progressBar.Visible = true;
                pengembalian.AddPengembalian(noNotaTb.Text, Classes.Login.currentUser, tanggalTb.Value, keteranganTb.Text, namaTb.Text);
                foreach (DataGridViewRow item in itemView.Rows)
                {
                    Guid idbarang = Guid.Parse(item.Cells[1].Value.ToString());
                    string namabarang = item.Cells[2].Value.ToString();
                    double jumlahbarang = double.Parse(item.Cells[3].Value.ToString(), new CultureInfo("id-ID"));
                    pengembalian.AddItem(idbarang, selectedNotaPengambilan, jumlahbarang);
                }
                await pengembalian.StorePengembalian();
                ClearField();
                statusLabel.Text = "Ready";
                progressBar.Visible = false;
            }
            else
                MessageBox.Show("Pastikan barang-barang sudah dimasukkan dan Anda sudah memilih supplier!");
        }

        private void ClearField()
        {
            this.selectedNotaPengambilan = string.Empty;
            //this.pengembalian = new Classes.PengembalianBarang();
            selectedNotaTb.Text = "[Belum ada nota dipilih]";
            keteranganTb.Text = string.Empty;
            namaTb.Text = string.Empty;
            tanggalTb.Value = DateTime.Today;
            this.listBarang.Clear();
            itemView.DataSource = null;
            statusLabel.Text = "Pilih nota terlebih dahulu";
            progressBar.Visible = false;
            GenerateNota();
        }

        private async void PrintData()
        {
            var dlgmsg = MessageBox.Show("Anda harus menyimpan pengembalian ini agar dapat dicetak. Menyimpan data?", "Konfirmasi Mencetak", MessageBoxButtons.YesNo);
            if (dlgmsg == DialogResult.Yes)
            {
                await SaveData();
                var nota = pengembalian.GetNotaPengembalian();
                PrintNotaPengembalian printnota = new PrintNotaPengembalian(nota);
                printnota.ShowDialog();
            }
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private async void simpanBtn_Click(object sender, EventArgs e)
        {
            await SaveData();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintData();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var dlgmsg = MessageBox.Show("Yakin akan mengulangi pengembalian data? Semua barang yang dimasukkan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
            if (dlgmsg == DialogResult.Yes)
                ClearField();
        }

        private async void PengembalianBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                AddItem();
            else if (e.KeyCode == Keys.F3)
                await SaveData();
            else if (e.KeyCode == Keys.F5)
            {
                var dlgmsg = MessageBox.Show("Yakin akan mengulangi pengembalian data? Semua barang yang dimasukkan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
                if (dlgmsg == DialogResult.Yes)
                    ClearField();
            }
            else if (e.KeyCode == Keys.F4)
                PrintData();
        }
    }
}
