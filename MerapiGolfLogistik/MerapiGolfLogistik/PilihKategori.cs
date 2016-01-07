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
    public partial class PilihKategori : Form
    {
        public int selectedId;
        public PilihKategori()
        {
            InitializeComponent();
        }

        private void PilihKategori_Load(object sender, EventArgs e)
        {
            FetchData data = new FetchData();
            categoriesView.DataSource = data.GetCategory(catQuery.Text);
        }

        private void categoriesView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReturnToAddItems(e.RowIndex);
        }

        private void ReturnToAddItems(int rowindex)
        {
            string idstr = categoriesView.Rows[rowindex].Cells[0].Value.ToString();
            this.selectedId = Convert.ToInt32(idstr);
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PilihKategori_Load(sender, e);
        }

        private void catQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PilihKategori_Load(sender, e);
        }
    }
}
