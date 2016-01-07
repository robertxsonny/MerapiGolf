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
        internal string LoginRole(string username, string password)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                string md5 = MD5.Encrypt(password);
                var users = dbContent.Users.Where(p => p.username.Equals(username) && p.password.Equals(md5));
                if (users.Count() != 0)
                {
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
                    dbContent.Users.Add(user);
                    dbContent.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
