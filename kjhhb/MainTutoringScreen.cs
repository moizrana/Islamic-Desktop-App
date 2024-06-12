using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kjhhb
{
    public partial class MainTutoringScreen : Form
    {
        public static MainTutoringScreen instance;


        public MainTutoringScreen()
        {
            InitializeComponent();
            instance = this;
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void TutorSignup_btn_Click(object sender, EventArgs e)
        {

            TutorSignup tForm = new TutorSignup();
          //  MainForm.instance. callablepanel.Height = tForm.Height;
          //  MainForm.instance.callablepanel.Top = tForm.Top;
            loadform(tForm);
            TutorSignup_btn.Hide();
            studentLogin_btn.Hide();
            TutorLogin_btn.Hide();
            Or_Label.Hide();
           // TutoringScreenIcon.Hide();
            TutorSignup_btn.Hide();
        }

        private void TutorSignup_btn_Leave(object sender, EventArgs e)
        {

        }

        private void studentLogin_btn_Click(object sender, EventArgs e)
        {
            TutorCh tcForm = new TutorCh();
           // MainForm.instance.callablepanel.Height = tcForm.Height;
           // MainForm.instance. callablepanel.Top = tcForm.Top;
            loadform(tcForm);
            studentLogin_btn.Hide();
            TutorLogin_btn.Hide();
            Or_Label.Hide();
          //  TutoringScreenIcon.Hide();
            TutorSignup_btn.Hide();
        }

        private void TutorLogin_btn_Click(object sender, EventArgs e)
        {
            Form1 fForm = new Form1();
            fForm.Show();
            //Form1.instance.Hide();
            this.Hide();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
