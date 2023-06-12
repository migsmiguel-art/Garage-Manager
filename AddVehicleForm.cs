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
    public partial class AddVehicleForm : Form
    {
        public AddVehicleForm()
        {
            InitializeComponent();
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Testing ADD BUTTON");
            this.DialogResult = DialogResult.OK;
            this.Hide();


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Testing REMOVE BUTTON");
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
