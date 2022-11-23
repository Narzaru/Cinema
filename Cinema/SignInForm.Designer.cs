namespace Cinema {
    partial class SignInForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.m_password_text_box = new System.Windows.Forms.TextBox();
            this.m_login_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_log_in_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_password_text_box
            // 
            this.m_password_text_box.Location = new System.Drawing.Point(17, 90);
            this.m_password_text_box.Name = "m_password_text_box";
            this.m_password_text_box.PasswordChar = '*';
            this.m_password_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_password_text_box.TabIndex = 21;
            // 
            // m_login_text_box
            // 
            this.m_login_text_box.Location = new System.Drawing.Point(17, 35);
            this.m_login_text_box.Name = "m_login_text_box";
            this.m_login_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_login_text_box.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Логин";
            // 
            // m_log_in_button
            // 
            this.m_log_in_button.Location = new System.Drawing.Point(17, 126);
            this.m_log_in_button.Name = "m_log_in_button";
            this.m_log_in_button.Size = new System.Drawing.Size(193, 23);
            this.m_log_in_button.TabIndex = 22;
            this.m_log_in_button.Text = "вход";
            this.m_log_in_button.UseVisualStyleBackColor = true;
            this.m_log_in_button.Click += new System.EventHandler(this.TryLogin);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 161);
            this.Controls.Add(this.m_log_in_button);
            this.Controls.Add(this.m_password_text_box);
            this.Controls.Add(this.m_login_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignInForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_password_text_box;
        private System.Windows.Forms.TextBox m_login_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button m_log_in_button;
    }
}