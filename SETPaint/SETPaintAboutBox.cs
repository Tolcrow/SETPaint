/**
* \file SETPaintAboutBox.cs
* \short PROG2120-FinalProject
* \author Zach Walters
* \date 2016-11-28
* \brief SetPaint's about box
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

namespace SETPaint {
    /**
    * \class SETPaintAboutBox
    * \breif <b>Description :</b> display information about SETPaint
    * \author Zach Walters
    */
    public partial class SETPaintAboutBox : Form {
        public SETPaintAboutBox() {
            InitializeComponent();
        }
        /**
        * \brief <b>close_Click</b> - clsoe the window
        * \details clsoe the window
        * \param object sender - reference to the object that raised the event.  not used
        * \param EventArgs e - contains event data,  not used
        * \return none
        */
        private void close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
