
namespace TP.P.A.V.I
{
    partial class HabitacionXHotel
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
            this.Hotel = new System.Windows.Forms.Label();
            this.CmbHotel = new System.Windows.Forms.ComboBox();
            this.CmbHabitacion = new System.Windows.Forms.ComboBox();
            this.Habitación = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hotel
            // 
            this.Hotel.AutoSize = true;
            this.Hotel.Location = new System.Drawing.Point(70, 56);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(32, 13);
            this.Hotel.TabIndex = 0;
            this.Hotel.Text = "Hotel";
            // 
            // CmbHotel
            // 
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(143, 56);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(95, 21);
            this.CmbHotel.TabIndex = 1;
            // 
            // CmbHabitacion
            // 
            this.CmbHabitacion.FormattingEnabled = true;
            this.CmbHabitacion.Location = new System.Drawing.Point(143, 114);
            this.CmbHabitacion.Name = "CmbHabitacion";
            this.CmbHabitacion.Size = new System.Drawing.Size(95, 21);
            this.CmbHabitacion.TabIndex = 3;
            // 
            // Habitación
            // 
            this.Habitación.AutoSize = true;
            this.Habitación.Location = new System.Drawing.Point(67, 122);
            this.Habitación.Name = "Habitación";
            this.Habitación.Size = new System.Drawing.Size(56, 13);
            this.Habitación.TabIndex = 2;
            this.Habitación.Text = "habitacion";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(163, 179);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 342);
            this.dataGridView1.TabIndex = 5;
            // 
            // HabitacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CmbHabitacion);
            this.Controls.Add(this.Habitación);
            this.Controls.Add(this.CmbHotel);
            this.Controls.Add(this.Hotel);
            this.Name = "HabitacionXHotel";
            this.Text = "HabitacionXHotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hotel;
        private System.Windows.Forms.ComboBox CmbHotel;
        private System.Windows.Forms.ComboBox CmbHabitacion;
        private System.Windows.Forms.Label Habitación;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}