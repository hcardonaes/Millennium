using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Millennium
{
    public partial class ProtagonistasForm : Form
    {
        public ProtagonistasForm()
        {
            InitializeComponent();
            CargarPersonajes();
            CargarEventos();
            CargarProtagonistas();
            CargarRoles();

        }

        private void CargarProtagonistas()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener eventos, personajes, roles y descripciones
                    string query = "SELECT ep.id, " +
                                   "       p.nombre || ' ' || p.apellido AS protagonista, " +
                                   "       r.nombre AS rol, " +
                                   "       e.nombre AS evento, " +
                                   "       ep.descripcion " +
                                   "FROM protagonismos_de_eventos ep " +
                                   "JOIN eventos e ON ep.evento_id = e.id " +
                                   "JOIN personajes p ON ep.personaje_id = p.id " +
                                   "JOIN roles r ON ep.rol_id = r.id";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgvProtagonistas.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los protagonistas y eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProtagonista_Click(object sender, EventArgs e)
        {
            // Validar selección de evento desde el DataGridView
            if (dgvEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un evento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar selección de personaje desde el ComboBox
            if (cmbPersonaje.SelectedValue == null || !int.TryParse(cmbPersonaje.SelectedValue.ToString(), out int personajeId))
            {
                MessageBox.Show("Por favor, selecciona un protagonista válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbRol.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecciona un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar rol de protagonista desde el ComboBox
            //if (cmbRol.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Por favor, selecciona un rol válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            // Obtener el ID del evento seleccionado desde el DataGridView
            int eventoId = Convert.ToInt32(dgvEventos.SelectedRows[0].Cells["id"].Value);

            // Obtener la descripción opcional
            string descripcion = txtDescripcionProtagonista.Text?.Trim();
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                descripcion = null; // Manejar descripción opcional como nula
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar el protagonista en la tabla intermedia
                    string query = "INSERT INTO protagonismos_de_eventos (evento_id, rol_id, personaje_id, descripcion) " +
                                   "VALUES (@eventoId, @rolId, @personajeId, @descripcion)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personajeId", personajeId);
                        command.Parameters.AddWithValue("@rolId", cmbRol.SelectedValue); // ID del rol de protagonista
                        command.Parameters.AddWithValue("@eventoId", eventoId);
                        command.Parameters.AddWithValue("@descripcion", descripcion ?? (object)DBNull.Value);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Protagonista agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recargar la lista de protagonistas del evento seleccionado
                    CargarProtagonistas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el protagonista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                        cmbPersonaje.DataSource = dataTable;
                        cmbPersonaje.DisplayMember = "nombre_completo"; // Columna que se muestra en el ComboBox
                        cmbPersonaje.ValueMember = "id"; // Valor asociado al elemento
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los personajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    // Consulta para obtener los roles
                    string query = "SELECT id, nombre FROM roles";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbRol.DataSource = dataTable;
                        cmbRol.DisplayMember = "nombre"; // Columna que se muestra en el ComboBox
                        cmbRol.ValueMember = "id"; // Valor asociado al elemento
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarEventos(string filtro = "")
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta base para obtener los eventos
                    string query = "SELECT e.id, e.nombre, e.fecha_inicio, e.fecha_fin, l.nombre AS lugar, e.descripcion " +
                                   "FROM eventos e " +
                                   "LEFT JOIN lugares l ON e.lugar_id = l.id";

                    // Aplicar filtro si es necesario
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        query += " WHERE e.nombre LIKE @filtro OR e.descripcion LIKE @filtro";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            command.Parameters.AddWithValue("@filtro", $"%{filtro}%");
                        }

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgvEventos.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los eventos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscarEvento_TextChanged(object sender, EventArgs e)
        {
            // Recargar los eventos aplicando el filtro ingresado
            string filtro = txtBuscarEvento.Text.Trim();
            CargarEventos(filtro);
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener el ID del evento seleccionado
                int eventoId = Convert.ToInt32(dgvEventos.Rows[e.RowIndex].Cells["id"].Value);

                // Cargar datos adicionales o realizar acciones
                MessageBox.Show($"Evento seleccionado: {eventoId}");
            }
        }

}
}
