
namespace TP.P.A.V.I
{
    partial class AltaTarjeta
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
            this.Tarjeta = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnLimpiarCampos = new System.Windows.Forms.Button();
            this.BtnAgregarTarjeta = new System.Windows.Forms.Button();
            this.BtnModificarTarjeta = new System.Windows.Forms.Button();
            this.GrillaTarjeta = new System.Windows.Forms.DataGridView();
            this.Id_Tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnEliminarTarjeta = new System.Windows.Forms.Button();
            this.panelFormulariosHijos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormulariosHijos
            // 
            this.panelFormulariosHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFormulariosHijos.Controls.Add(this.btnEliminarTarjeta);
            this.panelFormulariosHijos.Controls.Add(this.txtid);
            this.panelFormulariosHijos.Controls.Add(this.Tarjeta);
            this.panelFormulariosHijos.Controls.Add(this.txtNombre);
            this.panelFormulariosHijos.Controls.Add(this.BtnLimpiarCampos);
            this.panelFormulariosHijos.Controls.Add(this.BtnAgregarTarjeta);
            this.panelFormulariosHijos.Controls.Add(this.BtnModificarTarjeta);
            this.panelFormulariosHijos.Controls.Add(this.GrillaTarjeta);
            this.panelFormulariosHijos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulariosHijos.Location = new System.Drawing.Point(0, 0);
            this.panelFormulariosHijos.Name = "panelFormulariosHijos";
            this.panelFormulariosHijos.Size = new System.Drawing.Size(733, 426);
            this.panelFormulariosHijos.TabIndex = 9;
            this.panelFormulariosHijos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormulariosHijos_Paint);
            // 
            // Tarjeta
            // 
            this.Tarjeta.AutoSize = true;
            this.Tarjeta.ForeColor = System.Drawing.Color.White;
            this.Tarjeta.Location = new System.Drawing.Point(39, 93);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Size = new System.Drawing.Size(80, 13);
            this.Tarjeta.TabIndex = 8;
            this.Tarjeta.Text = "Nombre Tarjeta";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(42, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(413, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // BtnLimpiarCampos
            // 
            this.BtnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnLimpiarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarCampos.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiarCampos.Location = new System.Drawing.Point(42, 202);
            this.BtnLimpiarCampos.Name = "BtnLimpiarCampos";
            this.BtnLimpiarCampos.Size = new System.Drawing.Size(100, 23);
            this.BtnLimpiarCampos.TabIndex = 6;
            this.BtnLimpiarCampos.Text = "Limpiar Campos";
            this.BtnLimpiarCampos.UseVisualStyleBackColor = false;
            this.BtnLimpiarCampos.Click += new System.EventHandler(this.BtnLimpiarCampos_Click);
            // 
            // BtnAgregarTarjeta
            // 
            this.BtnAgregarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnAgregarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnAgregarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarTarjeta.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarTarjeta.Location = new System.Drawing.Point(334, 202);
            this.BtnAgregarTarjeta.Name = "BtnAgregarTarjeta";
            this.BtnAgregarTarjeta.Size = new System.Drawing.Size(96, 23);
            this.BtnAgregarTarjeta.TabIndex = 5;
            this.BtnAgregarTarjeta.Text = "Agregar Tarjeta";
            this.BtnAgregarTarjeta.UseVisualStyleBackColor = false;
            this.BtnAgregarTarjeta.Click += new System.EventHandler(this.BtnAgregarTarjeta_Click);
            // 
            // BtnModificarTarjeta
            // 
            this.BtnModificarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnModificarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.BtnModificarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarTarjeta.ForeColor = System.Drawing.Color.White;
            this.BtnModificarTarjeta.Location = new System.Drawing.Point(453, 202);
            this.BtnModificarTarjeta.Name = "BtnModificarTarjeta";
            this.BtnModificarTarjeta.Size = new System.Drawing.Size(103, 23);
            this.BtnModificarTarjeta.TabIndex = 4;
            this.BtnModificarTarjeta.Text = "Modificar Tarjeta";
            this.BtnModificarTarjeta.UseVisualStyleBackColor = false;
            this.BtnModificarTarjeta.Click += new System.EventHandler(this.BtnModificarTarjeta_Click);
            // 
            // GrillaTarjeta
            // 
            this.GrillaTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaTarjeta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.GrillaTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaTarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tarjeta,
            this.NombreTarjeta});
            this.GrillaTarjeta.Location = new System.Drawing.Point(42, 236);
            this.GrillaTarjeta.Name = "GrillaTarjeta";
            this.GrillaTarjeta.Size = new System.Drawing.Size(643, 150);
            this.GrillaTarjeta.TabIndex = 1;
            this.GrillaTarjeta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaTarjeta_CellContentClick);
            // 
            // Id_Tarjeta
            // 
            this.Id_Tarjeta.DataPropertyName = "Id_Tarjeta";
            this.Id_Tarjeta.HeaderText = "ID";
            this.Id_Tarjeta.Name = "Id_Tarjeta";
            // 
            // NombreTarjeta
            // 
            this.NombreTarjeta.DataPropertyName = "Nombre";
            this.NombreTarjeta.HeaderText = "Nombre de la Tarjeta";
            this.NombreTarjeta.Name = "NombreTarjeta";
            this.NombreTarjeta.Width = 500;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtid.Location = new System.Drawing.Point(42, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(26, 20);
            this.txtid.TabIndex = 9;
            this.txtid.Visible = false;
            // 
            // btnEliminarTarjeta
            // 
            this.btnEliminarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEliminarTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTarjeta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTarjeta.Location = new System.Drawing.Point(585, 202);
            this.btnEliminarTarjeta.Name = "btnEliminarTarjeta";
            this.btnEliminarTarjeta.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarTarjeta.TabIndex = 10;
            this.btnEliminarTarjeta.Text = "Eliminar Tarjeta";
            this.btnEliminarTarjeta.UseVisualStyleBackColor = false;
            this.btnEliminarTarjeta.Click += new System.EventHandler(this.btnEliminarTarjeta_Click);
            // 
            // AltaTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.panelFormulariosHijos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaTarjeta";
            this.Text = "AltaTarjeta";
            this.panelFormulariosHijos.ResumeLayout(false);
            this.panelFormulariosHijos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormulariosHijos;
        private System.Windows.Forms.DataGridView GrillaTarjeta;
        private System.Windows.Forms.Button BtnLimpiarCampos;
        private System.Windows.Forms.Button BtnAgregarTarjeta;
        private System.Windows.Forms.Button BtnModificarTarjeta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTarjeta;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnEliminarTarjeta;
    }
}