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
    public partial class TambahSupplier : Form
    {
        private Guid selectedId = Guid.Empty;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public TambahSupplier()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = this.namaTb;
            RefreshSuppliers();
        }

        private void RefreshSuppliers()
        {
            dbContent = new MerapiGolfLogistikEntities();
            var suppliers = dbContent.mg_supplier.ToList();
            supplierList.DataSource = null;
            supplierList.DataSource = suppliers;
        }

        private bool ValidateSupplier()
        {
            return (!String.IsNullOrEmpty(namaTb.Text) && !String.IsNullOrEmpty(alamatTb.Text)
                && Regex.IsMatch(emailTb.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"));
        }

        private async void SaveSupplier()
        {
            progressBar.Visible = true;
            progressBar.Value = 50;
            InsertData insert = new InsertData();
            if (selectedId == Guid.Empty) //create new
            {
                statusLabel.Text = "Menyimpan...";
                await insert.InsertSupplier(Guid.NewGuid(), namaTb.Text, alamatTb.Text,
                    teleponTb.Text, emailTb.Text);
            }
            else //update
            {
                statusLabel.Text = "Mengubah...";
                var updateresult = await insert.UpdateSupplier(this.selectedId, namaTb.Text, alamatTb.Text,
                   teleponTb.Text, emailTb.Text);
                if (!updateresult)
                    MessageBox.Show("Ubah data gagal. Coba ulangi lagi atau hubungi administrator.");
            }
            this.selectedId = Guid.Empty;
            statusLabel.Text = "Ready";
            progressBar.Visible = false;
            groupBox1.Text = "Tambah Supplier";
            RefreshSuppliers();
            ClearField();
        }

        private void ClearField()
        {
            this.selectedId = Guid.Empty;
            namaTb.Text = String.Empty;
            alamatTb.Text = String.Empty;
            teleponTb.Text = String.Empty;
            emailTb.Text = String.Empty;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateSupplier())
                SaveSupplier();
            else
                MessageBox.Show("Lengkapi data supplier terlebih dahulu dan pastikan format email benar sebelum menyimpan!");
        }

        private void supplierList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var guidstr = supplierList.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.selectedId = Guid.Parse(guidstr);
            var supplier = dbContent.mg_supplier.Where(p => p.id == this.selectedId).Single();
            groupBox1.Text = "Ubah Supplier: " + supplier.nama_supplier;
            namaTb.Text = supplier.nama_supplier;
            alamatTb.Text = supplier.alamat_supplier;
            teleponTb.Text = supplier.telepon_supplier;
            emailTb.Text = supplier.email_supplier;
            namaTb.Focus();
        }

        private void TambahSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                if (ValidateSupplier())
                    SaveSupplier();
                else
                    MessageBox.Show("Lengkapi data supplier terlebih dahulu dan pastikan format email benar sebelum menyimpan!");
            }
        }

        private async void supplierList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1) //delete
            {
                var msgbox = MessageBox.Show("Anda yakin akan menghapus supplier ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (msgbox == DialogResult.Yes)
                {
                    try
                    {
                        progressBar.Visible = true;
                        progressBar.Value = 50;
                        statusLabel.Text = "Menghapus...";
                        dbContent = new MerapiGolfLogistikEntities();
                        Guid id = Guid.Parse(supplierList.Rows[e.RowIndex].Cells[0].Value.ToString());
                        var item = dbContent.mg_supplier.Where(p => p.id == id).Single();
                        dbContent.mg_supplier.Remove(item);
                        await dbContent.SaveChangesAsync();
                        RefreshSuppliers();
                    }
                    catch
                    {
                        MessageBox.Show("Supplier tidak dapat dihapus karena terkait dengan pembelian/pengambilan!");
                    }
                    finally
                    {
                        progressBar.Visible = false;
                        statusLabel.Text = "Ready";
                    }
                }
            }
        }
    }
}
