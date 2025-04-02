using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {
        Acciones blep = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bleeh.DataSource = null;
            Bleeh.DataSource = blep.MostrarPokemon();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (blep.EliminarPokemon(textBox1.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("MissingNo");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            if (blep.AgregarPokemon(a.Text, b.Text, c.Text, d.Text, f.Text))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("MissingNo");
        }
    }
}
