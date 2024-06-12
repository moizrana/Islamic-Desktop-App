using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using AxWMPLib;

namespace kjhhb
{
    public partial class Quran : Form
    {
        private string selectedQari = "Abdul Rahman";
        public Quran()
        {
            InitializeComponent();
            pdfViewer1.Visible = false;
            iconButton2.Visible = false;
        }

        bool expand = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                flowLayoutPanel1.Height += 15;
                if (flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 15;
                if (flowLayoutPanel1.Height <= flowLayoutPanel1.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void rahman_Click(object sender, EventArgs e)
        {
            selectedQari = rahman.Text;
        }

        private void mishary_Click(object sender, EventArgs e)
        {
            selectedQari = mishary.Text;
        }

        private void maher_Click(object sender, EventArgs e)
        {
            selectedQari = maher.Text;
        }


        private void SurahFatiha_Click_1(object sender, EventArgs e)
        {
            string selectedSurah = SurahFatiha.Name;
            string audioFilePath = $"Q:\\Downloads\\Audios\\{selectedQari}\\{selectedSurah}.mp3"; // Adjust
            axWindowsMediaPlayer1.URL = audioFilePath;
        }

        private void SurahZuha_Click(object sender, EventArgs e)
        {
            string selectedSurah = SurahZuha.Name;
            string audioFilePath = $"Q:\\Downloads\\Audios\\{selectedQari}\\{selectedSurah}.mp3"; // Adjust
            axWindowsMediaPlayer1.URL = audioFilePath;
        }

        private void SurahIkhlas_Click(object sender, EventArgs e)
        {
            string selectedSurah = SurahIkhlas.Name;
            string audioFilePath = $"Q:\\Downloads\\Audios\\{selectedQari}\\{selectedSurah}.mp3"; // Adjust
            axWindowsMediaPlayer1.URL = audioFilePath;
        }

        private void SurahKothar_Click(object sender, EventArgs e)
        {
            string selectedSurah = SurahKothar.Name;
            string audioFilePath = $"Q:\\Downloads\\Audios\\{selectedQari}\\{selectedSurah}.mp3"; // Adjust
            axWindowsMediaPlayer1.URL = audioFilePath;
        }

        private void SurahAsr_Click(object sender, EventArgs e)
        {
            string selectedSurah = SurahAsr.Name;
            string audioFilePath = $"Q:\\Downloads\\Audios\\{selectedQari}\\{selectedSurah}.mp3"; // Adjust
            axWindowsMediaPlayer1.URL = audioFilePath;
        }

        private void ShowPDFViewer(string filePath)
        {
            // Remove the PDF viewer control from its current parent container
            if (pdfViewer1.Parent != null)
            {
                pdfViewer1.Parent.Controls.Remove(pdfViewer1);
            }

            // Add the PDF viewer control to the form's controls collection
            this.Controls.Add(pdfViewer1);
            // Show the PDF viewer control
            pdfViewer1.Visible = true;
            pdfViewer1.BringToFront();

            // Remove the PDF viewer control from its current parent container
            if (iconButton2.Parent != null)
            {
                iconButton2.Parent.Controls.Remove(iconButton2);
            }

            // Add the PDF viewer control to the form's controls collection
            this.Controls.Add(iconButton2);

            panel2.Visible = false;
            panel1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;

            iconButton2.Dock = DockStyle.None;
            iconButton2.Visible = true;
            iconButton2.BringToFront();

            // Calculate the location and size of the PDF viewer control
            int x = 0; // X-coordinate of the PDF viewer (aligned with the left edge of the form)
            int y = 0; // Y-coordinate of the PDF viewer (aligned with the top edge of the form)
            int width = this.ClientSize.Width; // Width of the PDF viewer (same as the form)
            int height = this.ClientSize.Height; // Height of the PDF viewer (same as the form)

            // Set the size and location of the PDF viewer control
            pdfViewer1.Location = new Point(x, y);
            pdfViewer1.Size = new Size(width, height);

            // Load the PDF document
            pdfViewer1.LoadDocument(filePath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Surahs\\Al Fatiha.pdf");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Load the PDF document
            ShowPDFViewer("Q:\\Downloads\\Surahs\\al-mulk.pdf"); // Replace with the actual path to your PDF file
        }


        private void pdfViewer1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Hide the PDF viewer control
            pdfViewer1.Visible = false;
            iconButton2.Visible = false;

            panel2.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            panel1.Visible = true ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Surahs\\Al-duha.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Surahs\\al-asr.pdf");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Surahs\\al-kawthar.pdf");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Surahs\\al-ikhlas.pdf");
        }

        private void pdfViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
