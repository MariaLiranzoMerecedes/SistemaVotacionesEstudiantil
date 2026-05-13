namespace ProyectoSistemaElectoralEstudiantil
{
    partial class FrmDatosGenerales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPadron = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(145, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Generales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(204, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo Eleccion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Honeydew;
            this.txtTitulo.Location = new System.Drawing.Point(191, 163);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 22);
            this.txtTitulo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(204, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = " Fecha inicio:";
            // 
            // dtInicio
            // 
            this.dtInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.CalendarForeColor = System.Drawing.Color.Teal;
            this.dtInicio.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dtInicio.CalendarTitleForeColor = System.Drawing.Color.Teal;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(191, 252);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(143, 22);
            this.dtInicio.TabIndex = 4;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // dtFin
            // 
            this.dtFin.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(191, 342);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(143, 22);
            this.dtFin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(204, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha fin: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(202, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Padrón activo: ";
            // 
            // cbPadron
            // 
            this.cbPadron.BackColor = System.Drawing.Color.Honeydew;
            this.cbPadron.FormattingEnabled = true;
            this.cbPadron.Location = new System.Drawing.Point(184, 424);
            this.cbPadron.Name = "cbPadron";
            this.cbPadron.Size = new System.Drawing.Size(150, 24);
            this.cbPadron.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnGuardar.Location = new System.Drawing.Point(95, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 47);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Honeydew;
            this.btnVolver.Location = new System.Drawing.Point(279, 481);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(115, 47);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmDatosGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::ProyectoSistemaElectoralEstudiantil.Properties.Resources.fondo6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 572);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbPadron);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDatosGenerales";
            this.Text = "FrmDatosGenerales";
            this.Load += new System.EventHandler(this.FrmDatosGenerales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPadron;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}