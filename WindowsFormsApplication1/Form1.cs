﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtA.Text != null )
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a / b;
            txt_ketqua.Text = c.ToString();
        }
    }
}
