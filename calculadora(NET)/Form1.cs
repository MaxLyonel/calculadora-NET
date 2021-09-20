using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_NET_
{
    public partial class Form1 : Form
    {
        String numCad = "";
        Boolean sw = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void num7_Click(object sender, EventArgs e)
        {
            
        }
        private void leeNumero(object sender, EventArgs e)
        {
            if(sw)
            {
                visualizador.Text = String.Empty;
                sw = false;
            }
            String aux = ((Button)sender).Text;
            numCad = visualizador.Text + aux;
            visualizador.Text = numCad;
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            visualizador.Text = String.Empty;
        }

        private void suma_Click(object sender, EventArgs e)
        {
            // int num1 = Int32.Parse(visualizador.Text);
            String vis = visualizador.Text + " + ";
            visualizador.Text = vis; 
        }
        private void resta_Click(object sender, EventArgs e)
        {
            String vis = visualizador.Text + " - ";
            visualizador.Text = vis;
        }
        private void multiplicacion_Click(object sender, EventArgs e)
        {
            String vis = visualizador.Text + " x ";
            visualizador.Text = vis;
        }
        private void division_Click(object sender, EventArgs e)
        {
            String vis = visualizador.Text + " / ";
            visualizador.Text = vis;
        }

        private void igual_Click(object sender, EventArgs e)
        {
            ArbolBinario arb = new ArbolBinario();
            //list = visualizador.Text.Split(' ').ToList();            
            String cadCal = visualizador.Text;

            String nueCad = "";
            for (int i = 0; i < cadCal.Length; i++)
            {
                if (!cadCal[i].Equals(' ') && !cadCal[i].Equals('+') &&
                    !cadCal[i].Equals('-') && !cadCal[i].Equals('x') && !cadCal[i].Equals('/')){
                    
                    nueCad = nueCad + cadCal[i] + "";
                    if (i == cadCal.Length - 1)
                        arb.insertar_x_abajo(nueCad);
                } else
                if(cadCal[i].Equals(' '))
                {
                    if (!nueCad.Equals(String.Empty))
                    {
                        arb.insertar_x_abajo(nueCad);
                        nueCad = String.Empty;
                    }
                    
                } else if(cadCal[i].Equals('+') || cadCal[i].Equals('-') ||
                    cadCal[i].Equals('x') || cadCal[i].Equals('/'))
                {
                    arb.insertar_x_abajo(cadCal[i]+"");
                }
            }
            double res = arb.evaluar(arb.raiz);
            visualizador.Text = String.Empty;
            visualizador.Text = res + "";
            sw = true;
        }

        private void retro_Click(object sender, EventArgs e)
        {
            if (!visualizador.Text.Equals(String.Empty) && !sw)
            {
                String aux = visualizador.Text;
                String nuevo = aux.Substring(0, aux.Length - 1);
                visualizador.Text = nuevo;
            }
            
        }
    }
}
