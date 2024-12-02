using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Millennium
{
    public partial class RelacionesSociopoliticasForm : Form
    {
        public RelacionesSociopoliticasForm()
        {
            InitializeComponent();
            CargarPersonajes();
            CargarTiposDeRelacion();
            CargarRelaciones();

        }

        private void CargarPersonajes()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los personajes
                    string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM personajes";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dgvPersonajes.DataSource = dataTable;

                        // Configurar el DataGridView para mostrar nombres completos
                        dgvPersonajes.Columns["id"].HeaderText = "ID";
                        dgvPersonajes.Columns["id"].Width = 50;
                        dgvPersonajes.Columns["nombre_completo"].HeaderText = "Nombre Completo";
                        dgvPersonajes.Columns["nombre_completo"].Width = 200;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarTiposDeRelacion()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los tipos de relación
                    string query = "SELECT id, nombre FROM tipos_relaciones_sociopoliticas";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbTipoRelacion.DataSource = dataTable;
                        cmbTipoRelacion.DisplayMember = "nombre"; // Mostrar nombre
                        cmbTipoRelacion.ValueMember = "id"; // Usar ID como valor
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void btnAgregarRelacion_Click(object sender, EventArgs e)
        //{
        //    // Validar selección de personajes
        //    if (dgvPersonajes.SelectedRows.Count < 2)
        //    {
        //        MessageBox.Show("Por favor, selecciona dos personajes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Validar selección de tipo de relación
        //    if (cmbTipoRelacion.SelectedValue == null || !int.TryParse(cmbTipoRelacion.SelectedValue.ToString(), out int tipoRelacionId))
        //    {
        //        MessageBox.Show("Por favor, selecciona un tipo de relación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Obtener IDs de los personajes seleccionados
        //    int personajeId1 = Convert.ToInt32(dgvPersonajes.SelectedRows[0].Cells["id"].Value);
        //    int personajeId2 = Convert.ToInt32(dgvPersonajes.SelectedRows[1].Cells["id"].Value);

        //    // Validar que los personajes no sean iguales
        //    if (personajeId1 == personajeId2)
        //    {
        //        MessageBox.Show("No se puede establecer una relación entre el mismo personaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Obtener fechas
        //    string fechaInicio = FormatearFechaHistorica(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
        //    string fechaFin = FormatearFechaHistorica(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

        //    if (fechaInicio == null || fechaFin == null)
        //    {
        //        MessageBox.Show("Por favor, ingresa fechas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    string connectionString = "Data Source=Millennium.db;Version=3;";
        //    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            // Insertar relación directa
        //            string queryDirecta = "INSERT INTO relacionesSociopoliticas (personaje_id1, personaje_id2, tipo_relacion_id, fecha_inicio, fecha_fin) " +
        //                                  "VALUES (@id1, @id2, @tipoRelacion, @fechaInicio, @fechaFin)";
        //            using (SQLiteCommand command = new SQLiteCommand(queryDirecta, connection))
        //            {
        //                command.Parameters.AddWithValue("@id1", personajeId1);
        //                command.Parameters.AddWithValue("@id2", personajeId2);
        //                command.Parameters.AddWithValue("@tipoRelacion", tipoRelacionId);
        //                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
        //                command.Parameters.AddWithValue("@fechaFin", fechaFin);
        //                command.ExecuteNonQuery();
        //            }

        //            // Insertar relación recíproca si aplica
        //            string queryReciproca = "SELECT reciproca FROM tipos_relaciones_sociopoliticas WHERE id = @tipoRelacion";
        //            using (SQLiteCommand commandReciproca = new SQLiteCommand(queryReciproca, connection))
        //            {
        //                commandReciproca.Parameters.AddWithValue("@tipoRelacion", tipoRelacionId);
        //                string tipoReciproca = commandReciproca.ExecuteScalar()?.ToString();

        //                if (!string.IsNullOrEmpty(tipoReciproca))
        //                {
        //                    string queryInsertReciproca = "INSERT INTO relacionesSociopoliticas (personaje_id1, personaje_id2, tipo_relacion_id, fecha_inicio, fecha_fin) " +
        //                                                  "VALUES (@id2, @id1, (SELECT id FROM tipos_relaciones_sociopoliticas WHERE nombre = @tipoReciproca), @fechaInicio, @fechaFin)";
        //                    using (SQLiteCommand commandInsertReciproca = new SQLiteCommand(queryInsertReciproca, connection))
        //                    {
        //                        commandInsertReciproca.Parameters.AddWithValue("@id1", personajeId1);
        //                        commandInsertReciproca.Parameters.AddWithValue("@id2", personajeId2);
        //                        commandInsertReciproca.Parameters.AddWithValue("@tipoReciproca", tipoReciproca);
        //                        commandInsertReciproca.Parameters.AddWithValue("@fechaInicio", fechaInicio);
        //                        commandInsertReciproca.Parameters.AddWithValue("@fechaFin", fechaFin);
        //                        commandInsertReciproca.ExecuteNonQuery();
        //                    }
        //                }
        //            }

        //            MessageBox.Show("Relación sociopolítica agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Recargar relaciones
        //            CargarRelaciones();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error al agregar la relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void CargarRelaciones()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para cargar relaciones
                    string query = "SELECT rs.id, " +
                                   "       p1.nombre || ' ' || p1.apellido AS personaje1, " +
                                   "       p2.nombre || ' ' || p2.apellido AS personaje2, " +
                                   "       tr.nombre AS tipo_relacion, " +
                                   "       rs.fecha_inicio, rs.fecha_fin " +
                                   "FROM relacionesSociopoliticas rs " +
                                   "JOIN personajes p1 ON rs.personaje_id1 = p1.id " +
                                   "JOIN personajes p2 ON rs.personaje_id2 = p2.id " +
                                   "JOIN tipos_relaciones_sociopoliticas tr ON rs.tipo_relacion_id = tr.id";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvRelaciones.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las relaciones sociopolíticas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FormatearFechaHistorica(string dia, string mes, string anio)
        {
            // Validar que día, mes y año son enteros
            if (int.TryParse(dia, out int d) && int.TryParse(mes, out int m) && int.TryParse(anio, out int y))
            {
                // Validar rango de día y mes
                if (m < 1 || m > 12 || d < 1 || d > 31)
                {
                    return null; // Mes o día inválido
                }

                // Validar el rango de días permitidos según el mes (y año bisiesto si es aplicable)
                bool esBisiesto = (y > 0 && y % 4 == 0 && (y % 100 != 0 || y % 400 == 0));
                int[] diasPorMes = { 31, (esBisiesto ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                if (d > diasPorMes[m - 1])
                {
                    return null; // Día fuera de rango para el mes especificado
                }

                // Construir la fecha en formato personalizado
                string fechaFormateada = $"{(y < 0 ? "-" : "")}{Math.Abs(y):D4}-{m:D2}-{d:D2}";
                return fechaFormateada;
            }

            // Si la validación falla, devolver null
            return null;
        }

        private void btnAgregarRelacion_Click(object sender, EventArgs e)
        {
            // Validar que se han seleccionado exactamente dos filas
            if (dgvPersonajes.SelectedRows.Count != 2)
            {
                MessageBox.Show("Por favor, selecciona exactamente dos personajes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los IDs de los personajes seleccionados en el orden en que se seleccionaron
            var filasSeleccionadas = dgvPersonajes.SelectedRows;
            int personajeId1 = Convert.ToInt32(filasSeleccionadas[0].Cells["id"].Value);
            int personajeId2 = Convert.ToInt32(filasSeleccionadas[1].Cells["id"].Value);

            // Validar que los personajes son diferentes
            if (personajeId1 == personajeId2)
            {
                MessageBox.Show("No puedes seleccionar el mismo personaje dos veces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener el tipo de relación y las fechas
            int tipoRelacionId = Convert.ToInt32(cmbTipoRelacion.SelectedValue);
            string fechaInicio = FormatearFechaHistorica(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFechaHistorica(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            if (fechaInicio == null || fechaFin == null)
            {
                MessageBox.Show("Por favor, ingresa fechas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lógica para guardar la relación en la base de datos
            AgregarRelacion(personajeId1, personajeId2, tipoRelacionId, fechaInicio, fechaFin);
        }

        private void AgregarRelacion(int personajeId1, int personajeId2, int tipoRelacionId, string fechaInicio, string fechaFin)
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar relación directa
                    string queryDirecta = "INSERT INTO relacionesSociopoliticas (personaje_id1, personaje_id2, tipo_relacion_id, fecha_inicio, fecha_fin) " +
                                          "VALUES (@id1, @id2, @tipoRelacion, @fechaInicio, @fechaFin)";
                    using (SQLiteCommand command = new SQLiteCommand(queryDirecta, connection))
                    {
                        command.Parameters.AddWithValue("@id1", personajeId1);
                        command.Parameters.AddWithValue("@id2", personajeId2);
                        command.Parameters.AddWithValue("@tipoRelacion", tipoRelacionId);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.ExecuteNonQuery();
                    }

                    // Insertar relación recíproca si aplica
                    string queryReciproca = "SELECT reciproca FROM tipos_relaciones_sociopoliticas WHERE id = @tipoRelacion";
                    using (SQLiteCommand commandReciproca = new SQLiteCommand(queryReciproca, connection))
                    {
                        commandReciproca.Parameters.AddWithValue("@tipoRelacion", tipoRelacionId);
                        string tipoReciproca = commandReciproca.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(tipoReciproca))
                        {
                            string queryInsertReciproca = "INSERT INTO relacionesSociopoliticas (personaje_id1, personaje_id2, tipo_relacion_id, fecha_inicio, fecha_fin) " +
                                                          "VALUES (@id2, @id1, (SELECT id FROM tipos_relaciones_sociopoliticas WHERE nombre = @tipoReciproca), @fechaInicio, @fechaFin)";
                            using (SQLiteCommand commandInsertReciproca = new SQLiteCommand(queryInsertReciproca, connection))
                            {
                                commandInsertReciproca.Parameters.AddWithValue("@id1", personajeId1);
                                commandInsertReciproca.Parameters.AddWithValue("@id2", personajeId2);
                                commandInsertReciproca.Parameters.AddWithValue("@tipoReciproca", tipoReciproca);
                                commandInsertReciproca.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                                commandInsertReciproca.Parameters.AddWithValue("@fechaFin", fechaFin);
                                commandInsertReciproca.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Relación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar el DataGridView de relaciones
                    CargarRelaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la relación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
