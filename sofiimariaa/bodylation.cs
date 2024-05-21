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
    public partial class bodylation : Form
    {
        public bodylation()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Barang Form = new Barang();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BELI Form = new BELI();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ket_bodylation Form = new ket_bodylation();
            Form.ShowDialog();
        }
    }
}
