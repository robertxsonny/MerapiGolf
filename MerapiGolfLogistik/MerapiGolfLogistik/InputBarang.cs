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
    public partial class InputBarang : Form
    {
        private MerapiGolfLogistikEntities dbContent;
        public InputBarang()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void Gudang_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Akun yang login sekarang: " + user);
        }

        private void pilihKategoriBtn_Click(object sender, EventArgs e)
        {
            ReadCategory();
        }

        private void ReadCategory()
        {
            PilihKategori kategoriform = new PilihKategori();
            var res = kategoriform.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (dbContent = new MerapiGolfLogistikEntities())
                {
                    var cat = dbContent.mg_kategori.Where(p => p.id == kategoriform.selectedId).Single();
                    kategoriTb.Text = cat.nama_kategori;
                }
            }
        }
        

        private void InputBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                ReadCategory();
            else if (e.KeyCode == Keys.F2)
                searchTb.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
