namespace kjhhb
{
    partial class Signup
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            signup_confirmPassword = new TextBox();
            signup_close = new Label();
            signup_loginHere = new Label();
            label8 = new Label();
            label4 = new Label();
            signup_showPass = new CheckBox();
            signup_password = new TextBox();
            label9 = new Label();
            signup_btn = new Button();
            signup_email = new TextBox();
            label3 = new Label();
            signup_username = new TextBox();
            label2 = new Label();
            Label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(signup_confirmPassword);
            panel1.Controls.Add(signup_close);
            panel1.Controls.Add(signup_loginHere);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(signup_showPass);
            panel1.Controls.Add(signup_password);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(signup_email);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(signup_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 604);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // signup_confirmPassword
            // 
            signup_confirmPassword.Cursor = Cursors.Hand;
            signup_confirmPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_confirmPassword.Location = new Point(357, 399);
            signup_confirmPassword.Margin = new Padding(3, 4, 3, 4);
            signup_confirmPassword.Name = "signup_confirmPassword";
            signup_confirmPassword.PasswordChar = '*';
            signup_confirmPassword.Size = new Size(414, 30);
            signup_confirmPassword.TabIndex = 3;
            signup_confirmPassword.TextChanged += signup_confirmPassword_TextChanged;
            signup_confirmPassword.Leave += signup_confirmPassword_Leave;
            // 
            // signup_close
            // 
            signup_close.AutoSize = true;
            signup_close.Cursor = Cursors.Hand;
            signup_close.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_close.Location = new Point(763, 8);
            signup_close.Name = "signup_close";
            signup_close.Size = new Size(27, 26);
            signup_close.TabIndex = 11;
            signup_close.Text = "X";
            signup_close.Click += signup_close_Click;
            // 
            // signup_loginHere
            // 
            signup_loginHere.AutoSize = true;
            signup_loginHere.Cursor = Cursors.Hand;
            signup_loginHere.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_loginHere.ForeColor = Color.DimGray;
            signup_loginHere.Location = new Point(615, 552);
            signup_loginHere.Name = "signup_loginHere";
            signup_loginHere.Size = new Size(97, 20);
            signup_loginHere.TabIndex = 10;
            signup_loginHere.Text = "Login Here";
            signup_loginHere.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 370);
            label8.Name = "label8";
            label8.Size = new Size(160, 25);
            label8.TabIndex = 14;
            label8.Text = "Confirm Password:";
            label8.Click += label8_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(391, 552);
            label4.Name = "label4";
            label4.Size = new Size(218, 22);
            label4.TabIndex = 9;
            label4.Text = "Already have an account?";
            label4.Click += label4_Click;
            // 
            // signup_showPass
            // 
            signup_showPass.AutoSize = true;
            signup_showPass.BackColor = Color.Transparent;
            signup_showPass.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_showPass.ForeColor = Color.Gray;
            signup_showPass.Location = new Point(579, 451);
            signup_showPass.Margin = new Padding(3, 4, 3, 4);
            signup_showPass.Name = "signup_showPass";
            signup_showPass.Size = new Size(179, 29);
            signup_showPass.TabIndex = 8;
            signup_showPass.Text = "Show Password";
            signup_showPass.UseVisualStyleBackColor = false;
            signup_showPass.CheckedChanged += signup_showPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Cursor = Cursors.Hand;
            signup_password.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_password.Location = new Point(357, 323);
            signup_password.Margin = new Padding(3, 4, 3, 4);
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(414, 30);
            signup_password.TabIndex = 2;
            signup_password.TextChanged += signup_password_TextChanged;
            signup_password.Leave += signup_password_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(357, 294);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 12;
            label9.Text = "Password:";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.DodgerBlue;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(374, 483);
            signup_btn.Margin = new Padding(3, 4, 3, 4);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(111, 44);
            signup_btn.TabIndex = 7;
            signup_btn.Text = "SignUp";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_email
            // 
            signup_email.Cursor = Cursors.Hand;
            signup_email.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_email.Location = new Point(357, 247);
            signup_email.Margin = new Padding(3, 4, 3, 4);
            signup_email.Name = "signup_email";
            signup_email.Size = new Size(414, 30);
            signup_email.TabIndex = 1;
            signup_email.Leave += signup_email_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 218);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 5;
            label3.Text = "Email Address:";
            // 
            // signup_username
            // 
            signup_username.Cursor = Cursors.Hand;
            signup_username.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_username.Location = new Point(357, 168);
            signup_username.Margin = new Padding(3, 4, 3, 4);
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(414, 30);
            signup_username.TabIndex = 0;
            signup_username.Leave += signup_username_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 139);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(353, 47);
            Label1.Name = "Label1";
            Label1.Size = new Size(163, 28);
            Label1.TabIndex = 1;
            Label1.Text = "Get Started";
            Label1.Click += Label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 137);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 600);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(46, 314);
            label6.Name = "label6";
            label6.Size = new Size(226, 55);
            label6.TabIndex = 1;
            label6.Text = "ٱلسَّلَامُ عَلَيْكُمْ";
            label6.Click += label6_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(46, 62);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 195);
            panel3.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label signup_loginHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox signup_confirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label9;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
    }
}