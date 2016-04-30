using System;
using System.Windows.Forms;

namespace GAS_Calculator
{
    public partial class frmMain : Form
    {

        public static string language = "English";
        public static string measurementSystem = "";
        public static bool firstStart = true;
        frmSettings settings = new frmSettings();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudPetrolPrice.Value < nudGASPrice.Value)
                {
                    tbSavings.Text = LanguagePack.errorEN;
                    tbPetrolPerOne.Text = "";
                    tbGASPerOne.Text = "";
                    return;
                }

                Math.PetrolPrice = nudPetrolPrice.Value;
                Math.GASPrice = nudGASPrice.Value;
                Math.PetrolRate = nudPetrolRate.Value;
                Math.GASRate = nudGASRate.Value;
                Math.PriceForParts = nudPriceForParts.Value;

                tbPetrolPerOne.Text = Convert.ToDouble(Math.PricePerOne(nudPetrolPrice.Value, nudPetrolRate.Value)).ToString("N2");
                tbGASPerOne.Text = Math.PricePerOne(nudGASPrice.Value, nudGASRate.Value).ToString("N2");

                tbPetrolPerDistance.Text = (Math.PricePerOne(nudPetrolPrice.Value, nudPetrolRate.Value) * nudDistance.Value).ToString("N2");
                tbGASPerDistance.Text = (Math.PricePerOne(nudGASPrice.Value, nudGASRate.Value) * nudDistance.Value).ToString("N2");
                tbSavings.Text = (Convert.ToDecimal(tbPetrolPerDistance.Text) - Convert.ToDecimal(tbGASPerDistance.Text)).ToString("N2");

                Math.SavingsPerOne();
                Math.DistanceForZeroPrice();

                tbDistanceForZero.Text = Math.Result.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nudPetrolRate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                nudGASRate.Value = nudPetrolRate.Value + 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nudDistance_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbPetrolPerDistance.Text = (Math.PricePerOne(nudPetrolPrice.Value, nudPetrolRate.Value) * nudDistance.Value).ToString();
                tbGASPerDistance.Text = (Math.PricePerOne(nudGASPrice.Value, nudGASRate.Value) * nudDistance.Value).ToString();
                tbSavings.Text = (Convert.ToDecimal(tbPetrolPerDistance.Text) - Convert.ToDecimal(tbGASPerDistance.Text)).ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LanguageSelector()
        {
            try
            {
                if (language == "English")
                {
                    lblPetrol.Text = LanguagePack.petrolEN;
                    lblGAS.Text = LanguagePack.gasEN;

                    gbPrice.Text = LanguagePack.priceForOneFuelEN;
                    gbPetrolRate.Text = LanguagePack.rateForHundretDistanceEN;
                    gbDistanceRate.Text = LanguagePack.priceForOneDistanceEN;
                    gbPriceCalculator.Text = LanguagePack.priceForDistanceEN;
                    lblCost.Text = LanguagePack.costEN;
                    lblDistance.Text = LanguagePack.distanceEN;
                    lblSaving.Text = LanguagePack.savingEN;
                    gbDistanceForZero.Text = LanguagePack.paybackEN;
                    lblEquipmentCost.Text = LanguagePack.equipmentCostEN;
                    lblEquipmentRePaid.Text = LanguagePack.equipmentRepaidEN;
                    lblDistance2.Text = LanguagePack.distanceEN;
                    toolTip.SetToolTip(pbTip, LanguagePack.tipEN);

                    btnCalculate.Text = LanguagePack.calculateEN;
                    btnSettings.Text = LanguagePack.settingsEN;

                    settings.lblLanguage.Text = LanguagePack.languageEN;
                    settings.lblMeasurementSystem.Text = LanguagePack.measuringSystemEN;
                    settings.btnCancel.Text = LanguagePack.cancelEN;
                    settings.cbMeasurementSystem.Text = LanguagePack.underDevelopmentEN;

                    settings.Text = LanguagePack.settingsEN;
                }

                if (language == "Українська")
                {
                    lblPetrol.Text = LanguagePack.petrolUA;
                    lblGAS.Text = LanguagePack.gasUA;

                    gbPrice.Text = LanguagePack.priceForOneFuelUA;
                    gbPetrolRate.Text = LanguagePack.rateForHundretDistanceUA;
                    gbDistanceRate.Text = LanguagePack.priceForOneDistanceUA;
                    gbPriceCalculator.Text = LanguagePack.priceForDistanceUA;
                    lblCost.Text = LanguagePack.costUA;
                    lblDistance.Text = LanguagePack.distanceUA;
                    lblSaving.Text = LanguagePack.savingUA;
                    gbDistanceForZero.Text = LanguagePack.paybackUA;
                    lblEquipmentCost.Text = LanguagePack.equipmentCostUA;
                    lblEquipmentRePaid.Text = LanguagePack.equipmentRepaidUA;
                    lblDistance2.Text = LanguagePack.distanceUA;
                    toolTip.SetToolTip(pbTip, LanguagePack.tipUA);

                    btnCalculate.Text = LanguagePack.calculateUA;
                    btnSettings.Text = LanguagePack.settingsUA;

                    settings.lblLanguage.Text = LanguagePack.languageUA;
                    settings.lblMeasurementSystem.Text = LanguagePack.measuringSystemUA;
                    settings.btnCancel.Text = LanguagePack.cancelUA;
                    settings.cbMeasurementSystem.Text = LanguagePack.underDevelopmentUA;

                    settings.Text = LanguagePack.settingsUA;
                }

                if (language == "Русский")
                {
                    lblPetrol.Text = LanguagePack.petrolRU;
                    lblGAS.Text = LanguagePack.gasRU;

                    gbPrice.Text = LanguagePack.priceForOneFuelRU;
                    gbPetrolRate.Text = LanguagePack.rateForOneRU;
                    gbDistanceRate.Text = LanguagePack.priceForOneDistanceRU;
                    gbPriceCalculator.Text = LanguagePack.priceForDistanceRU;
                    lblCost.Text = LanguagePack.costRU;
                    lblDistance.Text = LanguagePack.distanceRU;
                    lblSaving.Text = LanguagePack.savingRU;
                    gbDistanceForZero.Text = LanguagePack.paybackRU;
                    lblEquipmentCost.Text = LanguagePack.equipmentCostRU;
                    lblEquipmentRePaid.Text = LanguagePack.equipmentRepaidRU;
                    lblDistance2.Text = LanguagePack.distanceRU;
                    toolTip.SetToolTip(pbTip, LanguagePack.tipRU);

                    btnCalculate.Text = LanguagePack.calculateRU;
                    btnSettings.Text = LanguagePack.settingsRU;

                    settings.lblLanguage.Text = LanguagePack.languageRU;
                    settings.lblMeasurementSystem.Text = LanguagePack.measuringSystemRU;
                    settings.btnCancel.Text = LanguagePack.cancelRU;
                    settings.cbMeasurementSystem.Text = LanguagePack.underDevelopmentRU;

                    settings.Text = LanguagePack.settingsRU;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                CallSettings();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            try
            {
                LanguageSelector();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void CallSettings()
        {
            try
            {
                this.BackColor = System.Drawing.SystemColors.InactiveCaption;
                settings.ShowDialog(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            frmWelcome welcome = new frmWelcome();
            try
            {
                frmSettings.ReadSettings();

                if (firstStart)
                {
                    welcome.ShowDialog();
                    firstStart = false;
                    frmSettings.WriteSettings();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
