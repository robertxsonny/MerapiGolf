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
    public partial class Login : Form
    {
        private MerapiGolfLogistik.Classes.Login login = new Classes.Login();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;
            switch (login.LoginRole(username, password))
            {
                case ("input"):
                    PilihInputBarang inputform = new PilihInputBarang(username);
                    inputform.Show();
                    this.Hide();
                    break;
                case ("pengambilan"):
                    AdministratorAmbil ambilform = new AdministratorAmbil();
                    ambilform.Show();
                    this.Hide();
                    break;
                case ("admin"):
                    Administrator adminform = new Administrator();
                    adminform.Show();
                    this.Hide();
                    break;
                case ("laporan"):
                    AdministratorReport reportform = new AdministratorReport();
                    reportform.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Username atau password yang Anda masukkan salah!");
                    break;
            }

        }

        private void usernameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
                passwordTb.Focus();
        }

        private void passwordTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                loginBtn.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.usernameTb;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    InputBarang gudangform = new InputBarang(usernameTb.Text);
        //    //gudangform.Show();
        //    //this.Hide();
        //    var dialog = gudangform.ShowDialog();
        //    if (dialog == DialogResult.OK)
        //    {
        //        MessageBox.Show("Nilai dikembalikan: " + gudangform.id);
        //    }
        //}

        //private void loginBtn_Click(object sender, EventArgs e)
        //{
        //    if (login.InsertLoginRole("adminreport", "report", "laporan"))
        //        MessageBox.Show("Sukses buat user baru!");
        //}
    }
}
