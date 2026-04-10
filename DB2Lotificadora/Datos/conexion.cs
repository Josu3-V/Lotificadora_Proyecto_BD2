using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2Lotificadora.Datos
{
    public class conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Password;
        private static conexion Con = null;

        private conexion()
        {
            this.Base = "DB20222030646";//base de datos la que se creo las tablas, trigguer
            this.Servidor = "3.128.144.165";//servidor de la base de datos el primero que aparece en desktop
            this.Usuario = "eddie.merino";//usuario de la base de datos eje pepe2020
            this.Password = "EM20222030646"; //la que borjas proporciono u otra
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try {
                Cadena.ConnectionString = "Server = " + this.Servidor +
                                          "; DataBase = " + this.Base +
                                          "; User Id= " + this.Usuario +
                                          "; Password = " + this.Password;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
                Console.WriteLine("Error al crear la conexion: " + ex.Message);
            }
            return Cadena;
        }

        public static conexion crarInstacia() {
            if (Con == null)
            {
                Con = new conexion();
            }
            return Con;
        }

        public DataTable EjecutarConsulta(string query, SqlParameter[] parametros = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public int EjecutarComando(string nombreProcedimiento, SqlParameter[] parametros = null)
        {
            using (SqlConnection conn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand(nombreProcedimiento, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                conn.Open();
                return cmd.ExecuteNonQuery();
                
            }
        }

        public DataTable EjecutarProcedimiento(string nombreProcedimiento, SqlParameter[] parametros = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand(nombreProcedimiento, conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public object EjecutarEscalar(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection conn = CrearConexion())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.CommandType = CommandType.Text;
                if (parametros != null)
                    cmd.Parameters.AddRange(parametros);

                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

    }
}
