namespace PNR_Contact_Tracing_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form Load
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Form Load
        }

        private void lblHealthInformation_Click(object sender, EventArgs e)
        {
            // Health Information
        }

        private void label25_Click(object sender, EventArgs e)
        {
            // label renamed as lblSanAndres
        }

        private void lblCurrentEspana_Click(object sender, EventArgs e)
        {
            // label for Espana
        }

        private void btnSubmit_Click(object sender, EventArgs e) // When you clicked Submit 
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
                contact = "Yes";
            }
            else if (rdbtnPersonalcontactyes.Checked)
            {
                contact = "No";
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

            int temp = int.Parse(txtbxTemperature.Text); // If temperature is greater than 37 Degrees, cannot ride the train

            if (temp > 37)
            {
                MessageBox.Show("Sorry, due to your temperature greater than 37 Degrees, our management assumes that you have a fever. For the staffs and our beloved passengers safety, we cannot let you ride this train. Consider isolating yourself. Thank you!", "Notice", MessageBoxButtons.OK);
                Application.Exit();
            }




            StreamWriter file = new StreamWriter(@"C:\Users\ASUS DEMO\Downloads\PNR Contact Tracing Folder\Contact Tracing.txt");

            // Introduction
            file.WriteLine("You, " + txtbxFirstname.Text + " " + txtbxLastName.Text + "," + " answered this Contact tracing form on " + txtbxDateandTime.Text);
            file.WriteLine("");


            // Personal Introduction
            file.WriteLine("Personal Information");
            file.WriteLine("Full Name of the Respondent: " + txtbxFirstname.Text + " " + txtbxLastName.Text);
            file.WriteLine("Address: " + txtbxAddress.Text);
            file.WriteLine("Age: " + txtbxAge.Text + " years old");
            file.WriteLine("Sex: " + txtbxSex.Text);
            file.WriteLine("Mobile Number: " + txtbxMobilenumber.Text);
            file.WriteLine("Email Address: " + txtbxEmailaddress.Text);

            // Health Information about Covid
            file.WriteLine("");
            file.WriteLine("Health Information about Covid");
            file.WriteLine("Temperature: " + txtbxTemperature.Text + " Degrees");
            file.WriteLine("Vaccinated: " + vaccinated);
            file.WriteLine("Vaccination Dose: " + dose);
            file.WriteLine("Had symptoms: " + symptoms);
            file.WriteLine("Close contact on covid positive: " + contact);
            file.WriteLine("Tested positive for Covid 19: " + positive);
            file.WriteLine("Elligible to travel: " + eligibility);

            // Travel Information
            file.WriteLine("");
            file.WriteLine("Date and Time you ride this train: " + txtbxDateandTime.Text);
            file.WriteLine("Current Location: " + txtbxCurrentlocation.Text);
            file.WriteLine("Desired Destination: " + txtbxDesiredDestination.Text);

            // CLosing Remarks
            file.WriteLine("");
            file.WriteLine("Thank you for choosing PNR Station!");

            file.Close();

            MessageBox.Show("We are pleased to serve you with genuine love and joy. Thank you for choosing PNR Station. Have a safe ride ahead.", "PNR Station");
            if (MessageBox.Show("Submit another response?", "PNR Station", MessageBoxButtons.RetryCancel) == DialogResult.Cancel)
            {
                Application.Exit(); //  Exits the program
            }
            else // repeats the process
            {
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

                // radiobuttons 
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
            }
        }

        private void btnDateandtime_Click(object sender, EventArgs e) // For Time and Date
        {
            txtbxDateandTime.Text = dateandtimepicker.Value.ToString();
        }

        private void lblPhilippineNationalRailways_Click(object sender, EventArgs e)
        {
            // Phillipine Nationa Railways Label
        }
    }
}