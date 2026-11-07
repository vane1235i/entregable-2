using Sistema_de_adopcion_de_mascotas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HUELLITAS
{
    public partial class Mascotas : Form
    {
        // Lista donde se guardarán las mascotas mientras el programa esté abierto.
        private BindingList<Mascota> listaMascotas =
            new BindingList<Mascota>();


        // CONEXION A SQL SERVER
        private string cadenaConexion =
            @"Data Source=localhost;Initial Catalog=Sistema de Adopcion;Integrated Security=True";

        public Mascotas()
        {
            InitializeComponent();

            // Configurar las opciones de los ComboBox.
            cmbEspecie.Items.AddRange(new string[]
            {
                "Perro",
                "Gato",
                "Conejo",
                "Ave",
                "Otro"
            });

            cmbEstado.Items.AddRange(new string[]
            {
                "Disponible",
                "Adoptado",
                "En tratamiento"
            });

            // Mostrar los registros en la tabla.
            dgvMascotas.AutoGenerateColumns = true;
            dgvMascotas.DataSource = listaMascotas;

            // Conectar los botones con sus funciones.
            btnGuardar.Click += btnGuardar_Click;
            btnActualizar.Click += btnActualizar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnInicio.Click += btnInicio_Click;

            // Al seleccionar una fila, mostrar sus datos.
            dgvMascotas.SelectionChanged += dgvMascotas_SelectionChanged;

            // Evitar que se modifiquen los datos directamente en la tabla.
            dgvMascotas.ReadOnly = true;
            dgvMascotas.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMascotas.MultiSelect = false;
            dgvMascotas.AllowUserToAddRows = false;
        }

        // Clase que representa a una mascota.
        public class Mascota
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Especie { get; set; }
            public string Raza { get; set; }
            public string Edad { get; set; }
            public string Estado { get; set; }
        }

        // BOTÓN GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "" ||
                txtNombre.Text.Trim() == "" ||
                cmbEspecie.Text.Trim() == "" ||
                txtRaza.Text.Trim() == "" ||
                txtEdad.Text.Trim() == "" ||
                cmbEstado.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Completa todos los campos antes de guardar.");

                return;
            }

            // Comprobar que el código no esté repetido.
            bool existe = listaMascotas.Any(m =>
                m.Codigo.Equals(
                    txtCodigo.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            if (existe)
            {
                MessageBox.Show("Ese código ya está registrado.");
                return;
            }

            Mascota nueva = new Mascota
            {
                Codigo = txtCodigo.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Especie = cmbEspecie.Text,
                Raza = txtRaza.Text.Trim(),
                Edad = txtEdad.Text.Trim(),
                Estado = cmbEstado.Text
            };

            listaMascotas.Add(nueva);

            MessageBox.Show("Mascota registrada correctamente.");

            LimpiarCampos();
        }

        // BOTÓN ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null ||
                dgvMascotas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Selecciona una mascota de la tabla.");

                return;
            }

            if (txtCodigo.Text.Trim() == "" ||
                txtNombre.Text.Trim() == "" ||
                cmbEspecie.Text.Trim() == "" ||
                txtRaza.Text.Trim() == "" ||
                txtEdad.Text.Trim() == "" ||
                cmbEstado.Text.Trim() == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            string codigo = txtCodigo.Text.Trim();

            Mascota mascota = listaMascotas.FirstOrDefault(m =>
                m.Codigo.Equals(
                    codigo,
                    StringComparison.OrdinalIgnoreCase));

            if (mascota == null)
            {
                MessageBox.Show(
                    "No se encontró la mascota que deseas actualizar.");

                return;
            }

            mascota.Nombre = txtNombre.Text.Trim();
            mascota.Especie = cmbEspecie.Text;
            mascota.Raza = txtRaza.Text.Trim();
            mascota.Edad = txtEdad.Text.Trim();
            mascota.Estado = cmbEstado.Text;

            // Actualizar la tabla.
            dgvMascotas.Refresh();

            MessageBox.Show("Mascota actualizada correctamente.");

            LimpiarCampos();
        }

        // BOTÓN ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null ||
                dgvMascotas.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Selecciona una mascota para eliminar.");

                return;
            }

            Mascota seleccionada =
                dgvMascotas.CurrentRow.DataBoundItem as Mascota;

            if (seleccionada == null)
            {
                MessageBox.Show("Selecciona una mascota válida.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar esta mascota?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                listaMascotas.Remove(seleccionada);

                MessageBox.Show("Mascota eliminada correctamente.");

                LimpiarCampos();
            }
        }

        // BOTÓN LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // FUNCIÓN PARA LIMPIAR LOS CAMPOS
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtRaza.Clear();
            txtEdad.Clear();

            cmbEspecie.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            dgvMascotas.ClearSelection();

            txtCodigo.Focus();
        }

        // BOTÓN BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (codigo == "" && nombre == "")
            {
                MessageBox.Show(
                    "Escribe el código o el nombre de la mascota.");

                return;
            }

            Mascota encontrada = listaMascotas.FirstOrDefault(m =>
                (codigo != "" &&
                 m.Codigo.Equals(
                     codigo,
                     StringComparison.OrdinalIgnoreCase))
                ||
                (nombre != "" &&
                 m.Nombre.IndexOf(
                     nombre,
                     StringComparison.OrdinalIgnoreCase) >= 0));

            if (encontrada == null)
            {
                MessageBox.Show("No se encontró ninguna mascota.");
                return;
            }

            txtCodigo.Text = encontrada.Codigo;
            txtNombre.Text = encontrada.Nombre;
            cmbEspecie.Text = encontrada.Especie;
            txtRaza.Text = encontrada.Raza;
            txtEdad.Text = encontrada.Edad;
            cmbEstado.Text = encontrada.Estado;

            // Seleccionar la mascota encontrada en la tabla.
            foreach (DataGridViewRow fila in dgvMascotas.Rows)
            {
                Mascota mascotaFila =
                    fila.DataBoundItem as Mascota;

                if (mascotaFila == encontrada)
                {
                    fila.Selected = true;
                    dgvMascotas.CurrentCell =
                        fila.Cells[0];

                    break;
                }
            }
        }

        // AL SELECCIONAR UNA MASCOTA EN LA TABLA
        private void dgvMascotas_SelectionChanged(
            object sender, EventArgs e)
        {
            if (dgvMascotas.CurrentRow == null ||
                dgvMascotas.CurrentRow.IsNewRow)
            {
                return;
            }

            Mascota seleccionada =
                dgvMascotas.CurrentRow.DataBoundItem as Mascota;

            if (seleccionada == null)
            {
                return;
            }

            txtCodigo.Text = seleccionada.Codigo;
            txtNombre.Text = seleccionada.Nombre;
            cmbEspecie.Text = seleccionada.Especie;
            txtRaza.Text = seleccionada.Raza;
            txtEdad.Text = seleccionada.Edad;
            cmbEstado.Text = seleccionada.Estado;
        }

        // BOTÓN INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();

            this.Hide();
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {

        }
    }
}