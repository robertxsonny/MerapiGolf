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
                    PilihInputBarang form = new PilihInputBarang(username);
                    form.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Username atau password yang Anda masukkan salah!");
                    break;
            }
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

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    if (login.InsertLoginRole("admininput", "admin", "input"))
        //        MessageBox.Show("Sukses buat user baru!");
        //}
    }
}
