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
    public partial class PilihSupplier : Form
    {
        public Guid selectedId;
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        public PilihSupplier()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.supplierList;
            supplierList.DataSource = dbContent.mg_supplier.ToList();
            supplierList.KeyDown += SupplierList_KeyDown;
        }

        private void SupplierList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int rowindex = supplierList.SelectedCells[0].RowIndex;
                this.selectedId = Guid.Parse
                    (supplierList.Rows[rowindex].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
            }
            else if (e.KeyCode == Keys.F2)
                queryTb.Focus();
        }

        private void SearchSuppliers()
        {
            string query = queryTb.Text.ToLower();
            var suppliers = dbContent.mg_supplier.Where(p => p.nama_supplier.ToLower().Contains(query)
            || p.alamat_supplier.ToLower().Contains(query) || p.email_supplier.ToLower().Contains(query) ||
            p.telepon_supplier.ToLower().Contains(query)).ToList();
            supplierList.DataSource = suppliers;
            supplierList.Focus();
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
        }

        private void supplierList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedId = Guid.Parse(supplierList.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
