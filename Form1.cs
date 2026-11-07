using HUELLITAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_adopcion_de_mascotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        // BOTON MASCOTAS
        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Mascotas formulario = new Mascotas();
            formulario.Show();
            this.Hide();
        }

        // BOTON ADOPTANTES
        private void btnAdoptantes_Click(object sender, EventArgs e)
        {
            ADOPTANTES formulario = new ADOPTANTES();
            formulario.Show();
            this.Hide();
        }

        private void btnAdoptantes_Click_1(object sender, EventArgs e)
        {
            ADOPTANTES formulario = new ADOPTANTES();

            formulario.Show();

            this.Hide();

        }
    }
}