namespace kjhhb
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            translation = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            hadith = new FontAwesome.Sharp.IconButton();
            tajweed = new FontAwesome.Sharp.IconButton();
            quran = new FontAwesome.Sharp.IconButton();
            home = new FontAwesome.Sharp.IconButton();
            panellogo = new Panel();
            name = new Label();
            pictureBox2 = new PictureBox();
            toppanel = new Panel();
            pictureBox1 = new PictureBox();
            buttonclose = new Button();
            label2 = new Label();
            mainpanel = new Panel();
            panelMenu.SuspendLayout();
            panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(translation);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(iconButton5);
            panelMenu.Controls.Add(hadith);
            panelMenu.Controls.Add(tajweed);
            panelMenu.Controls.Add(quran);
            panelMenu.Controls.Add(home);
            panelMenu.Controls.Add(panellogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(175, 470);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // translation
            // 
            translation.Dock = DockStyle.Top;
            translation.FlatAppearance.BorderSize = 0;
            translation.FlatStyle = FlatStyle.Flat;
            translation.ForeColor = Color.Gainsboro;
            translation.IconChar = FontAwesome.Sharp.IconChar.Language;
            translation.IconColor = Color.Gainsboro;
            translation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            translation.IconSize = 40;
            translation.ImageAlign = ContentAlignment.MiddleLeft;
            translation.Location = new Point(0, 376);
            translation.Name = "translation";
            translation.Padding = new Padding(10, 0, 20, 0);
            translation.Size = new Size(175, 46);
            translation.TabIndex = 8;
            translation.Text = "Translations";
            translation.TextAlign = ContentAlignment.MiddleLeft;
            translation.TextImageRelation = TextImageRelation.ImageBeforeText;
            translation.UseVisualStyleBackColor = true;
            translation.Click += iconButton2_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Location = new Point(0, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 39);
            panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 330);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(175, 46);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Tutoring";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButton5
            // 
            iconButton5.Dock = DockStyle.Top;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.Gainsboro;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.VideoCamera;
            iconButton5.IconColor = Color.Gainsboro;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 38;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(0, 284);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 20, 0);
            iconButton5.Size = new Size(175, 46);
            iconButton5.TabIndex = 6;
            iconButton5.Text = "Lectures";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // hadith
            // 
            hadith.Dock = DockStyle.Top;
            hadith.FlatAppearance.BorderSize = 0;
            hadith.FlatStyle = FlatStyle.Flat;
            hadith.ForeColor = Color.Gainsboro;
            hadith.IconChar = FontAwesome.Sharp.IconChar.Book;
            hadith.IconColor = Color.Gainsboro;
            hadith.IconFont = FontAwesome.Sharp.IconFont.Auto;
            hadith.IconSize = 38;
            hadith.ImageAlign = ContentAlignment.MiddleLeft;
            hadith.Location = new Point(0, 238);
            hadith.Name = "hadith";
            hadith.Padding = new Padding(10, 0, 20, 0);
            hadith.Size = new Size(175, 46);
            hadith.TabIndex = 5;
            hadith.Text = "Hadith";
            hadith.TextAlign = ContentAlignment.MiddleLeft;
            hadith.TextImageRelation = TextImageRelation.ImageBeforeText;
            hadith.UseVisualStyleBackColor = true;
            hadith.Click += iconButton4_Click;
            // 
            // tajweed
            // 
            tajweed.Dock = DockStyle.Top;
            tajweed.FlatAppearance.BorderSize = 0;
            tajweed.FlatStyle = FlatStyle.Flat;
            tajweed.ForeColor = Color.Gainsboro;
            tajweed.IconChar = FontAwesome.Sharp.IconChar.ScaleUnbalanced;
            tajweed.IconColor = Color.Gainsboro;
            tajweed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            tajweed.IconSize = 38;
            tajweed.ImageAlign = ContentAlignment.MiddleLeft;
            tajweed.Location = new Point(0, 192);
            tajweed.Name = "tajweed";
            tajweed.Padding = new Padding(10, 0, 20, 0);
            tajweed.Size = new Size(175, 46);
            tajweed.TabIndex = 4;
            tajweed.Text = "Tajweed";
            tajweed.TextAlign = ContentAlignment.MiddleLeft;
            tajweed.TextImageRelation = TextImageRelation.ImageBeforeText;
            tajweed.UseVisualStyleBackColor = true;
            tajweed.Click += tajweed_Click;
            // 
            // quran
            // 
            quran.Dock = DockStyle.Top;
            quran.FlatAppearance.BorderSize = 0;
            quran.FlatStyle = FlatStyle.Flat;
            quran.ForeColor = Color.Gainsboro;
            quran.IconChar = FontAwesome.Sharp.IconChar.BookQuran;
            quran.IconColor = Color.Gainsboro;
            quran.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quran.IconSize = 38;
            quran.ImageAlign = ContentAlignment.MiddleLeft;
            quran.Location = new Point(0, 146);
            quran.Name = "quran";
            quran.Padding = new Padding(10, 0, 20, 0);
            quran.Size = new Size(175, 46);
            quran.TabIndex = 3;
            quran.Text = "Quran";
            quran.TextAlign = ContentAlignment.MiddleLeft;
            quran.TextImageRelation = TextImageRelation.ImageBeforeText;
            quran.UseVisualStyleBackColor = true;
            quran.Click += iconButton2_Click;
            // 
            // home
            // 
            home.Dock = DockStyle.Top;
            home.FlatAppearance.BorderSize = 0;
            home.FlatStyle = FlatStyle.Flat;
            home.ForeColor = Color.Gainsboro;
            home.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            home.IconColor = Color.Gainsboro;
            home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            home.IconSize = 38;
            home.ImageAlign = ContentAlignment.MiddleLeft;
            home.Location = new Point(0, 100);
            home.Name = "home";
            home.Padding = new Padding(10, 0, 20, 0);
            home.Size = new Size(175, 46);
            home.TabIndex = 2;
            home.Text = "Home";
            home.TextAlign = ContentAlignment.MiddleLeft;
            home.TextImageRelation = TextImageRelation.ImageBeforeText;
            home.UseVisualStyleBackColor = true;
            home.Click += Home_Click;
            // 
            // panellogo
            // 
            panellogo.Controls.Add(name);
            panellogo.Controls.Add(pictureBox2);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Padding = new Padding(10, 0, 20, 0);
            panellogo.Size = new Size(175, 100);
            panellogo.TabIndex = 1;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = SystemColors.ButtonFace;
            name.Location = new Point(48, 71);
            name.Name = "name";
            name.Size = new Size(48, 16);
            name.TabIndex = 1;
            name.Text = "label1";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.DarkSlateBlue;
            toppanel.Controls.Add(pictureBox1);
            toppanel.Controls.Add(buttonclose);
            toppanel.Dock = DockStyle.Top;
            toppanel.Location = new Point(175, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(675, 71);
            toppanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(224, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonclose
            // 
            buttonclose.BackColor = Color.DarkSlateBlue;
            buttonclose.FlatAppearance.BorderSize = 0;
            buttonclose.FlatStyle = FlatStyle.Flat;
            buttonclose.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonclose.ForeColor = SystemColors.Control;
            buttonclose.Location = new Point(650, 0);
            buttonclose.Name = "buttonclose";
            buttonclose.Size = new Size(25, 21);
            buttonclose.TabIndex = 3;
            buttonclose.Text = "x";
            buttonclose.UseVisualStyleBackColor = false;
            buttonclose.Click += buttonclose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 142);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // mainpanel
            // 
            mainpanel.Anchor = AnchorStyles.None;
            mainpanel.BackColor = Color.SlateGray;
            mainpanel.Location = new Point(175, 71);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(675, 399);
            mainpanel.TabIndex = 3;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 470);
            Controls.Add(mainpanel);
            Controls.Add(label2);
            Controls.Add(toppanel);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panellogo;
        private FontAwesome.Sharp.IconButton home;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton hadith;
        private FontAwesome.Sharp.IconButton tajweed;
        private FontAwesome.Sharp.IconButton quran;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Panel toppanel;
        private Label label2;
        private Button buttonclose;
        private Panel mainpanel;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton translation;
        private Label name;
        private PictureBox pictureBox2;
    }
}
