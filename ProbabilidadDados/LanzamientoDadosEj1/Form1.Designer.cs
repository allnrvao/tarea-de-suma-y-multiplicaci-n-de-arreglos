﻿namespace LanzamientoDadosEj1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTablaResultados = new System.Windows.Forms.DataGridView();
            this.tbProbabilidadde7 = new System.Windows.Forms.TextBox();
            this.tbProbabilidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblLandado2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblLandado1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lblsuma = new System.Windows.Forms.Label();
            this.LblSumatirada = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(167, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Probabilidad de dos dados";
            // 
            // btnLanzar
            // 
            this.btnLanzar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnLanzar.Location = new System.Drawing.Point(461, 262);
            this.btnLanzar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(177, 48);
            this.btnLanzar.TabIndex = 2;
            this.btnLanzar.Text = "Comprobar";
            this.btnLanzar.UseVisualStyleBackColor = false;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox1.Controls.Add(this.dgvTablaResultados);
            this.groupBox1.Controls.Add(this.tbProbabilidadde7);
            this.groupBox1.Controls.Add(this.tbProbabilidad);
            this.groupBox1.Controls.Add(this.btnLanzar);
            this.groupBox1.Location = new System.Drawing.Point(31, 319);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(763, 341);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dgvTablaResultados
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaResultados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaResultados.Location = new System.Drawing.Point(18, 15);
            this.dgvTablaResultados.Name = "dgvTablaResultados";
            this.dgvTablaResultados.RowHeadersWidth = 62;
            this.dgvTablaResultados.Size = new System.Drawing.Size(277, 312);
            this.dgvTablaResultados.TabIndex = 5;
            // 
            // tbProbabilidadde7
            // 
            this.tbProbabilidadde7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProbabilidadde7.Location = new System.Drawing.Point(360, 126);
            this.tbProbabilidadde7.Multiline = true;
            this.tbProbabilidadde7.Name = "tbProbabilidadde7";
            this.tbProbabilidadde7.Size = new System.Drawing.Size(356, 100);
            this.tbProbabilidadde7.TabIndex = 6;
            // 
            // tbProbabilidad
            // 
            this.tbProbabilidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProbabilidad.Location = new System.Drawing.Point(360, 15);
            this.tbProbabilidad.Multiline = true;
            this.tbProbabilidad.Name = "tbProbabilidad";
            this.tbProbabilidad.Size = new System.Drawing.Size(356, 89);
            this.tbProbabilidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(25, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Probabilidades al lanzar un dado de 1 a 36,000 veces";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.LblLandado2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblLandado1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Lblsuma);
            this.groupBox2.Controls.Add(this.LblSumatirada);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(31, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 212);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tirar dos dados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // LblLandado2
            // 
            this.LblLandado2.AutoSize = true;
            this.LblLandado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLandado2.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblLandado2.Location = new System.Drawing.Point(561, 93);
            this.LblLandado2.Name = "LblLandado2";
            this.LblLandado2.Size = new System.Drawing.Size(52, 55);
            this.LblLandado2.TabIndex = 30;
            this.LblLandado2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "DADO 1";
            // 
            // LblLandado1
            // 
            this.LblLandado1.AutoSize = true;
            this.LblLandado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLandado1.ForeColor = System.Drawing.Color.ForestGreen;
            this.LblLandado1.Location = new System.Drawing.Point(179, 76);
            this.LblLandado1.Name = "LblLandado1";
            this.LblLandado1.Size = new System.Drawing.Size(52, 55);
            this.LblLandado1.TabIndex = 29;
            this.LblLandado1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(139, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "El numero lanzado es:";
            // 
            // Lblsuma
            // 
            this.Lblsuma.AutoSize = true;
            this.Lblsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblsuma.ForeColor = System.Drawing.Color.Red;
            this.Lblsuma.Location = new System.Drawing.Point(407, 152);
            this.Lblsuma.Name = "Lblsuma";
            this.Lblsuma.Size = new System.Drawing.Size(24, 25);
            this.Lblsuma.TabIndex = 4;
            this.Lblsuma.Text = "0";
            // 
            // LblSumatirada
            // 
            this.LblSumatirada.AutoSize = true;
            this.LblSumatirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSumatirada.Location = new System.Drawing.Point(260, 152);
            this.LblSumatirada.Name = "LblSumatirada";
            this.LblSumatirada.Size = new System.Drawing.Size(130, 25);
            this.LblSumatirada.TabIndex = 5;
            this.LblSumatirada.Text = "La suma es:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(51, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "LANZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(360, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(491, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "El numero lanzado es:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(366, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "DADO 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(829, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lanzamiento de Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProbabilidad;
        private System.Windows.Forms.TextBox tbProbabilidadde7;
        private System.Windows.Forms.DataGridView dgvTablaResultados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblLandado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblLandado1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lblsuma;
        private System.Windows.Forms.Label LblSumatirada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}



