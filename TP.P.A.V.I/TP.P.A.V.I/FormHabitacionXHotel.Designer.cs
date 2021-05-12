
namespace TP.P.A.V.I
{
    partial class FormHabitacionXHotel
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
            this.LblHotel = new System.Windows.Forms.Label();
            this.CmbHotel = new System.Windows.Forms.ComboBox();
            this.CmbHabitacion = new System.Windows.Forms.ComboBox();
            this.LblHabitacion = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHotel
            // 
            this.LblHotel.AutoSize = true;
            this.LblHotel.Location = new System.Drawing.Point(60, 46);
            this.LblHotel.Name = "LblHotel";
            this.LblHotel.Size = new System.Drawing.Size(38, 13);
            this.LblHotel.TabIndex = 0;
            this.LblHotel.Text = "Hotel: ";
            // 
            // CmbHotel
            // 
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(111, 43);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(143, 21);
            this.CmbHotel.TabIndex = 1;
            // 
            // CmbHabitacion
            // 
            this.CmbHabitacion.FormattingEnabled = true;
            this.CmbHabitacion.Location = new System.Drawing.Point(111, 105);
            this.CmbHabitacion.Name = "CmbHabitacion";
            this.CmbHabitacion.Size = new System.Drawing.Size(143, 21);
            this.CmbHabitacion.TabIndex = 3;
            // 
            // LblHabitacion
            // 
            this.LblHabitacion.AutoSize = true;
            this.LblHabitacion.Location = new System.Drawing.Point(34, 108);
            this.LblHabitacion.Name = "LblHabitacion";
            this.LblHabitacion.Size = new System.Drawing.Size(64, 13);
            this.LblHabitacion.TabIndex = 2;
            this.LblHabitacion.Text = "Habitación: ";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(166, 206);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 40);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Habitacion,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(343, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 384);
            this.dataGridView1.TabIndex = 5;
            // 
            // Hotel
            // 
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            // 
            // Habitacion
            // 
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Location = new System.Drawing.Point(34, 167);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(43, 13);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 7;
            // 
            // FormHabitacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 433);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CmbHabitacion);
            this.Controls.Add(this.LblHabitacion);
            this.Controls.Add(this.CmbHotel);
            this.Controls.Add(this.LblHotel);
            this.Name = "FormHabitacionXHotel";
            this.Text = "FormHabitacionXHotel";
            this.Load += new System.EventHandler(this.FormHabitacionXHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHotel;
        private System.Windows.Forms.ComboBox CmbHotel;
        private System.Windows.Forms.ComboBox CmbHabitacion;
        private System.Windows.Forms.Label LblHabitacion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox textBox1;
    }
}