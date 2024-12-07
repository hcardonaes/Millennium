using Millennium;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Millennium
{
    public partial class RolesForm : Form
    {
        public RolesForm()
        {
            InitializeComponent();
            CargarPersonajes();
            CargarRoles();
            CargarEventos();
            CargarRolesAsignados();
            // Valores por defecto para las fechas de inicio y fin
            //txtDiaInicio.Text = "1";
            //txtMesInicio.Text = "1";
            //txtAñoInicio.Text = "1";

            //txtDiaFin.Text = "1";
            //txtMesFin.Text = "1";
            //txtAñoFin.Text = "1";

        }

        private void CargarPersonajes()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM personajes";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbPersonaje.DataSource = dataTable;
                        cmbPersonaje.DisplayMember = "nombre_completo";
                        cmbPersonaje.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarRoles()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, nombre FROM roles";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbRol.DataSource = dataTable;
                        cmbRol.DisplayMember = "nombre";
                        cmbRol.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarEventos()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, nombre || ' (' || fecha_inicio || ')' AS nombre_evento FROM eventos";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbEvento.DataSource = dataTable;
                        cmbEvento.DisplayMember = "nombre_evento";
                        cmbEvento.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            if (cmbPersonaje.SelectedValue == null || cmbRol.SelectedValue == null || cmbEvento.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un personaje, un rol y un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personajeId = Convert.ToInt32(cmbPersonaje.SelectedValue);
            int rolId = Convert.ToInt32(cmbRol.SelectedValue);
            int eventoId = Convert.ToInt32(cmbEvento.SelectedValue);

            string fechaInicio = FormatearFecha(txtDiaInicio.Text, txtMesInicio.Text, txtAñoInicio.Text);
            string fechaFin = FormatearFecha(txtDiaFin.Text, txtMesFin.Text, txtAñoFin.Text);

            if (fechaInicio == null || fechaFin == null)
            {
                MessageBox.Show("Por favor, ingresa fechas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO rolPersonajes (personaje_id, rol_id, evento_id, fecha_inicio, fecha_fin) " +
                                   "VALUES (@personajeId, @rolId, @eventoId, @fechaInicio, @fechaFin)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personajeId", personajeId);
                        command.Parameters.AddWithValue("@rolId", rolId);
                        command.Parameters.AddWithValue("@eventoId", eventoId);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Rol asignado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar el DataGridView
                    CargarRolesAsignados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al asignar rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarRolesAsignados()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT rp.id, " +
                                   "       p.nombre || ' ' || p.apellido AS personaje, " +
                                   "       r.nombre AS rol, " +
                                   "       e.nombre AS evento, " +
                                   "       rp.fecha_inicio, rp.fecha_fin " +
                                   "FROM rolPersonajes rp " +
                                   "JOIN personajes p ON rp.personaje_id = p.id " +
                                   "JOIN roles r ON rp.rol_id = r.id " +
                                   "JOIN eventos e ON rp.evento_id = e.id";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvRoles.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar roles asignados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
