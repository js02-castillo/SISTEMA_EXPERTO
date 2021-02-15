using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_EXPERTO
{
    public partial class ResultadoEstres : Form
    {
        public ResultadoEstres()
        {
            InitializeComponent();
        }

        private void ResultadoEstres_Load(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
                string[] p = { "-q", "-f", @"SistemaExperto.pl" };
                if (!PlEngine.IsInitialized)
                {
                    PlEngine.Initialize(p);
                }

                richTextBox1.Clear();

                    PlQuery consulta1 = new PlQuery("tratamiento_estres('" + lblResultado.Text + "',X).");
                    foreach (PlQueryVariables z in consulta1.SolutionVariables)
                    {
                    richTextBox1.Text += "-" + z["X"].ToString() + "\n";
                    }
                
            }
            catch (PlException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }
    }
}
