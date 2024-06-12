using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace kjhhb
{
    public partial class Tajweed : Form
    {
        public Tajweed()
        {
            InitializeComponent();
        }

        private void Tajweed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            // Change cursor to hand cursor when mouse enters the button
            Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Change cursor back to default when mouse leaves the button
            Cursor = Cursors.Default;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // URL of the website to open
            string websiteUrl = "https://www.getquranic.com/a-quick-guide-to-tajweed/#Idhaar_to_make_clear"; // Replace with your website URL

            // Open the website in the default web browser
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = websiteUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while opening the website: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.getquranic.com/a-quick-guide-to-tajweed/#Idghaam_to_merge";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.getquranic.com/a-quick-guide-to-tajweed/#Iqlaab_to_convert";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.getquranic.com/a-quick-guide-to-tajweed/#Ikhfaa_to_hide";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.getquranic.com/a-quick-guide-to-tajweed/#Qalqalah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://riwaqalquran.com/blog/types-of-madd/#:~:text=Al%2DMadd%20in%20Tajweed%20comes,Madd%20must%20not%20be%20hamza.";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://attajweed4beginners.wordpress.com/the-rules-of-noon-as-sakinah-and-tanween/4-al-ikhfaa-%D8%A7%D9%84%D8%A5%D9%90%D8%AE%D9%92%D9%81%D9%8E%D8%A7%D8%A1/";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }
    }
}
