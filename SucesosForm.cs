using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Millennium
{
    public partial class SucesosForm : Form
    {
        public SucesosForm()
        {
            InitializeComponent();
        }

        private void SucesosForm_Load(object sender, EventArgs e)
        {
            CargarDatosSucesos();
        }

        private void CargarDatosSucesos()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los datos de la tabla eventos_protagonistas
                    string query = "SELECT * FROM protagonismos_de_eventos";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar los datos al DataGridView
                        dgvSucesos.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
