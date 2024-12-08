using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class TiposRelacionesPersonalesForm : Form
    {
        public TiposRelacionesPersonalesForm()
        {
            InitializeComponent();
            CargarTiposRelacionesPersonalesForm();

        }
        private void CargarTiposRelacionesPersonalesForm()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Consulta para obtener los tipos de roles
                    string query = "SELECT * FROM tipos_relaciones_personales";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbTiposDeRelacionesPersonales.DataSource = dataTable;
                        cmbTiposDeRelacionesPersonales.DisplayMember = "nombre";
                        cmbTiposDeRelacionesPersonales.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los tipos de relacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarTipoDeRol_Click(object sender, EventArgs e)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del tipo de relacion no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO tipos_relaciones_personales (nombre) VALUES (@nombre)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.ExecuteNonQuery();
                    }
                    // Recargar los tipos de cargos
                    CargarTiposRelacionesPersonalesForm();
                    //mostrar mensaje de exito
                    MessageBox.Show("Tipo de relacion agregado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //expandir el combobox
                    cmbTiposDeRelacionesPersonales.DroppedDown = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el tipo de relacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
