﻿
namespace TP.P.A.V.I
{
    partial class Instalacion_por_huesped
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
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.cmb_Habitacion = new System.Windows.Forms.ComboBox();
            this.msk_FechaUso = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Hotel = new System.Windows.Forms.ComboBox();
            this.msk_FechaAlojamiento = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminarIXH = new System.Windows.Forms.Button();
            this.btnModificarIXH = new System.Windows.Forms.Button();
            this.btnAgregarIXH = new System.Windows.Forms.Button();
            this.grillaInstalacion = new System.Windows.Forms.DataGridView();
            this.Id_IXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Instalacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_FechaAlojamiento = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Instalacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaInstalacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_Id.ForeColor = System.Drawing.Color.White;
            this.txt_Id.Location = new System.Drawing.Point(91, 9);
            this.txt_Id.Multiline = true;
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(36, 20);
            this.txt_Id.TabIndex = 94;
            this.txt_Id.Visible = false;
            // 
            // cmb_Habitacion
            // 
            this.cmb_Habitacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Habitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Habitacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Habitacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_Habitacion.FormattingEnabled = true;
            this.cmb_Habitacion.Location = new System.Drawing.Point(216, 105);
            this.cmb_Habitacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Habitacion.Name = "cmb_Habitacion";
            this.cmb_Habitacion.Size = new System.Drawing.Size(236, 25);
            this.cmb_Habitacion.TabIndex = 91;
            // 
            // msk_FechaUso
            // 
            this.msk_FechaUso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_FechaUso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.msk_FechaUso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_FechaUso.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.msk_FechaUso.Location = new System.Drawing.Point(216, 211);
            this.msk_FechaUso.Margin = new System.Windows.Forms.Padding(2);
            this.msk_FechaUso.Mask = "00/00/0000 00:00";
            this.msk_FechaUso.Name = "msk_FechaUso";
            this.msk_FechaUso.Size = new System.Drawing.Size(198, 22);
            this.msk_FechaUso.TabIndex = 89;
            this.msk_FechaUso.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_Hotel
            // 
            this.cmb_Hotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Hotel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Hotel.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_Hotel.FormattingEnabled = true;
            this.cmb_Hotel.Location = new System.Drawing.Point(216, 68);
            this.cmb_Hotel.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Hotel.Name = "cmb_Hotel";
            this.cmb_Hotel.Size = new System.Drawing.Size(236, 25);
            this.cmb_Hotel.TabIndex = 88;
            // 
            // msk_FechaAlojamiento
            // 
            this.msk_FechaAlojamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msk_FechaAlojamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.msk_FechaAlojamiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_FechaAlojamiento.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.msk_FechaAlojamiento.Location = new System.Drawing.Point(216, 178);
            this.msk_FechaAlojamiento.Margin = new System.Windows.Forms.Padding(2);
            this.msk_FechaAlojamiento.Mask = "00/00/0000";
            this.msk_FechaAlojamiento.Name = "msk_FechaAlojamiento";
            this.msk_FechaAlojamiento.Size = new System.Drawing.Size(198, 22);
            this.msk_FechaAlojamiento.TabIndex = 87;
            this.msk_FechaAlojamiento.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SkyBlue;
            this.label9.Location = new System.Drawing.Point(619, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 86;
            this.label9.Text = "Hoteleria";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(379, 265);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 24);
            this.btnLimpiar.TabIndex = 84;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminarIXH
            // 
            this.btnEliminarIXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminarIXH.FlatAppearance.BorderSize = 0;
            this.btnEliminarIXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarIXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIXH.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIXH.Location = new System.Drawing.Point(263, 265);
            this.btnEliminarIXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarIXH.Name = "btnEliminarIXH";
            this.btnEliminarIXH.Size = new System.Drawing.Size(112, 24);
            this.btnEliminarIXH.TabIndex = 83;
            this.btnEliminarIXH.Text = "Eliminar";
            this.btnEliminarIXH.UseVisualStyleBackColor = false;
            this.btnEliminarIXH.Click += new System.EventHandler(this.btnEliminarIXH_Click);
            // 
            // btnModificarIXH
            // 
            this.btnModificarIXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificarIXH.FlatAppearance.BorderSize = 0;
            this.btnModificarIXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarIXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIXH.ForeColor = System.Drawing.Color.White;
            this.btnModificarIXH.Location = new System.Drawing.Point(147, 265);
            this.btnModificarIXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarIXH.Name = "btnModificarIXH";
            this.btnModificarIXH.Size = new System.Drawing.Size(112, 24);
            this.btnModificarIXH.TabIndex = 82;
            this.btnModificarIXH.Text = "Modificar";
            this.btnModificarIXH.UseVisualStyleBackColor = false;
            this.btnModificarIXH.Click += new System.EventHandler(this.btnModificarIXH_Click);
            // 
            // btnAgregarIXH
            // 
            this.btnAgregarIXH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAgregarIXH.FlatAppearance.BorderSize = 0;
            this.btnAgregarIXH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIXH.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIXH.ForeColor = System.Drawing.Color.White;
            this.btnAgregarIXH.Location = new System.Drawing.Point(31, 265);
            this.btnAgregarIXH.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarIXH.Name = "btnAgregarIXH";
            this.btnAgregarIXH.Size = new System.Drawing.Size(112, 24);
            this.btnAgregarIXH.TabIndex = 81;
            this.btnAgregarIXH.Text = "Agregar";
            this.btnAgregarIXH.UseVisualStyleBackColor = false;
            this.btnAgregarIXH.Click += new System.EventHandler(this.btnAgregarIXH_Click);
            // 
            // grillaInstalacion
            // 
            this.grillaInstalacion.AllowUserToAddRows = false;
            this.grillaInstalacion.AllowUserToDeleteRows = false;
            this.grillaInstalacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaInstalacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grillaInstalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaInstalacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_IXH,
            this.Hotel,
            this.Habitacion,
            this.Id_Instalacion,
            this.FechaAloj,
            this.FechaUso});
            this.grillaInstalacion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grillaInstalacion.Location = new System.Drawing.Point(31, 293);
            this.grillaInstalacion.Margin = new System.Windows.Forms.Padding(2);
            this.grillaInstalacion.Name = "grillaInstalacion";
            this.grillaInstalacion.ReadOnly = true;
            this.grillaInstalacion.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.grillaInstalacion.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaInstalacion.RowTemplate.Height = 24;
            this.grillaInstalacion.Size = new System.Drawing.Size(691, 126);
            this.grillaInstalacion.TabIndex = 80;
            this.grillaInstalacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaInstalacion_CellClick);
            // 
            // Id_IXH
            // 
            this.Id_IXH.DataPropertyName = "Id_IXH";
            this.Id_IXH.HeaderText = "Id";
            this.Id_IXH.Name = "Id_IXH";
            this.Id_IXH.ReadOnly = true;
            this.Id_IXH.Width = 50;
            // 
            // Hotel
            // 
            this.Hotel.DataPropertyName = "Id_Hotel";
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            // 
            // Habitacion
            // 
            this.Habitacion.DataPropertyName = "Id_Habitacion";
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            this.Habitacion.ReadOnly = true;
            this.Habitacion.Width = 60;
            // 
            // Id_Instalacion
            // 
            this.Id_Instalacion.DataPropertyName = "Id_Instalacion";
            this.Id_Instalacion.HeaderText = "Id Instalación";
            this.Id_Instalacion.Name = "Id_Instalacion";
            this.Id_Instalacion.ReadOnly = true;
            this.Id_Instalacion.Width = 80;
            // 
            // FechaAloj
            // 
            this.FechaAloj.DataPropertyName = "FechaAlojamiento";
            this.FechaAloj.HeaderText = "Fecha Alojamiento";
            this.FechaAloj.Name = "FechaAloj";
            this.FechaAloj.ReadOnly = true;
            this.FechaAloj.Width = 150;
            // 
            // FechaUso
            // 
            this.FechaUso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaUso.DataPropertyName = "FechaUso";
            this.FechaUso.HeaderText = "Fecha y hora de uso";
            this.FechaUso.Name = "FechaUso";
            this.FechaUso.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(157, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 79;
            this.label7.Text = "Hotel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(42, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Fecha y hora de uso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 75;
            this.label3.Text = "Id Habitación:";
            // 
            // lbl_FechaAlojamiento
            // 
            this.lbl_FechaAlojamiento.AutoSize = true;
            this.lbl_FechaAlojamiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaAlojamiento.ForeColor = System.Drawing.Color.White;
            this.lbl_FechaAlojamiento.Location = new System.Drawing.Point(27, 178);
            this.lbl_FechaAlojamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaAlojamiento.Name = "lbl_FechaAlojamiento";
            this.lbl_FechaAlojamiento.Size = new System.Drawing.Size(185, 21);
            this.lbl_FechaAlojamiento.TabIndex = 74;
            this.lbl_FechaAlojamiento.Text = "Fecha de alojamiento:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox2.Location = new System.Drawing.Point(502, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 97;
            this.label4.Text = "Instalación:";
            // 
            // cmb_Instalacion
            // 
            this.cmb_Instalacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Instalacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_Instalacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Instalacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Instalacion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmb_Instalacion.FormattingEnabled = true;
            this.cmb_Instalacion.Location = new System.Drawing.Point(216, 142);
            this.cmb_Instalacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Instalacion.Name = "cmb_Instalacion";
            this.cmb_Instalacion.Size = new System.Drawing.Size(236, 25);
            this.cmb_Instalacion.TabIndex = 98;
            // 
            // Instalacion_por_huesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(733, 426);
            this.Controls.Add(this.cmb_Instalacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.cmb_Habitacion);
            this.Controls.Add(this.msk_FechaUso);
            this.Controls.Add(this.cmb_Hotel);
            this.Controls.Add(this.msk_FechaAlojamiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminarIXH);
            this.Controls.Add(this.btnModificarIXH);
            this.Controls.Add(this.btnAgregarIXH);
            this.Controls.Add(this.grillaInstalacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_FechaAlojamiento);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Instalacion_por_huesped";
            this.Text = "Instalacion por huesped";
            this.Load += new System.EventHandler(this.Instalacion_por_huesped_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaInstalacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.ComboBox cmb_Habitacion;
        private System.Windows.Forms.MaskedTextBox msk_FechaUso;
        private System.Windows.Forms.ComboBox cmb_Hotel;
        private System.Windows.Forms.MaskedTextBox msk_FechaAlojamiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminarIXH;
        private System.Windows.Forms.Button btnModificarIXH;
        private System.Windows.Forms.Button btnAgregarIXH;
        private System.Windows.Forms.DataGridView grillaInstalacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_FechaAlojamiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Instalacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_IXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Instalacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUso;
    }
}