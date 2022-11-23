using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema {
    public partial class SignInForm : Form {
        public SignInForm() {
            InitializeComponent();
        }

        private void TryLogin(object sender, EventArgs e) {
            string login = m_login_text_box.Text;
            string password = m_password_text_box.Text;
            string query_string = $"SELECT [code], [login], [first name], [second name], [third name], [email] FROM [user] WHERE [user].login = '{login}' AND [user].password = '{password}';";
            var response = DataBase.GetData(query_string).Rows;
            if (response.Count == 0) {
                MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK);
            } else {
                try {
                    User.GetInstance().Data = new UserDataBuilder().SetUserID(Convert.ToInt32(response[0][0]))
                                                                   .SetUsername(response[0][1].ToString())
                                                                   .SetFirstName(response[0][2].ToString())
                                                                   .SetSecondName(response[0][3].ToString())
                                                                   .SetThirdName(response[0][4].ToString())
                                                                   .SetEmail(response[0][5].ToString())
                                                                   .Build();
                    MessageBox.Show($"Добро пожаловать, {response[0][2]}!");
                    Close();
                } catch (Exception exception) {
                    MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
