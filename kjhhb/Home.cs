using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjhhb
{
    public partial class Home : Form
    {
        private List<string> islamicQuotes = new List<string>
        {
            "The best of you are those who learn the Quran and teach it. - Prophet Muhammad (peace be upon him)",
            "Do not despair of the mercy of Allah. – Quran",
            "Speak the truth even when it is bitter. - Prophet Muhammad (peace be upon him)",
            "    Indeed, Allah is with the patient. – Quran",
            "Allah is the Light of the heavens and the earth. – Quran",
            "  Verily, with hardship, there is relief. – Quran"
            // Add more Islamic quotes here
        };
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Get current Islamic date
            DateTime today = DateTime.Now;
            HijriCalendar hijriCalendar = new HijriCalendar();
            string islamicDate = GetIslamicDate(today, hijriCalendar);

            // Display Islamic date in the label
            label1.Text = islamicDate;

            // Get a random Islamic quote
            string randomQuote = GetRandomIslamicQuote();

            // Format the quote text to fit within the label
            string[] formattedQuoteLines = FormatQuoteText(randomQuote);

            // Display the quote in the label
            label2.Text = formattedQuoteLines[0];
            if (formattedQuoteLines.Length > 1)
            {
                label2.Text += "\n" + formattedQuoteLines[1];
            }


            // Get current date and time
            DateTime currentDate = DateTime.Now;

            // Display current date in the label
            label3.Text = currentDate.ToShortDateString();
        }

        private string GetIslamicDate(DateTime date, HijriCalendar hijriCalendar)
        {
            int year = hijriCalendar.GetYear(date);
            int month = hijriCalendar.GetMonth(date);
            int day = hijriCalendar.GetDayOfMonth(date);

            return $"{day} {GetHijriMonthName(month)} {year} AH";
        }

        private string GetHijriMonthName(int month)
        {
            // Get the name of the Hijri month based on the month number
            // You can customize the month names as per your preference
            switch (month)
            {
                case 1: return "Muharram";
                case 2: return "Safar";
                case 3: return "Rabi' al-Awwal";
                case 4: return "Rabi' al-Sani";
                case 5: return "Jammadi' al-Awwal";
                case 6: return "jammadi' al-Sani";
                case 7: return "Rajab";
                case 8: return "Shaban";
                case 9: return "Ramadan";
                case 10: return "Shawal";
                case 11: return "ZilQad";
                case 12: return "ZilHajj";
                // Add more cases for other months
                default: return "Unknown";
            }
        }

        private string GetRandomIslamicQuote()
        {
            // Generate a random index to select a quote from the list
            Random random = new Random();
            int index = random.Next(islamicQuotes.Count);

            return islamicQuotes[index];
        }

        private string[] FormatQuoteText(string quote)
        {
            const int MaxWidth = 1130; // Maximum width in pixels before wrapping

            // Calculate the number of characters that fit in one line
            int charsPerLine = MaxWidth / (int)label2.Font.GetHeight();

            // Check if the quote fits within one line
            if (quote.Length <= charsPerLine)
            {
                return new string[] { quote }; // Return the quote as a single line
            }
            else
            {
                // Split the quote into two parts based on the available width
                string line1 = quote.Substring(0, charsPerLine);
                string line2 = quote.Substring(charsPerLine);

                return new string[] { line1.Trim(), line2.Trim() }; // Return two lines
            }
        }

    }
}
