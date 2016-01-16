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
    public partial class PilihNota : Form
    {
        public string selectedNo;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihNota()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.notaList;
            notaList.DataSource = dbContent.mg_nota_pengambilan.ToList();
            notaList.KeyDown += NotaList_KeyDown;
        }

        private void NotaList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowindex = notaList.SelectedCells[0].RowIndex;
                this.selectedNo = notaList.Rows[rowindex].Cells[0].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.F2)
                notaQuery.Focus();
        }

        private void SearchNotaPembelian()
        {
            string query = notaQuery.Text.ToLower();
            var pengambilans = dbContent.mg_nota_pengambilan.Where(p => p.no_nota.ToLower().Contains(query)).ToList();
            notaList.DataSource = pengambilans;
            notaList.Focus();
        }

        private void searchNota_Click(object sender, EventArgs e)
        {
            SearchNotaPembelian();
        }
        
        private void notaQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchNotaPembelian();
        }

        private void PilihNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                notaQuery.Focus();
            else if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void notaList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedNo = notaList.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
