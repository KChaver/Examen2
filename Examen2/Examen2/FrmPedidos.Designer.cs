namespace Examen2
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductoGroupBox = new System.Windows.Forms.GroupBox();
            this.PrecioProductoTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PedidosDataGridView = new System.Windows.Forms.DataGridView();
            this.ComprobarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.ProductoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductoGroupBox
            // 
            this.ProductoGroupBox.Controls.Add(this.PrecioProductoTextBox);
            this.ProductoGroupBox.Controls.Add(this.AgregarButton);
            this.ProductoGroupBox.Controls.Add(this.label1);
            this.ProductoGroupBox.Controls.Add(this.CantidadTextBox);
            this.ProductoGroupBox.Controls.Add(this.label5);
            this.ProductoGroupBox.Controls.Add(this.DescripcionProductoTextBox);
            this.ProductoGroupBox.Controls.Add(this.label3);
            this.ProductoGroupBox.Enabled = false;
            this.ProductoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoGroupBox.Location = new System.Drawing.Point(205, 58);
            this.ProductoGroupBox.Name = "ProductoGroupBox";
            this.ProductoGroupBox.Size = new System.Drawing.Size(595, 154);
            this.ProductoGroupBox.TabIndex = 5;
            this.ProductoGroupBox.TabStop = false;
            this.ProductoGroupBox.Text = "Producto";
            // 
            // PrecioProductoTextBox
            // 
            this.PrecioProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProductoTextBox.Location = new System.Drawing.Point(487, 33);
            this.PrecioProductoTextBox.Name = "PrecioProductoTextBox";
            this.PrecioProductoTextBox.ReadOnly = true;
            this.PrecioProductoTextBox.Size = new System.Drawing.Size(100, 21);
            this.PrecioProductoTextBox.TabIndex = 8;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(158, 90);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(229, 39);
            this.AgregarButton.TabIndex = 7;
            this.AgregarButton.Text = "Agregar Pedido";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio:";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadTextBox.Location = new System.Drawing.Point(78, 33);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(85, 21);
            this.CantidadTextBox.TabIndex = 6;
            this.CantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // DescripcionProductoTextBox
            // 
            this.DescripcionProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionProductoTextBox.Location = new System.Drawing.Point(249, 33);
            this.DescripcionProductoTextBox.Name = "DescripcionProductoTextBox";
            this.DescripcionProductoTextBox.ReadOnly = true;
            this.DescripcionProductoTextBox.Size = new System.Drawing.Size(175, 21);
            this.DescripcionProductoTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // CodigoProductoTextBox
            // 
            this.CodigoProductoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoProductoTextBox.Location = new System.Drawing.Point(78, 43);
            this.CodigoProductoTextBox.Name = "CodigoProductoTextBox";
            this.CodigoProductoTextBox.Size = new System.Drawing.Size(85, 21);
            this.CodigoProductoTextBox.TabIndex = 4;
            this.CodigoProductoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductoTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.AllowUserToAddRows = false;
            this.PedidosDataGridView.AllowUserToDeleteRows = false;
            this.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDataGridView.Enabled = false;
            this.PedidosDataGridView.Location = new System.Drawing.Point(12, 218);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.ReadOnly = true;
            this.PedidosDataGridView.Size = new System.Drawing.Size(745, 220);
            this.PedidosDataGridView.TabIndex = 6;
            // 
            // ComprobarButton
            // 
            this.ComprobarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprobarButton.Location = new System.Drawing.Point(26, 73);
            this.ComprobarButton.Name = "ComprobarButton";
            this.ComprobarButton.Size = new System.Drawing.Size(137, 39);
            this.ComprobarButton.TabIndex = 9;
            this.ComprobarButton.Text = "Comprobar Producto";
            this.ComprobarButton.UseVisualStyleBackColor = true;
            this.ComprobarButton.Click += new System.EventHandler(this.ComprobarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodigoProductoTextBox);
            this.groupBox1.Controls.Add(this.ComprobarButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Codigo del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del cliente:";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(141, 12);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(194, 22);
            this.NombreClienteTextBox.TabIndex = 11;
            this.NombreClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreClienteTextBox_KeyPress);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PedidosDataGridView);
            this.Controls.Add(this.ProductoGroupBox);
            this.Name = "FrmPedidos";
            this.Text = "FrmPedidos";
            this.Load += new System.EventHandler(this.FrmPedidos_Load);
            this.ProductoGroupBox.ResumeLayout(false);
            this.ProductoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductoGroupBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodigoProductoTextBox;
        private System.Windows.Forms.TextBox DescripcionProductoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView PedidosDataGridView;
        private System.Windows.Forms.TextBox PrecioProductoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button ComprobarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
    }
}