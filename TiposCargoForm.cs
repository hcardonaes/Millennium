using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class TiposCargoForm : Form
    {
        public TiposCargoForm()
        {
            InitializeComponent();
            CargarTiposDeCargos();
        }
        private void CargarTiposDeCargos()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Consulta para obtener los tipos de cargos
                    string query = "SELECT * FROM tipos_de_cargos";
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

        private void btnAgregarTipoDeCargo_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del tipo de cargo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tipos_de_cargos (nombre) VALUES (@nombre)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.ExecuteNonQuery();
                    }
                    // Recargar los tipos de cargos
                    CargarTiposDeCargos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el tipo de cargo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
 }

    

    



