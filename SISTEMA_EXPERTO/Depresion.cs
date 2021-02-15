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
    public partial class Depresion : Form
    {
        private int[] p;
        private int puntaje;
        public Depresion()
        {
            InitializeComponent();
        }

        private void Depresion_Load(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlQuery cargar = new PlQuery("cargar('SistemaExperto.pl')");
            String alternativa;
            p = new int[21];
            int i;
            int c = 0;
            for (i = 1; i <= 20; i++)
            {
                alternativa = "";
                switch (i)
                {

                    case 1:

                        if (radioButton1.Checked) { alternativa = "nunca"; }
                        if (radioButton2.Checked) { alternativa = "poco"; }
                        if (radioButton3.Checked) { alternativa = "regular"; }
                        if (radioButton4.Checked) { alternativa = "mucho"; }

                        PlQuery consulta1 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");

                        foreach (PlQueryVariables z in consulta1.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 2:
                        if (radioButton5.Checked) { alternativa = "nunca"; }
                        if (radioButton6.Checked) { alternativa = "poco"; }
                        if (radioButton7.Checked) { alternativa = "regular"; }
                        if (radioButton8.Checked) { alternativa = "mucho"; }

                        PlQuery consulta2 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");

                        foreach (PlQueryVariables z in consulta2.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 3:
                        if (radioButton9.Checked) { alternativa = "nunca"; }
                        if (radioButton10.Checked) { alternativa = "poco"; }
                        if (radioButton11.Checked) { alternativa = "regular"; }
                        if (radioButton12.Checked) { alternativa = "mucho"; }

                        PlQuery consulta3 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta3.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 4:
                        if (radioButton13.Checked) { alternativa = "nunca"; }
                        if (radioButton14.Checked) { alternativa = "poco"; }
                        if (radioButton15.Checked) { alternativa = "regular"; }
                        if (radioButton16.Checked) { alternativa = "mucho"; }

                        PlQuery consulta4 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta4.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 5:
                        if (radioButton17.Checked) { alternativa = "nunca"; }
                        if (radioButton18.Checked) { alternativa = "poco"; }
                        if (radioButton19.Checked) { alternativa = "regular"; }
                        if (radioButton20.Checked) { alternativa = "mucho"; }

                        PlQuery consulta5 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta5.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 6:
                        if (radioButton21.Checked) { alternativa = "nunca"; }
                        if (radioButton22.Checked) { alternativa = "poco"; }
                        if (radioButton23.Checked) { alternativa = "regular"; }
                        if (radioButton24.Checked) { alternativa = "mucho"; }

                        PlQuery consulta6 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta6.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 7:
                        if (radioButton25.Checked) { alternativa = "nunca"; }
                        if (radioButton26.Checked) { alternativa = "poco"; }
                        if (radioButton27.Checked) { alternativa = "regular"; }
                        if (radioButton28.Checked) { alternativa = "mucho"; }

                        PlQuery consulta7 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta7.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 8:
                        if (radioButton29.Checked) { alternativa = "nunca"; }
                        if (radioButton30.Checked) { alternativa = "poco"; }
                        if (radioButton31.Checked) { alternativa = "regular"; }
                        if (radioButton32.Checked) { alternativa = "mucho"; }

                        PlQuery consulta8 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta8.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 9:
                        if (radioButton33.Checked) { alternativa = "nunca"; }
                        if (radioButton34.Checked) { alternativa = "poco"; }
                        if (radioButton35.Checked) { alternativa = "regular"; }
                        if (radioButton36.Checked) { alternativa = "mucho"; }

                        PlQuery consulta9 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta9.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 10:
                        if (radioButton37.Checked) { alternativa = "nunca"; }
                        if (radioButton38.Checked) { alternativa = "poco"; }
                        if (radioButton39.Checked) { alternativa = "regular"; }
                        if (radioButton40.Checked) { alternativa = "mucho"; }

                        PlQuery consulta10 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta10.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 11:
                        if (radioButton41.Checked) { alternativa = "nunca"; }
                        if (radioButton42.Checked) { alternativa = "poco"; }
                        if (radioButton43.Checked) { alternativa = "regular"; }
                        if (radioButton44.Checked) { alternativa = "mucho"; }

                        PlQuery consulta11 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta11.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 12:
                        if (radioButton45.Checked) { alternativa = "nunca"; }
                        if (radioButton46.Checked) { alternativa = "poco"; }
                        if (radioButton47.Checked) { alternativa = "regular"; }
                        if (radioButton48.Checked) { alternativa = "mucho"; }

                        PlQuery consulta12 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta12.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 13:
                        if (radioButton49.Checked) { alternativa = "nunca"; }
                        if (radioButton50.Checked) { alternativa = "poco"; }
                        if (radioButton51.Checked) { alternativa = "regular"; }
                        if (radioButton52.Checked) { alternativa = "mucho"; }

                        PlQuery consulta13 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta13.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 14:
                        if (radioButton53.Checked) { alternativa = "nunca"; }
                        if (radioButton54.Checked) { alternativa = "poco"; }
                        if (radioButton55.Checked) { alternativa = "regular"; }
                        if (radioButton56.Checked) { alternativa = "mucho"; }

                        PlQuery consulta14 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta14.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 15:
                        if (radioButton57.Checked) { alternativa = "nunca"; }
                        if (radioButton58.Checked) { alternativa = "poco"; }
                        if (radioButton59.Checked) { alternativa = "regular"; }
                        if (radioButton60.Checked) { alternativa = "mucho"; }

                        PlQuery consulta15 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta15.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 16:
                        if (radioButton61.Checked) { alternativa = "nunca"; }
                        if (radioButton62.Checked) { alternativa = "poco"; }
                        if (radioButton63.Checked) { alternativa = "regular"; }
                        if (radioButton64.Checked) { alternativa = "mucho"; }

                        PlQuery consulta16 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta16.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;

                    case 17:
                        if (radioButton65.Checked) { alternativa = "nunca"; }
                        if (radioButton66.Checked) { alternativa = "poco"; }
                        if (radioButton67.Checked) { alternativa = "regular"; }
                        if (radioButton68.Checked) { alternativa = "mucho"; }

                        PlQuery consulta17 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta17.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 18:
                        if (radioButton69.Checked) { alternativa = "nunca"; }
                        if (radioButton70.Checked) { alternativa = "poco"; }
                        if (radioButton71.Checked) { alternativa = "regular"; }
                        if (radioButton72.Checked) { alternativa = "mucho"; }

                        PlQuery consulta18 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta18.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 19:
                        if (radioButton73.Checked) { alternativa = "nunca"; }
                        if (radioButton74.Checked) { alternativa = "poco"; }
                        if (radioButton75.Checked) { alternativa = "regular"; }
                        if (radioButton76.Checked) { alternativa = "mucho"; }

                        PlQuery consulta19 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta19.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 20:
                        if (radioButton77.Checked) { alternativa = "nunca"; }
                        if (radioButton78.Checked) { alternativa = "poco"; }
                        if (radioButton79.Checked) { alternativa = "regular"; }
                        if (radioButton80.Checked) { alternativa = "mucho"; }

                        PlQuery consulta20 = new PlQuery("puntaje_depresion('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta20.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                }

                puntaje += p[i];
            }

            if (c < 20)
            {
                MessageBox.Show("RESPONDER TODAS LAS PREGUNTAS", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string resultado = "";
                
                if (puntaje >= 20 && puntaje <= 35) { resultado = "Persona Normal"; } else if (puntaje >= 36 && puntaje <= 45) { resultado = "Depresión Leve"; } else if (puntaje >= 46 && puntaje <= 65) { resultado = "Cuadro depresivo de Mediana Intensidad"; } else { resultado = "Estado Depresivo Severo"; }
                ResultadoDepresion d = new ResultadoDepresion();
                d.lblResultado.Text = resultado;
                d.Show();
                this.Close();
            }
        }
    }
}
