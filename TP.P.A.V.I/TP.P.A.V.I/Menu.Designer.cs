﻿namespace TP.P.A.V.I
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuLogin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnServicios = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnHuespedes = new System.Windows.Forms.Button();
            this.BtnHoteles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.MenuLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 35);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoteleria App";
            // 
            // MenuLogin
            // 
            this.MenuLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuLogin.Controls.Add(this.BtnServicios);
            this.MenuLogin.Controls.Add(this.BtnEmpleados);
            this.MenuLogin.Controls.Add(this.BtnHuespedes);
            this.MenuLogin.Controls.Add(this.BtnHoteles);
            this.MenuLogin.Controls.Add(this.panel3);
            this.MenuLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLogin.Location = new System.Drawing.Point(0, 35);
            this.MenuLogin.Name = "MenuLogin";
            this.MenuLogin.Size = new System.Drawing.Size(225, 465);
            this.MenuLogin.TabIndex = 7;
            this.MenuLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuLogin_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 138);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hoteleria";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 465);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnServicios
            // 
            this.BtnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnServicios.FlatAppearance.BorderSize = 0;
            this.BtnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnServicios.ForeColor = System.Drawing.Color.White;
            this.BtnServicios.Image = global::TP.P.A.V.I.Properties.Resources.hotel;
            this.BtnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServicios.Location = new System.Drawing.Point(0, 258);
            this.BtnServicios.Name = "BtnServicios";
            this.BtnServicios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnServicios.Size = new System.Drawing.Size(225, 40);
            this.BtnServicios.TabIndex = 4;
            this.BtnServicios.Text = "Servicios e Instalaciones";
            this.BtnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServicios.UseVisualStyleBackColor = false;
            this.BtnServicios.Click += new System.EventHandler(this.BtnServicios_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.Color.White;
            this.BtnEmpleados.Image = global::TP.P.A.V.I.Properties.Resources.hotel;
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 218);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEmpleados.Size = new System.Drawing.Size(225, 40);
            this.BtnEmpleados.TabIndex = 3;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEmpleados.UseVisualStyleBackColor = false;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnHuespedes
            // 
            this.BtnHuespedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnHuespedes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHuespedes.FlatAppearance.BorderSize = 0;
            this.BtnHuespedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnHuespedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHuespedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHuespedes.ForeColor = System.Drawing.Color.White;
            this.BtnHuespedes.Image = global::TP.P.A.V.I.Properties.Resources.hotel;
            this.BtnHuespedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHuespedes.Location = new System.Drawing.Point(0, 178);
            this.BtnHuespedes.Name = "BtnHuespedes";
            this.BtnHuespedes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHuespedes.Size = new System.Drawing.Size(225, 40);
            this.BtnHuespedes.TabIndex = 2;
            this.BtnHuespedes.Text = "Huespedes";
            this.BtnHuespedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHuespedes.UseVisualStyleBackColor = false;
            this.BtnHuespedes.Click += new System.EventHandler(this.BtnHuespedes_Click);
            // 
            // BtnHoteles
            // 
            this.BtnHoteles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BtnHoteles.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHoteles.FlatAppearance.BorderSize = 0;
            this.BtnHoteles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHoteles.ForeColor = System.Drawing.Color.White;
            this.BtnHoteles.Image = global::TP.P.A.V.I.Properties.Resources.hotel;
            this.BtnHoteles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHoteles.Location = new System.Drawing.Point(0, 138);
            this.BtnHoteles.Name = "BtnHoteles";
            this.BtnHoteles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnHoteles.Size = new System.Drawing.Size(225, 40);
            this.BtnHoteles.TabIndex = 1;
            this.BtnHoteles.Text = "Hoteles";
            this.BtnHoteles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnHoteles.UseVisualStyleBackColor = false;
            this.BtnHoteles.Click += new System.EventHandler(this.BtnHoteles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP.P.A.V.I.Properties.Resources.q;
            this.pictureBox1.Location = new System.Drawing.Point(62, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::TP.P.A.V.I.Properties.Resources.cuadricula16px;
            this.btnRestaurar.Location = new System.Drawing.Point(908, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(46, 35);
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::TP.P.A.V.I.Properties.Resources.cuadrado16px;
            this.btnMaximizar.Location = new System.Drawing.Point(908, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(46, 35);
            this.btnMaximizar.TabIndex = 10;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::TP.P.A.V.I.Properties.Resources.menos16px;
            this.btnMinimizar.Location = new System.Drawing.Point(862, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(46, 35);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::TP.P.A.V.I.Properties.Resources.cerrar16px;
            this.btnCerrar.Location = new System.Drawing.Point(954, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(46, 35);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::TP.P.A.V.I.Properties.Resources.Qblanca;
            this.pictureBox4.Location = new System.Drawing.Point(7, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MenuLogin.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel MenuLogin;
        private System.Windows.Forms.Button BtnHoteles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button BtnServicios;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnHuespedes;
    }
}