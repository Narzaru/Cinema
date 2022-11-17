using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class User {
        public static User GetInstance() {
            if (m_instance is null) {
                m_instance = new User();
            }
            return m_instance;
        }


        public static bool IsLoggedIn() {
            return m_user_id != -1 ? true : false;
        }
        

        public int UserId {
            get { return m_user_id; }
            set { m_user_id = value; }
        }

        private User() { m_user_id = -1; }

        private static User m_instance;
        private static int m_user_id;
    }
}
