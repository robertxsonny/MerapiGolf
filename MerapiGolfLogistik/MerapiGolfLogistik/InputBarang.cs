using MerapiGolfLogistik.Classes;
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
    public partial class InputBarang : Form
    {
        private MerapiGolfLogistikEntities dbContent;
        private static Guid selectedCat = Guid.Empty;
        public InputBarang()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            ReadItems();
        }

        private void Gudang_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Akun yang login sekarang: " + user);
        }

        private void pilihKategoriBtn_Click(object sender, EventArgs e)
        {
            ReadCategory();
        }

        private void ReadCategory()
        {
            PilihKategori kategoriform = new PilihKategori();
            var res = kategoriform.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (dbContent = new MerapiGolfLogistikEntities())
                {
                    var cat = dbContent.mg_kategori.Where(p => p.id == kategoriform.selectedId).Single();
                    kategoriTb.Text = cat.nama_kategori;
                    selectedCat = cat.id;
                }
            }
        }

        private void ReadItems()
        {
            FetchData fetch = new FetchData();
            var items = fetch.GetItems(searchTb.Text);
            itemsView.DataSource = items;
        }


        private void InputBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ReadCategory();
            else if (e.KeyCode == Keys.F2)
                searchTb.Focus();
        }

        private void cariBtn_Click(object sender, EventArgs e)
        {
            ReadItems();
        }

        private void searchTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ReadItems();
        }

        private void itemsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //if delete
            {
                string namabarang = itemsView.Rows[e.RowIndex].Cells[2].Value.ToString();
                var dialogresult = MessageBox.Show("Apakah yakin Anda akan menghapus barang " + namabarang + "?", "Konfirmasi Hapus Barang", MessageBoxButtons.YesNo);
                if (dialogresult == DialogResult.Yes)
                {
                    var id = Guid.Parse(itemsView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    using (dbContent = new MerapiGolfLogistikEntities())
                    {
                        var item = dbContent.mg_barang.Where(p => p.id == id).Single();
                        dbContent.mg_barang.Remove(item);
                        dbContent.SaveChanges();
                        ReadItems();
                    }
                }

            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(tanggalInputTb.Text);
            if (selectedCat != Guid.Empty)
            {
                InsertData insert = new InsertData();
                insert.InsertItem(selectedCat, namaBarangTb.Text, satuanTb.Text,
                    date);
                ReadItems();
                ClearField();
            }
            else
                MessageBox.Show("Pilih kategori terlebih dahulu!");

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            selectedCat = Guid.Empty;
            kategoriTb.Text = string.Empty;
            tanggalInputTb.Text = string.Empty;
            kodeBarangTb.Text = string.Empty;
            namaBarangTb.Text = string.Empty;
            satuanTb.Text = string.Empty;
        }
    }
}
