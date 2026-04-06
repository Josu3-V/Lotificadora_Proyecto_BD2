using System;
using System.Collections.Generic;
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
        private string Contrasenia;
        private static conexion Con = null;

        private conexion()
        {
            this.Base = "";//base de datos la que se creo las tablas, trigguer
            this.Servidor = "";//servidor de la base de datos el primero que aparece en desktop
            this.Usuario = "";//usuario de la base de datos eje pepe2020
            this.Contrasenia = ""; //la que borjas proporciono u otra
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();

            try {
                Cadena.ConnectionString = "Server = " + this.Servidor +
                                          "; DataBase = " + this.Base +
                                          "; Usuario ID= " + this.Usuario +
                                          "; Contrasenia = " + this.Contrasenia;
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

    }
}
