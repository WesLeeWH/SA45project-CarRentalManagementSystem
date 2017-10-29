﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Group3CA2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Rental_Click(object sender, EventArgs e)
        {
            RentalUI rent = new RentalUI();
            rent.ShowDialog();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            ReturnUI retrun = new ReturnUI();
            retrun.ShowDialog();

        }

        private void Enquiry_Click(object sender, EventArgs e)
        {
            EnquiryUI enquiry = new EnquiryUI();
            enquiry.ShowDialog();

        }
    }
}
