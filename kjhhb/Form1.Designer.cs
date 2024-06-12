namespace kjhhb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_close = new Label();
            login_registerHere = new Label();
            label4 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            login_password = new TextBox();
            label3 = new Label();
            login_username = new TextBox();
            label2 = new Label();
            Label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(login_close);
            panel1.Controls.Add(login_registerHere);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_showPass);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(login_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(login_username);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, -1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 364);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // login_close
            // 
            login_close.AutoSize = true;
            login_close.Cursor = Cursors.Hand;
            login_close.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_close.Location = new Point(537, 7);
            login_close.Margin = new Padding(2, 0, 2, 0);
            login_close.Name = "login_close";
            login_close.Size = new Size(18, 18);
            login_close.TabIndex = 11;
            login_close.Text = "X";
            login_close.Click += login_close_Click;
            // 
            // login_registerHere
            // 
            login_registerHere.AutoSize = true;
            login_registerHere.Cursor = Cursors.Hand;
            login_registerHere.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_registerHere.ForeColor = Color.DimGray;
            login_registerHere.Location = new Point(423, 331);
            login_registerHere.Margin = new Padding(2, 0, 2, 0);
            login_registerHere.Name = "login_registerHere";
            login_registerHere.Size = new Size(87, 13);
            login_registerHere.TabIndex = 10;
            login_registerHere.Text = "Register Now!";
            login_registerHere.Click += login_registerHere_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(279, 331);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account?";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.BackColor = Color.Transparent;
            login_showPass.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.ForeColor = Color.Gray;
            login_showPass.Location = new Point(415, 238);
            login_showPass.Margin = new Padding(2, 2, 2, 2);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(126, 21);
            login_showPass.TabIndex = 8;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = false;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.DodgerBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(268, 283);
            login_btn.Margin = new Padding(2, 2, 2, 2);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(84, 32);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Cursor = Cursors.Hand;
            login_password.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(251, 202);
            login_password.Margin = new Padding(2, 2, 2, 2);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(290, 23);
            login_password.TabIndex = 6;
            login_password.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(248, 185);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            label3.Click += label3_Click_1;
            // 
            // login_username
            // 
            login_username.Cursor = Cursors.Hand;
            login_username.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(251, 133);
            login_username.Margin = new Padding(2, 2, 2, 2);
            login_username.Name = "login_username";
            login_username.Size = new Size(290, 23);
            login_username.TabIndex = 4;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("MS UI Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.Location = new Point(259, 27);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(269, 38);
            Label1.TabIndex = 1;
            Label1.Text = "Welcome Back!";
            Label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 56, 137);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 364);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 197);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 37);
            label6.TabIndex = 1;
            label6.Text = "ٱلسَّلَامُ عَلَيْكُمْ";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(19, 41);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(164, 117);
            panel3.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 360);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login_registerHere;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label login_close;
    }
}

