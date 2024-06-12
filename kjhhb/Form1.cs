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
using kjhhb;
using System.Drawing.Text;

namespace kjhhb
{
    public partial class Form1 : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=LoginDetails;Integrated Security=True;TrustServerCertificate=True");
        SqlConnection connect2 = new SqlConnection(@"Data Source=desktop-84n9sh8\sqlexpress;Initial Catalog=tutorloginmd;Integrated Security=True;TrustServerCertificate=True");
        public static Form1 instance;
        public TextBox tb1;
        public bool Check_if_foundInTutor;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = login_username;
            Check_if_foundInTutor = false;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (login_showPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            bool foundInStudent = false;
            bool foundInTutor = false;
            bool isempty = false;
            bool extremeCase = false;
            if (login_username.Text == "" || login_password.Text == "")
            {
                isempty = true;
                MessageBox.Show("Please fill all Blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND passowrd = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                foundInStudent = true;
                              
                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                //MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                foundInStudent = false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting to Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

                if ((foundInStudent == false) && (isempty == false))
                {
                    if (connect2.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect2.Open();

                            String selectData = "SELECT * FROM TutorLoginData WHERE name = @username AND password = @pass";
                            using (SqlCommand cmd2 = new SqlCommand(selectData, connect2))
                            {
                                cmd2.Parameters.AddWithValue("@username", login_username.Text);
                                cmd2.Parameters.AddWithValue("@pass", login_password.Text);
                                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                                DataTable table2 = new DataTable();
                                adapter2.Fill(table2);

                                if (table2.Rows.Count >= 1)
                                {
                                    MessageBox.Show("Logged In Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    foundInTutor = true;
                                    Check_if_foundInTutor = true;
                                    MainForm mForm = new MainForm();
                                    mForm.Show();
                                    this.Hide();

                                }
                                else
                                {
                                    MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Connecting to Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect2.Close();
                        }
                    }


                }
                else if((foundInStudent == false) && (isempty == false) && (foundInTutor == false))
                {
                    MessageBox.Show("User Not Found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    extremeCase = true;
                }

            }

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
