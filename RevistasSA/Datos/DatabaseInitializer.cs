using System;
using System.Data.SQLite;
using System.IO;

namespace RevistasSA.Datos
{
    public class DatabaseInitializer
    {
        private string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBRevistasSA.db"); // Ruta de la base de datos

        public void CrearBaseDeDatos()
        {
            // Verifica si el archivo de base de datos ya existe
            if (!File.Exists(dbPath))
            {
                // Crear la base de datos
                SQLiteConnection.CreateFile(dbPath);
                Console.WriteLine("Base de datos creada: " + dbPath);
                // Crear las tablas
                using (var cn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    cn.Open();
                    CrearTablas(cn);
                    InsertarDatosIniciales(cn);
                    cn.Close();
                }
            }

        }

        private void CrearTablas(SQLiteConnection cn)
        {
            string crearTablasSQL = @"
            CREATE TABLE IF NOT EXISTS Cliente (
                ClienteID INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre NVARCHAR(100) NOT NULL,
                Apellido NVARCHAR(100) NOT NULL,
                Direccion NVARCHAR(255) NOT NULL,
                Telefono NVARCHAR(20),
                Nit NVARCHAR(20) NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Revista (
                RevistaID INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre NVARCHAR(100) NOT NULL,
                Precio DECIMAL(10, 2) NOT NULL,
                Categoria NVARCHAR(100),
                Frecuencia NVARCHAR(50)  -- (ej. mensual, quincenal, etc.)
            );

            CREATE TABLE IF NOT EXISTS Empleado (
                EmpleadoID INTEGER PRIMARY KEY AUTOINCREMENT,
                Nombre NVARCHAR(100) NOT NULL,
                Apellido NVARCHAR(100) NOT NULL,
                Telefono NVARCHAR(20),
                Direccion NVARCHAR(255) NOT NULL
            );

            CREATE TABLE IF NOT EXISTS Suscripcion (
                SuscripcionID INTEGER PRIMARY KEY AUTOINCREMENT,
                ClienteID INTEGER,
                RevistaID INTEGER,
                FechaInicio NVARCHAR(255) NOT NULL,
                FechaFin NVARCHAR(255) NOT NULL,
                NumeroSuscripcion NVARCHAR(50) UNIQUE NOT NULL,
                FOREIGN KEY (ClienteID) REFERENCES Cliente(ClienteID),
                FOREIGN KEY (RevistaID) REFERENCES Revista(RevistaID)
            );

            CREATE TABLE IF NOT EXISTS Entrega (
                EntregaID INTEGER PRIMARY KEY AUTOINCREMENT,
                SuscripcionID INTEGER,
                EmpleadoID INTEGER,
                FechaProgramada NVARCHAR(255) NOT NULL,
                FechaEntrega NVARCHAR(255),
                DireccionEntrega NVARCHAR(255) NOT NULL,
                TelefonoEntrega NVARCHAR(20),
                Observaciones NVARCHAR(255),
                FOREIGN KEY (SuscripcionID) REFERENCES Suscripcion(SuscripcionID),
                FOREIGN KEY (EmpleadoID) REFERENCES Empleado(EmpleadoID)
            );";

            using (var cmd = new SQLiteCommand(crearTablasSQL, cn))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Tablas creadas o ya existen.");
            }
        }

