namespace ProyectoJardin
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionJardinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadPruebas = new System.Windows.Forms.Button();
            this.lstBoxPrincipal = new System.Windows.Forms.ListBox();
            this.verAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(615, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.verAulasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDeDocenteToolStripMenuItem
            // 
            this.altaDeDocenteToolStripMenuItem.Name = "altaDeDocenteToolStripMenuItem";
            this.altaDeDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaDeDocenteToolStripMenuItem.Text = "Alta de docente";
            this.altaDeDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDeDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta No docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altaAulaToolStripMenuItem.Text = "Alta Aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recaudacionJardinToolStripMenuItem,
            this.informacionPadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionPadresToolStripMenuItem
            // 
            this.informacionPadresToolStripMenuItem.Name = "informacionPadresToolStripMenuItem";
            this.informacionPadresToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.informacionPadresToolStripMenuItem.Text = "Informacion Padres";
            this.informacionPadresToolStripMenuItem.Click += new System.EventHandler(this.informacionPadresToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo Docente";
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo No Docente";
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion Por Aula";
            // 
            // recaudacionJardinToolStripMenuItem
            // 
            this.recaudacionJardinToolStripMenuItem.Name = "recaudacionJardinToolStripMenuItem";
            this.recaudacionJardinToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recaudacionJardinToolStripMenuItem.Text = "Recaudacion Jardin";
            this.recaudacionJardinToolStripMenuItem.Click += new System.EventHandler(this.recaudacionJardinToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoJardin.Properties.Resources.jardines;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadPruebas
            // 
            this.btnLoadPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPruebas.Location = new System.Drawing.Point(148, 2);
            this.btnLoadPruebas.Name = "btnLoadPruebas";
            this.btnLoadPruebas.Size = new System.Drawing.Size(96, 22);
            this.btnLoadPruebas.TabIndex = 2;
            this.btnLoadPruebas.Text = "Load Pruebas";
            this.btnLoadPruebas.UseVisualStyleBackColor = true;
            this.btnLoadPruebas.Click += new System.EventHandler(this.btnLoadPruebas_Click);
            // 
            // lstBoxPrincipal
            // 
            this.lstBoxPrincipal.FormattingEnabled = true;
            this.lstBoxPrincipal.Location = new System.Drawing.Point(0, 251);
            this.lstBoxPrincipal.Name = "lstBoxPrincipal";
            this.lstBoxPrincipal.Size = new System.Drawing.Size(612, 225);
            this.lstBoxPrincipal.TabIndex = 3;
            this.lstBoxPrincipal.SelectedIndexChanged += new System.EventHandler(this.lstBoxPrincipal_SelectedIndexChanged);
            // 
            // verAulasToolStripMenuItem
            // 
            this.verAulasToolStripMenuItem.Name = "verAulasToolStripMenuItem";
            this.verAulasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verAulasToolStripMenuItem.Text = "Ver Aulas";
            this.verAulasToolStripMenuItem.Click += new System.EventHandler(this.verAulasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 480);
            this.Controls.Add(this.lstBoxPrincipal);
            this.Controls.Add(this.btnLoadPruebas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Jardin \"Los Pichoncitos\" - Francisco Cesare 2D";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem informacionPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionJardinToolStripMenuItem;
        private System.Windows.Forms.Button btnLoadPruebas;
        private System.Windows.Forms.ListBox lstBoxPrincipal;
        private System.Windows.Forms.ToolStripMenuItem verAulasToolStripMenuItem;
    }
}

