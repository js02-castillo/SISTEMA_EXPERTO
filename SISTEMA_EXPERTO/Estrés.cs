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

    public partial class Estrés : Form
    {
        private int[] p;
        private int puntaje;
        public Estrés()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            this.Close();
        }

        private void Dislexia_Load(object sender, EventArgs e)
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            PlQuery cargar = new PlQuery("cargar('SistemaExperto.pl')");
            String alternativa ;
            p = new int[15];
            int i;
            int c = 0;
            for ( i=1; i <= 14; i++) {
                alternativa = "";
                switch (i)
                {
                    
                    case 1:
                        
                        if (radioButton1.Checked) { alternativa = "nunca"; }
                        if (radioButton2.Checked) { alternativa = "casi nunca"; }
                        if (radioButton3.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton4.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta1 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
             
                        foreach (PlQueryVariables z in consulta1.SolutionVariables)
                        {
                            p[i]= Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 2:
                        if (radioButton5.Checked) { alternativa = "nunca"; }
                        if (radioButton6.Checked) { alternativa = "casi nunca"; }
                        if (radioButton7.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton8.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery  consulta2 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                    
                        foreach (PlQueryVariables z in consulta2.SolutionVariables)
                        {
                            p[i]= Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 3:
                        if (radioButton9.Checked) { alternativa = "nunca"; }
                        if (radioButton10.Checked) { alternativa = "casi nunca"; }
                        if (radioButton11.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton12.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta3 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta3.SolutionVariables)
                        {
                            p[i]= Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 4:
                        if (radioButton13.Checked) { alternativa = "muy frecuentemente"; }
                        if (radioButton14.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton15.Checked) { alternativa = "casi nunca"; }
                        if (radioButton16.Checked) { alternativa = "nunca"; }

                        PlQuery consulta4 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta4.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 5:
                        if (radioButton17.Checked) { alternativa = "muy frecuentemente"; }
                        if (radioButton18.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton19.Checked) { alternativa = "casi nunca"; }
                        if (radioButton20.Checked) { alternativa = "nunca"; }

                        PlQuery consulta5 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta5.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 6:
                        if (radioButton21.Checked) { alternativa = "muy frecuentemente"; }
                        if (radioButton22.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton23.Checked) { alternativa = "casi nunca"; }
                        if (radioButton24.Checked) { alternativa = "nunca"; }

                        PlQuery consulta6 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta6.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 7:
                        if (radioButton25.Checked) { alternativa = "nunca"; }
                        if (radioButton26.Checked) { alternativa = "casi nunca"; }
                        if (radioButton27.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton28.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta7 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta7.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 8:
                        if (radioButton29.Checked) { alternativa = "nunca"; }
                        if (radioButton30.Checked) { alternativa = "casi nunca"; }
                        if (radioButton31.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton32.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta8 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta8.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 9:
                        if (radioButton33.Checked) { alternativa = "muy frecuentemente"; }
                        if (radioButton34.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton35.Checked) { alternativa = "casi nunca"; }
                        if (radioButton36.Checked) { alternativa = "nunca"; }

                        PlQuery consulta9 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta9.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 10:
                        if (radioButton37.Checked) { alternativa = "nunca"; }
                        if (radioButton38.Checked) { alternativa = "casi nunca"; }
                        if (radioButton39.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton40.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta10 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta10.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 11:
                        if (radioButton41.Checked) { alternativa = "nunca"; }
                        if (radioButton42.Checked) { alternativa = "casi nunca"; }
                        if (radioButton43.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton44.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta11 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta11.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 12:
                        if (radioButton45.Checked) { alternativa = "nunca"; }
                        if (radioButton46.Checked) { alternativa = "casi nunca"; }
                        if (radioButton47.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton48.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta12 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta12.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 13:
                        if (radioButton49.Checked) { alternativa = "nunca"; }
                        if (radioButton50.Checked) { alternativa = "casi nunca"; }
                        if (radioButton51.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton52.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta13 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
                        foreach (PlQueryVariables z in consulta13.SolutionVariables)
                        {
                            p[i] = Convert.ToInt32(z["X"].ToString());
                            c++;
                        }
                        break;
                    case 14:
                        if (radioButton53.Checked) { alternativa = "nunca"; }
                        if (radioButton54.Checked) { alternativa = "casi nunca"; }
                        if (radioButton55.Checked) { alternativa = "frecuentemente"; }
                        if (radioButton56.Checked) { alternativa = "muy frecuentemente"; }

                        PlQuery consulta14 = new PlQuery("puntaje_estres('" + alternativa + "',X).");
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
            else{
                string resultado = "";
                
                if (puntaje >= 14 && puntaje <= 24){ resultado = "Persona Normal"; }else if(puntaje >= 25 && puntaje <= 35) { resultado = "Estrés Leve"; } else if(puntaje >= 36 && puntaje <= 46) { resultado = "Estrés de Mediana Intensidad"; } else { resultado = "Estrés Severo"; }
                ResultadoEstres d = new ResultadoEstres();
                d.lblResultado.Text = resultado;
                d.Show();
                this.Close();
            }
            

        }
    }
}
