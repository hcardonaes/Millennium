using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MillenniumApp
{
    public partial class FormEditarPersonaje : Form
    {
        private int personajeId;
        public EventHandler DatosModificados;

        public FormEditarPersonaje(int id)
        {
            InitializeComponent();
            personajeId = id;
            CargarDatosPersonaje();
        }

        private void CargarDatosPersonaje()
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta para obtener los datos del personaje
                    string query = "SELECT * FROM personajes WHERE id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personajeId);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtMote.Text = reader["mote"].ToString();
                                txtDiaNac.Text = ObtenerParteFecha(reader["fecha_nacimiento"].ToString(), "dia");
                                txtMesNac.Text = ObtenerParteFecha(reader["fecha_nacimiento"].ToString(), "mes");
                                txtAñoNac.Text = ObtenerParteFecha(reader["fecha_nacimiento"].ToString(), "anio");
                                txtDiaMuerte.Text = ObtenerParteFecha(reader["fecha_muerte"].ToString(), "dia");
                                txtMesMuerte.Text = ObtenerParteFecha(reader["fecha_muerte"].ToString(), "mes");
                                txtAñoMuerte.Text = ObtenerParteFecha(reader["fecha_muerte"].ToString(), "anio");
                                nudImportancia.Value = Convert.ToDecimal(reader["importancia"]);
                                txtBiografia.Text = reader["biografia"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del personaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Millennium.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Actualizar los datos del personaje
                    string query = "UPDATE personajes SET nombre = @nombre, apellido = @apellido, mote = @mote, " +
                                   "fecha_nacimiento = @fecha_nacimiento, fecha_muerte = @fecha_muerte, importancia = @importancia, " +
                                   "biografia = @biografia WHERE id = @id";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", personajeId);
                        command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        command.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        command.Parameters.AddWithValue("@mote", txtMote.Text);
                        command.Parameters.AddWithValue("@fecha_nacimiento", FormatearFecha(txtDiaNac.Text, txtMesNac.Text, txtAñoNac.Text));
                        command.Parameters.AddWithValue("@fecha_muerte", FormatearFecha(txtDiaMuerte.Text, txtMesMuerte.Text, txtAñoMuerte.Text));
                        command.Parameters.AddWithValue("@importancia", nudImportancia.Value);
                        command.Parameters.AddWithValue("@biografia", txtBiografia.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Personaje actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el personaje: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            DatosModificados?.Invoke(this, EventArgs.Empty);

        }

        private string ObtenerParteFecha(string fecha, string parte)
        {
            if (string.IsNullOrWhiteSpace(fecha)) return "";
            var partes = fecha.Split('-');
            return parte switch
            {
                "dia" => partes.Length > 2 ? partes[2] : "",
                "mes" => partes.Length > 1 ? partes[1] : "",
                "anio" => partes.Length > 0 ? partes[0] : "",
                _ => ""
            };
        }

        private string FormatearFecha(string dia, string mes, string anio)
        {
            if (int.TryParse(dia, out int d) && int.TryParse(mes, out int m) && int.TryParse(anio, out int y))
            {
                return $"{y:D4}-{m:D2}-{d:D2}";
            }
            return null;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
