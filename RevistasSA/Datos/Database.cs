using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RevistasSA.Datos
{
    public class Database
    {
        public SQLiteConnection cn;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter adaptador;

        public Database()
        {

            string dbPath = "RevistasSA.db";
            //MessageBox.Show(dbPath);
            cn = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            AbrirConexion();
        }

        // Método para abrir la conexión
        private void AbrirConexion()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No se pudo conectar a la base de datos: " + ex.ToString());
            }
        }

        // Método para cerrar la conexión
        private void CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public void InsertarCliente(string nombre, string apellido, string direccion, string telefono, string nit)
        {
            string consulta = "INSERT INTO Cliente (Nombre, Apellido, Direccion, Telefono, Nit) VALUES (@nombre, @apellido, @direccion, @telefono, @nit)";

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@nit", nit);
                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }

        public DataTable ObtenerDatosClientes()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT ClienteID, Nombre || ' ' || Apellido AS Nombre, Nit, Direccion, Telefono FROM Cliente";
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public void InsertarEmpleado(string nombre, string apellido, string telefono, string direccion)
        {
            string consulta = "INSERT INTO Empleado (Nombre, Apellido, Telefono, Direccion) VALUES (@nombre, @apellido, @telefono, @direccion)";

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }

        public DataTable ObtenerDatosEmpleados()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT EmpleadoId, CONCAT(Nombre, ' ', Apellido) AS Nombre, Telefono, Direccion FROM Empleado";
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public void InsertarRevista(string nombre, float precio, string categoria, string frecuencia)
        {
            string consulta = "INSERT INTO Revista (Nombre, Precio, Categoria, Frecuencia) VALUES (@nombre, @precio, @categoria, @frecuencia)";

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@frecuencia", frecuencia);
                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }

        public DataTable ObtenerDatosRevistas()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT * 
                                FROM Revista";
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public DataTable ObtenerDatosSuscripciones()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT s.SuscripcionID as ID, CONCAT(c.Nombre, ' ', c.Apellido) as Cliente, r.Nombre as Revista, s.FechaInicio, s.FechaFin, s.NumeroSuscripcion
                                FROM Suscripcion s
                                INNER JOIN Cliente c on s.ClienteID = c.ClienteID
                                INNER JOIN Revista r on s.RevistaID = r.RevistaID";
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public DataTable ObtenerDatosEntregas()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT e.EntregaID as ID, s.NumeroSuscripcion as Suscripcion, CONCAT(em.Nombre, ' ', em.Apellido) as Empleado, e.FechaProgramada, e.FechaEntrega, e.DireccionEntrega, e.TelefonoEntrega, e.Observaciones
                                FROM Entrega e
                                INNER JOIN Suscripcion s on e.SuscripcionID = s.SuscripcionID
                                INNER JOIN Empleado em on e.EmpleadoID = em.EmpleadoID
                                ";
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public void InsertarSuscripcion(int cliente, int revista, DateTime fechainicio, DateTime fechafin, string numerosuscripcion)
        {
            string consulta = "INSERT INTO Suscripcion (ClienteID, RevistaID, FechaInicio, FechaFin, NumeroSuscripcion) VALUES (@cliente, @revista, @fechainicio, @fechafin, @numerosuscripcion)";

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@revista", revista);
                cmd.Parameters.AddWithValue("@fechainicio", fechainicio);
                cmd.Parameters.AddWithValue("@fechafin", fechafin);
                cmd.Parameters.AddWithValue("@numerosuscripcion", numerosuscripcion);
                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }

        public int ObtenerUltimaSuscripcion()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT LAST_INSERT_ROWID() AS LastID"; // SQLite utiliza LAST_INSERT_ROWID para obtener el último ID insertado

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["LastID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la última suscripción: " + ex.ToString());
            }
            return 0;
        }

        public void InsertarEntrega(int suscripcion, int empleado, DateTime fechaProgramada, DateTime fechaEntrega, string direccion, string telefonoEntrega, string observaciones)
        {
            string consulta = "INSERT INTO Entrega (SuscripcionID, EmpleadoID, FechaProgramada, FechaEntrega, DireccionEntrega, TelefonoEntrega, Observaciones) VALUES (@suscripcion, @empleado, @fechaProgramada, @fechaEntrega, @direccion, @telefonoEntrega, @observaciones)";

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@suscripcion", suscripcion);
                cmd.Parameters.AddWithValue("@empleado", empleado);
                cmd.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefonoEntrega", telefonoEntrega ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@observaciones", observaciones ?? (object)DBNull.Value);
                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }

        public DataTable BuscarRevistas(string revista)
        {
            string consulta = "SELECT RevistaID, Nombre FROM Revista WHERE Nombre LIKE @Revista";
            DataTable dt = new DataTable();
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Revista", $"%{revista}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public DataTable BuscarCliente(string Cliente)
        {
            string consulta = "SELECT ClienteID, CONCAT(Nombre, ' ', Apellido) as Nombre, Nit, Direccion, Telefono " +
                                "FROM Cliente WHERE Nombre LIKE @Cliente OR Nit LIKE @Cliente";
            DataTable dt = new DataTable();
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Cliente", $"%{Cliente}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public DataTable BuscarEmpleado(string Empleado)
        {
            string consulta = "SELECT EmpleadoID, CONCAT(Nombre, ' ', Apellido) as Nombre, Telefono, Direccion " +
                                "FROM Empleado WHERE Nombre LIKE @Empleado";
            DataTable dt = new DataTable();
            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Empleado", $"%{Empleado}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }

        public void Dispose()
        {
            CerrarConexion();
        }
    }
}
