using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.Add("CV-210", "Facial cleanser everwell","Rp 599.000","11");
            dataGridView1.Rows.Add("D-122", "skin refresher everwell","Rp 270.000","4");
            dataGridView1.Rows.Add("UI-410", "Serum everwell","Rp 3.444.999", "6  ");
            dataGridView1.Rows.Add("VC-68", "Moisturizer everwell","Rp 999.999","12 ");
            dataGridView1.Rows.Add("F-310","Mask everwell","Rp 150.000","76 ");

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
