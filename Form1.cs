using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        vector v1,v2,v3;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new vector();
            v2 = new vector();
            v3 = new vector();
        }

        private void cARGARRANDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {

            v1.cargar_vector_random(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox4.Text = v1.descargar_vector();
        }

        private void cARGAR1X1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1 = new vector();
            int d;
            d = int.Parse(Interaction.InputBox("pon la dimension del vector"));
            for (int i = 1; i <= d; i++)
                v1.cargar_1_x_1(int.Parse(Interaction.InputBox("vector" + i)));
              textBox4.Text = v1.descargar_vector();
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.descargar_vector();
        }

        private void cARGARFIBONACCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar_fibonaci(int.Parse(textBox1.Text));
            textBox4.Text = v1.descargar_vector();
        }

        private void sUMADEVECTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.sumar_vectores());
        }

        private void mEDIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.media_o_promedio());
        }

        private void dESVIACIONMEDIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.desviacion_media());
        }

        private void dESVIACIONESTANDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.desviacion_estandar());
        }

        private void sELECCEXELENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2 = new vector();
            v1.seleccionar_exelentes(ref v2);
            textBox5.Text = v2.descargar_vector();
        }

        private void rANDOMRAPIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar_vector_random(10, 1, 11);
            textBox4.Text = v1.descargar_vector();
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = v2.descargar_vector();
        }

        private void mAXIMOYFRECCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int m, f;
            m = 0;
            f = 0;
            v1.maxfrec(ref m, ref f);
            textBox5.Text = string.Concat("maximo: " + m +  "  frecuencia: " + f);
        }
        private void aLMENOS1PRIMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text= string.Concat(v1.verifica_pri());
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           textBox6.Text=v3.descargar_vector();
        }

        private void cARGARRAPIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.cargar_vector_random(10, 1, 11);
            textBox5.Text = v2.descargar_vector();
        }

        private void oRDENAMIENTOINTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.ordinamiento_intercambio();
            textBox6.Text = v2.descargar_vector();
        }

        private void cARGARRANDOMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v2.cargar_vector_random(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void oRDINTERDESENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.ordenamiento_intercambio_des();
            textBox6.Text = v2.descargar_vector();
        }

        private void oRDMIGUELANGELOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.ordBurburbujamiguel();
            textBox6.Text = v2.descargar_vector();
        }

        private void oRDBURBUJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.ordenamiento_burbuja();
            textBox6.Text = v2.descargar_vector();
        }

        private void bURBUJA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.ordBurburbuja2();
            textBox6.Text = v2.descargar_vector();
        }

        private void vERIFORDENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.verificar_orden());
        }

        private void vECTORMAYORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.maximo());
        }

        private void oRDENQUICKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.orden_quick();
            textBox6.Text = v2.descargar_vector();
        }

        private void sEGMENTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.segpar_impar();
            textBox6.Text = v2.descargar_vector();
        }

        private void sEGPRIMOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2.segprimo_noprimo();
            textBox6.Text = v2.descargar_vector();
        }

        private void gRAFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n1, i;
            n1 = v1.retornar_dim();
            chart1.Series[0].Points.Clear();
            for (i = 1; i <= n1; i++)
                chart1.Series[0].Points.AddY(v1.retornar_Elemto(i));
        }

        private void iNTERSECCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.interseccion(v2,ref v3);
        }
        private void sALTODEPOSICIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v2 = new vector();
            v1.saleccion_de_posiciones(int.Parse(textBox1.Text), ref v2);

            textBox5.Text = v2.descargar_vector();
        }
    }
}
