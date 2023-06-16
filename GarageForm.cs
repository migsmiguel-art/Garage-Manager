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

                listBox1.Items.Add(veh.ToString());

        // END SAMPLE
            }
         }

        private void RemoveVehicleBtn_Click(object sender, EventArgs e)
        {
            //  MainListBox.Items.Add("Sample");
            // Create a variable that holds the index of the selected employee
            // Validate if an item is selected,
            // If there is a selected item proceed to remove,
            // Else Alert user to select an item from the list.
            int currentSelection = listBox1.SelectedIndex;

            if (currentSelection > -1)
            {
                Console.WriteLine("Removed Item from Index: " + currentSelection);
                listBox1.Items.RemoveAt(currentSelection);
            }
            else
            {
                MessageBox.Show("Please Select a Vehicle from the List");
            }

        }

        public void getInput()
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
