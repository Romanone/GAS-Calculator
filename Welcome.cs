using System;
using System.Windows.Forms;

namespace GAS_Calculator
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void cbWelcomeLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWelcomeLanguage.Text == "English")
            {
                lblWelcomeLanguage.Text = LanguagePack.languageEN;
                rtbWelcome.Text = LanguagePack.aboutEN;
            }

            else if (cbWelcomeLanguage.Text == "Українська")
            {
                lblWelcomeLanguage.Text = LanguagePack.languageUA;
                rtbWelcome.Text = LanguagePack.aboutUA;
            }


            else if (cbWelcomeLanguage.Text == "Русский")
            {
                lblWelcomeLanguage.Text = LanguagePack.languageRU;
                rtbWelcome.Text = LanguagePack.aboutRU;
            }

        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            cbWelcomeLanguage.SelectedIndex = 0;
        }

        private void btnWelcomeOK_Click(object sender, EventArgs e)
        {
            frmMain.language = cbWelcomeLanguage.Text;
            this.Close();
        }
    }
}
