
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
            this.SuspendLayout();
            // 
            // m_sign_in_button
            // 
            this.m_sign_in_button.Location = new System.Drawing.Point(632, 12);
            this.m_sign_in_button.Name = "m_sign_in_button";
            this.m_sign_in_button.Size = new System.Drawing.Size(75, 23);
            this.m_sign_in_button.TabIndex = 0;
            this.m_sign_in_button.Text = "Sign in";
            this.m_sign_in_button.UseVisualStyleBackColor = true;
            // 
            // m_sign_up_button
            // 
            this.m_sign_up_button.Location = new System.Drawing.Point(713, 12);
            this.m_sign_up_button.Name = "m_sign_up_button";
            this.m_sign_up_button.Size = new System.Drawing.Size(75, 23);
            this.m_sign_up_button.TabIndex = 1;
            this.m_sign_up_button.Text = "Sign up";
            this.m_sign_up_button.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_sign_up_button);
            this.Controls.Add(this.m_sign_in_button);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_sign_in_button;
        private System.Windows.Forms.Button m_sign_up_button;
    }
}

