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
    public partial class BELI : Form
    {
        public BELI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bpcreamSerum, bpmoisturizer, bpbodyWash, bpbodyLation, bpskinrefer, bptotalBiaya, bpuang, bpbiayaPajak, bpkembalian;
            double hargaCs, hargaMs, hargaBw, hargaBl, hargaSk, bptotalPembayaran;

            bpcreamSerum = double.Parse(creamSerum.Text);
            bpmoisturizer = double.Parse(moisturizer.Text);
            bpbodyWash = double.Parse(bodyWash.Text);
            bpbodyLation = double.Parse(bodyLation.Text);
            bpskinrefer = double.Parse(skinrefer.Text);
            bpuang = double.Parse(uang.Text);


            hargaCs = bpcreamSerum * 95000;
            hargaMs = bpmoisturizer * 30000;
            hargaBw = bpbodyWash * 40000;
            hargaBl = bpbodyLation * 85000;
            hargaSk = bpskinrefer * 20000;


            bptotalBiaya = hargaCs + hargaMs + hargaBw + hargaBl + hargaSk;
            bpbiayaPajak = bptotalBiaya * 0.1;

            bptotalPembayaran = bptotalBiaya + bpbiayaPajak;
            bpkembalian = bpuang - bptotalPembayaran;

            totalBiaya.Text = "Rp." + bptotalBiaya.ToString("N");
            biayaPajak.Text = "Rp." + bpbiayaPajak.ToString("N");
            totalPembayaran.Text = "Rp." + bptotalPembayaran.ToString("N");
            kembalian.Text = "Rp." + bpkembalian.ToString("N");


        }

        private void BELI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selesai Form = new selesai();
            Form.ShowDialog();
        }
    }
}
