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
    public partial class TambahAktiva : Form
    {
        private Guid selectedId = Guid.Empty;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public TambahAktiva()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = this.namaTb;
            RefreshAktiva();
        }

        private void RefreshAktiva()
        {
            dbContent = new MerapiGolfLogistikEntities();
            var aktivas = dbContent.mg_aktiva.ToList();
            aktivaList.DataSource = null;
            aktivaList.DataSource = aktivas;
        }

        private bool ValidateAktiva()
        {
            return (!String.IsNullOrEmpty(namaTb.Text) && !String.IsNullOrEmpty(keteranganTb.Text));
        }

        private async void SaveAktiva()
        {
            progressBar.Visible = true;
            progressBar.Value = 50;
            InsertData insert = new InsertData();
            if (selectedId == Guid.Empty) //create new
            {
                statusLabel.Text = "Menyimpan...";
                await insert.InsertAktiva(Guid.NewGuid(), namaTb.Text, keteranganTb.Text);
            }
            else //update
            {
                statusLabel.Text = "Mengubah...";
                var updateresult = await insert.UpdateAktiva(this.selectedId, namaTb.Text, keteranganTb.Text);
                if (!updateresult)
                    MessageBox.Show("Ubah data gagal. Coba ulangi lagi atau hubungi administrator.");
            }
            this.selectedId = Guid.Empty;
            statusLabel.Text = "Ready. Tekan [Enter] di tabel untuk mengubah data.";
            progressBar.Visible = false;
            groupBox1.Text = "Tambah Aktiva";
            RefreshAktiva();
            ClearField();
        }

        private void ClearField()
        {
            this.selectedId = Guid.Empty;
            namaTb.Text = String.Empty;
            keteranganTb.Text = String.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateAktiva())
                SaveAktiva();
            else
                MessageBox.Show("Lengkapi data aktiva terlebih dahulu!");
        }

        private void supplierList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var guidstr = aktivaList.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.selectedId = Guid.Parse(guidstr);
            var aktiva = dbContent.mg_aktiva.Where(p => p.id == this.selectedId).Single();
            groupBox1.Text = "Ubah Aktiva: " + aktiva.nama_aktiva;
            namaTb.Text = aktiva.nama_aktiva;
            keteranganTb.Text = aktiva.keterangan_aktiva;
            namaTb.Focus();
        }

        private void TambahSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (ValidateAktiva())
                    SaveAktiva();
                else
                    MessageBox.Show("Lengkapi data aktiva terlebih dahulu!");
            }
        }

        private async void supplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //delete
            {
                var msgbox = MessageBox.Show("Anda yakin akan menghapus aktiva ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (msgbox == DialogResult.Yes)
                {
                    try
                    {
                        progressBar.Visible = true;
                        progressBar.Value = 50;
                        statusLabel.Text = "Menghapus...";
                        dbContent = new MerapiGolfLogistikEntities();
                        Guid id = Guid.Parse(aktivaList.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var item = dbContent.mg_aktiva.Where(p => p.id == id).Single();
                        dbContent.mg_aktiva.Remove(item);
                        await dbContent.SaveChangesAsync();
                        RefreshAktiva();
                    }
                    catch
                    {
                        MessageBox.Show("Aktiva tidak dapat dihapus karena terkait dengan pengambilan!");
                    }
                    finally
                    {
                        progressBar.Visible = false;
                        statusLabel.Text = "Ready. Tekan [Enter] di tabel untuk mengubah data.";
                    }
                }
            }
        }

        private void aktivaList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var guidstr = aktivaList.Rows[aktivaList.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                this.selectedId = Guid.Parse(guidstr);
                var aktiva = dbContent.mg_aktiva.Where(p => p.id == this.selectedId).Single();
                groupBox1.Text = "Ubah Aktiva: " + aktiva.nama_aktiva;
                namaTb.Text = aktiva.nama_aktiva;
                keteranganTb.Text = aktiva.keterangan_aktiva;
                namaTb.Focus();
            }
        }
    }
}
