namespace ProyectoSistemaElectoralEstudiantil
{
    partial class FrmPlanchas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtLema = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCandidato = new System.Windows.Forms.TextBox();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Honeydew;
            this.button1.Location = new System.Drawing.Point(223, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Honeydew;
            this.button2.Location = new System.Drawing.Point(573, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "VOLVER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel4.BackgroundImage = global::ProyectoSistemaElectoralEstudiantil.Properties.Resources.fondo4;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.btnSeleccionar);
            this.panel4.Controls.Add(this.txtLogo);
            this.panel4.Controls.Add(this.txtColor);
            this.panel4.Controls.Add(this.txtLema);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 607);
            this.panel4.TabIndex = 14;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSeleccionar.Location = new System.Drawing.Point(143, 344);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(141, 49);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.Honeydew;
            this.txtLogo.Location = new System.Drawing.Point(12, 344);
            this.txtLogo.Multiline = true;
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(109, 33);
            this.txtLogo.TabIndex = 9;
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Honeydew;
            this.txtColor.Location = new System.Drawing.Point(15, 273);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(106, 22);
            this.txtColor.TabIndex = 8;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtLema
            // 
            this.txtLema.BackColor = System.Drawing.Color.Honeydew;
            this.txtLema.Location = new System.Drawing.Point(15, 202);
            this.txtLema.Name = "txtLema";
            this.txtLema.Size = new System.Drawing.Size(224, 22);
            this.txtLema.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Honeydew;
            this.txtNombre.Location = new System.Drawing.Point(19, 132);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Logo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANCHAS ELECTORALES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.BackgroundImage = global::ProyectoSistemaElectoralEstudiantil.Properties.Resources.Fondo3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtCandidato);
            this.panel2.Controls.Add(this.dgvCandidatos);
            this.panel2.Controls.Add(this.cbPuesto);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(398, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 607);
            this.panel2.TabIndex = 11;
            // 
            // txtCandidato
            // 
            this.txtCandidato.BackColor = System.Drawing.Color.Honeydew;
            this.txtCandidato.Location = new System.Drawing.Point(211, 107);
            this.txtCandidato.Name = "txtCandidato";
            this.txtCandidato.Size = new System.Drawing.Size(164, 22);
            this.txtCandidato.TabIndex = 6;
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(16, 313);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.RowHeadersWidth = 51;
            this.dgvCandidatos.RowTemplate.Height = 24;
            this.dgvCandidatos.Size = new System.Drawing.Size(573, 263);
            this.dgvCandidatos.TabIndex = 5;
            // 
            // cbPuesto
            // 
            this.cbPuesto.BackColor = System.Drawing.Color.Honeydew;
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(211, 182);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(164, 24);
            this.cbPuesto.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(175)))), ((int)(((byte)(158)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.Location = new System.Drawing.Point(211, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 47);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Puesto";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(186, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 59);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CANDIDATOS";
            // 
            // FrmPlanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(999, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmPlanchas";
            this.Text = "FrmPlanchas";
            this.Load += new System.EventHandler(this.FrmPlanchas_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLema;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.TextBox txtCandidato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
    }
}