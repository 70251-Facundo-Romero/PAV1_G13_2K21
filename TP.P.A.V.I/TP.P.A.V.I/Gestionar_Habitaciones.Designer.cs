
namespace TP.P.A.V.I
{
    partial class Gestionar_Habitaciones
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
            this.GestionarHabitaciones = new System.Windows.Forms.GroupBox();
            this.str_Id = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Str_Descripcion_Hab = new System.Windows.Forms.RichTextBox();
            this.Descripcion_hab = new System.Windows.Forms.Label();
            this.EnviarHabilitaciones = new System.Windows.Forms.Button();
            this.Cb_Options_hab = new System.Windows.Forms.ComboBox();
            this.NombreHabitaciones = new System.Windows.Forms.Label();
            this.Optinons = new System.Windows.Forms.Label();
            this.Str_Nombre_hab = new System.Windows.Forms.TextBox();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GestionarHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionarHabitaciones
            // 
            this.GestionarHabitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GestionarHabitaciones.Controls.Add(this.str_Id);
            this.GestionarHabitaciones.Controls.Add(this.Clear);
            this.GestionarHabitaciones.Controls.Add(this.Str_Descripcion_Hab);
            this.GestionarHabitaciones.Controls.Add(this.Descripcion_hab);
            this.GestionarHabitaciones.Controls.Add(this.EnviarHabilitaciones);
            this.GestionarHabitaciones.Controls.Add(this.Cb_Options_hab);
            this.GestionarHabitaciones.Controls.Add(this.NombreHabitaciones);
            this.GestionarHabitaciones.Controls.Add(this.Optinons);
            this.GestionarHabitaciones.Controls.Add(this.Str_Nombre_hab);
            this.GestionarHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionarHabitaciones.ForeColor = System.Drawing.Color.White;
            this.GestionarHabitaciones.Location = new System.Drawing.Point(12, 12);
            this.GestionarHabitaciones.Name = "GestionarHabitaciones";
            this.GestionarHabitaciones.Size = new System.Drawing.Size(591, 232);
            this.GestionarHabitaciones.TabIndex = 1;
            this.GestionarHabitaciones.TabStop = false;
            this.GestionarHabitaciones.Text = "Gestionar Habitaciones";
            // 
            // str_Id
            // 
            this.str_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.str_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.str_Id.Location = new System.Drawing.Point(33, 138);
            this.str_Id.Name = "str_Id";
            this.str_Id.Size = new System.Drawing.Size(25, 20);
            this.str_Id.TabIndex = 9;
            this.str_Id.Visible = false;
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Location = new System.Drawing.Point(501, 162);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(83, 35);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Limpiar";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Str_Descripcion_Hab
            // 
            this.Str_Descripcion_Hab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Str_Descripcion_Hab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Str_Descripcion_Hab.ForeColor = System.Drawing.Color.White;
            this.Str_Descripcion_Hab.Location = new System.Drawing.Point(139, 96);
            this.Str_Descripcion_Hab.Name = "Str_Descripcion_Hab";
            this.Str_Descripcion_Hab.Size = new System.Drawing.Size(318, 110);
            this.Str_Descripcion_Hab.TabIndex = 6;
            this.Str_Descripcion_Hab.Text = "";
            // 
            // Descripcion_hab
            // 
            this.Descripcion_hab.AutoSize = true;
            this.Descripcion_hab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_hab.ForeColor = System.Drawing.Color.White;
            this.Descripcion_hab.Location = new System.Drawing.Point(29, 96);
            this.Descripcion_hab.Name = "Descripcion_hab";
            this.Descripcion_hab.Size = new System.Drawing.Size(104, 19);
            this.Descripcion_hab.TabIndex = 5;
            this.Descripcion_hab.Text = "Descripción:";
            // 
            // EnviarHabilitaciones
            // 
            this.EnviarHabilitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnviarHabilitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EnviarHabilitaciones.FlatAppearance.BorderSize = 0;
            this.EnviarHabilitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarHabilitaciones.Location = new System.Drawing.Point(501, 121);
            this.EnviarHabilitaciones.Name = "EnviarHabilitaciones";
            this.EnviarHabilitaciones.Size = new System.Drawing.Size(83, 35);
            this.EnviarHabilitaciones.TabIndex = 4;
            this.EnviarHabilitaciones.Text = "Enviar";
            this.EnviarHabilitaciones.UseVisualStyleBackColor = false;
            this.EnviarHabilitaciones.Click += new System.EventHandler(this.EnviarHabitaciones_Click);
            // 
            // Cb_Options_hab
            // 
            this.Cb_Options_hab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_Options_hab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Cb_Options_hab.ForeColor = System.Drawing.Color.White;
            this.Cb_Options_hab.FormattingEnabled = true;
            this.Cb_Options_hab.Location = new System.Drawing.Point(463, 39);
            this.Cb_Options_hab.Name = "Cb_Options_hab";
            this.Cb_Options_hab.Size = new System.Drawing.Size(121, 27);
            this.Cb_Options_hab.TabIndex = 3;
            // 
            // NombreHabitaciones
            // 
            this.NombreHabitaciones.AutoSize = true;
            this.NombreHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreHabitaciones.ForeColor = System.Drawing.Color.White;
            this.NombreHabitaciones.Location = new System.Drawing.Point(15, 42);
            this.NombreHabitaciones.Name = "NombreHabitaciones";
            this.NombreHabitaciones.Size = new System.Drawing.Size(208, 19);
            this.NombreHabitaciones.TabIndex = 0;
            this.NombreHabitaciones.Text = "Nombre de Habitaciones:";
            // 
            // Optinons
            // 
            this.Optinons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Optinons.AutoSize = true;
            this.Optinons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optinons.ForeColor = System.Drawing.Color.White;
            this.Optinons.Location = new System.Drawing.Point(386, 42);
            this.Optinons.Name = "Optinons";
            this.Optinons.Size = new System.Drawing.Size(71, 19);
            this.Optinons.TabIndex = 2;
            this.Optinons.Text = "Options:";
            // 
            // Str_Nombre_hab
            // 
            this.Str_Nombre_hab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Str_Nombre_hab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Str_Nombre_hab.ForeColor = System.Drawing.Color.White;
            this.Str_Nombre_hab.Location = new System.Drawing.Point(227, 41);
            this.Str_Nombre_hab.Name = "Str_Nombre_hab";
            this.Str_Nombre_hab.Size = new System.Drawing.Size(143, 27);
            this.Str_Nombre_hab.TabIndex = 1;
            // 
            // Viewer
            // 
            this.Viewer.AllowUserToAddRows = false;
            this.Viewer.AllowUserToDeleteRows = false;
            this.Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Viewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Viewer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Viewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Viewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Habitacion,
            this.Descripcion});
            this.Viewer.GridColor = System.Drawing.Color.White;
            this.Viewer.Location = new System.Drawing.Point(12, 264);
            this.Viewer.MultiSelect = false;
            this.Viewer.Name = "Viewer";
            this.Viewer.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Viewer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Viewer.Size = new System.Drawing.Size(709, 150);
            this.Viewer.TabIndex = 0;
            this.Viewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewer_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id _Habitacion";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "Nombre";
            this.Habitacion.HeaderText = "Nombre Habitacion";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.Width = 250;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(634, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Hoteleria";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(632, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // Gestionar_Habitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GestionarHabitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestionar_Habitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar_Habitaciones";
            this.Load += new System.EventHandler(this.Gestionar_Habitaciones_Load);
            this.GestionarHabitaciones.ResumeLayout(false);
            this.GestionarHabitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GestionarHabitaciones;
        private System.Windows.Forms.Button EnviarHabilitaciones;
        private System.Windows.Forms.ComboBox Cb_Options_hab;
        private System.Windows.Forms.Label NombreHabitaciones;
        private System.Windows.Forms.Label Optinons;
        private System.Windows.Forms.TextBox Str_Nombre_hab;
        private System.Windows.Forms.RichTextBox Str_Descripcion_Hab;
        private System.Windows.Forms.Label Descripcion_hab;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.TextBox str_Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}