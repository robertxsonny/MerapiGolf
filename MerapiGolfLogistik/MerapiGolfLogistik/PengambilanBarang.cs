using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerapiGolfLogistik.Models;

namespace MerapiGolfLogistik
{
    public partial class PengambilanBarang : Form
    {
        private List<PengambilanItemExtended> listBarang;
        private MerapiGolfLogistikEntities dbContent;
        private Classes.PengambilanBarang pengambilan;
        public PengambilanBarang()
        {
            InitializeComponent();
            dbContent = new MerapiGolfLogistikEntities();
            pengambilan = new Classes.PengambilanBarang();
            this.listBarang = new List<PengambilanItemExtended>();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            GenerateNota();
        }

        private void GenerateNota()
        {
            dbContent = new MerapiGolfLogistikEntities();
            var pengambilans = dbContent.mg_pengambilan.ToList();
            string nonota = "";
            if (pengambilans.Count > 0)
            {
                pengambilans = pengambilans.OrderByDescending(p => p.id).ToList();
                Classes.PembelianBarang pembelianbarang = new Classes.PembelianBarang();
                nonota = pembelianbarang.GenerateNoNota(pengambilans.FirstOrDefault().id);
            }
            else
                nonota = "A000001";
            noNotaTb.Text = nonota;
        }

        private void ClearField()
        {
            this.listBarang.Clear();
            itemView.DataSource = null;
            keteranganTb.Text = string.Empty;
            GenerateNota();
        }

        private void AddItem()
        {
            PilihBarangWithAktiva pilihform = new PilihBarangWithAktiva();
            var dialogres = pilihform.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                var barang = dbContent.mg_barang.Where(p => p.id == pilihform.selectedId).Single();
                int jumlah = pilihform.jumlah;
                Guid aktivaId = pilihform.selectedAktiva;
                var aktiva = dbContent.mg_aktiva.Where(p => p.id == pilihform.selectedAktiva).Single();

                PengambilanItemExtended item = new PengambilanItemExtended();
                item.id = barang.id;
                item.id_aktiva = aktivaId;
                item.jumlah = jumlah;
                item.nama_aktiva = aktiva.nama_aktiva;
                item.nama_barang = barang.nama_barang;
                item.satuan = barang.satuan;
                item.tanggalinput = barang.tanggalinput;
                if (this.listBarang.Where(p => p.id == item.id).ToList().Count > 0)
                {
                    MessageBox.Show("Anda sudah menambahkan barang ini sebelumnya!");
                    return;
                }
                this.listBarang.Add(item);
                itemView.DataSource = null;
                itemView.DataSource = this.listBarang;
            }
        }

        private bool Validation()
        {
            return this.listBarang.Count > 0;
        }

        private async Task SaveData()
        {
            if (Validation())
            {
                statusLabel.Text = "Menyimpan...";
                progressBar.Visible = true;
                progressBar.Value = 50;
                pengambilan.AddPengambilan(noNotaTb.Text, DateTime.Now, keteranganTb.Text,
               Classes.Login.currentUser);
                foreach (var item in this.listBarang)
                {
                    pengambilan.AddItem(item.id, item.jumlah, item.id_aktiva);
                }
                await pengambilan.StorePengambilan();
                ClearField();
                statusLabel.Text = "Ready";
                progressBar.Visible = false;
            }
            else
                MessageBox.Show("Masukkan barang terlebih dahulu!");
        }

        private async void PrintData()
        {
            var dlgmsg = MessageBox.Show("Anda harus menyimpan pengambilan ini agar dapat dicetak. Menyimpan data?", "Konfirmasi Mencetak", MessageBoxButtons.YesNo);
            if(dlgmsg == DialogResult.Yes)
            {
                await SaveData();
                var nota = pengambilan.GetNotaPengambilan();
                PrintNotaPengambilan printnota = new PrintNotaPengambilan(nota);
                printnota.ShowDialog();
            }
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private async void PengambilanBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                AddItem();
            else if (e.KeyCode == Keys.F3)
                await SaveData();
            else if (e.KeyCode == Keys.F5)
            {
                var dlgmsg = MessageBox.Show("Yakin akan mengulangi pengambilan data? Semua barang yang dimasukkan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
                if (dlgmsg == DialogResult.Yes)
                    ClearField();
            }
            else if (e.KeyCode == Keys.F4)
                PrintData();
        }

        private void itemView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //delete
            {
                var msgbox = MessageBox.Show("Anda yakin akan menghapus item ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (msgbox == DialogResult.Yes)
                {
                    Guid selectedid = Guid.Parse(itemView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    this.listBarang.Remove(this.listBarang.Where(p => p.id == selectedid).Single());
                    itemView.DataSource = null;
                    itemView.DataSource = this.listBarang;
                }
            }
        }

        private async void simpanBtn_Click(object sender, EventArgs e)
        {
            await SaveData();
        }

        private void ulangiBtn_Click(object sender, EventArgs e)
        {
            var dlgmsg = MessageBox.Show("Yakin akan mengulangi pengambilan data? Semua barang yang dimasukkan akan terhapus.", "Konfirmasi Pengulangan", MessageBoxButtons.YesNo);
            if (dlgmsg == DialogResult.Yes)
                ClearField();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintData();
        }
    }
}
