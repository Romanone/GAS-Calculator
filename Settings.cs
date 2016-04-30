using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace GAS_Calculator
{
    public partial class frmSettings : Form
    {

        static string regKeyName = "Software\\EasyBreezySoftware\\" + LanguagePack.applicationName;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.language = cbLanguageSelector.Text;
                WriteSettings();
                CloseAction();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CloseAction()
        {
            try
            {
                if (this.Owner != null)
                {
                    frmMain main = (frmMain)this.Owner;
                    main.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    main.Activate();
                }
                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                CloseAction();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                cbLanguageSelector.Text = frmMain.language;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAction();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void WriteSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null) return;
                rk.SetValue("Language", frmMain.language);
                rk.SetValue("MeasurementSystem", frmMain.measurementSystem);
                rk.SetValue("FirstStart", frmMain.firstStart);
            }

            finally
            {
                if (rk != null) rk.Close();
            }
        }
        static public void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (rk != null)
                {
                    frmMain.language = (string)rk.GetValue("Language");
                    frmMain.measurementSystem = (string)rk.GetValue("MeasurementSystem");
                    frmMain.firstStart = Convert.ToBoolean(rk.GetValue("FirstStart", true));
                }
            }

            finally
            {
                if (rk != null) rk.Close();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            if (frmMain.language == "English")
                about.rtbAbout.Text = LanguagePack.aboutEN;
            else if(frmMain.language == "Українська")
                about.rtbAbout.Text = LanguagePack.aboutUA;
            else if (frmMain.language == "Русский")
                about.rtbAbout.Text = LanguagePack.aboutRU;
            about.Show();
        }
    }
}
