using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class TiposDeRol : Form
    {
        public TiposDeRol()
        {
            InitializeComponent();
            CargarTiposDeRol();

        }
        private void CargarTiposDeRol()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Consulta para obtener los tipos de roles
                    string query = "SELECT * FROM roles";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbTiposDeRoles.DataSource = dataTable;
                        cmbTiposDeRoles.DisplayMember = "nombre";
                        cmbTiposDeRoles.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarTipoDeRol_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del tipo de rol no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO roles (nombre) VALUES (@nombre)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.ExecuteNonQuery();
                    }
                    // Recargar los tipos de cargos
                    CargarTiposDeRol();
                    //mostrar mensaje de exito
                    MessageBox.Show("Tipo de rol agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //expandir el combobox
                    cmbTiposDeRoles.DroppedDown = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el tipo de rol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}







