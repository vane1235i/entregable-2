using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sistema_de_adopcion_de_mascotas
{
    public partial class ADOPTANTES : Form
    {
        // CONEXION A SQL SERVER
        private string cadenaConexion =
            @"Data Source=localhost;Initial Catalog=Sistema de Adopcion;Integrated Security=True";

        public ADOPTANTES()
        {
            InitializeComponent();

            this.Load += ADOPTANTES_Load;

            dgvAdoptantes.CellClick += dgvAdoptantes_CellClick;
        }

        // CARGAR FORMULARIO
        private void ADOPTANTES_Load(object sender, EventArgs e)
        {
            MostrarAdoptantes();
        }

        // MOSTRAR REGISTROS
        private void MostrarAdoptantes()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    string consulta = "SELECT * FROM Adoptante";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(consulta, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgvAdoptantes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar adoptantes: " + ex.Message);
            }
        }

        // GUARDAR ADOPTANTE
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtIdAdoptante.Text, out id))
            {
                MessageBox.Show("Ingrese un ID numérico válido.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtApellidos.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Adoptante
                    (Id_Adoptante, Nombre, Apellidos, Telefono, Direccion)
                    VALUES
                    (@Id, @Nombre, @Apellidos, @Telefono, @Direccion)";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("¡Adoptante registrado correctamente!");

                LimpiarCampos();
                MostrarAdoptantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // BUSCAR ADOPTANTE
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtIdAdoptante.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido para buscar.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();

                    string consulta = @"SELECT * FROM Adoptante
                    WHERE Id_Adoptante = @Id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            txtNombre.Text = lector["Nombre"].ToString();
                            txtApellidos.Text = lector["Apellidos"].ToString();
                            txtTelefono.Text = lector["Telefono"].ToString();
                            txtDireccion.Text = lector["Direccion"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Adoptante no encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        // ACTUALIZAR ADOPTANTE
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtIdAdoptante.Text, out id))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            if (txtNombre.Text.Trim() == "" ||
                txtApellidos.Text.Trim() == "" ||
                txtTelefono.Text.Trim() == "" ||
                txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            try
            {
                int resultado;

                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();

                    string consulta = @"UPDATE Adoptante SET
                    Nombre = @Nombre,
                    Apellidos = @Apellidos,
                    Telefono = @Telefono,
                    Direccion = @Direccion
                    WHERE Id_Adoptante = @Id";

                    SqlCommand cmd = new SqlCommand(consulta, cn);

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellidos", txtApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());

                    resultado = cmd.ExecuteNonQuery();
                }

                if (resultado > 0)
                {
                    MessageBox.Show("Adoptante actualizado correctamente.");
                    LimpiarCampos();
                    MostrarAdoptantes();
                }
                else
                {
                    MessageBox.Show("No se encontró el adoptante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        // ELIMINAR ADOPTANTE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtIdAdoptante.Text, out id))
            {
                MessageBox.Show("Ingrese el ID del adoptante.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este adoptante?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    int resultado;

                    using (SqlConnection cn = new SqlConnection(cadenaConexion))
                    {
                        cn.Open();

                        string consulta = @"DELETE FROM Adoptante
                        WHERE Id_Adoptante = @Id";

                        SqlCommand cmd = new SqlCommand(consulta, cn);

                        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                        resultado = cmd.ExecuteNonQuery();
                    }

                    if (resultado > 0)
                    {
                        MessageBox.Show("Adoptante eliminado correctamente.");
                        LimpiarCampos();
                        MostrarAdoptantes();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el adoptante.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "No se pudo eliminar el adoptante. Puede tener adopciones relacionadas.\n" +
                        ex.Message
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        // LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtIdAdoptante.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            txtIdAdoptante.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // SELECCIONAR REGISTRO DE LA TABLA
        private void dgvAdoptantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAdoptantes.Rows[e.RowIndex];

                if (fila.Cells["Id_Adoptante"].Value != DBNull.Value)
                {
                    txtIdAdoptante.Text =
                        fila.Cells["Id_Adoptante"].Value.ToString();

                    txtNombre.Text =
                        fila.Cells["Nombre"].Value.ToString();

                    txtApellidos.Text =
                        fila.Cells["Apellidos"].Value.ToString();

                    txtTelefono.Text =
                        fila.Cells["Telefono"].Value.ToString();

                    txtDireccion.Text =
                        fila.Cells["Direccion"].Value.ToString();
                }
            }
        }

        // EVENTO ANTIGUO DEL DISEÑADOR
        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se conserva para evitar errores del diseñador.
        }

        // BOTON INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
    }
}


