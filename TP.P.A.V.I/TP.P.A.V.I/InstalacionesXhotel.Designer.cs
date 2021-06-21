
namespace TP.P.A.V.I
{
    partial class InstalacionesXhotel
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblHotel = new System.Windows.Forms.Label();
            this.LblInstalacion = new System.Windows.Forms.Label();
            this.DgvInstalacionXHotel = new System.Windows.Forms.DataGridView();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instalacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInstalacionXHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbHotel = new System.Windows.Forms.ComboBox();
            this.CmbInstalacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorHotel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInstalacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnListadoInstalacionXHotel = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstalacionXHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstalacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(263, 225);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(107, 26);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(150, 225);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 26);
            this.BtnEliminar.TabIndex = 1;
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
            this.BtnModificar.Location = new System.Drawing.Point(37, 225);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(107, 26);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblHotel
            // 
            this.LblHotel.AutoSize = true;
            this.LblHotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHotel.Location = new System.Drawing.Point(74, 78);
            this.LblHotel.Name = "LblHotel";
            this.LblHotel.Size = new System.Drawing.Size(59, 21);
            this.LblHotel.TabIndex = 5;
            this.LblHotel.Text = "Hotel: ";
            // 
            // LblInstalacion
            // 
            this.LblInstalacion.AutoSize = true;
            this.LblInstalacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstalacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblInstalacion.Location = new System.Drawing.Point(33, 140);
            this.LblInstalacion.Name = "LblInstalacion";
            this.LblInstalacion.Size = new System.Drawing.Size(100, 21);
            this.LblInstalacion.TabIndex = 6;
            this.LblInstalacion.Text = "Instalación:";
            // 
            // DgvInstalacionXHotel
            // 
            this.DgvInstalacionXHotel.AllowUserToAddRows = false;
            this.DgvInstalacionXHotel.AllowUserToDeleteRows = false;
            this.DgvInstalacionXHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvInstalacionXHotel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DgvInstalacionXHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInstalacionXHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Instalacion,
            this.IdInstalacionXHotel});
            this.DgvInstalacionXHotel.Location = new System.Drawing.Point(35, 257);
            this.DgvInstalacionXHotel.Name = "DgvInstalacionXHotel";
            this.DgvInstalacionXHotel.ReadOnly = true;
            this.DgvInstalacionXHotel.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DgvInstalacionXHotel.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvInstalacionXHotel.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DgvInstalacionXHotel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DgvInstalacionXHotel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DgvInstalacionXHotel.Size = new System.Drawing.Size(659, 157);
            this.DgvInstalacionXHotel.TabIndex = 7;
            this.DgvInstalacionXHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInstalacionXHotel_CellClick);
            // 
            // Hotel
            // 
            this.Hotel.DataPropertyName = "NombreHotel";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            this.Hotel.Width = 250;
            // 
            // Instalacion
            // 
            this.Instalacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Instalacion.DataPropertyName = "NombreInstalacion";
            this.Instalacion.HeaderText = "Instalación";
            this.Instalacion.Name = "Instalacion";
            this.Instalacion.ReadOnly = true;
            // 
            // IdInstalacionXHotel
            // 
            this.IdInstalacionXHotel.DataPropertyName = "Id";
            this.IdInstalacionXHotel.HeaderText = "IdInstalacionXHotel";
            this.IdInstalacionXHotel.Name = "IdInstalacionXHotel";
            this.IdInstalacionXHotel.ReadOnly = true;
            this.IdInstalacionXHotel.Visible = false;
            this.IdInstalacionXHotel.Width = 70;
            // 
            // CmbHotel
            // 
            this.CmbHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbHotel.ForeColor = System.Drawing.Color.White;
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(139, 78);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(350, 21);
            this.CmbHotel.TabIndex = 8;
            this.CmbHotel.SelectedIndexChanged += new System.EventHandler(this.CmbHotel_SelectedIndexChanged);
            // 
            // CmbInstalacion
            // 
            this.CmbInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbInstalacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CmbInstalacion.ForeColor = System.Drawing.Color.White;
            this.CmbInstalacion.FormattingEnabled = true;
            this.CmbInstalacion.Location = new System.Drawing.Point(139, 140);
            this.CmbInstalacion.Name = "CmbInstalacion";
            this.CmbInstalacion.Size = new System.Drawing.Size(350, 21);
            this.CmbInstalacion.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(271, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instalaciones por Hotel";
            // 
            // errorHotel
            // 
            this.errorHotel.ContainerControl = this;
            // 
            // errorInstalacion
            // 
            this.errorInstalacion.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(644, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Hoteleria";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(527, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // BtnListadoInstalacionXHotel
            // 
            this.BtnListadoInstalacionXHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnListadoInstalacionXHotel.FlatAppearance.BorderSize = 0;
            this.BtnListadoInstalacionXHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListadoInstalacionXHotel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListadoInstalacionXHotel.ForeColor = System.Drawing.Color.White;
            this.BtnListadoInstalacionXHotel.Location = new System.Drawing.Point(382, 225);
            this.BtnListadoInstalacionXHotel.Name = "BtnListadoInstalacionXHotel";
            this.BtnListadoInstalacionXHotel.Size = new System.Drawing.Size(107, 26);
            this.BtnListadoInstalacionXHotel.TabIndex = 63;
            this.BtnListadoInstalacionXHotel.Text = "Listado";
            this.BtnListadoInstalacionXHotel.UseVisualStyleBackColor = false;
            this.BtnListadoInstalacionXHotel.Click += new System.EventHandler(this.BtnListadoInstalacionXHotel_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.White;
            this.BtnReporte.Location = new System.Drawing.Point(495, 225);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(107, 26);
            this.BtnReporte.TabIndex = 64;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // InstalacionesXhotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnListadoInstalacionXHotel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbInstalacion);
            this.Controls.Add(this.CmbHotel);
            this.Controls.Add(this.DgvInstalacionXHotel);
            this.Controls.Add(this.LblInstalacion);
            this.Controls.Add(this.LblHotel);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstalacionesXhotel";
            this.Text = "Instalaciones por Hotel";
            this.Load += new System.EventHandler(this.InstalacionesXhotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstalacionXHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstalacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblHotel;
        private System.Windows.Forms.Label LblInstalacion;
        private System.Windows.Forms.DataGridView DgvInstalacionXHotel;
        private System.Windows.Forms.ComboBox CmbHotel;
        private System.Windows.Forms.ComboBox CmbInstalacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorHotel;
        private System.Windows.Forms.ErrorProvider errorInstalacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instalacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInstalacionXHotel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnListadoInstalacionXHotel;
        private System.Windows.Forms.Button BtnReporte;
    }
}