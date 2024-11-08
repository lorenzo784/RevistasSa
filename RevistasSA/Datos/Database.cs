using RevistasSA.Modelos;
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

            string dbPath = "DBRevistasSA.db";
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
                AbrirConexion();
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
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable ObtenerDatosClientes()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT ClienteID, Nombre || ' ' || Apellido AS Nombre, Nit, Direccion, Telefono FROM Cliente";
            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public void InsertarEmpleado(string nombre, string apellido, string telefono, string direccion)
        {
            string consulta = "INSERT INTO Empleado (Nombre, Apellido, Telefono, Direccion) VALUES (@nombre, @apellido, @telefono, @direccion)";

            try
            {
                AbrirConexion();
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
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable ObtenerDatosEmpleados()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT EmpleadoId, CONCAT(Nombre, ' ', Apellido) AS Nombre, Telefono, Direccion FROM Empleado";
            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public void InsertarRevista(string nombre, float precio, string categoria, string frecuencia)
        {
            string consulta = "INSERT INTO Revista (Nombre, Precio, Categoria, Frecuencia) VALUES (@nombre, @precio, @categoria, @frecuencia)";

            try
            {
                AbrirConexion();
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
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable ObtenerDatosRevistas()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT * 
                                FROM Revista";
            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
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
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public DataTable ObtenerDatosEntregas()
        {
            DataTable dt = new DataTable();
            string consulta = @"SELECT e.EntregaID as ID, 
                               s.NumeroSuscripcion as Suscripcion, 
                               CONCAT(em.Nombre, ' ', em.Apellido) as Empleado, 
                               e.FechaProgramada, 
                               e.FechaEntrega, 
                               e.DireccionEntrega, 
                               e.TelefonoEntrega, 
                               e.Observaciones
                        FROM Entrega e
                        INNER JOIN Suscripcion s on e.SuscripcionID = s.SuscripcionID
                        INNER JOIN Empleado em on e.EmpleadoID = em.EmpleadoID";
            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message); // Mostrar solo el mensaje de error
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }


        public void InsertarSuscripcion(int cliente, int revista, string fechainicio, string fechafin, string numerosuscripcion)
        {
            string consulta = "INSERT INTO Suscripcion (ClienteID, RevistaID, FechaInicio, FechaFin, NumeroSuscripcion) VALUES (@cliente, @revista, @fechainicio, @fechafin, @numerosuscripcion)";

            try
            {
                AbrirConexion();
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
            finally
            {
                CerrarConexion();
            }
        }

        public int ObtenerUltimaSuscripcion()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT SuscripcionID from Suscripcion order by SuscripcionID desc limit 1"; // SQLite utiliza LAST_INSERT_ROWID para obtener el último ID insertado

            try
            {
                cmd = new SQLiteCommand(consulta, cn);
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["SuscripcionID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la última suscripción: " + ex.ToString());
            }
            return 0;
        }

        public void InsertarEntrega(int suscripcion, int empleado, string fechaProgramada, string fechaEntrega, string direccion, string telefonoEntrega, string observaciones)
        {
            string consulta = "INSERT INTO Entrega (SuscripcionID, EmpleadoID, FechaProgramada, FechaEntrega, DireccionEntrega, TelefonoEntrega, Observaciones) " +
                              "VALUES (@suscripcion, @empleado, @fechaProgramada, @fechaEntrega, @direccion, @telefonoEntrega, @observaciones)";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@suscripcion", suscripcion);
                cmd.Parameters.AddWithValue("@empleado", empleado);
                cmd.Parameters.AddWithValue("@fechaProgramada", fechaProgramada);
                cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefonoEntrega", string.IsNullOrEmpty(telefonoEntrega) ? (object)DBNull.Value : telefonoEntrega);
                cmd.Parameters.AddWithValue("@observaciones", string.IsNullOrEmpty(observaciones) ? (object)DBNull.Value : observaciones);

                // Ejecuta el comando
                int filasAfectadas = cmd.ExecuteNonQuery();

                // Si lo deseas, puedes verificar las filas afectadas
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Entrega registrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la entrega.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }


        public DataTable BuscarRevistas(string revista)
        {
            string consulta = "SELECT RevistaID, Nombre FROM Revista WHERE Nombre LIKE @Revista";
            DataTable dt = new DataTable();
            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Revista", $"%{revista}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
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
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Cliente", $"%{Cliente}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
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
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Empleado", $"%{Empleado}%");
                adaptador = new SQLiteDataAdapter(cmd);
                adaptador.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
            return dt;
        }

        public void EliminarCliente(int clienteID)
        {
            string consulta = "DELETE FROM Cliente WHERE ClienteID = @clienteID";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@clienteID", clienteID);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Cliente eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarEmpleado(int empleadoID)
        {
            string consulta = "DELETE FROM Empleado WHERE EmpleadoID = @empleadoID";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@empleadoID", empleadoID);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Empleado eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void EliminarRevista(int revistaID)
        {
            string consulta = "DELETE FROM Revista WHERE RevistaID = @revistaID";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@revistaID", revistaID);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Revista eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la revista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la revista: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }


        public void EliminarSuscripcion(int suscripcionID)
        {
            string consulta = "DELETE FROM Suscripcion WHERE SuscripcionID = @suscripcionID";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@suscripcionID", suscripcionID);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Suscripción eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la suscripción.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la suscripción: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }


        public void EliminarEntrega(int entregaID)
        {
            string consulta = "DELETE FROM Entrega WHERE EntregaID = @entregaID";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@entregaID", entregaID);
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Entrega eliminada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró la entrega.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la entrega: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ModificarCliente(int clienteId, string nombre, string apellido, string direccion, string telefono, string nit)
        {
            string consulta = "UPDATE Cliente SET Nombre = @nombre, Apellido = @apellido, Direccion = @direccion, Telefono = @telefono, Nit = @nit WHERE ClienteID = @clienteId";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@nit", nit);
                cmd.Parameters.AddWithValue("@clienteId", clienteId);

                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el cliente: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ModificarEmpleado(int empleadoId, string nombre, string apellido, string telefono, string direccion)
        {
            string consulta = "UPDATE Empleado SET Nombre = @nombre, Apellido = @apellido, Telefono = @telefono, Direccion = @direccion WHERE EmpleadoID = @empleadoId";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@empleadoId", empleadoId);

                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ModificarRevista(int revistaId, string nombre, float precio, string categoria, string frecuencia)
        {
            string consulta = "UPDATE Revista SET Nombre = @nombre, Precio = @precio, Categoria = @categoria, Frecuencia = @frecuencia WHERE RevistaID = @revistaId";

            try
            {
                AbrirConexion();
                cmd = new SQLiteCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@categoria", categoria);
                cmd.Parameters.AddWithValue("@frecuencia", frecuencia);
                cmd.Parameters.AddWithValue("@revistaId", revistaId);

                int filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la revista: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }
        }

        public Cliente BuscarClientePorID(int clienteID)
        {
            Cliente cliente = null;
            string consulta = "SELECT * FROM Cliente WHERE ClienteID = @ClienteID";

            try
            {
                AbrirConexion();
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                ClienteID = Convert.ToInt32(reader["ClienteID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Nit = reader["Nit"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }

            return cliente;
        }

        public Revista BuscarRevistaPorID(int revistaID)
        {
            Revista revista = null;
            string consulta = "SELECT * FROM Revista WHERE RevistaID = @RevistaID";

            try
            {
                AbrirConexion();
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@RevistaID", revistaID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            revista = new Revista
                            {
                                RevistaID = Convert.ToInt32(reader["RevistaID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                Categoria = reader["Categoria"].ToString(),
                                Frecuencia = reader["Frecuencia"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la revista: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }

            return revista;
        }

        public Empleado BuscarEmpleadoPorID(int empleadoID)
        {
            Empleado empleado = null;
            string consulta = "SELECT * FROM Empleado WHERE EmpleadoID = @EmpleadoID";

            try
            {
                AbrirConexion();
                using (SQLiteCommand cmd = new SQLiteCommand(consulta, cn))
                {
                    cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                EmpleadoID = Convert.ToInt32(reader["EmpleadoID"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Direccion = reader["Direccion"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el empleado: " + ex.ToString());
            }
            finally
            {
                CerrarConexion();
            }

            return empleado;
        }


        public void Dispose()
        {
            CerrarConexion();
        }
    }
}
