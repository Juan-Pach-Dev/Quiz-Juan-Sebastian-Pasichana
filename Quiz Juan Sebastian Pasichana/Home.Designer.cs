
namespace Quiz_Juan_Sebastian_Pasichana
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.txtNombrepelicula = new System.Windows.Forms.TextBox();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtguardar = new System.Windows.Forms.TextBox();
            this.rchAlmacenamiento = new System.Windows.Forms.RichTextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.chkPuntuación = new System.Windows.Forms.CheckedListBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(438, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitulo.Size = new System.Drawing.Size(363, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario Registro de Asistencia Cine Foro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(16, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre y Apellido del asistente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(19, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(16, 120);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(126, 16);
            this.lblAsistencia.TabIndex = 3;
            this.lblAsistencia.Text = "Día de la asistencia";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(16, 249);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(143, 16);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Nombre de la pelicula:";
            // 
            // txtNombrepelicula
            // 
            this.txtNombrepelicula.Location = new System.Drawing.Point(19, 279);
            this.txtNombrepelicula.Name = "txtNombrepelicula";
            this.txtNombrepelicula.Size = new System.Drawing.Size(340, 26);
            this.txtNombrepelicula.TabIndex = 6;
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuación.Location = new System.Drawing.Point(16, 325);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(160, 16);
            this.lblPuntuación.TabIndex = 7;
            this.lblPuntuación.Text = "Puntuación de la película:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(19, 139);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(340, 26);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(18, 182);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 16);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero";
            // 
            // txtguardar
            // 
            this.txtguardar.Location = new System.Drawing.Point(773, 42);
            this.txtguardar.Name = "txtguardar";
            this.txtguardar.Size = new System.Drawing.Size(231, 26);
            this.txtguardar.TabIndex = 15;
            // 
            // rchAlmacenamiento
            // 
            this.rchAlmacenamiento.Location = new System.Drawing.Point(623, 80);
            this.rchAlmacenamiento.Name = "rchAlmacenamiento";
            this.rchAlmacenamiento.Size = new System.Drawing.Size(483, 361);
            this.rchAlmacenamiento.TabIndex = 16;
            this.rchAlmacenamiento.Text = "";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Maculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(19, 201);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 28);
            this.cmbGenero.TabIndex = 17;
            // 
            // chkPuntuación
            // 
            this.chkPuntuación.FormattingEnabled = true;
            this.chkPuntuación.Items.AddRange(new object[] {
            "Excelente",
            "Regular",
            "Mala"});
            this.chkPuntuación.Location = new System.Drawing.Point(19, 353);
            this.chkPuntuación.Name = "chkPuntuación";
            this.chkPuntuación.Size = new System.Drawing.Size(140, 88);
            this.chkPuntuación.TabIndex = 18;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(263, 475);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(96, 35);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.chkPuntuación);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.rchAlmacenamiento);
            this.Controls.Add(this.txtguardar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPuntuación);
            this.Controls.Add(this.txtNombrepelicula);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.TextBox txtNombrepelicula;
        private System.Windows.Forms.Label lblPuntuación;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtguardar;
        private System.Windows.Forms.RichTextBox rchAlmacenamiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.CheckedListBox chkPuntuación;
        private System.Windows.Forms.Button btnReport;
    }
}