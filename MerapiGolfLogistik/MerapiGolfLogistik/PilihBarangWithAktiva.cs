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
    public partial class PilihBarangWithAktiva : Form
    {
        public Guid selectedId = Guid.Empty;
        public int jumlah;
        private int jumlahlimit;
        public Guid selectedAktiva = Guid.Empty;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihBarangWithAktiva()
        {
            InitializeComponent();
            if (Classes.Login.role != "admin")
                daftarAktivaBtn.Visible = false;
            this.KeyPreview = true;
            this.ActiveControl = this.barangList;
            barangList.DataSource = dbContent.mg_stok_barang_total.ToList();
            barangList.KeyDown += barangList_KeyDown;
        }

        private void barangList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.jumlah = 0;
                groupBox1.Visible = true;
                tambahBarangBtn.Visible = true;
                int rowindex = barangList.SelectedCells[0].RowIndex;
                this.selectedId = Guid.Parse
                    (barangList.Rows[rowindex].Cells[0].Value.ToString());
                var barang = dbContent.mg_barang.Where(p => p.id == this.selectedId).Single();
                namaBarangTb.Text = barang.nama_barang;
                satuanLabel.Text = barang.satuan;
                this.jumlahlimit = Convert.ToInt32
                    (dbContent.mg_stok_barang_total.Where(p => p.id_barang == barang.id).Single().stok.Value);
                jumlahTb.Focus();
            }
            else if (e.KeyCode == Keys.F2)
                queryTb.Focus();
            else if (e.KeyCode == Keys.F3)
                GetAktiva();
            else if (e.KeyCode == Keys.F5)
            {
                if (this.selectedId != Guid.Empty && this.jumlah != 0 &&
               this.selectedAktiva != Guid.Empty)
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Lengkapi semua field: pilih barang, harga satuan, dan jumlah pembelian sebelum menambahkan barang!");
            }
        }

        private void GetAktiva()
        {
            PilihAktiva pilihaktivaform = new PilihAktiva();
            var dialogres = pilihaktivaform.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                this.selectedAktiva = pilihaktivaform.selectedId;
                var aktiva = dbContent.mg_aktiva.Where(p => p.id == this.selectedAktiva).Single();
                aktivaTb.Text = aktiva.nama_aktiva;
            }
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
            else if (e.KeyCode == Keys.F3)
                GetAktiva();
            else if (e.KeyCode == Keys.F5)
                AddBarangToForm();
        }

        private void barangList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Visible = true;
            tambahBarangBtn.Visible = true;
            this.jumlah = 0;
            this.selectedId = Guid.Parse(barangList.Rows[e.RowIndex].Cells[0].Value.ToString());
            //this.DialogResult = DialogResult.OK;
            var barang = dbContent.mg_barang.Where(p => p.id == this.selectedId).Single();
            namaBarangTb.Text = barang.nama_barang;
            satuanLabel.Text = barang.satuan;
            this.jumlahlimit = Convert.ToInt32
                     (dbContent.mg_stok_barang_total.Where(p => p.id_barang == barang.id).Single().stok.Value);
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

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            AddBarangToForm();
        }

        private void AddBarangToForm()
        {
            if (this.jumlah > this.jumlahlimit)
            {
                MessageBox.Show("Jumlah barang tidak dapat melebihi stok!");
                return;
            }


            if (this.selectedId != Guid.Empty && this.jumlah != 0 &&
                this.selectedAktiva != Guid.Empty)
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

        private void pilihAktivaBtn_Click(object sender, EventArgs e)
        {
            GetAktiva();
        }

        private void jumlahTb_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(jumlahTb.Text))
            {
                this.jumlah = Convert.ToInt32(jumlahTb.Text);
                groupBox2.Visible = true;
            }
            else groupBox2.Visible = false;
        }

        private void daftarAktivaBtn_Click(object sender, EventArgs e)
        {
            TambahAktiva tambahaktivaform = new TambahAktiva();
            tambahaktivaform.ShowDialog();
        }
    }
}
