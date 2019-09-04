using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataValidationWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            // Generate directory path

            string Plant = Location.SelectedItem.ToString();
            LocationDisplay.Text = Plant;

            string PlantCode = "L1_";

            if (Plant == "Primary")
            {
                PlantCode = "L1_";
            } else if (Plant == "Secondary")
            {
                PlantCode = "L2_";
            } else if (Plant == "Local")
            {
                PlantCode = "L3_";
            }

            string fileLocation = "F:\\Coding Projects\\Test Files\\" + Plant + "\\Configuration\\" + PlantCode + "GJ1234_Configuration.txt";
            

            //Check if File is present
            if (File.Exists(fileLocation))
            {
                ResultsDaf1220Box.Text = "File Present";
                ResultsDaf1220Box.ForeColor = Color.Green;
            }
            else
            {
                ResultsDaf1220Box.Text = "File Missing";
                ResultsDaf1220Box.ForeColor = Color.Red;
            }

        }

        private void Location_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ResultsDaf1220Box_Click(object sender, EventArgs e)
        {

        }
    }
}

