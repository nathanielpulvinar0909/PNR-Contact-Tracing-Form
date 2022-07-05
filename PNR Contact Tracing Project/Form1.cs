using System.IO;
using QRCoder;

namespace PNR_Contact_Tracing_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSubmitAllFiles_Click(object sender, EventArgs e)
        {
            {
                {
                    string vaccinated = ""; // for vaccinated radiobutton

                    if (rdbtnVaccinatedyes.Checked)
                    {
                        vaccinated = "Yes";
                    }
                    else if (rdbtnVaccinatedno.Checked)
                    {
                        vaccinated = "No";
                    }

                    string symptoms = ""; // for symmtoms radiobutton

                    if (rdbtnSymptomsyes.Checked)
                    {
                        symptoms = "Yes";

                    }
                    else if (rdbtnSymptomsno.Checked)
                    {
                        symptoms = "No";
                    }

                    string dose = ""; // for vaccination dose

                    if (rdbtnFirstdose.Checked)
                    {
                        dose = "First Dose";
                    }
                    else if (rdbtnSeconddose.Checked)
                    {
                        dose = "Second Dose";
                    }
                    else if (rdbtnBooster.Checked)
                    {
                        dose = "Booster";
                    }
                    else
                    {
                        dose = "Not yet vaccinated";
                    }

                    string contact = ""; // for personal contact

                    if (rdbtnPersonalcontactyes.Checked)
                    {
                        rdbtnPersonalcontactyes.Text = "Yes";
                        contact = rdbtnPersonalcontactyes.Text;
                    }
                    else if (rdbtnPersonalcontactyes.Checked)
                    {
                        rdbtnPersonalcontactno.Text = "Yes";
                        contact = rdbtnPersonalcontactno.Text;
                    }

                    string positive = ""; // for positive

                    if (rdbtnPositiveyes.Checked)
                    {
                        positive = rdbtnPositiveyes.Text;
                    }

                    else if (rdbtnPositiveno.Checked)
                    {
                        positive = rdbtnPositiveno.Text;

                    }

                    string eligibility = ""; // If all yes; cannot ride the train depends on the protocols

                    if ((symptoms == "Yes") && (contact == "Yes") && (positive == "Yes"))
                    {
                        eligibility = "Sorry. I'm afraid you cannot ride this train";
                    }
                    else
                    {
                        eligibility = "Yes. You are eligible to ride this train";
                    }

                    string current = "";

                    if (current == "") // features that when you click your current location, if reflects on the textbox
                    {
                        if (rdbtnCurrentBicutaan.Checked)
                        {
                            txtbxCurrentlocation.Text = "Bicutan";
                        }
                        else if (rdbtnCurrentFTI.Checked)
                        {
                            txtbxCurrentlocation.Text = "FTI";
                        }
                        else if (rdbtnCurrentNichols.Checked)
                        {
                            txtbxCurrentlocation.Text = "Nichols";
                        }
                        else if (rdbtnCurrentEdsa.Checked)
                        {
                            txtbxCurrentlocation.Text = "EDSA";
                        }
                        else if (rdbtnCurrentPasayRoad.Checked)
                        {
                            txtbxCurrentlocation.Text = "Pasay Road";
                        }
                        else if (rdbtnCurrentDelaRosa.Checked)
                        {
                            txtbxCurrentlocation.Text = "Dela Rosa";
                        }
                        else if (rdbtnCurrentVitoCruz.Checked)
                        {
                            txtbxCurrentlocation.Text = "Vito Cruz";
                        }
                        else if (rdbtnCurrentSanAndres.Checked)
                        {
                            txtbxCurrentlocation.Text = "San Andres";
                        }
                        else if (rdbtnCurrentPaco.Checked)
                        {
                            txtbxCurrentlocation.Text = "Paco";
                        }
                        else if (rdbtnCurrentPandacan.Checked)
                        {
                            txtbxCurrentlocation.Text = "Pandacan";
                        }
                        else if (rdbtnCurrentStaMesa.Checked)
                        {
                            txtbxCurrentlocation.Text = "Sta. Mesa";
                        }
                        else if (rdbtnCurrentEspana.Checked)
                        {
                            txtbxCurrentlocation.Text = "Espana";
                        }
                        else if (rdbtnCurrentLaonLaan.Checked)
                        {
                            txtbxCurrentlocation.Text = "Laon Laan";
                        }
                        else if (rdbtnCurrentBlumentrit.Checked)
                        {
                            txtbxCurrentlocation.Text = "Blumentrit";
                        }
                        else if (rdbtnCurrentTutuban.Checked)
                        {
                            txtbxCurrentlocation.Text = "Tutuban";
                        }
                    }

                    string desired = "";

                    if (desired == "") // features that when you click your desired destination, if reflects on the textbox
                    {
                        if (rdbtnDesiredBicutan.Checked)
                        {
                            txtbxDesiredDestination.Text = "Bicutan";
                        }
                        else if (rdbtnDesiredFTI.Checked)
                        {
                            txtbxDesiredDestination.Text = "FTI";
                        }
                        else if (rdbtnDesiredNichols.Checked)
                        {
                            txtbxDesiredDestination.Text = "Nichols";
                        }
                        else if (rdbtnDesiredEDSA.Checked)
                        {
                            txtbxDesiredDestination.Text = "EDSA";
                        }
                        else if (rdbtnDesiredPasayRoad.Checked)
                        {
                            txtbxDesiredDestination.Text = "Pasay Road";
                        }
                        else if (rdbtnDesiredDelaRosa.Checked)
                        {
                            txtbxDesiredDestination.Text = "Dela Rosa";
                        }
                        else if (rdbtnDesiredVitoCruz.Checked)
                        {
                            txtbxDesiredDestination.Text = "Vito Cruz";
                        }
                        else if (rdbtnDesiredSanAndres.Checked)
                        {
                            txtbxDesiredDestination.Text = "San Andres";
                        }
                        else if (rdbtnDesiredPaco.Checked)
                        {
                            txtbxDesiredDestination.Text = "Paco";
                        }
                        else if (rdbtnDesiredPandacan.Checked)
                        {
                            txtbxDesiredDestination.Text = "Pandacan";
                        }
                        else if (rdbtnDesiredStaMesa.Checked)
                        {
                            txtbxDesiredDestination.Text = "Sta. Mesa";
                        }
                        else if (rdbtnDesiredEspana.Checked)
                        {
                            txtbxDesiredDestination.Text = "Espana";
                        }
                        else if (rdbtnDesiredLaonLaan.Checked)
                        {
                            txtbxDesiredDestination.Text = "Laon Laan";
                        }
                        else if (rdbtnDesiredBlumentrit.Checked)
                        {
                            txtbxDesiredDestination.Text = "Blumentrit";
                        }
                        else if (rdbtnDesiredTutuban.Checked)
                        {
                            txtbxDesiredDestination.Text = "Tutuban";
                        }
                    }

                    StreamWriter file = new StreamWriter(@"C:\Users\ASUS DEMO\Downloads\PNR Contact Tracing Folder\" + datePicker.Text + ".txt", true); // appended na siya kaya mauulit

                    // They cant 

                    // Introduction

                    // Personal Introduction
                    file.WriteLine("Full Name: " + txtbxFirstname.Text + " " + txtbxLastName.Text);
                    file.WriteLine("Address: " + txtbxAddress.Text);
                    file.WriteLine("Age and Sex: " + txtbxAge.Text + " years old and a " + txtbxSex.Text);
                   
                    // Health Information about Covid
                    file.WriteLine("Elligible to travel: " + eligibility);

                    // Travel Information
                    file.WriteLine("Date: " + this.datePicker.Text);
                    file.WriteLine("Current Location: " + txtbxCurrentlocation.Text);
                    file.WriteLine("Desired Destination: " + txtbxDesiredDestination.Text);                    

                    file.Close();

                    MessageBox.Show("We are pleased to serve you, " + txtbxFirstname.Text + " " + txtbxLastName.Text + ", with genuine love and joy. Thank you for choosing PNR Station. Have a safe ride ahead.", "PNR Station");

                    // textboxes to ""
                    txtbxFirstname.Text = "";
                    txtbxLastName.Text = "";
                    txtbxAddress.Text = "";
                    txtbxAge.Text = "";
                    txtbxSex.Text = "";
                    txtbxMobilenumber.Text = "";
                    txtbxEmailaddress.Text = "";
                    txtbxCurrentlocation.Text = "";
                    txtbxDesiredDestination.Text = "";
                    txtbxDateandTime.Text = "";
                    txtbxTemperature.Text = "";

                    //radiobuttons to unchecked
                    rdbtnVaccinatedyes.Checked = false;
                    rdbtnVaccinatedno.Checked = false;
                    rdbtnFirstdose.Checked = false;
                    rdbtnSeconddose.Checked = false;
                    rdbtnBooster.Checked = false;
                    rdbtnSymptomsyes.Checked = false;
                    rdbtnSymptomsno.Checked = false;
                    rdbtnPersonalcontactyes.Checked = false;
                    rdbtnPersonalcontactno.Checked = false;
                    rdbtnPositiveyes.Checked = false;
                    rdbtnPositiveno.Checked = false;

                    // radiobuttons of locations, desired and current to unchecked
                    rdbtnCurrentBicutaan.Checked = false;
                    rdbtnCurrentBlumentrit.Checked = false;
                    rdbtnCurrentDelaRosa.Checked = false;
                    rdbtnCurrentEdsa.Checked = false;
                    rdbtnCurrentEspana.Checked = false;
                    rdbtnCurrentFTI.Checked = false;
                    rdbtnCurrentLaonLaan.Checked = false;
                    rdbtnCurrentNichols.Checked = false;
                    rdbtnCurrentPaco.Checked = false;
                    rdbtnCurrentPandacan.Checked = false;
                    rdbtnCurrentPasayRoad.Checked = false;
                    rdbtnCurrentSanAndres.Checked = false;
                    rdbtnCurrentStaMesa.Checked = false;
                    rdbtnCurrentTutuban.Checked = false;
                    rdbtnCurrentVitoCruz.Checked = false;

                    // radiobuttons of locations, desired and current to unchecked
                    rdbtnDesiredBicutan.Checked = false;
                    rdbtnDesiredBlumentrit.Checked = false;
                    rdbtnDesiredDelaRosa.Checked = false;
                    rdbtnDesiredEDSA.Checked = false;
                    rdbtnDesiredEspana.Checked = false;
                    rdbtnDesiredFTI.Checked = false;
                    rdbtnDesiredLaonLaan.Checked = false;
                    rdbtnDesiredNichols.Checked = false;
                    rdbtnDesiredPaco.Checked = false;
                    rdbtnDesiredPandacan.Checked = false;
                    rdbtnDesiredPasayRoad.Checked = false;
                    rdbtnDesiredSanAndres.Checked = false;
                    rdbtnDesiredStaMesa.Checked = false;
                    rdbtnDesiredTutuban.Checked = false;
                    rdbtnDesiredVitoCruz.Checked = false;
                    }
            }
        }

        private void btnGenerateQRCode_Click(object sender, EventArgs e)
        {
            QRCodeGenerator generateQRCode = new QRCodeGenerator();
            QRCodeData data = generateQRCode.CreateQrCode(txtbxQRInformation.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode generateCode = new QRCode(data);
            pctrbxQRCode.Image = generateCode.GetGraphic(5);
        }

        private void txtbxQRInformation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveQRInformation_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveQRInformation = new SaveFileDialog();
            saveQRInformation.ShowDialog();
            pctrbxQRCode.Image.Save(saveQRInformation.FileName);
            MessageBox.Show("The QR Code is saved in your files.");
        }


        private void btnExit_Click(object sender, EventArgs e) // To Exit the Application
        {
            MessageBox.Show("Thank you! Come again.");
            Application.Exit();
        }

        private void btnStreamReader_Click(object sender, EventArgs e) // For Sorting Dates and Reading it
        {
            StreamReader reader = new StreamReader(@"C:\Users\ASUS DEMO\Downloads\PNR Contact Tracing Folder\" + dateSort.Text + ".txt", true);
            String all = reader.ReadToEnd();
            MessageBox.Show(all, "Sorted by Date");
            

            this.dateSort.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredVitoCruz.Enabled = false;
            rdbtnDesiredVitoCruz.Checked = false;
            if (rdbtnCurrentVitoCruz.Checked == false)
            {
                rdbtnDesiredVitoCruz.Enabled = true;
            }
        }

        private void rdbtnCurrentFTI_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredFTI.Enabled = false;
            rdbtnDesiredFTI.Checked = false;
            if (rdbtnCurrentFTI.Checked == false)
            {
                rdbtnDesiredFTI.Enabled = true;
            }
        }

        private void rdbtnCurrentNichols_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredNichols.Enabled = false;
            rdbtnDesiredNichols.Checked = false;
            if (rdbtnCurrentNichols.Checked == false)
            {
                rdbtnDesiredNichols.Enabled = true;
            }
        }

        private void rdbtnCurrentEdsa_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredEDSA.Enabled = false;
            rdbtnDesiredEDSA.Checked = false;
            if (rdbtnCurrentEdsa.Checked == false)
            {
                rdbtnDesiredEDSA.Enabled = true;
            }
        }

        private void rdbtnCurrentPasayRoad_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredPasayRoad.Enabled = false;
            rdbtnDesiredPasayRoad.Checked = false;
            if (rdbtnCurrentPasayRoad.Checked == false)
            {
                rdbtnDesiredPasayRoad.Enabled = true;
            }
        }

        private void rdbtnCurrentDelaRosa_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredDelaRosa.Enabled = false;
            rdbtnDesiredDelaRosa.Checked = false;
            if (rdbtnCurrentDelaRosa.Checked == false)
            {
                rdbtnDesiredDelaRosa.Enabled = true;
            }
        }

        private void rdbtnCurrentStaMesa_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredStaMesa.Enabled = false;
            rdbtnDesiredStaMesa.Checked = false;
            if (rdbtnCurrentStaMesa.Checked == false)
            {
                rdbtnDesiredStaMesa.Enabled = true;
            }
        }

        private void rdbtnCurrentSanAndres_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredSanAndres.Enabled = false;
            rdbtnDesiredSanAndres.Checked = false;
            if (rdbtnCurrentSanAndres.Checked == false)
            {
                rdbtnDesiredSanAndres.Enabled = true;
            }
        }

        private void rdbtnCurrentPaco_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredPaco.Enabled = false;
            rdbtnDesiredPaco.Checked = false;
            if (rdbtnCurrentPaco.Checked == false)
            {
                rdbtnDesiredPaco.Enabled = true;
            }
        }

        private void rdbtnCurrentPandacan_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredPandacan.Enabled = false;
            rdbtnDesiredPandacan.Checked = false;
            if (rdbtnCurrentPandacan.Checked == false)
            {
                rdbtnDesiredPandacan.Enabled = true;
            }
        }

        private void rdbtnCurrentEspana_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredEspana.Enabled = false;
            rdbtnDesiredEspana.Checked = false;
            if (rdbtnCurrentEspana.Checked == false)
            {
                rdbtnDesiredEspana.Enabled = true;
            }
        }

        private void rdbtnCurrentLaonLaan_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredLaonLaan.Enabled = false;
            rdbtnDesiredLaonLaan.Checked = false;
            if (rdbtnCurrentLaonLaan.Checked == false)
            {
                rdbtnDesiredLaonLaan.Enabled = true;
            }
        }

        private void rdbtnCurrentBlumentrit_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredBlumentrit.Enabled = false;
            rdbtnDesiredBlumentrit.Checked = false;
            if (rdbtnCurrentBlumentrit.Checked == false)
            {
                rdbtnDesiredBlumentrit.Enabled = true;
            }
        }

        private void rdbtnCurrentTutuban_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnDesiredTutuban.Enabled = false;
            rdbtnDesiredTutuban.Checked = false;
            if (rdbtnCurrentTutuban.Checked == false)
            {
                rdbtnDesiredTutuban.Enabled = true;
            }
        }

        private void rdbtnVaccinatedyes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnVaccinatedno.Checked == true)
            {
                rdbtnVaccinatedyes.Enabled = true;
            }
        }

        private void rdbtnVaccinatedno_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnFirstdose.Enabled = false;
            rdbtnFirstdose.Checked = false;
            rdbtnSeconddose.Enabled = false;
            rdbtnSeconddose.Checked = false;
            rdbtnBooster.Enabled = false;
            rdbtnBooster.Checked = false;

            if (rdbtnVaccinatedno.Checked == false)
            {
                rdbtnVaccinatedyes.Enabled = true;
                rdbtnFirstdose.Enabled = true;
                rdbtnSeconddose.Enabled = true;
                rdbtnBooster.Enabled = true;
            }
        }

        private void rdbtnCurrentBicutaan_CheckedChanged(object sender, EventArgs e)
        {
            {
                rdbtnDesiredBicutan.Enabled = false;
                rdbtnDesiredBicutan.Checked = false;
                if (rdbtnCurrentBicutaan.Checked == false)
                {
                    rdbtnDesiredBicutan.Enabled = true;
                }
            }
        }

        private void rdbtnPersonalcontactyes_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnPersonalcontactyes.Text = "Yes";
        }

        private void rdbtnPersonalcontactno_CheckedChanged(object sender, EventArgs e)
        {
            rdbtnPersonalcontactno.Text = "No";
        }

        // I miscliked these and everytime I want to delete it, it results to error in the designer
        private void btnDateandtime_Click(object sender, EventArgs e) // For Time and Date
        {
          
        }

        private void lblPhilippineNationalRailways_Click(object sender, EventArgs e)
        {
            // Phillipine National Railways Label
        }

        private void btnDateandTime_Click_1(object sender, EventArgs e) // For date and time updated
        {
            
        }

        private void lblPNR_Click(object sender, EventArgs e)
        {

        }



        private void grpbxCurrentLocation_Enter(object sender, EventArgs e)
        {
            // 
        }

        private void rdbtnCurrentBicutan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbxDesiredDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxTemperature_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Form Load
        }

        private void lblHealthInformation_Click(object sender, EventArgs e)
        {
            // Health Information
        }

        private void txtbxDateSort_TextChanged(object sender, EventArgs e)
        {
            // For Sorting Data
        }



        private void txtbxFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxCurrentlocation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void outputs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {

        }

        private void rdbtnDesiredBicutan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void txtbxDateandTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e) // When you clicked Submit, Writing files in txt file using WriteLine 
        {

        }

        private void btnScanQRCode_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.ShowDialog();
        }
    }
}
