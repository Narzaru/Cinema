namespace Cinema {
    public class UserDataBuilder {
        private UserData userData;

        public UserDataBuilder() {
            userData = new UserData();
        }

        public UserDataBuilder SetUserID(int id) {
            userData.UserID = id;
            return this;
        }

        public UserDataBuilder SetUsername(string username) {
            userData.Username = username;
            return this;
        }

        public UserDataBuilder SetFirstName(string firstName) {
            userData.UserFirstName = firstName;
            return this;
        }

        public UserDataBuilder SetSecondName(string secondName) {
            userData.UserSecondName = secondName;
            return this;
        }

        public UserDataBuilder SetThirdName(string thirdName) {
            userData.UserThirdName = thirdName;
            return this;
        }

        public UserDataBuilder SetEmail(string email) {
            userData.UserEmail = email;
            return this;
        }

        public UserData Build() {
            return userData;
        }

    }
}
