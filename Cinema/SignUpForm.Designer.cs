namespace Cinema {
    partial class SignUpForm {
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
            this.m_send_form_button = new System.Windows.Forms.Button();
            this.m_email_text_box = new System.Windows.Forms.TextBox();
            this.m_second_name_text_box = new System.Windows.Forms.TextBox();
            this.m_name_text_box = new System.Windows.Forms.TextBox();
            this.m_password_text_box = new System.Windows.Forms.TextBox();
            this.m_login_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_transition_link_label = new System.Windows.Forms.LinkLabel();
            this.m_third_name_text_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_send_form_button
            // 
            this.m_send_form_button.Location = new System.Drawing.Point(16, 329);
            this.m_send_form_button.Name = "m_send_form_button";
            this.m_send_form_button.Size = new System.Drawing.Size(193, 23);
            this.m_send_form_button.TabIndex = 21;
            this.m_send_form_button.Text = "отправить форму";
            this.m_send_form_button.UseVisualStyleBackColor = true;
            this.m_send_form_button.Click += new System.EventHandler(this.TryRegister);
            // 
            // m_email_text_box
            // 
            this.m_email_text_box.Location = new System.Drawing.Point(16, 298);
            this.m_email_text_box.Name = "m_email_text_box";
            this.m_email_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_email_text_box.TabIndex = 6;
            // 
            // m_second_name_text_box
            // 
            this.m_second_name_text_box.Location = new System.Drawing.Point(16, 204);
            this.m_second_name_text_box.Name = "m_second_name_text_box";
            this.m_second_name_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_second_name_text_box.TabIndex = 4;
            // 
            // m_name_text_box
            // 
            this.m_name_text_box.Location = new System.Drawing.Point(16, 149);
            this.m_name_text_box.Name = "m_name_text_box";
            this.m_name_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_name_text_box.TabIndex = 3;
            // 
            // m_password_text_box
            // 
            this.m_password_text_box.Location = new System.Drawing.Point(16, 94);
            this.m_password_text_box.Name = "m_password_text_box";
            this.m_password_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_password_text_box.TabIndex = 2;
            // 
            // m_login_text_box
            // 
            this.m_login_text_box.Location = new System.Drawing.Point(16, 39);
            this.m_login_text_box.Name = "m_login_text_box";
            this.m_login_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_login_text_box.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // login_transition_link_label
            // 
            this.login_transition_link_label.AutoSize = true;
            this.login_transition_link_label.Location = new System.Drawing.Point(49, 363);
            this.login_transition_link_label.Name = "login_transition_link_label";
            this.login_transition_link_label.Size = new System.Drawing.Size(124, 13);
            this.login_transition_link_label.TabIndex = 22;
            this.login_transition_link_label.TabStop = true;
            this.login_transition_link_label.Text = "уже имеется аккаунт ?";
            this.login_transition_link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RedirectToLogIn);
            // 
            // m_third_name_text_box
            // 
            this.m_third_name_text_box.Location = new System.Drawing.Point(16, 251);
            this.m_third_name_text_box.Name = "m_third_name_text_box";
            this.m_third_name_text_box.Size = new System.Drawing.Size(193, 20);
            this.m_third_name_text_box.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Отчество";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 390);
            this.Controls.Add(this.m_third_name_text_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login_transition_link_label);
            this.Controls.Add(this.m_send_form_button);
            this.Controls.Add(this.m_email_text_box);
            this.Controls.Add(this.m_second_name_text_box);
            this.Controls.Add(this.m_name_text_box);
            this.Controls.Add(this.m_password_text_box);
            this.Controls.Add(this.m_login_text_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_send_form_button;
        private System.Windows.Forms.TextBox m_email_text_box;
        private System.Windows.Forms.TextBox m_second_name_text_box;
        private System.Windows.Forms.TextBox m_name_text_box;
        private System.Windows.Forms.TextBox m_password_text_box;
        private System.Windows.Forms.TextBox m_login_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel login_transition_link_label;
        private System.Windows.Forms.TextBox m_third_name_text_box;
        private System.Windows.Forms.Label label6;
    }
}