namespace Cinema {
    public class User {
        public static User GetInstance() {
            if (m_instance is null) {
                m_instance = new User();
            }
            return m_instance;
        }

        public bool IsLoggedIn() {
            return Data is null;
        }

        public UserData Data { get; set; }

        private User() { Data = null; }

        private static User m_instance = null;
    }
}
