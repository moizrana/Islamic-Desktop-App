using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace kjhhb
{
    public partial class Translation : Form
    {
        public Translation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://quran.com/en/al-fatihah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://hamariweb.com/islam/Surah-Fatiha-with-Urdu-Translation-oqa1.aspx";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label3_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://surahquran.com/Surah-translation/meanings-language-4-surah-1.html";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-al-faatiha/?translation=french-muhammad-hamidullah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://quran.com/en/ad-duhaa";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://hamariweb.com/islam/Surah-Duha-with-Urdu-Translation-oqa93.aspx";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://cdn69.urdupoint.com/islam/quran-pdf/spanish/Surah-Duha-in-Spanish.pdf";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-ad-dhuhaa/?translation=french-muhammad-hamidullah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label17_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://quran.com/en/ya-sin";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label16_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.urdupoint.com/islam/verses/36/surah-yaseen.html";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label13_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-yaseen/?translation=spanish-muhammad-isa-garcia";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label12_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-yaseen/?translation=french-muhammad-hamidullah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label23_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://quran.com/en/al-mulk";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label22_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://hamariweb.com/islam/Surah-Mulk-with-Urdu-Translation-oqa67.aspx";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label21_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-al-mulk/?translation=spanish-muhammad-isa-garcia";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }

        private void label20_Click(object sender, EventArgs e)
        {
            string websiteUrl = "https://www.islamicfinder.org/quran/surah-al-mulk/?translation=french-muhammad-hamidullah";
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = websiteUrl,
                UseShellExecute = true
            });
        }
    }
}
