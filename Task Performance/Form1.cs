using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace Task_Performance
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float input1 = float.Parse(txt1.Text);
            float input2 = float.Parse(txt2.Text);

            if (cb.Text == "+")
            {
                label3.Text = BasicComputation.addResult(input1, input2).ToString();

            }
            else if (cb.Text == "-")
            {
                label3.Text = BasicComputation.subResult(input1, input2).ToString();
            }
            else if (cb.Text == "*")
            {
                label3.Text = BasicComputation.multiResult(input1, input2).ToString();
            }
            else if (cb.Text == "/")
            {
                 label3.Text = BasicComputation.divResult(input1, input2).ToString();
            }
        }
    }
}
