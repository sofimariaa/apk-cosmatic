﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sofiimariaa
{
    public partial class Keterangan : Form
    {
        public Keterangan()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form3 Form = new Form3();
            Form.ShowDialog();
        }
    }
}
