namespace Ejemplo_Colegio
{
    partial class Form1
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
            this.gpbRegistroAlumno = new System.Windows.Forms.GroupBox();
            this.gpbRegistroNota = new System.Windows.Forms.GroupBox();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnRegistrarNota = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.gpbRegistroAlumno.SuspendLayout();
            this.gpbRegistroNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbRegistroAlumno
            // 
            this.gpbRegistroAlumno.Controls.Add(this.txtSeccion);
            this.gpbRegistroAlumno.Controls.Add(this.txtGrado);
            this.gpbRegistroAlumno.Controls.Add(this.txtNombre);
            this.gpbRegistroAlumno.Controls.Add(this.btnRegistrarAlumno);
            this.gpbRegistroAlumno.Controls.Add(this.lblSeccion);
            this.gpbRegistroAlumno.Controls.Add(this.lblGrado);
            this.gpbRegistroAlumno.Controls.Add(this.lblNombre);
            this.gpbRegistroAlumno.Location = new System.Drawing.Point(53, 13);
            this.gpbRegistroAlumno.Name = "gpbRegistroAlumno";
            this.gpbRegistroAlumno.Size = new System.Drawing.Size(684, 115);
            this.gpbRegistroAlumno.TabIndex = 0;
            this.gpbRegistroAlumno.TabStop = false;
            this.gpbRegistroAlumno.Text = "Datos Alumno";
            // 
            // gpbRegistroNota
            // 
            this.gpbRegistroNota.Controls.Add(this.txtNivel);
            this.gpbRegistroNota.Controls.Add(this.lblNivel);
            this.gpbRegistroNota.Controls.Add(this.btnRegistrarNota);
            this.gpbRegistroNota.Controls.Add(this.txtNota);
            this.gpbRegistroNota.Controls.Add(this.txtMateria);
            this.gpbRegistroNota.Controls.Add(this.txtDocente);
            this.gpbRegistroNota.Controls.Add(this.lblNota);
            this.gpbRegistroNota.Controls.Add(this.lblMateria);
            this.gpbRegistroNota.Controls.Add(this.lblDocente);
            this.gpbRegistroNota.Location = new System.Drawing.Point(53, 134);
            this.gpbRegistroNota.Name = "gpbRegistroNota";
            this.gpbRegistroNota.Size = new System.Drawing.Size(684, 114);
            this.gpbRegistroNota.TabIndex = 1;
            this.gpbRegistroNota.TabStop = false;
            this.gpbRegistroNota.Text = "Registro de Nota";
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(53, 277);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.RowTemplate.Height = 24;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(684, 150);
            this.dgvMostrarDatos.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(18, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(216, 18);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(48, 17);
            this.lblGrado.TabIndex = 1;
            this.lblGrado.Text = "Grado";
            // 
            // lblSeccion
            // 
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(426, 18);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(58, 17);
            this.lblSeccion.TabIndex = 2;
            this.lblSeccion.Text = "Seccion";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(551, 71);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(127, 23);
            this.btnRegistrarAlumno.TabIndex = 3;
            this.btnRegistrarAlumno.Text = "Registrar Alumno";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(21, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(139, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtGrado
            // 
            this.txtGrado.Location = new System.Drawing.Point(219, 42);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(145, 22);
            this.txtGrado.TabIndex = 5;
            // 
            // txtSeccion
            // 
            this.txtSeccion.Location = new System.Drawing.Point(429, 42);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(149, 22);
            this.txtSeccion.TabIndex = 6;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(30, 34);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(61, 17);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Docente";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(292, 34);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(435, 34);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 17);
            this.lblNota.TabIndex = 2;
            this.lblNota.Text = "Nota";
            // 
            // txtDocente
            // 
            this.txtDocente.Location = new System.Drawing.Point(33, 67);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(100, 22);
            this.txtDocente.TabIndex = 3;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(295, 67);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 22);
            this.txtMateria.TabIndex = 4;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(438, 66);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 22);
            this.txtNota.TabIndex = 5;
            // 
            // btnRegistrarNota
            // 
            this.btnRegistrarNota.Location = new System.Drawing.Point(551, 85);
            this.btnRegistrarNota.Name = "btnRegistrarNota";
            this.btnRegistrarNota.Size = new System.Drawing.Size(127, 23);
            this.btnRegistrarNota.TabIndex = 6;
            this.btnRegistrarNota.Text = "Registrar Nota";
            this.btnRegistrarNota.UseVisualStyleBackColor = true;
            this.btnRegistrarNota.Click += new System.EventHandler(this.btnRegistrarNota_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(604, 434);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(133, 23);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(164, 34);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(39, 17);
            this.lblNivel.TabIndex = 7;
            this.lblNivel.Text = "Nivel";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(167, 66);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(100, 22);
            this.txtNivel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.gpbRegistroNota);
            this.Controls.Add(this.gpbRegistroAlumno);
            this.Name = "Form1";
            this.Text = "Registro de ntoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbRegistroAlumno.ResumeLayout(false);
            this.gpbRegistroAlumno.PerformLayout();
            this.gpbRegistroNota.ResumeLayout(false);
            this.gpbRegistroNota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRegistroAlumno;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbRegistroNota;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnRegistrarNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

