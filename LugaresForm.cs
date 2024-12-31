using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class LugaresForm : Form
    {
        public event EventHandler LugarAñadido;
        public LugaresForm()
        {
            InitializeComponent();
            CargarLugares();
        }

        private void CargarLugares()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los datos de la tabla lugares
                    string query = "SELECT * FROM lugares";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dgvLugares.DataSource = dataTable;
                        // Formatear columnas
                        FormatearColumnas();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los lugares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormatearColumnas()
        {
            if (dgvLugares.Columns["latitud"] != null)
            {
                dgvLugares.Columns["latitud"].DefaultCellStyle.Format = "N6"; // Formato de 6 decimales
            }

            if (dgvLugares.Columns["longitud"] != null)
            {
                dgvLugares.Columns["longitud"].DefaultCellStyle.Format = "N6"; // Formato de 6 decimales
            }
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            double latitud = string.IsNullOrWhiteSpace(txtLatitud.Text) ? 0 : Convert.ToDouble(txtLatitud.Text);
            double longitud = string.IsNullOrWhiteSpace(txtLongitud.Text) ? 0 : Convert.ToDouble(txtLongitud.Text);

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar el lugar en la tabla
                    string query = "INSERT INTO lugares (nombre, latitud, longitud, descripcion) VALUES (@nombre, @latitud, @longitud, @descripcion)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@latitud", latitud);
                        command.Parameters.AddWithValue("@longitud", longitud);
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lugar agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LugarAñadido?.Invoke(this, EventArgs.Empty);
                    CargarLugares();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el lugar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            double latitud = string.IsNullOrWhiteSpace(txtLatitud.Text) ? 0 : Convert.ToDouble(txtLatitud.Text);
            double longitud = string.IsNullOrWhiteSpace(txtLongitud.Text) ? 0 : Convert.ToDouble(txtLongitud.Text);

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Actualizar el lugar
                    string query = "UPDATE lugares SET nombre = @nombre, latitud = @latitud, longitud = @longitud, descripcion = @descripcion WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@latitud", latitud);
                        command.Parameters.AddWithValue("@longitud", longitud);
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lugar actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarLugares();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el lugar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgvLugares.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString(); // Columna 0: id
                txtNombre.Text = row.Cells[1].Value.ToString(); // Columna 1: nombre
                txtLatitud.Text = row.Cells[2].Value != DBNull.Value ? row.Cells[2].Value.ToString() : ""; // Columna 2: latitud
                txtLongitud.Text = row.Cells[3].Value != DBNull.Value ? row.Cells[3].Value.ToString() : ""; // Columna 3: longitud
                txtDescripcion.Text = row.Cells[4].Value != DBNull.Value ? row.Cells[4].Value.ToString() : ""; // Columna 4: descripcion
            }
        }

    }
}
