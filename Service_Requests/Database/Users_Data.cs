using Service_Requests;
using Service_Rrequests.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Rrequests
{
    class users_data
    {
        public user ud;

        public Boolean db_connection_available()
        {
            try
            {
                using (var dbContext = new Service_Requests_Data_GOVEntities())
                {
                    dbContext.Database.Connection.Open();
                    dbContext.Database.Connection.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void saveUser(user u)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                dbContext.users.Add(u);
                dbContext.SaveChanges();
            }
        }

        public Boolean check_user_exists(String username)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var userData = dbContext.users.Where(u => u.user_username.Equals(username)).FirstOrDefault<user>();
                if (userData is null)
                {
                    return false;
                }
            }
            return true;
        }

        public int verified(String username)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                ud = dbContext.users.Where(u => u.user_username.Equals(username)).FirstOrDefault<user>();
                try
                {
                    if (ud.user_approved == true) return 1;
                }
                catch (Exception) { return 2; }
                return 0;
            }
        }

        public int authorize(String username, String password)
        {
            if (this.db_connection_available())
            {
                int verified_state = verified(username);
                if (verified_state == 0)
                {
                    if (Crypto.ValidatePassword(password, ud.user_password)) return 1; //authorized
                }
                else if (verified_state == 0) return 3; //account is not verified
                else return 2;
            }
            else return 4;   //cannot connect t DB    
            return 2;   //invalid username/ password
        }
    }
}
