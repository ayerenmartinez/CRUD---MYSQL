using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD___MYSQL
{
    public class clsConexion
    {
        private String Base;
        private String Servidor;
        private String Puerto;
        private String Usuario;
        private String Clave;
        private static clsConexion cnx = null;

        private clsConexion()
        {
            this.Base = "bdAlmacen";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "";
        }
        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor +
                                        "; port=" + this.Puerto +
                                        "; username=" + this.Usuario +
                                        "; password=" + this.Clave +
                                        "; Database=" + this.Base;
            }
            catch (Exception ex)
            {
                Cadena = null; //Si hubiera algun problema con la conexión la hacemos null
                throw ex;
            }
            return Cadena;
        }
        public static clsConexion getInstancia()
        {
            if (cnx ==null)
            {
                cnx = new clsConexion();
            }
            return cnx;
        }
    }
}
