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
        public Guid selectedId;
        public PilihKategori()
        {
            InitializeComponent();
            if (Classes.Login.role != "admin")
                button2.Visible = false;
            this.categoriesView.KeyDown += CategoriesView_KeyDown;
        }

        private void CategoriesView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = categoriesView.SelectedCells[0].RowIndex;
                ReturnToAddItems(index);
            }
            else if (e.KeyCode == Keys.F2)
                catQuery.Focus();
            else if (e.KeyCode == Keys.F3)
                AddCategory();
        }
        
        private void AddCategory()
        {
            TambahKategori tambahkatform = new TambahKategori();
            tambahkatform.ShowDialog();
            FetchData data = new FetchData();
            categoriesView.DataSource = data.GetCategory(catQuery.Text);
            this.ActiveControl = this.categoriesView;
        }

        private void PilihKategori_Load(object sender, EventArgs e)
        {
            FetchData data = new FetchData();
            categoriesView.DataSource = data.GetCategory(catQuery.Text);
            this.ActiveControl = this.categoriesView;
        }

        private void categoriesView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReturnToAddItems(e.RowIndex);
        }

        private void ReturnToAddItems(int rowindex)
        {
            string idstr = categoriesView.Rows[rowindex].Cells[0].Value.ToString();
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
                this.categoriesView.Focus();
            }
            
        }

        private void PilihKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCategory();
        }
    }
}
