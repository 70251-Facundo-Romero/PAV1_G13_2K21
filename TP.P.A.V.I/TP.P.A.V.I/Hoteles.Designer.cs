
namespace TP.P.A.V.I
{
    partial class Hoteles
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarHotel = new System.Windows.Forms.Button();
            this.btnActualizarHotel = new System.Windows.Forms.Button();
            this.btnEliminarHotel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreHotel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalleHotel = new System.Windows.Forms.TextBox();
            this.txtNumeroCalle = new System.Windows.Forms.TextBox();
            this.grillaHoteles = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K7G13_2021DataSet2 = new TP.P.A.V.I.BD3K7G13_2021DataSet2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.bD3K7G13_2021DataSet = new TP.P.A.V.I.BD3K7G13_2021DataSet();
            this.bD3K7G132021DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD3K7G13_2021DataSet1 = new TP.P.A.V.I.BD3K7G13_2021DataSet1();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barriosTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSet1TableAdapters.BarriosTableAdapter();
            this.hotelesTableAdapter = new TP.P.A.V.I.BD3K7G13_2021DataSet2TableAdapters.HotelesTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G132021DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar hoteles";
            // 
            // btnAgregarHotel
            // 
            this.btnAgregarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHotel.Location = new System.Drawing.Point(35, 284);
            this.btnAgregarHotel.Name = "btnAgregarHotel";
            this.btnAgregarHotel.Size = new System.Drawing.Size(165, 27);
            this.btnAgregarHotel.TabIndex = 1;
            this.btnAgregarHotel.Text = "Agregar hotel";
            this.btnAgregarHotel.UseVisualStyleBackColor = true;
            this.btnAgregarHotel.Click += new System.EventHandler(this.btnAgregarHotel_Click);
            // 
            // btnActualizarHotel
            // 
            this.btnActualizarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarHotel.Location = new System.Drawing.Point(220, 284);
            this.btnActualizarHotel.Name = "btnActualizarHotel";
            this.btnActualizarHotel.Size = new System.Drawing.Size(181, 27);
            this.btnActualizarHotel.TabIndex = 2;
            this.btnActualizarHotel.Text = "Actualizar Hotel";
            this.btnActualizarHotel.UseVisualStyleBackColor = true;
            this.btnActualizarHotel.Click += new System.EventHandler(this.btnActualizarHotel_Click);
            // 
            // btnEliminarHotel
            // 
            this.btnEliminarHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHotel.Location = new System.Drawing.Point(428, 284);
            this.btnEliminarHotel.Name = "btnEliminarHotel";
            this.btnEliminarHotel.Size = new System.Drawing.Size(182, 27);
            this.btnEliminarHotel.TabIndex = 3;
            this.btnEliminarHotel.Text = "Dar de baja hotel";
            this.btnEliminarHotel.UseVisualStyleBackColor = true;
            this.btnEliminarHotel.Click += new System.EventHandler(this.btnEliminarHotel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(42, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de hotel";
            // 
            // txtNombreHotel
            // 
            this.txtNombreHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNombreHotel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombreHotel.Location = new System.Drawing.Point(229, 78);
            this.txtNombreHotel.Name = "txtNombreHotel";
            this.txtNombreHotel.Size = new System.Drawing.Size(233, 22);
            this.txtNombreHotel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(62, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calle del hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(42, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Calle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(134, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barrio";
            // 
            // txtCalleHotel
            // 
            this.txtCalleHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCalleHotel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCalleHotel.Location = new System.Drawing.Point(229, 129);
            this.txtCalleHotel.Name = "txtCalleHotel";
            this.txtCalleHotel.Size = new System.Drawing.Size(233, 22);
            this.txtCalleHotel.TabIndex = 9;
            // 
            // txtNumeroCalle
            // 
            this.txtNumeroCalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtNumeroCalle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNumeroCalle.Location = new System.Drawing.Point(229, 178);
            this.txtNumeroCalle.Name = "txtNumeroCalle";
            this.txtNumeroCalle.Size = new System.Drawing.Size(233, 22);
            this.txtNumeroCalle.TabIndex = 10;
            // 
            // grillaHoteles
            // 
            this.grillaHoteles.AllowUserToAddRows = false;
            this.grillaHoteles.AllowUserToDeleteRows = false;
            this.grillaHoteles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grillaHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Calle,
            this.Numero,
            this.IdBarrio});
            this.grillaHoteles.Location = new System.Drawing.Point(23, 317);
            this.grillaHoteles.Name = "grillaHoteles";
            this.grillaHoteles.ReadOnly = true;
            this.grillaHoteles.RowHeadersWidth = 51;
            this.grillaHoteles.RowTemplate.Height = 24;
            this.grillaHoteles.Size = new System.Drawing.Size(808, 217);
            this.grillaHoteles.TabIndex = 12;
            this.grillaHoteles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaHoteles_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre del Hotel";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "Calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.MinimumWidth = 6;
            this.Calle.Name = "Calle";
            this.Calle.ReadOnly = true;
            this.Calle.Width = 200;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "NumeroCalle";
            this.Numero.HeaderText = "Numero de calle";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 125;
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "Id_Barrio";
            this.IdBarrio.HeaderText = "Barrio";
            this.IdBarrio.MinimumWidth = 6;
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            this.IdBarrio.Width = 200;
            // 
            // hotelesBindingSource
            // 
            this.hotelesBindingSource.DataMember = "Hoteles";
            this.hotelesBindingSource.DataSource = this.bD3K7G13_2021DataSet2;
            // 
            // bD3K7G13_2021DataSet2
            // 
            this.bD3K7G13_2021DataSet2.DataSetName = "BD3K7G13_2021DataSet2";
            this.bD3K7G13_2021DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(562, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(702, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hoteleria";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(636, 284);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 27);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(229, 225);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(233, 24);
            this.cmbBarrio.TabIndex = 24;
            // 
            // bD3K7G13_2021DataSet
            // 
            this.bD3K7G13_2021DataSet.DataSetName = "BD3K7G13_2021DataSet";
            this.bD3K7G13_2021DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bD3K7G132021DataSetBindingSource
            // 
            this.bD3K7G132021DataSetBindingSource.DataSource = this.bD3K7G13_2021DataSet;
            this.bD3K7G132021DataSetBindingSource.Position = 0;
            // 
            // bD3K7G13_2021DataSet1
            // 
            this.bD3K7G13_2021DataSet1.DataSetName = "BD3K7G13_2021DataSet1";
            this.bD3K7G13_2021DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataMember = "Barrios";
            this.barriosBindingSource.DataSource = this.bD3K7G13_2021DataSet1;
            // 
            // barriosTableAdapter
            // 
            this.barriosTableAdapter.ClearBeforeFill = true;
            // 
            // hotelesTableAdapter
            // 
            this.hotelesTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtId.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtId.Location = new System.Drawing.Point(502, 77);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(53, 22);
            this.txtId.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(468, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Id";
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(836, 552);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grillaHoteles);
            this.Controls.Add(this.txtNumeroCalle);
            this.Controls.Add(this.txtCalleHotel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreHotel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminarHotel);
            this.Controls.Add(this.btnActualizarHotel);
            this.Controls.Add(this.btnAgregarHotel);
            this.Controls.Add(this.label1);
            this.Name = "Hoteles";
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.Hoteles_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grillaHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G132021DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD3K7G13_2021DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarHotel;
        private System.Windows.Forms.Button btnActualizarHotel;
        private System.Windows.Forms.Button btnEliminarHotel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreHotel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalleHotel;
        private System.Windows.Forms.TextBox txtNumeroCalle;
        private System.Windows.Forms.DataGridView grillaHoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private BD3K7G13_2021DataSet bD3K7G13_2021DataSet;
        private System.Windows.Forms.BindingSource bD3K7G132021DataSetBindingSource;
        private BD3K7G13_2021DataSet1 bD3K7G13_2021DataSet1;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private BD3K7G13_2021DataSet1TableAdapters.BarriosTableAdapter barriosTableAdapter;
        private BD3K7G13_2021DataSet2 bD3K7G13_2021DataSet2;
        private System.Windows.Forms.BindingSource hotelesBindingSource;
        private BD3K7G13_2021DataSet2TableAdapters.HotelesTableAdapter hotelesTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
    }
}