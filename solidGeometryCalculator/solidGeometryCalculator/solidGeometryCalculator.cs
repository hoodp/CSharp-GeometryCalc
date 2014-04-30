using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//    Paul Hood
//    L2 Homework - Simple Geometric Calculator
//    Geometric calculator calculates volume & surface area for cone or cylinder
//    2/6/2013

namespace solidGeometryCalculator
{
    public partial class solidGeometryCalculator : Form
    {
        public solidGeometryCalculator()
        {
            InitializeComponent();
        }

        // Clicking Cylinder picture box sets the cylinder radiobox to checked
        private void picCylinder_Click(object sender, EventArgs e)
        {
            radCylinder.Checked = true;
        }

        // Clicking cone picture box sets cone radiobox to checked
        private void picCone_Click(object sender, EventArgs e)
        {
            radCone.Checked = true;
        }

        //Exits the Form
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clears All text boxes, and unchecks text box
        private void butClear_Click(object sender, EventArgs e)
        {
            // error message if data is already cleared
            if (txtRadius.TextLength == 0 || txtHeight.TextLength == 0)
            {
                MessageBox.Show("Radius and Height cleared.");
            }

            txtConeSurfaceArea.Clear();
            txtConeVolume.Clear();
            txtCylinderSurfaceArea.Clear();
            txtCylinderVolume.Clear();
            txtHeight.Clear();
            txtRadius.Clear();
            
            // uncheck radio boxes
            if (radCone.Checked)
            {
                radCone.Checked = false;    
            }
            else if (radCylinder.Checked)
            {
                radCylinder.Checked = false;
            }
        }


        // calculates formula for either cylinder or cone
        private void butCalculate_Click(object sender, EventArgs e)
        {
            // height and radius variables & conversion
            double height = Convert.ToDouble(txtHeight.Text);
            double radius = Convert.ToDouble(txtRadius.Text);
            double volume;
            double surfaceArea;
            
            // cone checked
            if(radCone.Checked)
            {
                
                // formulas for volume & surface area of a cone, rounds values so no decimals
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * height * 1 / 3);
                surfaceArea = Math.Round((Math.PI * Math.Pow(radius, 2)) + (Math.PI * radius * Math.Sqrt((Math.Pow(radius, 2) + Math.Pow(height, 2)))));
                
                // double conversion to string
                txtConeVolume.Text = volume.ToString();
                txtConeSurfaceArea.Text = surfaceArea.ToString();
  
                // clear cylinder data if entered
                txtCylinderSurfaceArea.Clear();
                txtCylinderVolume.Clear();
            
            }
            //cylinder checked
            else if(radCylinder.Checked)
            {
                
                // formulas for volume & surface area of a cylinder
                volume = Math.Round(Math.PI * Math.Pow(radius, 2) * height);
                surfaceArea = Math.Round((2 * Math.PI * Math.Pow(radius, 2)) + (2 * Math.PI * radius * height)); 
                
                // converstion to string
                txtCylinderVolume.Text = volume.ToString();
                txtCylinderSurfaceArea.Text = surfaceArea.ToString();

                // clear cone data if entered
                txtConeSurfaceArea.Clear();
                txtConeVolume.Clear();
            
            }
            // no boxes checked
            else if (radCylinder.Checked == false && radCone.Checked == false)
            {
                // message box telling user to enter data
                MessageBox.Show("Please select cone or cylinder.");
            }
        }

        // text Radius Maximum number of Digits
        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            if (txtRadius.TextLength > 10)
            {
                MessageBox.Show("Only 10 digits in radius allowed, please try again.");
                //clear data in radius textbox
                txtRadius.Clear();
            }
        }

        // text Height Maximum number of Digits
        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            if (txtHeight.TextLength > 10)
            {
                MessageBox.Show("Only 10 digits in radius allowed, please try again.");
                //clear data in Height textbox
                txtHeight.Clear();
            }
        }
    }
}
