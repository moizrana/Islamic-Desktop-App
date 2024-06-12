using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTvideo
{
    public partial class Lecture : Form
    {
        public Lecture()
        {
            InitializeComponent();
            // Initially hide the WebBrowser control
            webBrowser1.Visible = false;
            button2.Visible = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // YouTube video ID
            string videoId = "xjGJ5wYs8AQ"; // Extracted from the YouTube video URL

            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stop the video playback by executing JavaScript code
            webBrowser1.Document.InvokeScript("stopVideo");
            webBrowser1.Visible = false;
            button2.Visible = false;
        }

        private void Lecture_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string videoId = "Q8GOVAK40iw";
            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string videoId = "1fIBoImJECU";
            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string videoId = "c-N-i-y8Jws";
            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string videoId = "EDHUhwAdiTs";
            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string videoId = "1IBlR1eATKs";
            // Construct the HTML code to embed the YouTube video using an <iframe> tag
            string html = "<html> <head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += $"<iframe id='video' src='https://www.youtube.com/embed/{videoId}' width='590' height='330' frameborder='0' allowfullscreen></iframe>";
            html += "<script>";
            html += "function stopVideo() {";
            html += "var iframe = document.getElementById('video');";
            html += "var src = iframe.src;";
            html += "iframe.src = src;";
            html += "}";
            html += "</script>";
            html += "</head></html>";

            // Set the HTML content to the WebBrowser control
            webBrowser1.DocumentText = html;

            webBrowser1.Visible = true;
            webBrowser1.BringToFront();
            // Show the close button
            button2.Visible = true;
        }
    }
}
