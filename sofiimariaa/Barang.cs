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
    public partial class Barang : Form
    {
        public Barang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pembukaan Form = new pembukaan ();
            Form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Barang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3();
            Form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moisturaizer Form = new moisturaizer();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bodylation Form = new bodylation();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BodyWash Form = new BodyWash();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            skinrefesher Form = new skinrefesher();
            Form.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
