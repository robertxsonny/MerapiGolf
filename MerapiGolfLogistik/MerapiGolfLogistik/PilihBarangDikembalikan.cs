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
    public partial class PilihBarangDikembalikan : Form
    {
        public Guid selectedId = Guid.Empty;
        public string noNota = "";
        public double jumlah;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihBarangDikembalikan()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.barangList;
            barangList.DataSource = dbContent.mg_pengambilan_per_barang.ToList();
            barangList.KeyDown += barangList_KeyDown;
        }

        public PilihBarangDikembalikan(string no_nota)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.barangList;
            this.noNota = no_nota;
            barangList.DataSource = dbContent.mg_pengambilan_per_barang.Where(m => m.no_nota == no_nota).ToList();
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
                jumlahTb.Focus();
            }
            else if (e.KeyCode == Keys.F2)
                queryTb.Focus();

        }

        private void AddItemToForm()
        {
            if (this.selectedId != Guid.Empty && this.jumlah != 0)
            {
                double max = (double)dbContent.mg_pengambilan_per_barang.Where(p => p.id_barang == this.selectedId && p.no_nota == noNota).SingleOrDefault().banyak_barang;
                if (max >= this.jumlah)
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Banyak barang yang dikembalikan tidak boleh melebihi banyak barang yang diambil");
            }
            else if (this.selectedId != Guid.Empty)
            {
                var dlgmsg = MessageBox.Show("Banyak barang dikembalikan belum diisi! Yakin Anda akan mengisinya nanti?", "Peringatan", MessageBoxButtons.YesNo);
                if (dlgmsg == DialogResult.Yes)
                    this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Lengkapi semua field: pilih barang dan banyak barang yang dikembalikan sebelum menambahkan barang!");
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
            jumlahTb.Focus();
        }

        private void tambahBarangBtn_Click(object sender, EventArgs e)
        {
            AddItemToForm();
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

        private void PilihBarangDikembalikan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                queryTb.Focus();
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
            else if (e.KeyCode == Keys.F5)
                AddItemToForm();
        }

        private void SearchBarang()
        {
            string query = queryTb.Text.ToLower();
            var items = dbContent.mg_pengambilan_per_barang.Where(p => p.no_nota == noNota && p.nama_barang.ToLower().Contains(query)).ToList();
            barangList.DataSource = items;
            barangList.Focus();
        }
        

        private void jumlahTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestrictInputs(sender, e);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchBarang();
        }

        private void jumlahTb_TextChanged(object sender, EventArgs e)
        {
            this.jumlah = double.Parse(jumlahTb.Text, CultureInfo.GetCultureInfo("id-ID"));
        }
    }
}
