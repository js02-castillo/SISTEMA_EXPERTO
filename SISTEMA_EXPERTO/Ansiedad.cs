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
    public partial class Ansiedad : Form
    {
        private int[] p;
        private int puntaje;
        public Ansiedad()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PlQuery cargar = new PlQuery("cargar('SistemaExperto.pl')");
            String alternativa;
            p = new int[15];
            int i;
            int c = 0;
            for (i = 1; i <= 14; i++)
            {
                alternativa = "";
                switch (i)
                {

                    case 1:

                        if (radioButton1.Checked) { alternativa = "No Presente"; }
                        if (radioButton2.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton3.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton4.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton5.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta1 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");

                        foreach (PlQueryVariables z in consulta1.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 2:
                        if (radioButton6.Checked) { alternativa = "No Presente"; }
                        if (radioButton7.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton8.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton9.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton10.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta2 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");

                        foreach (PlQueryVariables z in consulta2.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 3:
                        if (radioButton11.Checked) { alternativa = "No Presente"; }
                        if (radioButton12.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton13.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton14.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton15.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta3 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta3.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 4:
                        if (radioButton16.Checked) { alternativa = "No Presente"; }
                        if (radioButton17.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton18.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton19.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton20.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta4 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta4.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 5:
                        if (radioButton21.Checked) { alternativa = "No Presente"; }
                        if (radioButton22.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton23.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton24.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton25.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta5 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta5.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 6:
                        if (radioButton26.Checked) { alternativa = "No Presente"; }
                        if (radioButton27.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton28.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton29.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton30.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta6 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta6.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 7:
                        if (radioButton31.Checked) { alternativa = "No Presente"; }
                        if (radioButton32.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton33.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton34.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton35.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta7 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta7.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 8:
                        if (radioButton36.Checked) { alternativa = "No Presente"; }
                        if (radioButton37.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton38.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton39.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton40.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta8 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta8.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 9:
                        if (radioButton41.Checked) { alternativa = "No Presente"; }
                        if (radioButton42.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton43.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton44.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton45.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta9 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta9.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 10:
                        if (radioButton46.Checked) { alternativa = "No Presente"; }
                        if (radioButton47.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton48.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton49.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton50.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta10 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta10.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 11:
                        if (radioButton51.Checked) { alternativa = "No Presente"; }
                        if (radioButton52.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton53.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton54.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton55.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta11 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta11.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 12:
                        if (radioButton56.Checked) { alternativa = "No Presente"; }
                        if (radioButton57.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton58.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton59.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton60.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta12 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta12.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 13:
                        if (radioButton61.Checked) { alternativa = "No Presente"; }
                        if (radioButton62.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton63.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton64.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton65.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta13 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta13.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 14:
                        if (radioButton66.Checked) { alternativa = "No Presente"; }
                        if (radioButton67.Checked) { alternativa = "Presente Eventualmente"; }
                        if (radioButton68.Checked) { alternativa = "Presente Con Frecuencia Leve"; }
                        if (radioButton69.Checked) { alternativa = "Presente Con Frecuencia"; }
                        if (radioButton70.Checked) { alternativa = "Presente Con Intensidad Severa"; }

                        PlQuery consulta14 = new PlQuery("puntaje_ansiedad('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta14.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;

                }

                puntaje += p[i];
            }

            if (c < 14)
            {
                MessageBox.Show("RESPONDER TODAS LAS PREGUNTAS", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string resultado = "";

                if (puntaje >= 14 && puntaje <= 17) { resultado = "Ansiedad Leve"; } else if (puntaje >= 18 && puntaje <= 44) { resultado = "Ansiedad Moderada"; } else { resultado = "Estado Severo de Ansiedad"; }
                ResultadoAnsiedad d = new ResultadoAnsiedad();
                d.lblResultado.Text = resultado;
                d.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }

        private void Ansiedad_Load(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
                string[] p = { "-q", "-f", @"SistemaExperto.pl" };
                if (!PlEngine.IsInitialized)
                {
                    PlEngine.Initialize(p);
                }

            }
            catch (PlException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
