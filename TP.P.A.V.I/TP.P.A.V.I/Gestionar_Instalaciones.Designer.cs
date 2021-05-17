
namespace TP.P.A.V.I
{
    partial class Gestionar_Instalaciones
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
            this.GestionarInstalaciones = new System.Windows.Forms.GroupBox();
            this.str_Id = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Str_Descripcion_Ints = new System.Windows.Forms.RichTextBox();
            this.Descripcion_inst = new System.Windows.Forms.Label();
            this.EnviarInstalaciones = new System.Windows.Forms.Button();
            this.Cb_Options_inst = new System.Windows.Forms.ComboBox();
            this.NombreHabitaciones = new System.Windows.Forms.Label();
            this.Optinons = new System.Windows.Forms.Label();
            this.Str_Nombre_inst = new System.Windows.Forms.TextBox();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GestionarInstalaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // GestionarInstalaciones
            // 
            this.GestionarInstalaciones.Controls.Add(this.str_Id);
            this.GestionarInstalaciones.Controls.Add(this.Clear);
            this.GestionarInstalaciones.Controls.Add(this.Str_Descripcion_Ints);
            this.GestionarInstalaciones.Controls.Add(this.Descripcion_inst);
            this.GestionarInstalaciones.Controls.Add(this.EnviarInstalaciones);
            this.GestionarInstalaciones.Controls.Add(this.Cb_Options_inst);
            this.GestionarInstalaciones.Controls.Add(this.NombreHabitaciones);
            this.GestionarInstalaciones.Controls.Add(this.Optinons);
            this.GestionarInstalaciones.Controls.Add(this.Str_Nombre_inst);
            this.GestionarInstalaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestionarInstalaciones.ForeColor = System.Drawing.Color.White;
            this.GestionarInstalaciones.Location = new System.Drawing.Point(12, 12);
            this.GestionarInstalaciones.Name = "GestionarInstalaciones";
            this.GestionarInstalaciones.Size = new System.Drawing.Size(618, 232);
            this.GestionarInstalaciones.TabIndex = 2;
            this.GestionarInstalaciones.TabStop = false;
            this.GestionarInstalaciones.Text = "GestionarHabitaciones";
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
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Clear.Location = new System.Drawing.Point(501, 162);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(83, 35);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Limpiar";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Str_Descripcion_Ints
            // 
            this.Str_Descripcion_Ints.Location = new System.Drawing.Point(139, 96);
            this.Str_Descripcion_Ints.Name = "Str_Descripcion_Ints";
            this.Str_Descripcion_Ints.Size = new System.Drawing.Size(231, 110);
            this.Str_Descripcion_Ints.TabIndex = 6;
            this.Str_Descripcion_Ints.Text = "";
            // 
            // Descripcion_inst
            // 
            this.Descripcion_inst.AutoSize = true;
            this.Descripcion_inst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion_inst.ForeColor = System.Drawing.Color.White;
            this.Descripcion_inst.Location = new System.Drawing.Point(29, 96);
            this.Descripcion_inst.Name = "Descripcion_inst";
            this.Descripcion_inst.Size = new System.Drawing.Size(104, 19);
            this.Descripcion_inst.TabIndex = 5;
            this.Descripcion_inst.Text = "Descripción:";
            // 
            // EnviarInstalaciones
            // 
            this.EnviarInstalaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.EnviarInstalaciones.Location = new System.Drawing.Point(501, 121);
            this.EnviarInstalaciones.Name = "EnviarInstalaciones";
            this.EnviarInstalaciones.Size = new System.Drawing.Size(83, 35);
            this.EnviarInstalaciones.TabIndex = 4;
            this.EnviarInstalaciones.Text = "Enviar";
            this.EnviarInstalaciones.UseVisualStyleBackColor = false;
            this.EnviarInstalaciones.Click += new System.EventHandler(this.EnviarInstalaciones_Click);
            // 
            // Cb_Options_inst
            // 
            this.Cb_Options_inst.FormattingEnabled = true;
            this.Cb_Options_inst.Location = new System.Drawing.Point(463, 39);
            this.Cb_Options_inst.Name = "Cb_Options_inst";
            this.Cb_Options_inst.Size = new System.Drawing.Size(121, 27);
            this.Cb_Options_inst.TabIndex = 3;
            // 
            // NombreHabitaciones
            // 
            this.NombreHabitaciones.AutoSize = true;
            this.NombreHabitaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreHabitaciones.ForeColor = System.Drawing.Color.White;
            this.NombreHabitaciones.Location = new System.Drawing.Point(15, 42);
            this.NombreHabitaciones.Name = "NombreHabitaciones";
            this.NombreHabitaciones.Size = new System.Drawing.Size(206, 19);
            this.NombreHabitaciones.TabIndex = 0;
            this.NombreHabitaciones.Text = "Nombre de Instalaciones:";
            // 
            // Optinons
            // 
            this.Optinons.AutoSize = true;
            this.Optinons.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Optinons.ForeColor = System.Drawing.Color.White;
            this.Optinons.Location = new System.Drawing.Point(386, 42);
            this.Optinons.Name = "Optinons";
            this.Optinons.Size = new System.Drawing.Size(71, 19);
            this.Optinons.TabIndex = 2;
            this.Optinons.Text = "Options:";
            // 
            // Str_Nombre_inst
            // 
            this.Str_Nombre_inst.Location = new System.Drawing.Point(227, 41);
            this.Str_Nombre_inst.Name = "Str_Nombre_inst";
            this.Str_Nombre_inst.Size = new System.Drawing.Size(143, 27);
            this.Str_Nombre_inst.TabIndex = 1;
            // 
            // Viewer
            // 
            this.Viewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
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
            this.Viewer.Location = new System.Drawing.Point(12, 269);
            this.Viewer.Name = "Viewer";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Viewer.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Viewer.Size = new System.Drawing.Size(618, 150);
            this.Viewer.TabIndex = 3;
            this.Viewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewer_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id _Instalaciones";
            this.id.Name = "id";
            this.id.Width = 175;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "Nombre";
            this.Habitacion.HeaderText = "Nombre Instalaciones";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion ";
            this.Descripcion.HeaderText = "Nombre Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 200;
            // 
            // Gestionar_Instalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(63)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.GestionarInstalaciones);
            this.Name = "Gestionar_Instalaciones";
            this.Text = "Gestionar_Instalaciones";
            this.Load += new System.EventHandler(this.Gestionar_Instalaciones_Load);
            this.GestionarInstalaciones.ResumeLayout(false);
            this.GestionarInstalaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GestionarInstalaciones;
        private System.Windows.Forms.TextBox str_Id;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.RichTextBox Str_Descripcion_Ints;
        private System.Windows.Forms.Label Descripcion_inst;
        private System.Windows.Forms.Button EnviarInstalaciones;
        private System.Windows.Forms.ComboBox Cb_Options_inst;
        private System.Windows.Forms.Label NombreHabitaciones;
        private System.Windows.Forms.Label Optinons;
        private System.Windows.Forms.TextBox Str_Nombre_inst;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}