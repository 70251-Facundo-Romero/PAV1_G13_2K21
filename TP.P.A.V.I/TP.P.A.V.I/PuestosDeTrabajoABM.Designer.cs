
namespace TP.P.A.V.I
{
    partial class PuestosDeTrabajoABM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuestosDeTrabajoABM));
            this.grillaPuestosTrabajo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombrePuesto = new System.Windows.Forms.Label();
            this.txtNomPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionPdt = new System.Windows.Forms.TextBox();
            this.btnAgregarPdt = new System.Windows.Forms.Button();
            this.btnActualizarPdt = new System.Windows.Forms.Button();
            this.btnEliminarPdt = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPuestosTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPuestosTrabajo
            // 
            this.grillaPuestosTrabajo.AllowUserToAddRows = false;
            this.grillaPuestosTrabajo.AllowUserToDeleteRows = false;
            this.grillaPuestosTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaPuestosTrabajo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grillaPuestosTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPuestosTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Puesto,
            this.Matricula,
            this.DescripcionPuesto});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaPuestosTrabajo.DefaultCellStyle = dataGridViewCellStyle1;
            this.grillaPuestosTrabajo.GridColor = System.Drawing.Color.White;
            this.grillaPuestosTrabajo.Location = new System.Drawing.Point(40, 237);
            this.grillaPuestosTrabajo.Name = "grillaPuestosTrabajo";
            this.grillaPuestosTrabajo.ReadOnly = true;
            this.grillaPuestosTrabajo.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.grillaPuestosTrabajo.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaPuestosTrabajo.Size = new System.Drawing.Size(625, 129);
            this.grillaPuestosTrabajo.TabIndex = 0;
            this.grillaPuestosTrabajo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaPuestosTrabajo_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Puesto
            // 
            this.Puesto.DataPropertyName = "Nombre";
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            this.Puesto.Width = 200;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 120;
            // 
            // DescripcionPuesto
            // 
            this.DescripcionPuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescripcionPuesto.DataPropertyName = "Descripcion";
            this.DescripcionPuesto.HeaderText = "Descripcion Puesto";
            this.DescripcionPuesto.Name = "DescripcionPuesto";
            this.DescripcionPuesto.ReadOnly = true;
            // 
            // lblNombrePuesto
            // 
            this.lblNombrePuesto.AutoSize = true;
            this.lblNombrePuesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePuesto.ForeColor = System.Drawing.Color.White;
            this.lblNombrePuesto.Location = new System.Drawing.Point(54, 7);
            this.lblNombrePuesto.Name = "lblNombrePuesto";
            this.lblNombrePuesto.Size = new System.Drawing.Size(121, 17);
            this.lblNombrePuesto.TabIndex = 1;
            this.lblNombrePuesto.Text = "Nombre del Puesto";
            // 
            // txtNomPuesto
            // 
            this.txtNomPuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNomPuesto.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomPuesto.ForeColor = System.Drawing.Color.White;
            this.txtNomPuesto.Location = new System.Drawing.Point(57, 27);
            this.txtNomPuesto.Multiline = true;
            this.txtNomPuesto.Name = "txtNomPuesto";
            this.txtNomPuesto.Size = new System.Drawing.Size(414, 32);
            this.txtNomPuesto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion del Puesto de Trabajo";
            // 
            // txtDescripcionPdt
            // 
            this.txtDescripcionPdt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionPdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtDescripcionPdt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPdt.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionPdt.Location = new System.Drawing.Point(57, 83);
            this.txtDescripcionPdt.Multiline = true;
            this.txtDescripcionPdt.Name = "txtDescripcionPdt";
            this.txtDescripcionPdt.Size = new System.Drawing.Size(414, 39);
            this.txtDescripcionPdt.TabIndex = 4;
            // 
            // btnAgregarPdt
            // 
            this.btnAgregarPdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarPdt.FlatAppearance.BorderSize = 0;
            this.btnAgregarPdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPdt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPdt.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPdt.Location = new System.Drawing.Point(40, 196);
            this.btnAgregarPdt.Name = "btnAgregarPdt";
            this.btnAgregarPdt.Size = new System.Drawing.Size(189, 30);
            this.btnAgregarPdt.TabIndex = 5;
            this.btnAgregarPdt.Text = "Agregar Puesto de Trabajo";
            this.btnAgregarPdt.UseVisualStyleBackColor = false;
            this.btnAgregarPdt.Click += new System.EventHandler(this.btnAgregarPdt_Click);
            // 
            // btnActualizarPdt
            // 
            this.btnActualizarPdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActualizarPdt.FlatAppearance.BorderSize = 0;
            this.btnActualizarPdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarPdt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPdt.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPdt.Location = new System.Drawing.Point(252, 196);
            this.btnActualizarPdt.Name = "btnActualizarPdt";
            this.btnActualizarPdt.Size = new System.Drawing.Size(203, 30);
            this.btnActualizarPdt.TabIndex = 9;
            this.btnActualizarPdt.Text = "Actualizar Puesto de Trabajo";
            this.btnActualizarPdt.UseVisualStyleBackColor = false;
            this.btnActualizarPdt.Click += new System.EventHandler(this.btnActualizarPdt_Click);
            // 
            // btnEliminarPdt
            // 
            this.btnEliminarPdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarPdt.FlatAppearance.BorderSize = 0;
            this.btnEliminarPdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPdt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPdt.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPdt.Location = new System.Drawing.Point(475, 196);
            this.btnEliminarPdt.Name = "btnEliminarPdt";
            this.btnEliminarPdt.Size = new System.Drawing.Size(204, 30);
            this.btnEliminarPdt.TabIndex = 10;
            this.btnEliminarPdt.Text = "Eliminar Puesto de Trabajo";
            this.btnEliminarPdt.UseVisualStyleBackColor = false;
            this.btnEliminarPdt.Click += new System.EventHandler(this.btnEliminarPdt_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(527, 110);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(84, 47);
            this.btnLimpiarCampos.TabIndex = 11;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Transparent;
            this.salir.ErrorImage = global::TP.P.A.V.I.Properties.Resources.close;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(0, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(33, 38);
            this.salir.TabIndex = 12;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtMatricula.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.White;
            this.txtMatricula.Location = new System.Drawing.Point(57, 145);
            this.txtMatricula.Multiline = true;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(342, 32);
            this.txtMatricula.TabIndex = 14;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(12, 74);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(32, 29);
            this.txtId.TabIndex = 15;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(606, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(561, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Puestos de Trabajo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(252, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "Listado Puestos de Trabajo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.Location = new System.Drawing.Point(459, 406);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(220, 30);
            this.btnEstadistica.TabIndex = 20;
            this.btnEstadistica.Text = "Empleados por Puesto de trabajo";
            this.btnEstadistica.UseVisualStyleBackColor = false;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // PuestosDeTrabajoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.btnEstadistica);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarPdt);
            this.Controls.Add(this.btnActualizarPdt);
            this.Controls.Add(this.btnAgregarPdt);
            this.Controls.Add(this.txtDescripcionPdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomPuesto);
            this.Controls.Add(this.lblNombrePuesto);
            this.Controls.Add(this.grillaPuestosTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PuestosDeTrabajoABM";
            this.Text = "Puestos de Trabajo";
            this.Load += new System.EventHandler(this.PuestosDeTrabajoABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPuestosTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPuestosTrabajo;
        private System.Windows.Forms.Label lblNombrePuesto;
        private System.Windows.Forms.TextBox txtNomPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionPdt;
        private System.Windows.Forms.Button btnAgregarPdt;
        private System.Windows.Forms.Button btnActualizarPdt;
        private System.Windows.Forms.Button btnEliminarPdt;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPuesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEstadistica;
    }
}