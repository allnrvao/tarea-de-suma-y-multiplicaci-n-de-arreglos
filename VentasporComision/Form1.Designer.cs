namespace VentasporComision
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.lstMostrarReporte = new System.Windows.Forms.ListBox();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.btnAggVenta = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.txtVentasButas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(49, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Actualizacion de Reporte";
            // 
            // lstMostrarReporte
            // 
            this.lstMostrarReporte.FormattingEnabled = true;
            this.lstMostrarReporte.ItemHeight = 20;
            this.lstMostrarReporte.Location = new System.Drawing.Point(37, 213);
            this.lstMostrarReporte.Name = "lstMostrarReporte";
            this.lstMostrarReporte.Size = new System.Drawing.Size(465, 204);
            this.lstMostrarReporte.TabIndex = 7;
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnMostrarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarReporte.Location = new System.Drawing.Point(250, 126);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(157, 41);
            this.btnMostrarReporte.TabIndex = 8;
            this.btnMostrarReporte.Text = "Mostrar Reporte";
            this.btnMostrarReporte.UseVisualStyleBackColor = false;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // btnAggVenta
            // 
            this.btnAggVenta.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAggVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggVenta.Location = new System.Drawing.Point(44, 126);
            this.btnAggVenta.Name = "btnAggVenta";
            this.btnAggVenta.Size = new System.Drawing.Size(151, 41);
            this.btnAggVenta.TabIndex = 9;
            this.btnAggVenta.Text = "Agregar Venta";
            this.btnAggVenta.UseVisualStyleBackColor = false;
            this.btnAggVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblVentas.Location = new System.Drawing.Point(40, 88);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(237, 24);
            this.lblVentas.TabIndex = 10;
            this.lblVentas.Text = "Ingreses Ventas Brutas:";
            // 
            // txtVentasButas
            // 
            this.txtVentasButas.Location = new System.Drawing.Point(283, 88);
            this.txtVentasButas.Name = "txtVentasButas";
            this.txtVentasButas.Size = new System.Drawing.Size(189, 26);
            this.txtVentasButas.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(37, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(720, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Programa de reportes de ventas y comisiones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMostrarReporte);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnAggVenta);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.txtVentasButas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstMostrarReporte;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.Button btnAggVenta;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.TextBox txtVentasButas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

