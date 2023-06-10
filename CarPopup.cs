using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_AddedTraffic_AddOns
{
    public partial class CarPopup : Form
    {
        public List<string> SelectedLocations = new List<string>();

        public CarPopup(string CarName, string DLCName, string[] Locations)
        {
            InitializeComponent();
            
            CarNameLabel.Text = $"{CarName} ({DLCName})";

            foreach (var Location in Locations)
            {
                LocationsCheckBoxList.Items.Add(Location);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            foreach (string check in LocationsCheckBoxList.CheckedItems)
            {
                SelectedLocations.Add(check);
            }

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
