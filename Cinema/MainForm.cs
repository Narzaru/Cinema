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
    public partial class MainForm : Form {
        public MainForm() {
            try {
                DataBase.TryConnect("Data Source=DESKTOP-MM05ULR;Database=Cinema;Integrated Security=True");
            } catch {
                MessageBox.Show("Have no connection.", "Error", MessageBoxButtons.OK);
                Environment.Exit(1);
                Application.Exit();
            }
            InitializeComponent();
        }

        private void OnSignInButtonClick(object sender, EventArgs e) {
            new SignInForm().ShowDialog(this);
        }

        private void OnSignUpButtonClick(object sender, EventArgs e) {
            new SignUpForm().ShowDialog(this);
        }
    }
}
