using System;
using System.Windows.Forms;

namespace tpmodul12_103022300134
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelOutput.Text = "Masukkan angka ke textbox dan tekan tombol.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tidak wajib diisi, opsional untuk inisialisasi lain
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int angka))
            {
                string hasil = CariTandaBilangan(angka);
                labelOutput.Text = $"Hasil: {hasil}";
            }
            else
            {
                labelOutput.Text = "Input tidak valid! Masukkan angka.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelOutput.Text = "";
        }

        private string CariTandaBilangan(int angka)
        {
            if (angka > 0) return "Positif";
            else if (angka < 0) return "Negatif";
            else return "Nol";
        }
    }
}
