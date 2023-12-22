namespace SyncFileExchange
{
    partial class AuthFrame
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
            emailLogin_tb = new TextBox();
            label1 = new Label();
            passwordLogin_tb = new TextBox();
            label2 = new Label();
            login_btn = new Button();
            signup_btn = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // emailLogin_tb
            // 
            emailLogin_tb.Location = new Point(70, 82);
            emailLogin_tb.Name = "emailLogin_tb";
            emailLogin_tb.Size = new Size(151, 23);
            emailLogin_tb.TabIndex = 0;
            emailLogin_tb.TextChanged += emailLogin_tb_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 64);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "E-Mail";
            // 
            // passwordLogin_tb
            // 
            passwordLogin_tb.Location = new Point(70, 139);
            passwordLogin_tb.Name = "passwordLogin_tb";
            passwordLogin_tb.Size = new Size(151, 23);
            passwordLogin_tb.TabIndex = 2;
            passwordLogin_tb.TextChanged += passwordLogin_tb_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.Location = new Point(70, 184);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 23);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // signup_btn
            // 
            signup_btn.Location = new Point(146, 184);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(75, 23);
            signup_btn.TabIndex = 5;
            signup_btn.Text = "Sign up";
            signup_btn.UseVisualStyleBackColor = true;
            signup_btn.Click += signup_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // AuthFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 342);
            Controls.Add(label3);
            Controls.Add(signup_btn);
            Controls.Add(login_btn);
            Controls.Add(label2);
            Controls.Add(passwordLogin_tb);
            Controls.Add(label1);
            Controls.Add(emailLogin_tb);
            Name = "AuthFrame";
            Text = "SFE - Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailLogin_tb;
        private Label label1;
        private TextBox passwordLogin_tb;
        private Label label2;
        private Button login_btn;
        private Button signup_btn;
        private Label label3;
    }
}