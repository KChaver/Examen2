using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class PedidosAD
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=chidori1;";

        MySqlConnection conn;
        MySqlCommand cmd;


        public DataTable ListarPedidos()
        {
            DataTable listaP = new DataTable();

            try
            {
                string sql = "SELECT * FROM Pedidos;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaP.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaP;
        }

        

        public bool InsertarPedidos(Pedidos pedidos)
        {
            bool insertoP = false;
            try
            {
                string sql = "INSERT INTO Pedidos (NombreCliente, CodigoProducto, Descripcion, Cantidad, Precio, Total) VALUES (@NombreCliente, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NombreCLiente", pedidos.NombreCliente);
                cmd.Parameters.AddWithValue("@CodigoProducto", pedidos.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", pedidos.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", pedidos.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", pedidos.Precio);
                cmd.Parameters.AddWithValue("@Total", pedidos.Total);
                cmd.ExecuteNonQuery();

                insertoP = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return insertoP;
        }

    }
}
