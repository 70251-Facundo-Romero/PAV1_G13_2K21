
namespace TP.P.A.V.I
{
    partial class Servicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomServ = new System.Windows.Forms.TextBox();
            this.lblNombrePuesto = new System.Windows.Forms.Label();
            this.grillaServicios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAgregarServ = new System.Windows.Forms.Button();
            this.btnActualizarServ = new System.Windows.Forms.Button();
            this.btnEliminarServ = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(614, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SkyBlue;
            this.label4.Location = new System.Drawing.Point(611, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Servicios";
            // 
            // txtNomServ
            // 
            this.txtNomServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNomServ.ForeColor = System.Drawing.Color.White;
            this.txtNomServ.Location = new System.Drawing.Point(81, 51);
            this.txtNomServ.Multiline = true;
            this.txtNomServ.Name = "txtNomServ";
            this.txtNomServ.Size = new System.Drawing.Size(369, 32);
            this.txtNomServ.TabIndex = 21;
            // 
            // lblNombrePuesto
            // 
            this.lblNombrePuesto.AutoSize = true;
            this.lblNombrePuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePuesto.ForeColor = System.Drawing.Color.White;
            this.lblNombrePuesto.Location = new System.Drawing.Point(78, 31);
            this.lblNombrePuesto.Name = "lblNombrePuesto";
            this.lblNombrePuesto.Size = new System.Drawing.Size(138, 17);
            this.lblNombrePuesto.TabIndex = 22;
            this.lblNombrePuesto.Text = "Nombre del Servicio";
            // 
            // grillaServicios
            // 
            this.grillaServicios.AllowUserToAddRows = false;
            this.grillaServicios.AllowUserToDeleteRows = false;
            this.grillaServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaServicios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grillaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaServicios.DefaultCellStyle = dataGridViewCellStyle1;
            this.grillaServicios.GridColor = System.Drawing.Color.White;
            this.grillaServicios.Location = new System.Drawing.Point(54, 137);
            this.grillaServicios.Name = "grillaServicios";
            this.grillaServicios.ReadOnly = true;
            this.grillaServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grillaServicios.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.grillaServicios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grillaServicios.Size = new System.Drawing.Size(396, 262);
            this.grillaServicios.TabIndex = 23;
            this.grillaServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaServicios_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre del Servicio";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(81, 99);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 32);
            this.txtId.TabIndex = 24;
            this.txtId.Visible = false;
            // 
            // btnAgregarServ
            // 
            this.btnAgregarServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarServ.FlatAppearance.BorderSize = 0;
            this.btnAgregarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServ.ForeColor = System.Drawing.Color.White;
            this.btnAgregarServ.Location = new System.Drawing.Point(472, 137);
            this.btnAgregarServ.Name = "btnAgregarServ";
            this.btnAgregarServ.Size = new System.Drawing.Size(138, 30);
            this.btnAgregarServ.TabIndex = 26;
            this.btnAgregarServ.Text = "Agregar Servicio";
            this.btnAgregarServ.UseVisualStyleBackColor = false;
            this.btnAgregarServ.Click += new System.EventHandler(this.btnAgregarPdt_Click);
            // 
            // btnActualizarServ
            // 
            this.btnActualizarServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActualizarServ.FlatAppearance.BorderSize = 0;
            this.btnActualizarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarServ.ForeColor = System.Drawing.Color.White;
            this.btnActualizarServ.Location = new System.Drawing.Point(472, 186);
            this.btnActualizarServ.Name = "btnActualizarServ";
            this.btnActualizarServ.Size = new System.Drawing.Size(138, 30);
            this.btnActualizarServ.TabIndex = 28;
            this.btnActualizarServ.Text = "Actualizar Servicio";
            this.btnActualizarServ.UseVisualStyleBackColor = false;
            this.btnActualizarServ.Click += new System.EventHandler(this.btnActualizarServ_Click);
            // 
            // btnEliminarServ
            // 
            this.btnEliminarServ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarServ.FlatAppearance.BorderSize = 0;
            this.btnEliminarServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServ.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServ.ForeColor = System.Drawing.Color.White;
            this.btnEliminarServ.Location = new System.Drawing.Point(472, 236);
            this.btnEliminarServ.Name = "btnEliminarServ";
            this.btnEliminarServ.Size = new System.Drawing.Size(138, 30);
            this.btnEliminarServ.TabIndex = 30;
            this.btnEliminarServ.Text = "Eliminar Servicio";
            this.btnEliminarServ.UseVisualStyleBackColor = false;
            this.btnEliminarServ.Click += new System.EventHandler(this.btnEliminarServ_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(472, 51);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(110, 37);
            this.btnLimpiarCampos.TabIndex = 31;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarServ);
            this.Controls.Add(this.btnActualizarServ);
            this.Controls.Add(this.btnAgregarServ);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.grillaServicios);
            this.Controls.Add(this.lblNombrePuesto);
            this.Controls.Add(this.txtNomServ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomServ;
        private System.Windows.Forms.Label lblNombrePuesto;
        private System.Windows.Forms.DataGridView grillaServicios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAgregarServ;
        private System.Windows.Forms.Button btnActualizarServ;
        private System.Windows.Forms.Button btnEliminarServ;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}