using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace kjhhb
{
    public partial class Hadith1 : Form
    {
        public Hadith1()
        {
            InitializeComponent();
            Back.Visible = false;
            pdfViewer1.Visible = false;
        }

        private void pdfViewer1_Load(object sender, EventArgs e)
        {

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

            // Remove the PDF viewer control from its current parent container
            if (Back.Parent != null)
            {
                Back.Parent.Controls.Remove(Back);
            }

            // Add the PDF viewer control to the form's controls collection
            this.Controls.Add(Back);

            // Show the PDF viewer control
            pdfViewer1.Visible = true;
            pdfViewer1.BringToFront();
            // Hide or move other controls that should not be displayed with the PDF viewer
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
            flowLayoutPanel1.Visible = false;

            Back.Dock = DockStyle.None;
            Back.Visible = true;
            Back.BringToFront();

            // Ensure the PDF viewer control is not docked
            pdfViewer1.Dock = DockStyle.None;

            // Calculate the location and size of the PDF viewer control
            int x = 0; // X-coordinate of the PDF viewer (aligned with the left edge of the form)
            int y = 0; // Y-coordinate of the PDF viewer (aligned with the top edge of the form)
            int width = this.ClientSize.Width; // Width of the PDF viewer (same as the form)
            int height = this.ClientSize.Height; // Height of the PDF viewer (same as the form)

            // Set the size and location of the PDF viewer control
            pdfViewer1.Location = new Point(x, y);
            pdfViewer1.Size = new Size(width, height);

            // Bring the PDF viewer control to the front
            pdfViewer1.LoadDocument(filePath);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Hadith\\Importance of salah.pdf");
        }


        private void Back_Click_1(object sender, EventArgs e)
        {
            // Hide the PDF viewer control
            pdfViewer1.Visible = false;
            Back.Visible = false;
            // Show the other controls that were hidden
            panel1.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            panel6.Visible = true;
            flowLayoutPanel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Hadith\\The Significance of Hajj in Islam.pdf");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Hadith\\Siyam.pdf");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowPDFViewer("Q:\\Downloads\\Hadith\\Zakat.pdf");
        }
    }
}
