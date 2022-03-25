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
        PedidosAD pedidosDA = new PedidosAD();
        
        
        Producto producto;
        ProductoAD productoAD = new ProductoAD();


        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ListarPedidos();

        }

        private void ListarPedidos()
        {
            PedidosDataGridView.DataSource = pedidosDA.ListarPedidos();
        }

        private void CodigoProductoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            ProductoGroupBox.Enabled = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoAD.GetProductoPorCodigo(CodigoProductoTextBox.Text);
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
                    pedidos.NombreCliente = NombreClienteTextBox.Text;
                    pedidos.CodigoProducto = producto.Codigo;
                    pedidos.Descripcion = producto.Descripcion;
                    pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
                    pedidos.Precio = producto.Precio;
                    pedidos.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);

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
            pedidos.NombreCliente = NombreClienteTextBox.Text;
            pedidos.CodigoProducto = producto.Codigo;
            pedidos.Descripcion = producto.Descripcion;
            pedidos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            pedidos.Precio = producto.Precio;
            pedidos.Total = producto.Precio * Convert.ToInt32(CantidadTextBox.Text);

            bool insertop = pedidosDA.InsertarPedidos(pedidos);
            if (insertop)
            {
                
                ListarPedidos();
                MessageBox.Show("Pedido insertado");
            }
        }
        

        private void ComprobarButton_Click(object sender, EventArgs e)
        {
            producto = new Producto();
            producto = productoAD.GetProductoPorCodigo(CodigoProductoTextBox.Text);
            DescripcionProductoTextBox.Text = producto.Descripcion;
            PrecioProductoTextBox.Text = producto.Precio.ToString();
            CantidadTextBox.Focus();

            ProductoGroupBox.Enabled = true;

        }

        private void NombreClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(CantidadTextBox.Text))
            {
                MessageBox.Show("Debe Poner el nombre del cliente");
                return;
            }

            groupBox1.Enabled = true;

        }
    }
}
