using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CRUD___MYSQL
{
    public class clsArticulos
    {
        private int codigoArticulo;
        private String descripcionArticulo;
        private String marcaArticulo;
        private int stockActual;
        private String fechaCreacion;
        private String fechaModificacion;

        public clsArticulos()
        {
        }

        public clsArticulos(int codigoArticulo, string descripcionArticulo, string marcaArticulo, int stockActual, string fechaCreacion, string fechaModificacion)
        {
            this.CodigoArticulo = codigoArticulo;
            this.DescripcionArticulo = descripcionArticulo;
            this.MarcaArticulo = marcaArticulo;
            this.StockActual = stockActual;
            this.FechaCreacion = fechaCreacion;
            this.FechaModificacion = fechaModificacion;
        }

        public DataTable listarArticulos(String filtro)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = clsConexion.getInstancia().CrearConexion();
                String sql = "select a.codigoArticulo," +
                    "a.descripcionArticulo," +
                    "a.marcaArticulo," +
                    "a.stockActual," +
                    "a.fechaCreacion," +
                    "a.fechaModificacion," +
                    "c.descripcionCategoria," +
                    "um.descripcionUM," +
                    "a.codigoUM," +
                    "a.codigoCategoria " +
                    "from articulos a " +
                    "inner join categorias c on a.codigoCategoria=c.codigoCategoria inner join unidadesmedidas um on a.codigoUM =um.codigoUM " +
                    "where a.descripcionArticulo like '" +filtro+"' "+
                    "order by a.codigoArticulo;";
                MySqlCommand comando = new MySqlCommand(sql,sqlCon);
                comando.CommandTimeout = 60;
                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }

            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
       

        public int CodigoArticulo { get => codigoArticulo; set => codigoArticulo = value; }

        public string DescripcionArticulo { get => descripcionArticulo; set => descripcionArticulo = value; }
        public string MarcaArticulo { get => marcaArticulo; set => marcaArticulo = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
    }
}
