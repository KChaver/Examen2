using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }
        ProductoAD productoDA = new ProductoAD();
        Producto producto;
        

        List<Pedidos> PedidosLista = new List<Pedidos>();

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            PedidosDataGridView.DataSource = PedidosLista;
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            ProductoGroupBox.Enabled = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoPorCodigo(CodigoProductoTextBox.Text);
                DescripcionProductoTextBox.Text = producto.Descripcion;
                PrecioProductoTextBox.Text = producto.Precio.ToString();
                CantidadTextBox.Focus();

                ProductoGroupBox.Enabled = true;
            }
            else
            {
                producto = null;
                DescripcionProductoTextBox.Clear();
                CantidadTextBox.Clear();
                PrecioProductoTextBox.Clear();
            }
        }

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox.Text))
                {


                    Pedidos pedidos = new Pedidos();
                    pedidos.CodigoProducto = producto.Codigo;
                    pedidos.Descripcion = producto.Descripcion;
                    pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                    pedidos.Precio = producto.Precio;
                    pedidos.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);


                    PedidosLista.Add(pedidos);
                    PedidosDataGridView.DataSource = null;
                    PedidosDataGridView.DataSource = PedidosLista;
                }

            }
            
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CantidadTextBox.Text) || string.IsNullOrEmpty(CodigoProductoTextBox.Text))
            {
                MessageBox.Show("Debe agregar la cantidad antes de agregar el pedido");
                return;
            }


            Pedidos pedidos = new Pedidos();
            pedidos.CodigoProducto = producto.Codigo;
            pedidos.Descripcion = producto.Descripcion;
            pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.Precio = producto.Precio;
            pedidos.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);


            PedidosLista.Add(pedidos);
            PedidosDataGridView.DataSource = null;
            PedidosDataGridView.DataSource = PedidosLista;
        }

        private void ComprobarButton_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto = productoDA.GetProductoPorCodigo(CodigoProductoTextBox.Text);
            DescripcionProductoTextBox.Text = producto.Descripcion;
            PrecioProductoTextBox.Text = producto.Precio.ToString();
            CantidadTextBox.Focus();

            ProductoGroupBox.Enabled = true;

        }
    }
}
