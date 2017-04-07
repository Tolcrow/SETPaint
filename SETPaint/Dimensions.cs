/**
* \file Dimensions.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief set the dimentions for a new bitmap image
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SETPaint {
    public partial class Dimensions : Form {
        public Dimensions() {
            InitializeComponent();
        }
        
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }

        private void okButton_Click(object sender, EventArgs e) {
            // height and width is between 1-5000
            if ((Regex.IsMatch(WidthTextBox.Text, @"^([0-4]?[0-9]?[0-9]?[0-9]|5000)$") == true) &&
                (Regex.IsMatch(WidthTextBox.Text, @"^0$") == false) &&
                (Regex.IsMatch(HeightTextBox.Text, @"^([0-4]?[0-9]?[0-9]?[0-9]|5000)$") == true) &&
                (Regex.IsMatch(HeightTextBox.Text, @"^0$") == false)) {
                
                ImageWidth = Int32.Parse(WidthTextBox.Text);
                ImageHeight = Int32.Parse(HeightTextBox.Text);
            }
            else {

                ImageWidth = 640; // default width
                ImageHeight = 480; // default height
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {

            Close();
        }
    }
}
