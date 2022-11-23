
namespace Cinema
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_sign_in_button = new System.Windows.Forms.Button();
            this.m_sign_up_button = new System.Windows.Forms.Button();
            this.m_user_log = new System.Windows.Forms.FlowLayoutPanel();
            this.m_user_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_sign_in_button
            // 
            this.m_sign_in_button.Location = new System.Drawing.Point(3, 3);
            this.m_sign_in_button.Name = "m_sign_in_button";
            this.m_sign_in_button.Size = new System.Drawing.Size(75, 23);
            this.m_sign_in_button.TabIndex = 0;
            this.m_sign_in_button.Text = "Sign in";
            this.m_sign_in_button.UseVisualStyleBackColor = true;
            this.m_sign_in_button.Click += new System.EventHandler(this.OnSignInButtonClick);
            // 
            // m_sign_up_button
            // 
            this.m_sign_up_button.Location = new System.Drawing.Point(84, 3);
            this.m_sign_up_button.Name = "m_sign_up_button";
            this.m_sign_up_button.Size = new System.Drawing.Size(75, 23);
            this.m_sign_up_button.TabIndex = 1;
            this.m_sign_up_button.Text = "Sign up";
            this.m_sign_up_button.UseVisualStyleBackColor = true;
            this.m_sign_up_button.Click += new System.EventHandler(this.OnSignUpButtonClick);
            // 
            // m_user_log
            // 
            this.m_user_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_user_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_user_log.Controls.Add(this.m_sign_in_button);
            this.m_user_log.Controls.Add(this.m_sign_up_button);
            this.m_user_log.Location = new System.Drawing.Point(624, 12);
            this.m_user_log.Name = "m_user_log";
            this.m_user_log.Size = new System.Drawing.Size(164, 31);
            this.m_user_log.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_user_log);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Cinemas";
            this.m_user_log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_sign_in_button;
        private System.Windows.Forms.Button m_sign_up_button;
        private System.Windows.Forms.FlowLayoutPanel m_user_log;
    }
}

