using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevistasSA.Datos
{
    public class Database
    {
        public SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter adaptador;
        DataSet ds;


        public Database()
        {

            cn = new SqlConnection("Data Source=DESKTOP-3JLMI6L;Initial Catalog=RevistasSA;Integrated Security=True");
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
                cmd = new SqlCommand(consulta, cn);
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
            string consulta = "SELECT ClienteID, CONCAT(Nombre, ' ', Apellido) as Nombre, Nit, Direccion, Telefono FROM Cliente";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
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
            string consulta = "INSERT INTO Empleado (Nombre, Apellido, Telefono, Direccion) VALUES (@nombre, @apellido,  @telefono, @direccion)";

            try
            {
                cmd = new SqlCommand(consulta, cn);
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
            string consulta = "SELECT * FROM Empleado";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
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
            string consulta = "INSERT INTO Revista (Nombre, precio, categoria, frecuencia) VALUES (@nombre, @precio,  @categoria, @frecuencia)";

            try
            {
                cmd = new SqlCommand(consulta, cn);
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
            string consulta = "SELECT * FROM Revista";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
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
            string consulta = "SELECT * FROM Suscripcion";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
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
            string consulta = "SELECT * FROM Entrega";
            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
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
                cmd = new SqlCommand(consulta, cn);

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


        public int ObtenerUltimaSuscripcion()  // Cambia a int? para manejar el caso de que no se encuentre ninguna suscripción
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT TOP 1 SuscripcionID FROM Suscripcion ORDER BY SuscripcionID DESC"; // Solo selecciona SuscripcionID

            try
            {
                cmd = new SqlCommand(consulta, cn);
                adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Devuelve el SuscripcionID de la primera fila
                    return Convert.ToInt32(dt.Rows[0]["SuscripcionID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
            return 0;
        }



        public void InsertarEntrega(int suscripcion, int empleado, DateTime fechaProgramada, DateTime fechaEntrega, string direccion, string telefonoEntrega, string observaciones)
        {
            string consulta = "INSERT INTO Entrega (SuscripcionID, EmpleadoID, FechaProgramada, FechaEntrega, DireccionEntrega, TelefonoEntrega, Observaciones) VALUES (@suscripcion, @empleado, @fechaProgramada, @fechaEntrega, @direccion, @telefonoEntrega, @observaciones)";

            try
            {
                cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@suscripcion", suscripcion);
                cmd.Parameters.AddWithValue("@empleado", empleado);
                cmd.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefonoEntrega", telefonoEntrega ?? (object)DBNull.Value);  // Handle nullable phone number
                cmd.Parameters.AddWithValue("@observaciones", observaciones ?? (object)DBNull.Value);  // Handle nullable observations

                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.ToString());
            }
        }


        public DataTable BuscarRevistas(string revista)
        {
            string consulta = "SELECT RevistaID, Nombre " +
                            "FROM Revista WHERE Nombre LIKE @Revista";

            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Revista", $"%{revista}%");

                adaptador = new SqlDataAdapter(cmd);

                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            return dt;
        }



    }
}
