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
    public partial class PilihAktiva : Form
    {
        public Guid selectedId;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihAktiva()
        {
            InitializeComponent();
            this.aktivaView.KeyDown += CategoriesView_KeyDown;
        }

        private void CategoriesView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = aktivaView.SelectedCells[0].RowIndex;
                ReturnToAddItems(index);
            }
            else if (e.KeyCode == Keys.F2)
                catQuery.Focus();

        }

        private void PilihKategori_Load(object sender, EventArgs e)
        {
            FetchData data = new FetchData();
            if (!String.IsNullOrWhiteSpace(catQuery.Text))
                aktivaView.DataSource = dbContent.mg_aktiva.Where(p => p.nama_aktiva.ToLower().Contains(catQuery.Text.ToLower())).ToList();
            else
                aktivaView.DataSource = dbContent.mg_aktiva.ToList();
            this.ActiveControl = this.aktivaView;
        }

        private void categoriesView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReturnToAddItems(e.RowIndex);
        }

        private void ReturnToAddItems(int rowindex)
        {
            string idstr = aktivaView.Rows[rowindex].Cells[0].Value.ToString();
            this.selectedId = Guid.Parse(idstr);
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PilihKategori_Load(sender, e);
        }

        private void catQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PilihKategori_Load(sender, e);
                this.aktivaView.Focus();
            }

        }

        private void PilihKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
