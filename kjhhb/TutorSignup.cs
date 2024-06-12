using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace kjhhb
{
    public partial class TutorSignup : Form
    {
        public static TutorSignup instance;
        public TextBox username_tb;
        public TextBox email_tb;
        public ComboBox gender_cmb;
        public TextBox password_tb;
        public TextBox country_tb;
        public TextBox sect_tb;
        public TextBox phonenumber_tb;
        public TextBox age_tb;
        public TextBox about_tb;
        public TextBox hourlyrate_tb;
        public TextBox firstlanguage_tb;
        public TextBox secondlanguage_tb;
        public TextBox experience_tb;
        public CheckBox recitation_ch;
        public CheckBox hifz_ch;
        public CheckBox arabic_ch;
        public CheckBox tajweed_ch;
        public PictureBox profilepic_picbox;

        SqlConnection con = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=tutorloginmd;Integrated Security=True;TrustServerCertificate=True");
        public TutorSignup()
        {
            InitializeComponent();
            instance = this;
            username_tb = txtusername;
            email_tb = txtemail;
            gender_cmb = cmbGender;
            password_tb = txtpassword;
            country_tb = txtcountry;
            sect_tb = txtsect;
            phonenumber_tb = txtphonenumber;
            age_tb = txtage;
            about_tb = txtabout;
            hourlyrate_tb = txthourlyrate;
            firstlanguage_tb = txtfirstlanguage;
            secondlanguage_tb = txtsecondlanguage;
            experience_tb = txtexperience_tb;
            recitation_ch = checkRecitation;
            hifz_ch = checkHifz;
            arabic_ch = checkArabic;
            tajweed_ch = checkTajweed;
            profilepic_picbox = profilepicupload;

        }

        private void profilepicupload_btn_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                /* dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*|";*/


                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    /*                    imageLocation = dialog.FileName;
                                        profilepicupload.ImageLocation = imageLocation;*/
                    profilepicupload.Image = new Bitmap(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadform(MainForm mainForm, object Form)
        {
            if (MainForm.instance.callmainpanel.Controls.Count > 0)
                MainForm.instance.callmainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            MainForm.instance.callmainpanel.Controls.Add(f);
            MainForm.instance.callmainpanel.Tag = f;
            f.Show();
        }

        private void TutorSignup_btn_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TutorLoginData]
                                                       ([name]
                                                       ,[email]
                                                       ,[password]
                                                       ,[country]
                                                       ,[sect]
                                                       ,[age]
                                                       ,[gender]
                                                       ,[phonenumber]
                                                       ,[about]
                                                       ,[hourlyrate]
                                                       ,[firstlanguage]
                                                       ,[secondlanguage]
                                                       ,[Experience]
                                                       ,[Recitation]
                                                       ,[Hifz]
                                                       ,[Arabic]
                                                       ,[Tajweed]
                                                       ,[Picture])
                                                VALUES
                                                        (@name,@email,@password,@country,@sect,@age,@gender,@phonenumber,@about,@hourlyrate,@firstlanguage,@secondlanguage,@Experience,@Recitation,@Hifz,@Arabic,@Tajweed,@Picture)");

            cmd.Parameters.AddWithValue("@name", txtusername.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@country", txtcountry.Text);
            cmd.Parameters.AddWithValue("@sect", txtsect.Text);
            cmd.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);
            cmd.Parameters.AddWithValue("@about", txtabout.Text);
            cmd.Parameters.AddWithValue("@hourlyrate", txthourlyrate.Text);
            cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@firstlanguage", txtfirstlanguage.Text);
            cmd.Parameters.AddWithValue("@secondlanguage", txtsecondlanguage.Text);
            cmd.Parameters.AddWithValue("@Experience", txtexperience_tb.Text);
            cmd.Parameters.AddWithValue("@age", txtage.Text);
            cmd.Parameters.AddWithValue("@Hifz", checkHifz.Checked);
            cmd.Parameters.AddWithValue("@Arabic", checkArabic.Checked);
            cmd.Parameters.AddWithValue("@Tajweed", checkTajweed.Checked);
            cmd.Parameters.AddWithValue("@Recitation", checkRecitation.Checked);
            cmd.Parameters.AddWithValue("@Picture", getPicture());
            cmd.Connection = con;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Signed Up Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //TutorProfile tpForm = new TutorProfile();

            Home hForm = new Home();
         //   MainForm.instance.callablepanel.Height = hForm.Height;
          //  MainForm.instance.callablepanel.Top = hForm.Top;
            loadform(MainForm.instance, hForm);

        }

        private byte[] getPicture()
        {
            MemoryStream stream = new MemoryStream();
            profilepicupload.Image.Save(stream, profilepicupload.Image.RawFormat);


            return stream.GetBuffer();
        }

        private void profilepicupload_Click(object sender, EventArgs e)
        {

        }

        private void TutorSignup_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
