
namespace TP.P.A.V.I
{
    partial class AltaServicioXHotel
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
            this.panelFormulariosHijos = new System.Windows.Forms.Panel();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.cmbHotel = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregarSerXHot = new System.Windows.Forms.Button();
            this.BtnModificarSerXHot = new System.Windows.Forms.Button();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panelFormulariosHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulariosHijos
            // 
            this.panelFormulariosHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFormulariosHijos.Controls.Add(this.BtnEliminar);
            this.panelFormulariosHijos.Controls.Add(this.cmbServicio);
            this.panelFormulariosHijos.Controls.Add(this.cmbHotel);
            this.panelFormulariosHijos.Controls.Add(this.txtPrecio);
            this.panelFormulariosHijos.Controls.Add(this.label2);
            this.panelFormulariosHijos.Controls.Add(this.label1);
            this.panelFormulariosHijos.Controls.Add(this.label3);
            this.panelFormulariosHijos.Controls.Add(this.BtnAgregarSerXHot);
            this.panelFormulariosHijos.Controls.Add(this.BtnModificarSerXHot);
            this.panelFormulariosHijos.Controls.Add(this.BtnLimpiarCampos);
            this.panelFormulariosHijos.Controls.Add(this.dataGridView1);
            this.panelFormulariosHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulariosHijos.Location = new System.Drawing.Point(0, 0);
            this.panelFormulariosHijos.Name = "panelFormulariosHijos";
            this.panelFormulariosHijos.Size = new System.Drawing.Size(733, 426);
            this.panelFormulariosHijos.TabIndex = 9;
            // 
            // cmbServicio
            // 
            this.cmbServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmbServicio.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(60, 96);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 21);
            this.cmbServicio.TabIndex = 14;
            // 
            // cmbHotel
            // 
            this.cmbHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmbHotel.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbHotel.FormattingEnabled = true;
            this.cmbHotel.Location = new System.Drawing.Point(60, 42);
            this.cmbHotel.Name = "cmbHotel";
            this.cmbHotel.Size = new System.Drawing.Size(121, 21);
            this.cmbHotel.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecio.Location = new System.Drawing.Point(60, 148);
            this.txtPrecio.Mask = "999999999";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(67, 20);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio";
            // 
            // BtnAgregarSerXHot
            // 
            this.BtnAgregarSerXHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregarSerXHot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarSerXHot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAgregarSerXHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarSerXHot.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarSerXHot.Location = new System.Drawing.Point(191, 190);
            this.BtnAgregarSerXHot.Name = "BtnAgregarSerXHot";
            this.BtnAgregarSerXHot.Size = new System.Drawing.Size(144, 23);
            this.BtnAgregarSerXHot.TabIndex = 6;
            this.BtnAgregarSerXHot.Text = "Añadir Servicio a un Hotel";
            this.BtnAgregarSerXHot.UseVisualStyleBackColor = false;
            this.BtnAgregarSerXHot.Click += new System.EventHandler(this.BtnAgregarSerXHot_Click);
            // 
            // BtnModificarSerXHot
            // 
            this.BtnModificarSerXHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnModificarSerXHot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarSerXHot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnModificarSerXHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarSerXHot.ForeColor = System.Drawing.Color.White;
            this.BtnModificarSerXHot.Location = new System.Drawing.Point(355, 190);
            this.BtnModificarSerXHot.Name = "BtnModificarSerXHot";
            this.BtnModificarSerXHot.Size = new System.Drawing.Size(175, 23);
            this.BtnModificarSerXHot.TabIndex = 5;
            this.BtnModificarSerXHot.Text = "Modificar Servicio, Hotel o precio";
            this.BtnModificarSerXHot.UseVisualStyleBackColor = false;
            this.BtnModificarSerXHot.Click += new System.EventHandler(this.BtnModificarSerXHot_Click);
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(60, 190);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(102, 23);
            this.BtnLimpiarCampos.TabIndex = 4;
            this.BtnLimpiarCampos.Text = "Limpiar Campos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            this.BtnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Hotel,
            this.Id_Servicio,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(60, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id_Hotel
            // 
            this.Id_Hotel.DataPropertyName = "Id_Hotel";
            this.Id_Hotel.HeaderText = "Id Hotel";
            this.Id_Hotel.Name = "Id_Hotel";
            this.Id_Hotel.ReadOnly = true;
            this.Id_Hotel.Width = 150;
            // 
            // Id_Servicio
            // 
            this.Id_Servicio.DataPropertyName = "Id_Servicio";
            this.Id_Servicio.HeaderText = "Servicio";
            this.Id_Servicio.Name = "Id_Servicio";
            this.Id_Servicio.ReadOnly = true;
            this.Id_Servicio.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioServicio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 200;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(553, 190);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(102, 23);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // AltaServicioXHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.panelFormulariosHijos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaServicioXHotel";
            this.Text = "AltaServicioXHotel";
            this.panelFormulariosHijos.ResumeLayout(false);
            this.panelFormulariosHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulariosHijos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregarSerXHot;
        private System.Windows.Forms.Button BtnModificarSerXHot;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.ComboBox cmbHotel;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnEliminar;
    }
}