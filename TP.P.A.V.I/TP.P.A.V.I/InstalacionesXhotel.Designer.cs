
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblHotel = new System.Windows.Forms.Label();
            this.LblInstalacion = new System.Windows.Forms.Label();
            this.DgvInstalacionXHotel = new System.Windows.Forms.DataGridView();
            this.CmbHotel = new System.Windows.Forms.ComboBox();
            this.CmbInstalacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instalacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInstalacionXHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorHotel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInstalacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstalacionXHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstalacion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnAgregar.Location = new System.Drawing.Point(278, 330);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(88, 40);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEliminar.Location = new System.Drawing.Point(162, 330);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(88, 40);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnModificar.Location = new System.Drawing.Point(49, 330);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(88, 40);
            this.BtnModificar.TabIndex = 2;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblHotel
            // 
            this.LblHotel.AutoSize = true;
            this.LblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblHotel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHotel.Location = new System.Drawing.Point(100, 64);
            this.LblHotel.Name = "LblHotel";
            this.LblHotel.Size = new System.Drawing.Size(55, 20);
            this.LblHotel.TabIndex = 5;
            this.LblHotel.Text = "Hotel: ";
            // 
            // LblInstalacion
            // 
            this.LblInstalacion.AutoSize = true;
            this.LblInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LblInstalacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblInstalacion.Location = new System.Drawing.Point(65, 185);
            this.LblInstalacion.Name = "LblInstalacion";
            this.LblInstalacion.Size = new System.Drawing.Size(90, 20);
            this.LblInstalacion.TabIndex = 6;
            this.LblInstalacion.Text = "Instalación:";
            // 
            // DgvInstalacionXHotel
            // 
            this.DgvInstalacionXHotel.AllowUserToAddRows = false;
            this.DgvInstalacionXHotel.AllowUserToDeleteRows = false;
            this.DgvInstalacionXHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInstalacionXHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hotel,
            this.Instalacion,
            this.IdInstalacionXHotel});
            this.DgvInstalacionXHotel.Location = new System.Drawing.Point(394, 61);
            this.DgvInstalacionXHotel.Name = "DgvInstalacionXHotel";
            this.DgvInstalacionXHotel.ReadOnly = true;
            this.DgvInstalacionXHotel.Size = new System.Drawing.Size(244, 309);
            this.DgvInstalacionXHotel.TabIndex = 7;
            this.DgvInstalacionXHotel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInstalacionXHotel_CellClick);
            // 
            // CmbHotel
            // 
            this.CmbHotel.FormattingEnabled = true;
            this.CmbHotel.Location = new System.Drawing.Point(188, 63);
            this.CmbHotel.Name = "CmbHotel";
            this.CmbHotel.Size = new System.Drawing.Size(120, 21);
            this.CmbHotel.TabIndex = 8;
            this.CmbHotel.SelectedIndexChanged += new System.EventHandler(this.CmbHotel_SelectedIndexChanged);
            // 
            // CmbInstalacion
            // 
            this.CmbInstalacion.FormattingEnabled = true;
            this.CmbInstalacion.Location = new System.Drawing.Point(188, 184);
            this.CmbInstalacion.Name = "CmbInstalacion";
            this.CmbInstalacion.Size = new System.Drawing.Size(120, 21);
            this.CmbInstalacion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Instalaciones por Hotel";
            // 
            // Hotel
            // 
            this.Hotel.DataPropertyName = "NombreHotel";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            // 
            // Instalacion
            // 
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
            // 
            // errorHotel
            // 
            this.errorHotel.ContainerControl = this;
            // 
            // errorInstalacion
            // 
            this.errorInstalacion.ContainerControl = this;
            // 
            // InstalacionesXhotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(677, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbInstalacion);
            this.Controls.Add(this.CmbHotel);
            this.Controls.Add(this.DgvInstalacionXHotel);
            this.Controls.Add(this.LblInstalacion);
            this.Controls.Add(this.LblHotel);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "InstalacionesXhotel";
            this.Text = "Instalaciones por Hotel";
            this.Load += new System.EventHandler(this.InstalacionesXhotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInstalacionXHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstalacion)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instalacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInstalacionXHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorHotel;
        private System.Windows.Forms.ErrorProvider errorInstalacion;
    }
}