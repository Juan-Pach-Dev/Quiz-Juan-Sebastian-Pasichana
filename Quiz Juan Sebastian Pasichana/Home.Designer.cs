
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.txtNombrepelicula = new System.Windows.Forms.TextBox();
            this.lblPuntuación = new System.Windows.Forms.Label();
            this.pnlResultados = new System.Windows.Forms.Panel();
            this.rbtnExcelente = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.rbtnMala = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlResultados.SuspendLayout();
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
            this.lblName.Location = new System.Drawing.Point(13, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(202, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre y Apellido del asistente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(13, 120);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(126, 16);
            this.lblAsistencia.TabIndex = 3;
            this.lblAsistencia.Text = "Día de la asistencia";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 139);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(340, 26);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelicula.Location = new System.Drawing.Point(12, 186);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(143, 16);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Nombre de la pelicula:";
            // 
            // txtNombrepelicula
            // 
            this.txtNombrepelicula.Location = new System.Drawing.Point(16, 205);
            this.txtNombrepelicula.Name = "txtNombrepelicula";
            this.txtNombrepelicula.Size = new System.Drawing.Size(340, 26);
            this.txtNombrepelicula.TabIndex = 6;
            // 
            // lblPuntuación
            // 
            this.lblPuntuación.AutoSize = true;
            this.lblPuntuación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuación.Location = new System.Drawing.Point(12, 252);
            this.lblPuntuación.Name = "lblPuntuación";
            this.lblPuntuación.Size = new System.Drawing.Size(160, 16);
            this.lblPuntuación.TabIndex = 7;
            this.lblPuntuación.Text = "Puntuación de la película:";
            // 
            // pnlResultados
            // 
            this.pnlResultados.Controls.Add(this.rbtnMala);
            this.pnlResultados.Controls.Add(this.rbtnRegular);
            this.pnlResultados.Controls.Add(this.rbtnExcelente);
            this.pnlResultados.Location = new System.Drawing.Point(16, 272);
            this.pnlResultados.Name = "pnlResultados";
            this.pnlResultados.Size = new System.Drawing.Size(340, 95);
            this.pnlResultados.TabIndex = 8;
            // 
            // rbtnExcelente
            // 
            this.rbtnExcelente.AutoSize = true;
            this.rbtnExcelente.Location = new System.Drawing.Point(3, 3);
            this.rbtnExcelente.Name = "rbtnExcelente";
            this.rbtnExcelente.Size = new System.Drawing.Size(106, 24);
            this.rbtnExcelente.TabIndex = 9;
            this.rbtnExcelente.TabStop = true;
            this.rbtnExcelente.Text = "Excelente";
            this.rbtnExcelente.UseVisualStyleBackColor = true;
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(3, 33);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(90, 24);
            this.rbtnRegular.TabIndex = 10;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // rbtnMala
            // 
            this.rbtnMala.AutoSize = true;
            this.rbtnMala.Location = new System.Drawing.Point(3, 63);
            this.rbtnMala.Name = "rbtnMala";
            this.rbtnMala.Size = new System.Drawing.Size(65, 24);
            this.rbtnMala.TabIndex = 11;
            this.rbtnMala.TabStop = true;
            this.rbtnMala.Text = "Mala";
            this.rbtnMala.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "RichTextBox";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1333, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlResultados);
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
            this.pnlResultados.ResumeLayout(false);
            this.pnlResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.TextBox txtNombrepelicula;
        private System.Windows.Forms.Label lblPuntuación;
        private System.Windows.Forms.Panel pnlResultados;
        private System.Windows.Forms.RadioButton rbtnMala;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.RadioButton rbtnExcelente;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
    }
}