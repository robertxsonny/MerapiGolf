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

namespace MerapiGolfLogistik
{
    public partial class BukaPembelian : Form
    {
        private FetchData fetch = new FetchData();
        public string selectedId = string.Empty;
        public BukaPembelian()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.filterCari;
            filterCari.SelectedIndex = 0;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReadPembelian()
        {
            bool isFinished = filterCari.SelectedIndex == 0;
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            DateTime.TryParse(dariTanggalTb.Text, out start);
            DateTime.TryParse(sampaiTanggalTb.Text, out end);

            bool isAll = semuaPembelianCb.Checked;
            var result = fetch.GetPreviousPembelian(isFinished, start, end, isAll);
            pembelianView.DataSource = null;
            pembelianView.DataSource = result;
        }

        private void filterCari_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadPembelian();
        }

        private void semuaPembelianCb_CheckedChanged(object sender, EventArgs e)
        {
            if (semuaPembelianCb.Checked)
            {
                dariTanggalTb.Enabled = false;
                sampaiTanggalTb.Enabled = false;
            }
            else
            {
                dariTanggalTb.Enabled = true;
                sampaiTanggalTb.Enabled = true;
            }
            ReadPembelian();
        }

        private void dariTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            ReadPembelian();
        }

        private void BukaPembelian_Load(object sender, EventArgs e)
        {
            this.semuaPembelianCb.Checked = true;
            ReadPembelian();
        }

        private void sampaiTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            ReadPembelian();
        }

        private void pembelianView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedId = pembelianView.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void pembelianView_KeyDown(object sender, KeyEventArgs e)
        {
            this.selectedId = pembelianView.Rows[pembelianView.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
