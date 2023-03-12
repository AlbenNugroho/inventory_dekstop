namespace ZeaMart
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbx_username = new TextBox();
            tbx_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonlogin = new Button();
            SuspendLayout();
            // 
            // tbx_username
            // 
            tbx_username.Location = new Point(168, 124);
            tbx_username.Name = "tbx_username";
            tbx_username.Size = new Size(206, 23);
            tbx_username.TabIndex = 0;
            // 
            // tbx_password
            // 
            tbx_password.Location = new Point(168, 186);
            tbx_password.Name = "tbx_password";
            tbx_password.Size = new Size(206, 23);
            tbx_password.TabIndex = 1;
            tbx_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(168, 100);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(168, 168);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // buttonlogin
            // 
            buttonlogin.Location = new Point(234, 231);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(75, 23);
            buttonlogin.TabIndex = 4;
            buttonlogin.Text = "Sign In";
            buttonlogin.UseVisualStyleBackColor = true;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 321);
            Controls.Add(buttonlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_password);
            Controls.Add(tbx_username);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_username;
        private TextBox tbx_password;
        private Label label1;
        private Label label2;
        private Button buttonlogin;
    }
}