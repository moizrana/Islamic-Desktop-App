namespace kjhhb
{
    partial class MainTutoringScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTutoringScreen));
            panel1 = new Panel();
            mainpanel = new Panel();
            Or_Label = new Label();
            TutorSignup_btn = new Button();
            TutorLogin_btn = new Button();
            studentLogin_btn = new Button();
            panel1.SuspendLayout();
            mainpanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mainpanel);
            panel1.Location = new Point(-3, -5);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 377);
            panel1.TabIndex = 0;
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.Plum;
            mainpanel.BackgroundImage = (Image)resources.GetObject("mainpanel.BackgroundImage");
            mainpanel.Controls.Add(Or_Label);
            mainpanel.Controls.Add(TutorSignup_btn);
            mainpanel.Controls.Add(TutorLogin_btn);
            mainpanel.Controls.Add(studentLogin_btn);
            mainpanel.Location = new Point(0, 0);
            mainpanel.Margin = new Padding(2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(675, 399);
            mainpanel.TabIndex = 0;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // Or_Label
            // 
            Or_Label.AutoSize = true;
            Or_Label.Location = new Point(308, 188);
            Or_Label.Margin = new Padding(2, 0, 2, 0);
            Or_Label.Name = "Or_Label";
            Or_Label.Size = new Size(20, 15);
            Or_Label.TabIndex = 4;
            Or_Label.Text = "Or";
            // 
            // TutorSignup_btn
            // 
            TutorSignup_btn.BackColor = Color.RebeccaPurple;
            TutorSignup_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TutorSignup_btn.ForeColor = SystemColors.Control;
            TutorSignup_btn.Location = new Point(218, 217);
            TutorSignup_btn.Margin = new Padding(2);
            TutorSignup_btn.Name = "TutorSignup_btn";
            TutorSignup_btn.Size = new Size(210, 33);
            TutorSignup_btn.TabIndex = 2;
            TutorSignup_btn.Text = "Signup As Tutor";
            TutorSignup_btn.UseVisualStyleBackColor = false;
            TutorSignup_btn.Click += TutorSignup_btn_Click;
            TutorSignup_btn.Leave += TutorSignup_btn_Leave;
            // 
            // TutorLogin_btn
            // 
            TutorLogin_btn.BackColor = Color.SeaGreen;
            TutorLogin_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TutorLogin_btn.ForeColor = SystemColors.ButtonHighlight;
            TutorLogin_btn.Location = new Point(218, 120);
            TutorLogin_btn.Margin = new Padding(2);
            TutorLogin_btn.Name = "TutorLogin_btn";
            TutorLogin_btn.Size = new Size(210, 34);
            TutorLogin_btn.TabIndex = 1;
            TutorLogin_btn.Text = "Login As Tutor";
            TutorLogin_btn.UseVisualStyleBackColor = false;
            TutorLogin_btn.Click += TutorLogin_btn_Click;
            // 
            // studentLogin_btn
            // 
            studentLogin_btn.BackColor = Color.Maroon;
            studentLogin_btn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLogin_btn.ForeColor = SystemColors.Control;
            studentLogin_btn.Location = new Point(218, 52);
            studentLogin_btn.Margin = new Padding(2);
            studentLogin_btn.Name = "studentLogin_btn";
            studentLogin_btn.Size = new Size(210, 40);
            studentLogin_btn.TabIndex = 0;
            studentLogin_btn.Text = "Login As Student";
            studentLogin_btn.UseVisualStyleBackColor = false;
            studentLogin_btn.Click += studentLogin_btn_Click;
            // 
            // MainTutoringScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 365);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainTutoringScreen";
            Text = "MainTutoringScreen";
            panel1.ResumeLayout(false);
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mainpanel;
        private Button TutorSignup_btn;
        private Button TutorLogin_btn;
        private Button studentLogin_btn;
        private Label Or_Label;
    }
}