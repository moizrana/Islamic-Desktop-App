using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjhhb
{
    public partial class TutorCh : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=tutorloginmd;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public static TutorCh instance;
        public static string username_selected = "";

        //Public instances for Tutor Pictures:
        public static PictureBox Tutor1Picbox_public;
        public static PictureBox Tutor2Picbox_public;
        public static PictureBox Tutor3Picbox_public;
        public static PictureBox Tutor4Picbox_public;
        public static PictureBox Tutor5Picbox_public;
        public static PictureBox Tutor6Picbox_public;
        public static PictureBox Tutor7Picbox_public;
        public static PictureBox Tutor8Picbox_public;
        public static PictureBox Tutor9Picbox_public;
        public static PictureBox Tutor10Picbox_public;
        public static PictureBox Tutor11Picbox_public;
        public static PictureBox Tutor12Picbox_public;
        public static PictureBox Tutor13Picbox_public;
        public static PictureBox Tutor14Picbox_public;
        public static PictureBox Tutor15Picbox_public;

        public static List<PictureBox> ProfilePicList;


        public TutorCh()
        {
            InitializeComponent();
            instance = this;
            PopulateTutorCards();

            //Public intializations
            Tutor1Picbox_public = Tutor1PicBox;
            Tutor2Picbox_public = Tutor2PicBox;
            Tutor3Picbox_public = Tutor3PicBox;
            Tutor4Picbox_public = Tutor4PicBox;
            Tutor5Picbox_public = Tutor5PicBox;
            Tutor6Picbox_public = Tutor6PicBox;
            Tutor7Picbox_public = Tutor7PicBox;
            Tutor8Picbox_public = Tutor8PicBox;
            Tutor9Picbox_public = Tutor9PicBox;
            Tutor10Picbox_public = Tutor10PicBox;
            Tutor11Picbox_public = Tutor11PicBox;
            Tutor12Picbox_public = Tutor12PicBox;
            Tutor13Picbox_public = Tutor13PicBox;
            Tutor14Picbox_public = Tutor14PicBox;
            Tutor15Picbox_public = Tutor15PicBox;
            ProfilePicList = new List<PictureBox> { Tutor1Picbox_public, Tutor2Picbox_public, Tutor3Picbox_public, Tutor4Picbox_public, Tutor5Picbox_public, Tutor6Picbox_public, Tutor7Picbox_public, Tutor8Picbox_public, Tutor9Picbox_public, Tutor10Picbox_public, Tutor11Picbox_public, Tutor12Picbox_public, Tutor13Picbox_public, Tutor14Picbox_public, Tutor15Picbox_public };

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadform(MainForm mainForm, object Form)
        {
            if (mainForm.callmainpanel.Controls.Count > 0)
                mainForm.callmainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainForm.callmainpanel.Controls.Add(f);
            mainForm.callmainpanel.Tag = f;
            f.Show();
        }


        private void PopulateTutorCards()
        {
            string query = "SELECT * FROM TutorLoginData";

            // List of Labels:
            var NameLabelsList = new List<Label> { Tutor1Name, Tutor2Name, Tutor3Name, Tutor4Name, Tutor5Name, Tutor6Name, Tutor7Name, Tutor8Name, Tutor9Name, Tutor10Name, Tutor11Name, Tutor12Name, Tutor13Name, Tutor14Name, Tutor15Name };
            var AgeLabelsList = new List<Label> { Tutor1Age, Tutor2Age, Tutor3Age, Tutor4Age, Tutor5Age, Tutor6Age, Tutor7Age, Tutor8Age, Tutor8Age, Tutor9Age, Tutor10Age, Tutor11Age, Tutor12Age, Tutor13Age, Tutor14Age, Tutor15Age };
            //   var RatingLabelsList = new List<Label> { Tutor1Rating, Tutor2Rating, Tutor3Rating, Tutor4Rating, Tutor5Rating, Tutor6Rating, Tutor7Rating, Tutor8Rating, Tutor9Rating, Tutor10Rating, Tutor11Rating, Tutor12Rating, Tutor13Rating, Tutor14Rating, Tutor15Rating };
            var PricingLabelsList = new List<Label> { Tutor1Pricing, Tutor2Pricing, Tutor3Pricing, Tutor4Pricing, Tutor5Pricing, Tutor6Pricing, Tutor7Pricing, Tutor8Pricing, Tutor9Pricing, Tutor10Pricing, Tutor11Pricing, Tutor12Pricing, Tutor13Pricing, Tutor14Pricing, Tutor15Pricing };
            var LocationLabelsList = new List<Label> { Tutor1Location, Tutor2Location, Tutor3Location, Tutor4Location, Tutor5Location, Tutor6Location, Tutor7Location, Tutor8Location, Tutor9Location, Tutor10Location, Tutor11Location, Tutor12Location, Tutor13Location, Tutor14Location, Tutor15Location };
            var ContactButtonsList = new List<Button> { Tutor1Contact_btn, Tutor2Contact_btn, Tutor3Contact_btn, Tutor4Contact_btn, Tutor5Contact_btn, Tutor6Contact_btn, Tutor7Contact_btn, Tutor8Contact_btn, Tutor9Contact_btn, Tutor10Contact_btn, Tutor11Contact_btn, Tutor12Contact_btn, Tutor13Contact_btn, Tutor14Contact_btn, Tutor15Contact_btn };
            // List of Picture Boxes:
            var ProfilePictureBoxesList = new List<PictureBox> { Tutor1PicBox, Tutor2PicBox, Tutor3PicBox, Tutor4PicBox, Tutor5PicBox, Tutor6PicBox, Tutor7PicBox, Tutor8PicBox, Tutor9PicBox, Tutor10PicBox, Tutor11PicBox, Tutor12PicBox, Tutor13PicBox, Tutor14PicBox, Tutor15PicBox };
            var PanelsList = new List<Panel> { panel2, panel3, panel4, panel5, panel6, panel7, panel8, panel9, panel10, panel11, panel12, panel13, panel14 };

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable TutorCardsTable = new DataTable();
                adapter.Fill(TutorCardsTable);

                if (TutorCardsTable != null && TutorCardsTable.Rows.Count > 0)
                {
                    int rowIndex = 0;
                    foreach (DataRow row in TutorCardsTable.Rows)
                    {
                        if (rowIndex < NameLabelsList.Count)
                        {
                            NameLabelsList[rowIndex].Text = row["name"].ToString();
                            AgeLabelsList[rowIndex].Text = row["age"].ToString();
                            PricingLabelsList[rowIndex].Text = "$ " + row["hourlyrate"].ToString();
                            LocationLabelsList[rowIndex].Text = row["country"].ToString();


                            byte[] ImageData = (byte[])row["Picture"];
                            ImageConverter converter = new ImageConverter();
                            Image ProfilePic = (Image)converter.ConvertFrom(ImageData);
                            ProfilePictureBoxesList[rowIndex].Image = ProfilePic;
                            ProfilePictureBoxesList[rowIndex].SizeMode = PictureBoxSizeMode.Zoom;

                            //Making Panels with Data Visible:
                            PanelsList[rowIndex].Update();
                            PanelsList[rowIndex].Visible = true;
                            ContactButtonsList[rowIndex].Update();
                            ContactButtonsList[rowIndex].Visible = true;
                            NameLabelsList[rowIndex].Update();
                            NameLabelsList[rowIndex].Visible = true;
                            PricingLabelsList[rowIndex].Update();
                            PricingLabelsList[rowIndex].Visible = true;
                            LocationLabelsList[rowIndex].Update();
                            LocationLabelsList[rowIndex].Visible = true;
                            ProfilePictureBoxesList[rowIndex].Update();
                            ProfilePictureBoxesList[rowIndex].Visible = true;

                            rowIndex++;
                        }
                        else
                        {
                            // Hide the labels and picture boxes that are not updated with data
                            for (int i = rowIndex; i < NameLabelsList.Count; i++)
                            {
                                NameLabelsList[i].Visible = false;
                                AgeLabelsList[i].Visible = false;
                                PricingLabelsList[i].Visible = false;
                                LocationLabelsList[i].Visible = false;
                                ProfilePictureBoxesList[i].Visible = false;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No data found.");
                }
            }
        }


        private void Tutor1Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor1Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor2Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor2Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor3Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor3Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor4Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor4Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor5Contact_btn_Click(object sender, EventArgs e)
        {

            username_selected = Tutor5Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor6Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor6Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor7Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor7Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor8Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor8Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor9Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor9Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor10Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor10Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor11Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor11Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor12Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor12Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor13Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor13Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor14Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor14Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor15Contact_btn_Click(object sender, EventArgs e)
        {
            username_selected = Tutor15Name.Text;
            TutorProfile tForm = new TutorProfile();
            MainForm.instance.callablepanel.Height = tForm.Height;
            MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor1Name_Click(object sender, EventArgs e)
        {

        }

        private void Tutor1Contact_btn_Click_1(object sender, EventArgs e)
        {
            username_selected = Tutor1Name.Text;
            TutorProfile tForm = new TutorProfile();
          //  MainForm.instance.callablepanel.Height = tForm.Height;
          //  MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor2Contact_btn_Click_1(object sender, EventArgs e)
        {
            username_selected = Tutor2Name.Text;
            TutorProfile tForm = new TutorProfile();
          //  MainForm.instance.callablepanel.Height = tForm.Height;
            //MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor3Contact_btn_Click_1(object sender, EventArgs e)
        {
            username_selected = Tutor3Name.Text;
            TutorProfile tForm = new TutorProfile();
          //  MainForm.instance.callablepanel.Height = tForm.Height;
          //  MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor4Contact_btn_Click_1(object sender, EventArgs e)
        {
            username_selected = Tutor4Name.Text;
            TutorProfile tForm = new TutorProfile();
          //  MainForm.instance.callablepanel.Height = tForm.Height;
          //  MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }

        private void Tutor6Contact_btn_Click_1(object sender, EventArgs e)
        {
            username_selected = Tutor6Name.Text;
            TutorProfile tForm = new TutorProfile();
             //MainForm.instance.callablepanel.Height = tForm.Height;
          //  MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(MainForm.instance, tForm);
        }
    }
}
