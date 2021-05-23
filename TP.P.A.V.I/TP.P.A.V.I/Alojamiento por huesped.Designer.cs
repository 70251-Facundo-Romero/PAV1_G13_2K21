
namespace TP.P.A.V.I
{
    partial class AlojamientoXHuesped
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarAXH = new System.Windows.Forms.Button();
            this.btnModificarAXH = new System.Windows.Forms.Button();
            this.btnAgregarAXH = new System.Windows.Forms.Button();
            this.grillaAlojamiento = new System.Windows.Forms.DataGridView();
            this.Id_AXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_FechaAlojamiento = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.msk_FechaAlojamiento = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Hotel = new System.Windows.Forms.ComboBox();
            this.msk_FechaSalida = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Pais = new System.Windows.Forms.ComboBox();
            this.cmb_Habitacion = new System.Windows.Forms.ComboBox();
            this.msk_numPasaporte = new System.Windows.Forms.MaskedTextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlojamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(647, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Hoteleria";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(474, 254);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 24);
            this.btnLimpiar.TabIndex = 57;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarAXH
            // 
            this.btnEliminarAXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarAXH.FlatAppearance.BorderSize = 0;
            this.btnEliminarAXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAXH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarAXH.Location = new System.Drawing.Point(336, 254);
            this.btnEliminarAXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarAXH.Name = "btnEliminarAXH";
            this.btnEliminarAXH.Size = new System.Drawing.Size(134, 24);
            this.btnEliminarAXH.TabIndex = 56;
            this.btnEliminarAXH.Text = "Eliminar Alojamiento";
            this.btnEliminarAXH.UseVisualStyleBackColor = false;
            this.btnEliminarAXH.Click += new System.EventHandler(this.btnEliminarAXH_Click);
            // 
            // btnModificarAXH
            // 
            this.btnModificarAXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarAXH.FlatAppearance.BorderSize = 0;
            this.btnModificarAXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAXH.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarAXH.Location = new System.Drawing.Point(198, 254);
            this.btnModificarAXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarAXH.Name = "btnModificarAXH";
            this.btnModificarAXH.Size = new System.Drawing.Size(134, 24);
            this.btnModificarAXH.TabIndex = 55;
            this.btnModificarAXH.Text = "Modificar Alojamiento";
            this.btnModificarAXH.UseVisualStyleBackColor = false;
            this.btnModificarAXH.Click += new System.EventHandler(this.btnModificarAXH_Click);
            // 
            // btnAgregarAXH
            // 
            this.btnAgregarAXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarAXH.FlatAppearance.BorderSize = 0;
            this.btnAgregarAXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAXH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarAXH.Location = new System.Drawing.Point(60, 254);
            this.btnAgregarAXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarAXH.Name = "btnAgregarAXH";
            this.btnAgregarAXH.Size = new System.Drawing.Size(134, 24);
            this.btnAgregarAXH.TabIndex = 54;
            this.btnAgregarAXH.Text = "Agregar Alojamiento";
            this.btnAgregarAXH.UseVisualStyleBackColor = false;
            this.btnAgregarAXH.Click += new System.EventHandler(this.btnAgregarAXH_Click);
            // 
            // grillaAlojamiento
            // 
            this.grillaAlojamiento.AllowUserToAddRows = false;
            this.grillaAlojamiento.AllowUserToDeleteRows = false;
            this.grillaAlojamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaAlojamiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grillaAlojamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAlojamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_AXH,
            this.NroPasaporte,
            this.Pais,
            this.Hotel,
            this.Habitacion,
            this.FechaAloj,
            this.FechaSalida});
            this.grillaAlojamiento.GridColor = System.Drawing.SystemColors.ControlLight;
            this.grillaAlojamiento.Location = new System.Drawing.Point(60, 282);
            this.grillaAlojamiento.Margin = new System.Windows.Forms.Padding(2);
            this.grillaAlojamiento.Name = "grillaAlojamiento";
            this.grillaAlojamiento.ReadOnly = true;
            this.grillaAlojamiento.RowHeadersVisible = false;
            this.grillaAlojamiento.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grillaAlojamiento.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaAlojamiento.RowTemplate.Height = 24;
            this.grillaAlojamiento.Size = new System.Drawing.Size(645, 133);
            this.grillaAlojamiento.TabIndex = 53;
            this.grillaAlojamiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaAlojamiento_CellClick);
            // 
            // Id_AXH
            // 
            this.Id_AXH.DataPropertyName = "IdAXH";
            this.Id_AXH.HeaderText = "Id";
            this.Id_AXH.Name = "Id_AXH";
            this.Id_AXH.ReadOnly = true;
            // 
            // NroPasaporte
            // 
            this.NroPasaporte.DataPropertyName = "NroPasaporte";
            this.NroPasaporte.HeaderText = "Nro de pasaporte";
            this.NroPasaporte.Name = "NroPasaporte";
            this.NroPasaporte.ReadOnly = true;
            // 
            // Pais
            // 
            this.Pais.DataPropertyName = "NombrePais";
            this.Pais.HeaderText = "Pais";
            this.Pais.Name = "Pais";
            this.Pais.ReadOnly = true;
            this.Pais.Width = 200;
            // 
            // Hotel
            // 
            this.Hotel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hotel.DataPropertyName = "NombreHotel";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "NombreHabitacion";
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            this.Habitacion.Width = 200;
            // 
            // FechaAloj
            // 
            this.FechaAloj.DataPropertyName = "FechaAlojamiento";
            this.FechaAloj.HeaderText = "Fecha Alojamiento";
            this.FechaAloj.Name = "FechaAloj";
            this.FechaAloj.ReadOnly = true;
            // 
            // FechaSalida
            // 
            this.FechaSalida.DataPropertyName = "FechaSalida";
            this.FechaSalida.HeaderText = "Fecha de salida";
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 45;
            this.label7.Text = "Hotel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(58, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(56, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Pais del huesped";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(56, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Numero de pasaporte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Id Habitacion";
            // 
            // lbl_FechaAlojamiento
            // 
            this.lbl_FechaAlojamiento.AutoSize = true;
            this.lbl_FechaAlojamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaAlojamiento.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaAlojamiento.Location = new System.Drawing.Point(56, 180);
            this.lbl_FechaAlojamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaAlojamiento.Name = "lbl_FechaAlojamiento";
            this.lbl_FechaAlojamiento.Size = new System.Drawing.Size(181, 21);
            this.lbl_FechaAlojamiento.TabIndex = 40;
            this.lbl_FechaAlojamiento.Text = "Fecha de alojamiento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(530, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // msk_FechaAlojamiento
            // 
            this.msk_FechaAlojamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_FechaAlojamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.msk_FechaAlojamiento.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.msk_FechaAlojamiento.Location = new System.Drawing.Point(266, 182);
            this.msk_FechaAlojamiento.Margin = new System.Windows.Forms.Padding(2);
            this.msk_FechaAlojamiento.Mask = "00/00/0000";
            this.msk_FechaAlojamiento.Name = "msk_FechaAlojamiento";
            this.msk_FechaAlojamiento.Size = new System.Drawing.Size(122, 20);
            this.msk_FechaAlojamiento.TabIndex = 61;
            this.msk_FechaAlojamiento.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_Hotel
            // 
            this.cmb_Hotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hotel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Hotel.ForeColor = System.Drawing.Color.White;
            this.cmb_Hotel.FormattingEnabled = true;
            this.cmb_Hotel.Location = new System.Drawing.Point(266, 47);
            this.cmb_Hotel.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Hotel.Name = "cmb_Hotel";
            this.cmb_Hotel.Size = new System.Drawing.Size(219, 24);
            this.cmb_Hotel.TabIndex = 65;
            // 
            // msk_FechaSalida
            // 
            this.msk_FechaSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_FechaSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.msk_FechaSalida.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.msk_FechaSalida.Location = new System.Drawing.Point(266, 215);
            this.msk_FechaSalida.Margin = new System.Windows.Forms.Padding(2);
            this.msk_FechaSalida.Mask = "00/00/0000";
            this.msk_FechaSalida.Name = "msk_FechaSalida";
            this.msk_FechaSalida.Size = new System.Drawing.Size(122, 20);
            this.msk_FechaSalida.TabIndex = 67;
            this.msk_FechaSalida.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_Pais
            // 
            this.cmb_Pais.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Pais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Pais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Pais.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_Pais.FormattingEnabled = true;
            this.cmb_Pais.Location = new System.Drawing.Point(266, 113);
            this.cmb_Pais.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Pais.Name = "cmb_Pais";
            this.cmb_Pais.Size = new System.Drawing.Size(219, 24);
            this.cmb_Pais.TabIndex = 68;
            // 
            // cmb_Habitacion
            // 
            this.cmb_Habitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Habitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Habitacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Habitacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_Habitacion.FormattingEnabled = true;
            this.cmb_Habitacion.Location = new System.Drawing.Point(266, 78);
            this.cmb_Habitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Habitacion.Name = "cmb_Habitacion";
            this.cmb_Habitacion.Size = new System.Drawing.Size(219, 24);
            this.cmb_Habitacion.TabIndex = 69;
            // 
            // msk_numPasaporte
            // 
            this.msk_numPasaporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_numPasaporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.msk_numPasaporte.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_numPasaporte.ForeColor = System.Drawing.Color.White;
            this.msk_numPasaporte.Location = new System.Drawing.Point(266, 147);
            this.msk_numPasaporte.Mask = "99999999";
            this.msk_numPasaporte.Name = "msk_numPasaporte";
            this.msk_numPasaporte.Size = new System.Drawing.Size(219, 21);
            this.msk_numPasaporte.TabIndex = 70;
            this.msk_numPasaporte.ValidatingType = typeof(int);
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_Id.Enabled = false;
            this.txt_Id.ForeColor = System.Drawing.Color.White;
            this.txt_Id.Location = new System.Drawing.Point(89, 9);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(36, 20);
            this.txt_Id.TabIndex = 73;
            this.txt_Id.Visible = false;
            // 
            // AlojamientoXHuesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.msk_numPasaporte);
            this.Controls.Add(this.cmb_Habitacion);
            this.Controls.Add(this.cmb_Pais);
            this.Controls.Add(this.msk_FechaSalida);
            this.Controls.Add(this.cmb_Hotel);
            this.Controls.Add(this.msk_FechaAlojamiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarAXH);
            this.Controls.Add(this.btnModificarAXH);
            this.Controls.Add(this.btnAgregarAXH);
            this.Controls.Add(this.grillaAlojamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_FechaAlojamiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlojamientoXHuesped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alojamiento por huesped";
            this.Load += new System.EventHandler(this.AlojamientoXHuesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAlojamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarAXH;
        private System.Windows.Forms.Button btnModificarAXH;
        private System.Windows.Forms.Button btnAgregarAXH;
        private System.Windows.Forms.DataGridView grillaAlojamiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_FechaAlojamiento;
        private System.Windows.Forms.MaskedTextBox msk_FechaAlojamiento;
        private System.Windows.Forms.ComboBox cmb_Hotel;
        private System.Windows.Forms.MaskedTextBox msk_FechaSalida;
        private System.Windows.Forms.ComboBox cmb_Pais;
        private System.Windows.Forms.ComboBox cmb_Habitacion;
        private System.Windows.Forms.MaskedTextBox msk_numPasaporte;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
    }
}