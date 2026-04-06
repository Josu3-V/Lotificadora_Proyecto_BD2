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
        private string Password;
        private static conexion Con = null;

        private conexion()
        {
            this.Base = "DB20202001796";//base de datos la que se creo las tablas, trigguer
            this.Servidor = "3.128.144.165";//servidor de la base de datos el primero que aparece en desktop
            this.Usuario = "milthon.garcia";//usuario de la base de datos eje pepe2020
            this.Password = "MG20202001796"; //la que borjas proporciono u otra
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

    }
}
