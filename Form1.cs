using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatosPersonajes();
        }

        private void CargarDatosPersonajes()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los datos de la tabla personajes
                    string query = "SELECT * FROM personajes";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dgvPersonajes.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPersonajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que la fila seleccionada es válida
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dgvPersonajes.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value); // Usamos la columna "id" como identificador único

                // Abrir el formulario de edición
                FormEditarPersonaje formEditar = new FormEditarPersonaje(id);
                formEditar.ShowDialog();

                // Recargar los datos después de editar un personaje
                CargarDatosPersonajes();
            }
        }

        private void btnAgregarPersonaje_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de agregar personaje
            FormAgregarPersonaje formAgregar = new FormAgregarPersonaje();
            formAgregar.ShowDialog();

            // Recargar los datos después de agregar un personaje
            CargarDatosPersonajes();
        }

        private void btnFamiliasForm_Click(object sender, EventArgs e)
        {
            // Crear una instancia de FamiliasForm
            FamiliasForm familiasForm = new FamiliasForm();
            familiasForm.ShowDialog();
        }

    }
}
