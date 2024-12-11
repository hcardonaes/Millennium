using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class CargosPersonajeForm : Form
    {
        public CargosPersonajeForm()
        {
            InitializeComponent();
            CargarPersonajes();
            CargarInstituciones();
            CargarTiposDeCargo();
            CargarCargos();
        }

        private void CargarPersonajes()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener el personaje
                    string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM personajes";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbPersonaje.DataSource = dataTable.Copy();
                        cmbPersonaje.DisplayMember = "nombre_completo";
                        cmbPersonaje.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarInstituciones()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener las instituciones
                    string query = "SELECT id, nombre FROM instituciones";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbInstitucion.DataSource = dataTable;
                        cmbInstitucion.DisplayMember = "nombre";
                        cmbInstitucion.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las instituciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarTiposDeCargo()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los tipos de cargos
                    string query = "SELECT id, nombre FROM tipos_de_cargos";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbTiposDeCargos.DataSource = dataTable;
                        cmbTiposDeCargos.DisplayMember = "nombre";
                        cmbTiposDeCargos.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de cargos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarCargos()   // en el DtaGridView
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los cargos
                    string query = "SELECT p.nombre || ' ' || p.apellido AS personaje, i.nombre AS institucion, " +
                                   "tc.nombre AS tipo_cargo, c.fecha_inicio, c.fecha_fin " +
                                   "FROM cargos c " +
                                   "JOIN personajes p ON c.personaje_id = p.id " +
                                   "JOIN instituciones i ON c.institucion_id = i.id " +
                                   "JOIN tipos_de_cargos tc ON c.tipo_cargo_id = tc.id";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvCargos.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las relaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            int personaje1 = Convert.ToInt32(cmbPersonaje.SelectedValue);
            int institucion = Convert.ToInt32(cmbInstitucion.SelectedValue);
            int tipoCargo = Convert.ToInt32(cmbTiposDeCargos.SelectedValue);
            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar el cargo en la institución
                    string queryDirecta = "INSERT INTO cargos (personaje_id, institucion_id, tipo_cargo_id, fecha_inicio, fecha_fin) " +
                                          "VALUES (@id1, @id2, @tipoRelacion, @fechaInicio, @fechaFin)";
                    using (SQLiteCommand command = new SQLiteCommand(queryDirecta, connection))
                    {

                        command.Parameters.AddWithValue("@id1", personaje1);
                        command.Parameters.AddWithValue("@id2", institucion);
                        command.Parameters.AddWithValue("@tipoRelacion", tipoCargo);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(fechaFin) ? (object)DBNull.Value : fechaFin);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Relación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCargos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cargar datos de la fila seleccionada en los campos de texto para editar
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCargos.Rows[e.RowIndex];
                cmbPersonaje.Text = row.Cells["personaje"].Value.ToString();
                cmbInstitucion.Text = row.Cells["institucion"].Value.ToString();
                cmbTiposDeCargos.Text = row.Cells["tipo_cargo"].Value.ToString();
                //Si la fecha de inicio no es nula, cargarla en los campos de texto
                if (row.Cells["fecha_inicio"].Value != DBNull.Value)
                {
                    txtDiaInicio.Text = row.Cells["fecha_inicio"].Value.ToString().Substring(8, 2);
                    txtMesInicio.Text = row.Cells["fecha_inicio"].Value.ToString().Substring(5, 2);
                    txtAñoInicio.Text = row.Cells["fecha_inicio"].Value.ToString().Substring(0, 4);
                }

                if (row.Cells["fecha_fin"].Value != DBNull.Value)
                {
                    txtDiaFin.Text = row.Cells["fecha_fin"].Value.ToString().Substring(8, 2);
                    txtMesFin.Text = row.Cells["fecha_fin"].Value.ToString().Substring(5, 2);
                    txtAñoFin.Text = row.Cells["fecha_fin"].Value.ToString().Substring(0, 4);
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Actualizar la base de datos con los campos de texto de los boxes

            int personaje1 = Convert.ToInt32(cmbPersonaje.SelectedValue);
            int institucion = Convert.ToInt32(cmbInstitucion.SelectedValue);
            int tipoCargo = Convert.ToInt32(cmbTiposDeCargos.SelectedValue);
            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //Actualizar la relación en la base de datos
                    string query = "UPDATE cargos SET personaje_id = @id1, institucion_id = @id2, tipo_cargo_id = @tipoRelacion, fecha_inicio = @fechaInicio, fecha_fin = @fechaFin " +
                                   "WHERE personaje_id = @id1 AND institucion_id = @id2 AND tipo_cargo_id = @tipoRelacion";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id1", personaje1);
                        command.Parameters.AddWithValue("@id2", institucion);
                        command.Parameters.AddWithValue("@tipoRelacion", tipoCargo);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(fechaFin) ? (object)DBNull.Value : fechaFin);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Relación actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCargos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //    //Actualizar la relación seleccionada
            //    int personaje1 = Convert.ToInt32(cmbPersonaje.SelectedValue);
            //    int institucion = Convert.ToInt32(cmbInstitucion.SelectedValue);
            //    int tipoCargo = Convert.ToInt32(cmbTiposDeCargos.SelectedValue);
            //    string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            //    string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            //    string connectionString = "Data Source=Millennium.db;Version=3;";
            //    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            //    {
            //        try
            //        {
            //            connection.Open();
            //            //Actualizar la relación en la base de datos
            //            string query = "UPDATE cargos SET personaje_id = @id1, institucion_id = @id2, tipo_cargo_id = @tipoRelacion, fecha_inicio = @fechaInicio, fecha_fin = @fechaFin " +
            //                           "WHERE personaje_id = @id1 AND institucion_id = @id2 AND tipo_cargo_id = @tipoRelacion";
            //            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            //            {
            //                command.Parameters.AddWithValue("@id1", personaje1);
            //                command.Parameters.AddWithValue("@id2", institucion);
            //                command.Parameters.AddWithValue("@tipoRelacion", tipoCargo);
            //                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            //                command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(fechaFin) ? (object)DBNull.Value : fechaFin);
            //                command.ExecuteNonQuery();
            //            }
            //            MessageBox.Show("Relación actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            CargarCargos();
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error al actualizar la relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }
    }
}
