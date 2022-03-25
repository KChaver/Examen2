using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Pedidos
    {
        public string CodigoProducto { get; set; }

        public string Descripcion { get; set;}

        public int Cantidad { get; set;}

        public decimal Precio { get; set; }

        public decimal Total { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(string codigoProducto, string descripcion, int cantidad, decimal precio, decimal total)
        {
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
