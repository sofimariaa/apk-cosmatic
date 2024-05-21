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
    public partial class Ket_moisturizer : Form
    {
        public Ket_moisturizer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void Ket_moisturizer_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            moisturaizer Form = new moisturaizer();
            Form.ShowDialog();
        }
    }
}