        private void InsertarDatosIniciales(SQLiteConnection cn)
        {
            // Inserción de datos iniciales
            string insertarClientesSQL = @"
            INSERT INTO Cliente (Nombre, Apellido, Direccion, Telefono, Nit) VALUES
            ('Juan', 'González', 'Calle A, Zona 8', '55550001', '1234567-8'),
            ('María', 'Díaz', 'Avenida B, Zona 5', '55550002', '2345678-9'),
            ('Pedro', 'Mejía', 'Calle C, Zona 3', '55550003', '3456789-0'),
            ('Luisa', 'Pineda', 'Avenida D, Zona 9', '55550004', '4567890-1'),
            ('Rosa', 'Campos', 'Calle E, Zona 6', '55550005', '5678901-2'),
            ('Carlos', 'Fernández', 'Avenida F, Zona 4', '55550006', '6789012-3'),
            ('Laura', 'Cruz', 'Calle G, Zona 7', '55550007', '7890123-4'),
            ('Sergio', 'Ortega', 'Avenida H, Zona 2', '55550008', '8901234-5'),
            ('Julia', 'Ruiz', 'Calle I, Zona 1', '55550009', '9012345-6'),
            ('Ricardo', 'Vargas', 'Avenida J, Zona 10', '55550010', '0123456-7');";

            string insertarEmpleadosSQL = @"
            INSERT INTO Empleado (Nombre, Apellido, Telefono, Direccion) VALUES
            ('Carlos', 'García', '555-1234', 'Calle 1, Zona 10'),
            ('Ana', 'Martínez', '555-5678', 'Avenida 5, Zona 1'),
            ('Luis', 'Hernández', '555-2345', 'Calle 3, Zona 4'),
            ('María', 'Lopez', '555-8765', 'Avenida 10, Zona 7'),
            ('José', 'Pérez', '555-3456', 'Calle 6, Zona 2'),
            ('Laura', 'Ramírez', '555-7890', 'Avenida 2, Zona 11'),
            ('Miguel', 'Vásquez', '555-4567', 'Calle 8, Zona 3'),
            ('Sofía', 'Castro', '555-9876', 'Avenida 12, Zona 5'),
            ('Jorge', 'Morales', '555-5670', 'Calle 4, Zona 6'),
            ('Gabriela', 'Reyes', '555-6789', 'Avenida 6, Zona 9');";

            string insertarRevistasSQL = @"
            INSERT INTO Revista (Nombre, Precio, Categoria, Frecuencia) VALUES
            ('Tecnología Hoy', 25.00, 'Tecnología', 'Mensual'),
            ('Salud y Bienestar', 20.00, 'Salud', 'Quincenal'),
            ('Cocina Gourmet', 18.50, 'Gastronomía', 'Mensual'),
            ('Mundo Deportivo', 22.00, 'Deportes', 'Semanal'),
            ('Arte y Cultura', 30.00, 'Arte', 'Trimestral'),
            ('Historia Universal', 24.00, 'Historia', 'Bimestral'),
            ('Viajes y Aventuras', 27.00, 'Turismo', 'Mensual'),
            ('Negocios Globales', 35.00, 'Negocios', 'Mensual'),
            ('Ciencia Moderna', 26.50, 'Ciencia', 'Bimestral'),
            ('Hogar y Decoración', 19.00, 'Hogar', 'Mensual');";

            string insertarSuscripcionesSQL = @"
            INSERT INTO Suscripcion (ClienteID, RevistaID, FechaInicio, FechaFin, NumeroSuscripcion) VALUES
            (1, 1, '2024-01-01', '2025-01-01', 'SUS001'),
            (2, 2, '2024-02-01', '2025-02-01', 'SUS002'),
            (3, 3, '2024-03-01', '2025-03-01', 'SUS003'),
            (4, 4, '2024-04-01', '2025-04-01', 'SUS004'),
            (5, 5, '2024-05-01', '2025-05-01', 'SUS005'),
            (6, 1, '2024-06-01', '2025-06-01', 'SUS006'),
            (7, 2, '2024-07-01', '2025-07-01', 'SUS007'),
            (8, 3, '2024-08-01', '2025-08-01', 'SUS008'),
            (9, 4, '2024-09-01', '2025-09-01', 'SUS009'),
            (10, 5, '2024-10-01', '2025-10-01', 'SUS010');";

            string insertarEntregasSQL = @"
                INSERT INTO Entrega (SuscripcionID, EmpleadoID, FechaProgramada, FechaEntrega, DireccionEntrega, TelefonoEntrega, Observaciones) VALUES
                (1, 1, '2024-01-15', '2024-01-20', 'Calle A, Zona 1', '5555-1111', 'Primera entrega'),
                (2, 2, '2024-02-15', '2024-02-20', 'Avenida B, Zona 2', '5555-2222', 'Primera entrega'),
                (3, 3, '2024-03-15', '2024-03-20', 'Calle C, Zona 3', '5555-3333', 'Primera entrega'),
                (4, 4, '2024-04-15', '2024-04-20', 'Avenida D, Zona 4', '5555-4444', 'Primera entrega'),
                (5, 5, '2024-05-15', '2024-05-20', 'Calle E, Zona 5', '5555-5555', 'Primera entrega'),
                (6, 6, '2024-06-15', '2024-06-20', 'Avenida F, Zona 6', '5555-6666', 'Primera entrega'),
                (7, 7, '2024-07-15', '2024-07-20', 'Calle G, Zona 7', '5555-7777', 'Primera entrega'),
                (8, 8, '2024-08-15', '2024-08-20', 'Avenida H, Zona 8', '555-8888', 'Primera entrega'),
                (9, 9, '2024-09-15', '2024-09-20', 'Calle I, Zona 9', '555-9999', 'Primera entrega'),
                (10, 10, '2024-10-15', '2024-10-20', 'Avenida J, Zona 10', '555-0000', 'Primera entrega');";

            using (var cmd = new SQLiteCommand(insertarClientesSQL, cn))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(insertarEmpleadosSQL, cn))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(insertarRevistasSQL, cn))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(insertarSuscripcionesSQL, cn))
            {
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SQLiteCommand(insertarEntregasSQL, cn))
            {
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Datos iniciales insertados.");
        }
    }
}
