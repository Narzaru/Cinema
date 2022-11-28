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
    public partial class SignUpForm : Form {
        public SignUpForm() {
            InitializeComponent();
        }

        private void RedirectToLogIn(object sender, LinkLabelLinkClickedEventArgs e) {
            var form = new SignInForm();
            Hide();
            form.ShowDialog(this);
            Close();
        }

        private void TryRegister(object sender, EventArgs e) {
            string login = m_login_text_box.Text;
            string password = m_password_text_box.Text;
            string name = m_name_text_box.Text;
            string second_name = m_second_name_text_box.Text;
            string third_name = m_third_name_text_box.Text;
            string email = m_email_text_box.Text;

            // TODO(Narzaru) add value validation

            try {
                DataBase.SetData($"INSERT INTO [user] ([login], [password], [first name], [second name], [third name], [email]) VALUES ('{login}', '{password}', '{name}', '{second_name}', '{third_name}', '{email}')");
                MessageBox.Show("Регистрация успешна", "", MessageBoxButtons.OK);
                Hide();
            } catch (Exception exception) {
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK);
            }
        }
    }
}
