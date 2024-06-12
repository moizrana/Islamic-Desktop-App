using System.Net.NetworkInformation;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YTvideo;
using System.Data.SqlClient;

namespace kjhhb
{
    public partial class MainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=tutorloginmd;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public Panel callablepanel;
        public Panel callmainpanel;
        public static MainForm instance;
        public PictureBox UserImage;
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            callmainpanel = mainpanel;
            callablepanel = panel1;
            name.Text = Form1.instance.tb1.Text;
            panel1.Height = home.Height;
            panel1.Top = home.Top;
            loadform(new Home());
            UserImage = pictureBox2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }



        private void tajweed_Click(object sender, EventArgs e)
        {
            panel1.Height = tajweed.Height;
            panel1.Top = tajweed.Top;
            loadform(new Tajweed());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panel1.Height = hadith.Height;
            panel1.Top = hadith.Top;
            loadform(new Hadith1());
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel1.Height = home.Height;
            panel1.Top = home.Top;
            loadform(new Home());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panel1.Height = quran.Height;
            panel1.Top = quran.Top;
            loadform(new Quran());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panel1.Height = iconButton5.Height;
            panel1.Top = iconButton5.Top;
            loadform(new Lecture());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            panel1.Height = translation.Height;
            panel1.Top = translation.Top;
            loadform(new Translation());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!Form1.instance.Check_if_foundInTutor)
            {
                panel1.Height = iconButton1.Height;
                panel1.Top = iconButton1.Top;
                loadform(new MainTutoringScreen());
            }
            else
            {
                panel1.Height = iconButton1.Height;
                panel1.Top = iconButton1.Top;
                TutorCh.username_selected = Form1.instance.tb1.Text;
                string query = "SELECT * FROM TutorLoginData";
                int rowIndex = 0;
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable TutorCardsTable = new DataTable();
                    adapter.Fill(TutorCardsTable);

                    // Iterate over each row in DataTable:
                    foreach (DataRow row in TutorCardsTable.Rows)
                    {
                        // Check if the name matches the selected username
                        if (row["name"].ToString() == TutorCh.username_selected)
                        {
                            byte[] ImageData = (byte[])row["Picture"];
                            ImageConverter converter = new ImageConverter();
                            Image ProfilePic = (Image)converter.ConvertFrom(ImageData);
                            UserImage.Image = ProfilePic;
                            // Exit the loop since we found the matching row
                            break;
                        }
                        else
                        {
                            rowIndex++;
                        }
                    }
                }
               


                TutorProfile tpForm = new TutorProfile();
               // MainForm.instance.callablepanel.Height = tpForm.Height;
               // MainForm.instance.callablepanel.Top = tpForm.Top;
                loadform (tpForm);
            }
        }
    }
}
