using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class EventosForm : Form
    {
        public EventosForm()
        {
            InitializeComponent();
            CargarEventos();
            CargarLugares();
        }

        private void CargarEventos()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los datos de la tabla eventos
                    string query = "SELECT e.id, e.nombre, e.fecha_inicio, e.fecha_fin, l.nombre AS lugar, e.descripcion " +
                                   "FROM eventos e " +
                                   "LEFT JOIN lugares l ON e.lugar_id = l.id";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvEventos.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarLugares()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los lugares
                    string query = "SELECT id, nombre FROM lugares";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbLugar.DataSource = dataTable;
                        cmbLugar.DisplayMember = "nombre";
                        cmbLugar.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los lugares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarEvento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);
            int lugarId = Convert.ToInt32(cmbLugar.SelectedValue);
            string descripcion = txtDescripcion.Text;

            if (fechaInicio == null || fechaFin == null)
            {
                MessageBox.Show("Las fechas no son válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar el evento
                    string query = "INSERT INTO eventos (nombre, fecha_inicio, fecha_fin, lugar_id, descripcion) " +
                                   "VALUES (@nombre, @fechaInicio, @fechaFin, @lugarId, @descripcion)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@lugarId", lugarId);
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Evento agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEventos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FormatearFecha(string dia, string mes, string anio)
        {
            if (int.TryParse(dia, out int d) && int.TryParse(mes, out int m) && int.TryParse(anio, out int y))
            {
                try
                {
                    DateTime fecha = new DateTime(y, m, d);
                    return $"{y:D4}-{m:D2}-{d:D2}";
                }
                catch
                {
                    return null; // Fecha no válida
                }
            }
            return null;
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carga comboBox y testBoxes con los valores del row seleccionado
            if (e.RowIndex >= 0 && e.RowIndex < dgvEventos.Rows.Count)
            {
                DataGridViewRow row = dgvEventos.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDiaInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "dia");
                txtMesInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "mes");
                txtAñoInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "anio");
                txtDiaFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "dia");
                txtMesFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "mes");
                txtAñoFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "anio");
                cmbLugar.SelectedValue = Convert.ToInt32(row.Cells["id"].Value);
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();

            }
        }

        private string ObtenerParteFecha(string fecha, string parte)
        {
            if (string.IsNullOrWhiteSpace(fecha)) return "";
            var partes = fecha.Split('-');
            return parte switch
            {
                "dia" => partes.Length > 2 ? partes[2] : "",
                "mes" => partes.Length > 1 ? partes[1] : "",
                "anio" => partes.Length > 0 ? partes[0] : "",
                _ => ""
            };
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
            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);
            int lugarId = Convert.ToInt32(cmbLugar.SelectedValue);
            string descripcion = txtDescripcion.Text;

            if (fechaInicio == null || fechaFin == null)
            {
                MessageBox.Show("Las fechas no son válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Actualizar el evento
                    string query = "UPDATE eventos SET nombre = @nombre, fecha_inicio = @fechaInicio, fecha_fin = @fechaFin, lugar_id = @lugarId, descripcion = @descripcion WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@lugarId", lugarId);
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Evento actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEventos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //carga comboBox y testBoxes con los valores del row seleccionado
            if (e.RowIndex >= 0 && e.RowIndex < dgvEventos.Rows.Count)
            {
                DataGridViewRow row = dgvEventos.Rows[e.RowIndex];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtNombre.Text = row.Cells["nombre"].Value.ToString();
                txtDiaInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "dia");
                txtMesInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "mes");
                txtAñoInicio.Text = ObtenerParteFecha(row.Cells["fecha_inicio"].Value.ToString(), "anio");
                txtDiaFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "dia");
                txtMesFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "mes");
                txtAñoFin.Text = ObtenerParteFecha(row.Cells["fecha_fin"].Value.ToString(), "anio");
                if (row.Cells["lugar"].Value != null)
                {
                    cmbLugar.SelectedValue = Convert.ToInt32(row.Cells["lugar"].Value);
                }
                else
                {
                    cmbLugar.SelectedValue = -1; // or any default value
                }
                txtDescripcion.Text = row.Cells["descripcion"].Value.ToString();
            }
        }

        private void btnAbrirLugaresForm_Click(object sender, EventArgs e)
        {
            LugaresForm lugaresForm = new LugaresForm();
            lugaresForm.LugarAñadido += LugaresForm_LugarAñadido;
            lugaresForm.Show();
        }

        private void LugaresForm_LugarAñadido(object sender, EventArgs e)
        {
            CargarLugares();
        }
    }
}
