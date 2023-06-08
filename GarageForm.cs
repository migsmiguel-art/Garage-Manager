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
            }
         }

        private void RemoveVehicleBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Add("Sample");
        }
    }
}
