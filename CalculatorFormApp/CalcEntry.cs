using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormApp
{
    public partial class CalcEntry : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(Calculator cal);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Calculator cal;

        public CalcEntry()
        {
            InitializeComponent();
        }
        public CalcEntry(string title) : this()
        {
            this.Text = title;
        }
        private void CmB_Operasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Proses_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new Calculator();
            // Menampilkan pesan jika data (Nilai A & B) belum diisi
            if (textA.Text == "" || textB.Text == "")
            {
                MessageBox.Show("Data belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textA.Focus();
            }
            // Menampilkan pesan jika belum memilih operasi
            else if (CmB_Operasi.Text == "")
            {
                MessageBox.Show("Pilih Operasi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CmB_Operasi.Focus();
            }
            // Proses operasi
            else
            {
                if (CmB_Operasi.Text == "Penjumlahan")
                {
                    cal.hasil = "Hasil dari " + textA.Text + " + " + textB.Text + " adalah " + (int.Parse(textA.Text) + int.Parse(textB.Text));
                }
                else if (CmB_Operasi.Text == "Pengurangan")
                {
                    cal.hasil = "Hasil dari " + textA.Text + " - " + textB.Text + " adalah " + (int.Parse(textA.Text) - int.Parse(textB.Text));
                }
                else if (CmB_Operasi.Text == "Perkalian")
                {
                    cal.hasil = "Hasil dari " + textA.Text + " x " + textB.Text + " adalah " + (int.Parse(textA.Text) * int.Parse(textB.Text));
                }
                else if (CmB_Operasi.Text == "Pembagian")
                {
                    cal.hasil = "Hasil dari " + textA.Text + " : " + textB.Text + " adalah " + (float.Parse(textA.Text) / float.Parse(textB.Text));
                }
                // data baru
                if (isNewData) 
                {
                    OnCreate(cal);
                }
                // update
                else
                {
                    // panggil event OnUpdate
                    OnUpdate(cal); 
                    this.Close();
                }
            }
        }
    }
}
