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

        public string NombreCliente { get; set; }

        public Pedidos()
        {
        }

        public Pedidos(string codigoProducto, string descripcion, int cantidad, decimal precio, decimal total, string nombreCliente)
        {
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
            NombreCliente = nombreCliente;
        }
    }
}
