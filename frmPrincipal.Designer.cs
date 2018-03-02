namespace Nutricion
{
    partial class frmPrincipal
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
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnResultado = new System.Windows.Forms.Button();
            this.gbPaciente = new System.Windows.Forms.GroupBox();
            this.nudCintura = new System.Windows.Forms.NumericUpDown();
            this.nudEstatura = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.mtxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCintura = new System.Windows.Forms.Label();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblFecNacimiento = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbClinicas = new System.Windows.Forms.GroupBox();
            this.rbtGamma = new System.Windows.Forms.RadioButton();
            this.rbtBeta = new System.Windows.Forms.RadioButton();
            this.rbtAlfa = new System.Windows.Forms.RadioButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.gbPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCintura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            this.gbClinicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.btnResultado);
            this.splitContainerMain.Panel1.Controls.Add(this.gbPaciente);
            this.splitContainerMain.Panel1.Controls.Add(this.gbClinicas);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.webBrowser);
            this.splitContainerMain.Size = new System.Drawing.Size(843, 481);
            this.splitContainerMain.SplitterDistance = 291;
            this.splitContainerMain.TabIndex = 0;
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(105, 431);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 32);
            this.btnResultado.TabIndex = 2;
            this.btnResultado.Text = "Ver Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // gbPaciente
            // 
            this.gbPaciente.Controls.Add(this.nudCintura);
            this.gbPaciente.Controls.Add(this.nudEstatura);
            this.gbPaciente.Controls.Add(this.nudPeso);
            this.gbPaciente.Controls.Add(this.dtpFechaNacimiento);
            this.gbPaciente.Controls.Add(this.cmbGenero);
            this.gbPaciente.Controls.Add(this.mtxTelefono);
            this.gbPaciente.Controls.Add(this.txtNombre);
            this.gbPaciente.Controls.Add(this.lblCintura);
            this.gbPaciente.Controls.Add(this.lblEstatura);
            this.gbPaciente.Controls.Add(this.lblPeso);
            this.gbPaciente.Controls.Add(this.lblFecNacimiento);
            this.gbPaciente.Controls.Add(this.lblGenero);
            this.gbPaciente.Controls.Add(this.lblTelefono);
            this.gbPaciente.Controls.Add(this.lblNombre);
            this.gbPaciente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaciente.Location = new System.Drawing.Point(12, 85);
            this.gbPaciente.Name = "gbPaciente";
            this.gbPaciente.Size = new System.Drawing.Size(269, 321);
            this.gbPaciente.TabIndex = 1;
            this.gbPaciente.TabStop = false;
            this.gbPaciente.Text = "Paciente";
            // 
            // nudCintura
            // 
            this.nudCintura.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCintura.Location = new System.Drawing.Point(106, 279);
            this.nudCintura.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCintura.Name = "nudCintura";
            this.nudCintura.Size = new System.Drawing.Size(103, 23);
            this.nudCintura.TabIndex = 13;
            this.nudCintura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEstatura
            // 
            this.nudEstatura.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstatura.Location = new System.Drawing.Point(106, 241);
            this.nudEstatura.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudEstatura.Name = "nudEstatura";
            this.nudEstatura.Size = new System.Drawing.Size(103, 23);
            this.nudEstatura.TabIndex = 12;
            this.nudEstatura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPeso
            // 
            this.nudPeso.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPeso.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPeso.Location = new System.Drawing.Point(106, 203);
            this.nudPeso.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(103, 23);
            this.nudPeso.TabIndex = 11;
            this.nudPeso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(106, 153);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(103, 23);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // cmbGenero
            // 
            this.cmbGenero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(106, 106);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(103, 24);
            this.cmbGenero.TabIndex = 9;
            // 
            // mtxTelefono
            // 
            this.mtxTelefono.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTelefono.Location = new System.Drawing.Point(106, 68);
            this.mtxTelefono.Name = "mtxTelefono";
            this.mtxTelefono.Size = new System.Drawing.Size(103, 23);
            this.mtxTelefono.TabIndex = 8;
            this.mtxTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(106, 30);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // lblCintura
            // 
            this.lblCintura.AutoSize = true;
            this.lblCintura.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCintura.Location = new System.Drawing.Point(14, 281);
            this.lblCintura.Name = "lblCintura";
            this.lblCintura.Size = new System.Drawing.Size(80, 16);
            this.lblCintura.TabIndex = 6;
            this.lblCintura.Text = "Cintura (cm)";
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatura.Location = new System.Drawing.Point(14, 243);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(86, 16);
            this.lblEstatura.TabIndex = 5;
            this.lblEstatura.Text = "Estatura (cm)";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(14, 205);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(62, 16);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso (kg)";
            // 
            // lblFecNacimiento
            // 
            this.lblFecNacimiento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecNacimiento.Location = new System.Drawing.Point(14, 147);
            this.lblFecNacimiento.Name = "lblFecNacimiento";
            this.lblFecNacimiento.Size = new System.Drawing.Size(119, 36);
            this.lblFecNacimiento.TabIndex = 3;
            this.lblFecNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(14, 109);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(49, 16);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(14, 71);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(58, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // gbClinicas
            // 
            this.gbClinicas.Controls.Add(this.rbtGamma);
            this.gbClinicas.Controls.Add(this.rbtBeta);
            this.gbClinicas.Controls.Add(this.rbtAlfa);
            this.gbClinicas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClinicas.Location = new System.Drawing.Point(12, 12);
            this.gbClinicas.Name = "gbClinicas";
            this.gbClinicas.Size = new System.Drawing.Size(269, 67);
            this.gbClinicas.TabIndex = 0;
            this.gbClinicas.TabStop = false;
            this.gbClinicas.Text = "Clínicas";
            // 
            // rbtGamma
            // 
            this.rbtGamma.AutoSize = true;
            this.rbtGamma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtGamma.Location = new System.Drawing.Point(178, 29);
            this.rbtGamma.Name = "rbtGamma";
            this.rbtGamma.Size = new System.Drawing.Size(70, 20);
            this.rbtGamma.TabIndex = 2;
            this.rbtGamma.TabStop = true;
            this.rbtGamma.Text = "Gamma";
            this.rbtGamma.UseVisualStyleBackColor = true;
            // 
            // rbtBeta
            // 
            this.rbtBeta.AutoSize = true;
            this.rbtBeta.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBeta.Location = new System.Drawing.Point(98, 29);
            this.rbtBeta.Name = "rbtBeta";
            this.rbtBeta.Size = new System.Drawing.Size(51, 20);
            this.rbtBeta.TabIndex = 1;
            this.rbtBeta.TabStop = true;
            this.rbtBeta.Text = "Beta";
            this.rbtBeta.UseVisualStyleBackColor = true;
            // 
            // rbtAlfa
            // 
            this.rbtAlfa.AutoSize = true;
            this.rbtAlfa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAlfa.Location = new System.Drawing.Point(21, 29);
            this.rbtAlfa.Name = "rbtAlfa";
            this.rbtAlfa.Size = new System.Drawing.Size(48, 20);
            this.rbtAlfa.TabIndex = 0;
            this.rbtAlfa.TabStop = true;
            this.rbtAlfa.Text = "Alfa";
            this.rbtAlfa.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(548, 481);
            this.webBrowser.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 481);
            this.Controls.Add(this.splitContainerMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.gbPaciente.ResumeLayout(false);
            this.gbPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCintura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            this.gbClinicas.ResumeLayout(false);
            this.gbClinicas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox gbPaciente;
        private System.Windows.Forms.Label lblCintura;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblFecNacimiento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbClinicas;
        private System.Windows.Forms.RadioButton rbtGamma;
        private System.Windows.Forms.RadioButton rbtBeta;
        private System.Windows.Forms.RadioButton rbtAlfa;
        private System.Windows.Forms.NumericUpDown nudCintura;
        private System.Windows.Forms.NumericUpDown nudEstatura;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.MaskedTextBox mtxTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

