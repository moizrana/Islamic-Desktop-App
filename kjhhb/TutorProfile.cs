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
    public partial class TutorProfile : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=tutorloginmd;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public static TutorProfile instance;



        public TutorProfile()
        {
            InitializeComponent();
            instance = this;
            GetTutorCardDetails();

            /*            TutorProfilePic.Image = TutorSignup.instance.profilepic_picbox.Image;
            *//*            TutorNameLabel.Text = TutorSignup.instance.username_tb.Text;*//*
                        TutorEmailLabel.Text = TutorSignup.instance.email_tb.Text;
                        TutorAgeLabel.Text = TutorSignup.instance.age_tb.Text;
                        TutorCountryLabel.Text = TutorSignup.instance.country_tb.Text;
                        TutorHourlyRateLabel.Text = TutorSignup.instance.hourlyrate_tb.Text;
                        TutorGenderLabel.Text = TutorSignup.instance.gender_cmb.Text;
                        TutorPhoneNumberLabel.Text = TutorSignup.instance.phonenumber_tb.Text;
                        TutorAboutLabel.Text = TutorSignup.instance.about_tb.Text;
                        TutorFirstLanguageLabel.Text = TutorSignup.instance.firstlanguage_tb.Text;
                        TutorSecondLanguageLabel.Text = TutorSignup.instance.secondlanguage_tb.Text;
                        TutorExperienceLabel.Text = TutorSignup.instance.experience_tb.Text;*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetTutorCardDetails()
        {
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
                        // Assign data to labels and PictureBoxes
                        TutorProfilePic.Image = MainForm.instance.UserImage.Image;
                        TutorNameLabel.Text = row["name"].ToString();
                        TutorEmailLabel.Text = row["email"].ToString();
                        TutorAgeLabel.Text = row["age"].ToString();
                        TutorCountryLabel.Text = row["country"].ToString();
                        TutorHourlyRateLabel.Text = "$ " + row["hourlyrate"].ToString();
                        TutorGenderLabel.Text = row["gender"].ToString();
                        TutorPhoneNumberLabel.Text = row["phonenumber"].ToString();
                        TutorAboutLabel.Text = row["about"].ToString();
                        TutorFirstLanguageLabel.Text = row["firstlanguage"].ToString();
                        TutorSecondLanguageLabel.Text = row["secondlanguage"].ToString();
                        TutorExperienceLabel.Text = row["Experience"].ToString();

                        // Exit the loop since we found the matching row
                        break;
                    }
                    else
                    {
                        rowIndex++;
                    }
                }
            }
        }

        private void MessageTutor_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
