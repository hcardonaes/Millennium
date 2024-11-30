using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class FormAgregarPersonaje : Form
    {
        public FormAgregarPersonaje()
        {
            InitializeComponent();

            // Valores por defecto para la fecha de nacimiento
            txtDiaNac.Text = "1";
            txtMesNac.Text = "1";
            txtAñoNac.Text = "1100";

            // Valores por defecto para la fecha de muerte (vacío por defecto)
            txtDiaMuerte.Text = "";
            txtMesMuerte.Text = "";
            txtAñoMuerte.Text = "";
        }


        private string ObtenerFechaValida(string dia, string mes, string anio)
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
                    return null;
                }
            }
            return null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que el campo nombre no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar fechas
            string fechaNacimiento = ObtenerFechaValida(txtDiaNac.Text, txtMesNac.Text, txtAñoNac.Text);
            string fechaMuerte = ObtenerFechaValida(txtDiaMuerte.Text, txtMesMuerte.Text, txtAñoMuerte.Text);

            if (fechaNacimiento == null)
            {
                MessageBox.Show("La fecha de nacimiento no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDiaMuerte.Text) && fechaMuerte == null)
            {
                MessageBox.Show("La fecha de muerte no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conexión a la base de datos SQLite
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para insertar un nuevo personaje
                    string query = "INSERT INTO personajes (nombre, apellido, mote, fecha_nacimiento, fecha_muerte, importancia, biografia) " +
                                   "VALUES (@nombre, @apellido, @mote, @fecha_nacimiento, @fecha_muerte, @importancia, @biografia)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Agregar parámetros
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@mote", txtMote.Text);
                        command.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                        command.Parameters.AddWithValue("@fecha_muerte", string.IsNullOrWhiteSpace(fechaMuerte) ? (object)DBNull.Value : fechaMuerte);
                        command.Parameters.AddWithValue("@importancia", nudImportancia.Value);
                        command.Parameters.AddWithValue("@biografia", txtBiografia.Text);

                        // Ejecutar el comando
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Personaje agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el personaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
