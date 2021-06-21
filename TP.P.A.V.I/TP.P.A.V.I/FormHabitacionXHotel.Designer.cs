
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacionXHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblHotel
            // 
            this.LblHotel.AutoSize = true;
            this.LblHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.LblHotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHotel.Location = new System.Drawing.Point(76, 63);
            this.LblHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHotel.Name = "LblHotel";
            this.LblHotel.Size = new System.Drawing.Size(59, 21);
            this.LblHotel.TabIndex = 0;
            this.LblHotel.Text = "Hotel: ";
            // 
            // CmbHotel
            // 
            this.CmbHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbHotel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(140, 63);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(292, 21);
            this.CmbHotel.TabIndex = 1;
            this.CmbHotel.SelectedIndexChanged += new System.EventHandler(this.CmbHotel_SelectedIndexChanged);
            // 
            // CmbHabitacion
            // 
            this.CmbHabitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbHabitacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CmbHabitacion.FormattingEnabled = true;
            this.CmbHabitacion.Location = new System.Drawing.Point(140, 103);
            this.CmbHabitacion.Name = "CmbHabitacion";
            this.CmbHabitacion.Size = new System.Drawing.Size(292, 21);
            this.CmbHabitacion.TabIndex = 3;
            // 
            // LblHabitacion
            // 
            this.LblHabitacion.AutoSize = true;
            this.LblHabitacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHabitacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHabitacion.Location = new System.Drawing.Point(33, 103);
            this.LblHabitacion.Name = "LblHabitacion";
            this.LblHabitacion.Size = new System.Drawing.Size(105, 21);
            this.LblHabitacion.TabIndex = 2;
            this.LblHabitacion.Text = "Habitación: ";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(45, 201);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(125, 26);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DgvHabitacionXHotel
            // 
            this.DgvHabitacionXHotel.AllowUserToAddRows = false;
            this.DgvHabitacionXHotel.AllowUserToDeleteRows = false;
            this.DgvHabitacionXHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHabitacionXHotel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DgvHabitacionXHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHabitacionXHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Habitacion,
            this.Precio,
            this.Id});
            this.DgvHabitacionXHotel.Location = new System.Drawing.Point(45, 233);
            this.DgvHabitacionXHotel.Name = "DgvHabitacionXHotel";
            this.DgvHabitacionXHotel.ReadOnly = true;
            this.DgvHabitacionXHotel.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DgvHabitacionXHotel.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvHabitacionXHotel.Size = new System.Drawing.Size(647, 181);
            this.DgvHabitacionXHotel.TabIndex = 5;
            this.DgvHabitacionXHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHabitacionXHotel_CellClick);
            // 
            // Hotel
            // 
            this.Hotel.DataPropertyName = "NombreHot";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            this.Hotel.Width = 250;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "NombreHab";
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            this.Habitacion.Width = 250;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Id.Width = 50;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPrecio.Location = new System.Drawing.Point(73, 146);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(65, 21);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio: ";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.TxtPrecio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtPrecio.Location = new System.Drawing.Point(140, 148);
            this.TxtPrecio.MaxLength = 9;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(292, 20);
            this.TxtPrecio.TabIndex = 7;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(307, 201);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(125, 26);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(176, 201);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(125, 26);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 27);
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(635, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Hoteleria";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(529, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // BtnListado
            // 
            this.BtnListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnListado.FlatAppearance.BorderSize = 0;
            this.BtnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListado.ForeColor = System.Drawing.Color.White;
            this.BtnListado.Location = new System.Drawing.Point(438, 201);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(125, 26);
            this.BtnListado.TabIndex = 63;
            this.BtnListado.Text = "Listado";
            this.BtnListado.UseVisualStyleBackColor = false;
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // FormHabitacionXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHabitacionXHotel";
            this.Text = "Habitación por Hotel";
            this.Load += new System.EventHandler(this.FormHabitacionXHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHabitacionXHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorPrecio;
        private System.Windows.Forms.ErrorProvider errorHotel;
        private System.Windows.Forms.ErrorProvider errorHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnListado;
    }
}