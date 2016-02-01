using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class Login
    {
        private MerapiGolfLogistikEntities dbContent;
        public static Guid currentUser;
        public static string role;
        internal string LoginRole(string username, string password)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                string md5 = MD5.Encrypt(password);
                var users = dbContent.mg_user.Where(p => p.username == username && p.password == md5);
                if (users.Count() != 0)
                {
                    currentUser = users.FirstOrDefault().id;
                    role = users.FirstOrDefault().role;
                    return users.FirstOrDefault().role.ToLower();
                }
                else return "failed";
            }
        }

        internal bool InsertLoginRole(string username, string password, string role)
        {
            try
            {
                using (dbContent = new MerapiGolfLogistikEntities())
                {
                    string md5 = MD5.Encrypt(password);
                    User user = new User();
                    user.id = Guid.NewGuid();
                    user.username = username;
                    user.password = md5;
                    user.role = role;
                    user.nama_karyawan = "Admin Input";
                    user.alamat_karyawan = "Jalan Default";

                    dbContent.mg_user.Add(user);
                    dbContent.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
