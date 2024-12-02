using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class SocialesForm : Form
    {
        public SocialesForm()
        {
            InitializeComponent();
            CargarPersonajes();
            CargarTipoRelacionSocial();
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

                        cmbPersonaje1.DataSource = dataTable.Copy();
                        cmbPersonaje1.DisplayMember = "nombre_completo";
                        cmbPersonaje1.ValueMember = "id";

                        cmbPersonaje2.DataSource = dataTable;
                        cmbPersonaje2.DisplayMember = "nombre_completo";
                        cmbPersonaje2.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarTipoRelacionSocial()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los tipos de parentesco
                    string query = "SELECT id, nombre FROM tipos_relaciones_sociopoliticas";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbRelSocial.DataSource = dataTable;
                        cmbRelSocial.DisplayMember = "nombre";
                        cmbRelSocial.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de relaciones sociales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarRelaciones()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener las relaciones
                    string query = "SELECT p1.nombre || ' ' || p1.apellido AS personaje1, " +
                                   "p2.nombre || ' ' || p2.apellido AS personaje2, " +
                                   "tp.nombre AS tipo_relacion, " +
                                   "lf.fecha_inicio, lf.fecha_fin " +
                                   "FROM relacionesSociopoliticas lf " +
                                   "JOIN personajes p1 ON lf.personaje_id1 = p1.id " +
                                   "JOIN personajes p2 ON lf.personaje_id2 = p2.id " +
                                   "JOIN tipos_relaciones_sociopoliticas tp ON lf.tipo_relacion_id = tp.id";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvRelacionesSociales.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las relaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarRelacion_Click(object sender, EventArgs e)
        {
            int personaje1 = Convert.ToInt32(cmbPersonaje1.SelectedValue);
            int personaje2 = Convert.ToInt32(cmbPersonaje2.SelectedValue);
            int tipoRelacion = Convert.ToInt32(cmbRelSocial.SelectedValue);
            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            if (personaje1 == personaje2)
            {
                MessageBox.Show("No se puede establecer una relación con el mismo personaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (fechaInicio == null)
            //{
            //    MessageBox.Show("La fecha de inicio no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Obtener la relación recíproca
                    string reciproca = null;
                    string queryReciproca = "SELECT reciproca FROM tipos_relaciones_sociopoliticas WHERE id = @tipoRelacion";
                    using (SQLiteCommand command = new SQLiteCommand(queryReciproca, connection))
                    {
                        command.Parameters.AddWithValue("@tipoRelacion", tipoRelacion);
                        reciproca = command.ExecuteScalar()?.ToString();
                    }

                    if (reciproca == null)
                    {
                        MessageBox.Show("No se pudo determinar la relación recíproca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insertar la relación directa
                    string queryDirecta = "INSERT INTO relacionesSociopoliticas (personaje_id1, tipo_relacion_id, personaje_id2, fecha_inicio, fecha_fin) " +
                                          "VALUES (@id1, @tipoRelacion, @id2, @fechaInicio, @fechaFin)";
                    using (SQLiteCommand command = new SQLiteCommand(queryDirecta, connection))
                    {
                        command.Parameters.AddWithValue("@id1", personaje1);
                        command.Parameters.AddWithValue("@tipoRelacion", tipoRelacion);
                        command.Parameters.AddWithValue("@id2", personaje2);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(fechaFin) ? (object)DBNull.Value : fechaFin);
                        command.ExecuteNonQuery();
                    }

                    // Insertar la relación recíproca
                    string queryReciprocaInsert = "INSERT INTO relacionesSociopoliticas (personaje_id1, tipo_relacion_id, personaje_id2, fecha_inicio, fecha_fin) " +
                                                  "VALUES (@id2, (SELECT id FROM tipos_relaciones_sociopoliticas WHERE nombre = @reciproca), @id1, @fechaInicio, @fechaFin)";
                    using (SQLiteCommand command = new SQLiteCommand(queryReciprocaInsert, connection))
                    {
                        command.Parameters.AddWithValue("@id1", personaje1);
                        command.Parameters.AddWithValue("@id2", personaje2);
                        command.Parameters.AddWithValue("@reciproca", reciproca);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(fechaFin) ? (object)DBNull.Value : fechaFin);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Relación agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarRelaciones();
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

    }
}