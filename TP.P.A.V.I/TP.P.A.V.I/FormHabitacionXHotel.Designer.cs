
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
            this.components = new System.ComponentModel.Container();
            this.LblHotel = new System.Windows.Forms.Label();
            this.CmbHotel = new System.Windows.Forms.ComboBox();
            this.CmbHabitacion = new System.Windows.Forms.ComboBox();
            this.LblHabitacion = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.DgvHabitacionXHotel = new System.Windows.Forms.DataGridView();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHotel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHabitacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacionXHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHabitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHotel
            // 
            this.LblHotel.AutoSize = true;
            this.LblHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.LblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHotel.Location = new System.Drawing.Point(90, 61);
            this.LblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHotel.Name = "LblHotel";
            this.LblHotel.Size = new System.Drawing.Size(55, 20);
            this.LblHotel.TabIndex = 0;
            this.LblHotel.Text = "Hotel: ";
            // 
            // CmbHotel
            // 
            this.CmbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbHotel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(158, 60);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(143, 21);
            this.CmbHotel.TabIndex = 1;
            this.CmbHotel.SelectedIndexChanged += new System.EventHandler(this.CmbHotel_SelectedIndexChanged);
            // 
            // CmbHabitacion
            // 
            this.CmbHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbHabitacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbHabitacion.FormattingEnabled = true;
            this.CmbHabitacion.Location = new System.Drawing.Point(158, 142);
            this.CmbHabitacion.Name = "CmbHabitacion";
            this.CmbHabitacion.Size = new System.Drawing.Size(143, 21);
            this.CmbHabitacion.TabIndex = 3;
            // 
            // LblHabitacion
            // 
            this.LblHabitacion.AutoSize = true;
            this.LblHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHabitacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHabitacion.Location = new System.Drawing.Point(52, 143);
            this.LblHabitacion.Name = "LblHabitacion";
            this.LblHabitacion.Size = new System.Drawing.Size(93, 20);
            this.LblHabitacion.TabIndex = 2;
            this.LblHabitacion.Text = "Habitación: ";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAgregar.Location = new System.Drawing.Point(252, 358);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 40);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvHabitacionXHotel
            // 
            this.DgvHabitacionXHotel.AllowUserToAddRows = false;
            this.DgvHabitacionXHotel.AllowUserToDeleteRows = false;
            this.DgvHabitacionXHotel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DgvHabitacionXHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHabitacionXHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Habitacion,
            this.Precio,
            this.Id});
            this.DgvHabitacionXHotel.Location = new System.Drawing.Point(422, 56);
            this.DgvHabitacionXHotel.Name = "DgvHabitacionXHotel";
            this.DgvHabitacionXHotel.ReadOnly = true;
            this.DgvHabitacionXHotel.Size = new System.Drawing.Size(343, 342);
            this.DgvHabitacionXHotel.TabIndex = 5;
            this.DgvHabitacionXHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitacionXHotel_CellClick);
            // 
            // Hotel
            // 
            this.Hotel.DataPropertyName = "NombreHot";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "NombreHab";
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPrecio.Location = new System.Drawing.Point(84, 223);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(61, 20);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio: ";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TxtPrecio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtPrecio.Location = new System.Drawing.Point(158, 223);
            this.TxtPrecio.MaxLength = 9;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(143, 20);
            this.TxtPrecio.TabIndex = 7;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEliminar.Location = new System.Drawing.Point(158, 358);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 40);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnModificar.Location = new System.Drawing.Point(64, 358);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(88, 40);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Habitaciones por Hotel";
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // errorHotel
            // 
            this.errorHotel.ContainerControl = this;
            // 
            // errorHabitacion
            // 
            this.errorHabitacion.ContainerControl = this;
            // 
            // FormHabitacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(850, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.DgvHabitacionXHotel);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CmbHabitacion);
            this.Controls.Add(this.LblHabitacion);
            this.Controls.Add(this.CmbHotel);
            this.Controls.Add(this.LblHotel);
            this.Name = "FormHabitacionXHotel";
            this.Text = "Habitación por Hotel";
            this.Load += new System.EventHandler(this.FormHabitacionXHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacionXHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHabitacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHotel;
        private System.Windows.Forms.ComboBox CmbHotel;
        private System.Windows.Forms.ComboBox CmbHabitacion;
        private System.Windows.Forms.Label LblHabitacion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.DataGridView DgvHabitacionXHotel;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorPrecio;
        private System.Windows.Forms.ErrorProvider errorHotel;
        private System.Windows.Forms.ErrorProvider errorHabitacion;
    }
}