#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CTempConverter2018.Business;

namespace CTempConverter2018
{

    public partial class Form1 : Form
    {

        //todo Unit Test both methods. 
        TempCalc myTempCalc = new TempCalc();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnFarToCel_Click(object sender, EventArgs e)
        {
            txtCel.Text = myTempCalc.ConvertFahToCel(txtFah.Text);
        }


        private void btncelTofah_Click(object sender, EventArgs e)
        {
            txtFah.Text = myTempCalc.CeToFah(txtCel.Text);

        }


    }
}
