using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace sofiimariaa
{
    public partial class skinrefesher : Form
    {
        public skinrefesher()
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
            Ket_skinrefresher Form = new Ket_skinrefresher();
            Form.ShowDialog();
        }
    }
}
