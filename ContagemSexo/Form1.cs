using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemSexo
{
    public partial class Form1 : Form
    {

        int masculinohomossexual, masculinoheterossexual, femininohomossexual, femininoheterossexual;

        public Form1()
        {
            InitializeComponent();
        }

        private void btresultado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Foram casdatrados "+ masculinohomossexual + " homens homossexuais e " + masculinoheterossexual + " homens heterossexuais.\nForam cadastradas " + femininohomossexual + " mulheres homossexuais e "+ femininoheterossexual + " mulheres heterossuais.");
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (rdmasculino.Checked == true && chheterossexual.Checked == true)
            {
                masculinoheterossexual++;
            }

            else if (rdmasculino.Checked == true && chhomossexual.Checked == true)
            {
                masculinohomossexual++;
            }

            else if (rdfeminino.Checked == true && chheterossexual.Checked == true)
            {
                femininoheterossexual++;
            }

            else if (rdfeminino.Checked == true && chhomossexual.Checked == true)
            {
                femininohomossexual++;
            }

        }
    }
}
