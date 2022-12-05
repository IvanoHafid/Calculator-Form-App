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
    public partial class CalcDisplay : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public CalcDisplay()
        {
            InitializeComponent();
        }

        private void FormEntry_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            listBox1.Items.Add(cal.hasil);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Hitung_Click(object sender, EventArgs e)
        {
            CalcEntry formEntry = new CalcEntry("Calculator");
            formEntry.OnCreate += FormEntry_OnCreate;
            formEntry.ShowDialog();
        }
    }
}
