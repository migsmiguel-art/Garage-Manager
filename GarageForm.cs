using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage_Manager
{
    public partial class GarageForm : Form
    {
        public GarageForm()
        {
            InitializeComponent();
        }

        private void AddVehicleBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Test adding vehicle");
            AddVehicleForm frmInput = new AddVehicleForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                // see if input form was cancelled
                if (result == DialogResult.Cancel)
                    return;

                string nickname = frmInput.NicknameTextBox.Text;
                string type = frmInput.TypeTextBox.Text;
                int year = int.Parse(frmInput.YearTextBox.Text);
                string make = frmInput.MakeTextBox.Text;
                string model = frmInput.ModelTextBox.Text;
                string trim = frmInput.TrimTextBox.Text;
                int odometer = int.Parse(frmInput.OdometerTextBox.Text);
                string plateNum = frmInput.PlateTextBox.Text;
                string VIN = frmInput.VINTextBox.Text;

                Vehicle veh = new Vehicle(nickname, type, year, make, model, trim, odometer, plateNum, VIN);
               Console.WriteLine(veh.ToString());

                MainListBox.Items.Add(veh.ToString());

        // END SAMPLE
            }
         }

        private void RemoveVehicleBtn_Click(object sender, EventArgs e)
        {
            MainListBox.Items.Add("Sample");
        }

        public void getInput()
        {

        }
    }
}
