namespace ProyectoJardin
{
    partial class FrmAltaPersonal
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
            this.txtbHoraEntrada = new System.Windows.Forms.TextBox();
            this.txtbHoraSalida = new System.Windows.Forms.TextBox();
            this.txtbPrecioHora = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraEgreso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtbHoraEntrada
            // 
            this.txtbHoraEntrada.Location = new System.Drawing.Point(10, 202);
            this.txtbHoraEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.txtbHoraEntrada.Name = "txtbHoraEntrada";
            this.txtbHoraEntrada.Size = new System.Drawing.Size(62, 20);
            this.txtbHoraEntrada.TabIndex = 10;
            // 
            // txtbHoraSalida
            // 
            this.txtbHoraSalida.Location = new System.Drawing.Point(91, 202);
            this.txtbHoraSalida.Margin = new System.Windows.Forms.Padding(2);
            this.txtbHoraSalida.Name = "txtbHoraSalida";
            this.txtbHoraSalida.Size = new System.Drawing.Size(62, 20);
            this.txtbHoraSalida.TabIndex = 10;
            // 
            // txtbPrecioHora
            // 
            this.txtbPrecioHora.Location = new System.Drawing.Point(179, 202);
            this.txtbPrecioHora.Margin = new System.Windows.Forms.Padding(2);
            this.txtbPrecioHora.Name = "txtbPrecioHora";
            this.txtbPrecioHora.Size = new System.Drawing.Size(62, 20);
            this.txtbPrecioHora.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Precio Por Hora";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(8, 187);
            this.lblHoraEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(68, 13);
            this.lblHoraEntrada.TabIndex = 11;
            this.lblHoraEntrada.Text = "Hora Ingreso";
            // 
            // lblHoraEgreso
            // 
            this.lblHoraEgreso.AutoSize = true;
            this.lblHoraEgreso.Location = new System.Drawing.Point(91, 187);
            this.lblHoraEgreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraEgreso.Name = "lblHoraEgreso";
            this.lblHoraEgreso.Size = new System.Drawing.Size(62, 13);
            this.lblHoraEgreso.TabIndex = 11;
            this.lblHoraEgreso.Text = "Hora Salida";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(5, 66);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 119);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "Dni";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(7, 149);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(42, 13);
            this.lblgenero.TabIndex = 13;
            this.lblgenero.Text = "Genero";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(179, 145);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 14;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            this.rdbFemenino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(68, 145);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 14;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(59, 112);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(193, 20);
            this.txtDni.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(74, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(193, 20);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(8, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 33);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(154, 274);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 33);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(12, 246);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 13;
            this.lblCargo.Text = "Cargo";
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(68, 246);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(148, 21);
            this.cmbCargos.TabIndex = 17;
            // 
            // FrmAltaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoJardin.Properties.Resources.jardines;
            this.ClientSize = new System.Drawing.Size(297, 384);
            this.Controls.Add(this.cmbCargos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblHoraEgreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbPrecioHora);
            this.Controls.Add(this.txtbHoraSalida);
            this.Controls.Add(this.txtbHoraEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAltaPersonal";
            this.Text = "FrmAltaPersonal";
            this.Load += new System.EventHandler(this.FrmAltaPersonal_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbHoraEntrada;
        private System.Windows.Forms.TextBox txtbHoraSalida;
        private System.Windows.Forms.TextBox txtbPrecioHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraEgreso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.ComboBox cmbCargos;
    }
}