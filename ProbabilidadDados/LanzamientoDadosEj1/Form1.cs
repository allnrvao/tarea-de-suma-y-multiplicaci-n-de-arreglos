using LanzamientoDadosEj1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LanzamientoDadosEj1
{
    public partial class Form1 : Form
    {
        probandolostiros simulacion = new probandolostiros();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            simulacion.Reproducirlanzamientos(36000);
            int[] frecuencias = simulacion.GetFrecuencias();

            // Limpiar los resultados anteriores 
            LimpiarElementos();

            // Encabezado del formato tabular
            // Asegurar que el DataGridView tenga las columnas configuradas
            if (dgvTablaResultados.Columns.Count == 0)
            {
                dgvTablaResultados.Columns.Add("Suma", "Suma");
                dgvTablaResultados.Columns.Add("Frecuencia", "Frecuencia");
            }

            // Agregar los resultados de las sumas al DataGridView
            for (int i = 2; i < frecuencias.Length; i++)
            {
                dgvTablaResultados.Rows.Add(i, frecuencias[i]);
            }

            // Comprobar si la suma 7 se aproxima al 16.67% de las tiradas
            double probabilidad7 = (double)frecuencias[7] / 36000;
            tbProbabilidad.Text = $"\nFrecuencia estimada de la suma 7:\n son {frecuencias[7]} veces.\n";
            tbProbabilidadde7.Text = $"\nSe estima que la probabilidad de la suma 7:\n  Es {probabilidad7:P2} \n(Debe ser aprox. 16.67%)";
        }

        public void LimpiarElementos()
        {
            dgvTablaResultados.Rows.Clear();
            tbProbabilidad.Clear();
            tbProbabilidadde7.Clear();
        }
        Dado dado1 = new Dado();
        Dado dado2 = new Dado();
        private void button1_Click(object sender, EventArgs e)
        {
            int resultadoDado1 = dado1.Darnumrand();
            int resultadoDado2 = dado2.Darnumrand();

            // Mostrar los resultados en los labels
            LblLandado1.Text = resultadoDado1.ToString();
            LblLandado2.Text = resultadoDado2.ToString();

            // Calcular y mostrar la suma de los dos dados
            int suma = resultadoDado1 + resultadoDado2;
            Lblsuma.Text = suma.ToString();
        }
    }
}
