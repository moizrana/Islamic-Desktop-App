using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Text.RegularExpressions;
using kjhhb;

namespace kjhhb
{
    public partial class Signup : Form
    {
        string pattern = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
       /* string email_pattern = @"^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";*/
       string email_pattern = @"^[a-z0-9]+(?!.*(?:\+{2,}|\-{2,}|\.{2,}))(?:[\.+\-]{0,1}[a-z0-9])*@gmail\.com$";

        SqlConnection connect = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=LoginDetails;Integrated Security=True;TrustServerCertificate=True");

        public Signup()
        {
            InitializeComponent();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            if (signup_email.Text == "" || signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all Blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '" + signup_username.Text.Trim() + "'"; //Here, admin is the name of the table in our database

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email,username,passowrd,date_created) VALUES(@email,@username,@pass,@date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //To Switch Forms:
                                    Form1 lForm = new Form1();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (signup_showPass.Checked)
            {
                signup_password.PasswordChar = '\0';
                signup_confirmPassword.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
                signup_confirmPassword.PasswordChar = '*';
            }
        }

        private void signup_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_password_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(signup_password.Text, pattern) == false)
            {
                signup_password.Focus();
                errorProvider1.SetError(this.signup_password, "Password must contain at least 1 Uppercase letter, 1 Lowercase letter,1 Number and 1 Special Character");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signup_confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_confirmPassword_Leave(object sender, EventArgs e)
        {
            if (signup_password.Text != signup_confirmPassword.Text)
            {
                signup_confirmPassword.Focus();
                errorProvider2.SetError(this.signup_confirmPassword, "Password Mismatch");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void signup_username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(signup_username.Text) == true)
            {
                signup_username.Focus();
                errorProvider3.SetError(signup_username, "Please Enter Username");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void signup_email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(signup_email.Text, email_pattern) == false)
            {
                signup_email.Focus();
                errorProvider4.SetError(signup_email, "Please enter email in valid format (Example@gmail.com)");
            }
            else
            {
                errorProvider4.Clear();
            }

        }
    }   
}
