namespace ProyectoJardin
{
    partial class FrmAltaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaAula));
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAlumnosEnSala = new System.Windows.Forms.Label();
            this.lblAlumnosSinAula = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstAlumnosSinSala = new System.Windows.Forms.ListBox();
            this.lstAlumnosEn = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDocente.Location = new System.Drawing.Point(447, 27);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Docente";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(249, 33);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Turno";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(21, 38);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // lblAlumnosEnSala
            // 
            this.lblAlumnosEnSala.AutoSize = true;
            this.lblAlumnosEnSala.Location = new System.Drawing.Point(84, 85);
            this.lblAlumnosEnSala.Name = "lblAlumnosEnSala";
            this.lblAlumnosEnSala.Size = new System.Drawing.Size(84, 13);
            this.lblAlumnosEnSala.TabIndex = 0;
            this.lblAlumnosEnSala.Text = "Alumnos en sala";
            // 
            // lblAlumnosSinAula
            // 
            this.lblAlumnosSinAula.AutoSize = true;
            this.lblAlumnosSinAula.Location = new System.Drawing.Point(390, 74);
            this.lblAlumnosSinAula.Name = "lblAlumnosSinAula";
            this.lblAlumnosSinAula.Size = new System.Drawing.Size(86, 13);
            this.lblAlumnosSinAula.TabIndex = 0;
            this.lblAlumnosSinAula.Text = "Alumnos sin aula";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(77, 30);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(121, 21);
            this.cmbColor.TabIndex = 1;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(290, 25);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 2;
            // 
            // cmbDocente
            // 
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.Location = new System.Drawing.Point(501, 24);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(145, 21);
            this.cmbDocente.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Tomato;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(303, 163);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 33);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstAlumnosSinSala
            // 
            this.lstAlumnosSinSala.FormattingEnabled = true;
            this.lstAlumnosSinSala.Location = new System.Drawing.Point(371, 101);
            this.lstAlumnosSinSala.Name = "lstAlumnosSinSala";
            this.lstAlumnosSinSala.Size = new System.Drawing.Size(290, 342);
            this.lstAlumnosSinSala.TabIndex = 5;
            this.lstAlumnosSinSala.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAlumnosSinSala_MouseDoubleClick);
            // 
            // lstAlumnosEn
            // 
            this.lstAlumnosEn.AllowDrop = true;
            this.lstAlumnosEn.FormattingEnabled = true;
            this.lstAlumnosEn.Location = new System.Drawing.Point(12, 101);
            this.lstAlumnosEn.Name = "lstAlumnosEn";
            this.lstAlumnosEn.Size = new System.Drawing.Size(290, 342);
            this.lstAlumnosEn.TabIndex = 5;
            this.lstAlumnosEn.SelectedIndexChanged += new System.EventHandler(this.lstAlumnosEn_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAltaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoJardin.Properties.Resources.jardines;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstAlumnosEn);
            this.Controls.Add(this.lstAlumnosSinSala);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbDocente);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblAlumnosSinAula);
            this.Controls.Add(this.lblAlumnosEnSala);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblDocente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmAltaAula";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pichoncitos a las Aulas";
            this.Load += new System.EventHandler(this.FrmAltaAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAlumnosEnSala;
        private System.Windows.Forms.Label lblAlumnosSinAula;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbDocente;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox lstAlumnosSinSala;
        private System.Windows.Forms.ListBox lstAlumnosEn;
        private System.Windows.Forms.Button btnCancelar;
    }
}