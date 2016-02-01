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
using System.Text.RegularExpressions;

namespace MerapiGolfLogistik
{
    public partial class TambahKategori : Form
    {
        private Guid selectedId = Guid.Empty;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public TambahKategori()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = this.namaTb;
            RefreshKategori();
        }

        private void RefreshKategori()
        {
            Classes.FetchData fetchdata = new FetchData();
            var categories = fetchdata.GetCategory(string.Empty);
            categoryList.DataSource = null;
            categoryList.DataSource = categories;
        }

        private bool ValidateKategori()
        {
            return (!String.IsNullOrEmpty(namaTb.Text));
        }

        private async void SaveCategory()
        {
            progressBar.Visible = true;
            progressBar.Value = 50;
            InsertData insert = new InsertData();
            if (selectedId == Guid.Empty) //create new
            {
                statusLabel.Text = "Menyimpan...";
                await insert.InsertCategory(Guid.NewGuid(), namaTb.Text);
            }
            else //update
            {
                statusLabel.Text = "Mengubah...";
                var updateresult = await insert.UpdateKategori(this.selectedId, namaTb.Text);
                if (!updateresult)
                    MessageBox.Show("Ubah data gagal. Coba ulangi lagi atau hubungi administrator.");
            }
            this.selectedId = Guid.Empty;
            statusLabel.Text = "Ready. Tekan [Enter] untuk mengubah data pada tabel.";
            progressBar.Visible = false;
            groupBox1.Text = "Tambah Kategori";
            RefreshKategori();
            ClearField();
        }

        private void ClearField()
        {
            this.selectedId = Guid.Empty;
            namaTb.Text = String.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateKategori())
                SaveCategory();
            else
                MessageBox.Show("Lengkapi data kategori terlebih dahulu");
        }

        private void supplierList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var guidstr = categoryList.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.selectedId = Guid.Parse(guidstr);
            var kategori = dbContent.mg_kategori.Where(p => p.id == this.selectedId).Single();
            groupBox1.Text = "Ubah Kategori: " + kategori.nama_kategori;
            namaTb.Text = kategori.nama_kategori;
            namaTb.Focus();
        }

        private void TambahSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (ValidateKategori())
                    SaveCategory();
                else
                    MessageBox.Show("Lengkapi data kategori terlebih dahulu dan pastikan format email benar sebelum menyimpan!");
            }
        }

        private async void supplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //delete
            {
                var msgbox = MessageBox.Show("Anda yakin akan menghapus kategori ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (msgbox == DialogResult.Yes)
                {
                    try
                    {
                        progressBar.Visible = true;
                        progressBar.Value = 50;
                        statusLabel.Text = "Menghapus...";
                        dbContent = new MerapiGolfLogistikEntities();
                        Guid id = Guid.Parse(categoryList.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var item = dbContent.mg_kategori.Where(p => p.id == id).Single();
                        dbContent.mg_kategori.Remove(item);
                        await dbContent.SaveChangesAsync();
                        RefreshKategori();
                    }
                    catch
                    {
                        MessageBox.Show("Kategori tidak dapat dihapus karena terkait dengan pembelian/pengambilan!");
                    }
                    finally
                    {
                        progressBar.Visible = false;
                        statusLabel.Text = "Ready. Tekan [Enter] untuk mengubah data pada tabel.";
                    }
                }
            }
        }

        private void categoryList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var guidstr = categoryList.Rows[categoryList.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                this.selectedId = Guid.Parse(guidstr);
                var kategori = dbContent.mg_kategori.Where(p => p.id == this.selectedId).Single();
                groupBox1.Text = "Ubah Kategori: " + kategori.nama_kategori;
                namaTb.Text = kategori.nama_kategori;
                namaTb.Focus();
            }
        }
    }
}
