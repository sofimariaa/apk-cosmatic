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
    public partial class Ket_bodywash : Form
    {
        public Ket_bodywash()
        {
            InitializeComponent();
        }

        private void Ket_bodywash_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BodyWash Form = new BodyWash();
            Form.ShowDialog();
        }
    }
}
