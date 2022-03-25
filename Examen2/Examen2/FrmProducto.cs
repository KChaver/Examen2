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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductoAD productoAD = new ProductoAD();

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            operacion = "Agregar";
            HabilitarControles();
        }


        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            DescripcionTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            //CancelarButton.Enabled = true;
            AgregarButton.Enabled = false;
            ModificarButton.Enabled = false;

        }


        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            DescripcionTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;
            
            GuardarButton.Enabled = false;
            
            AgregarButton.Enabled = true;
            ModificarButton.Enabled = true;

        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();
            
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionTextBox.Text))
                {
                    errorProvider1.SetError(DescripcionTextBox, "Ingrese una descripción");
                    DescripcionTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese un precio");
                    PrecioTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox, "Ingrese una existencia");
                    ExistenciaTextBox.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigoTextBox.Text;
                producto.Descripcion = DescripcionTextBox.Text;
                producto.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                producto.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);

                

                if (operacion == "Agregar")
                {
                    bool inserto = productoAD.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto insertado");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modifico = productoAD.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }
            }
            catch (Exception)
            {
            }

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }


        private void ListarProductos()
        {
            ProductosDataGridView.DataSource = productoAD.ListarProductos();
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PrecioTextBox, "Ingrese un caracter numerico");
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(PrecioTextBox, "Ingrese un caracter numerico");
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosDataGridView.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripcionTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                PrecioTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciaTextBox.Text = ProductosDataGridView.CurrentRow.Cells["Existencia"].Value.ToString();

                HabilitarControles();
                CodigoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
