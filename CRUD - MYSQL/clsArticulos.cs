using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

        public int CodigoArticulo { get => codigoArticulo; set => codigoArticulo = value; }

        public string DescripcionArticulo { get => descripcionArticulo; set => descripcionArticulo = value; }
        public string MarcaArticulo { get => marcaArticulo; set => marcaArticulo = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public string FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }
    }
}
