namespace Calculadora
{
    partial class CapitalSimple
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
            this.lblFin = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbEstimado = new System.Windows.Forms.RadioButton();
            this.rdbReal = new System.Windows.Forms.RadioButton();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.cmbInteres = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.Location = new System.Drawing.Point(417, 381);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(174, 21);
            this.lblFin.TabIndex = 39;
            this.lblFin.Text = "Fecha de finalización";
            this.lblFin.Visible = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(207, 381);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(127, 21);
            this.lblInicio.TabIndex = 38;
            this.lblInicio.Text = "Fecha de inicio";
            this.lblInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.Enabled = false;
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(401, 424);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(216, 23);
            this.dtpFin.TabIndex = 32;
            this.dtpFin.Visible = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(157, 424);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(218, 23);
            this.dtpInicio.TabIndex = 31;
            this.dtpInicio.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Capital:";
            // 
            // txtCapital
            // 
            this.txtCapital.Enabled = false;
            this.txtCapital.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(282, 520);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(161, 27);
            this.txtCapital.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "%";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(371, 595);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(83, 33);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(247, 595);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 33);
            this.btnCalcular.TabIndex = 33;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdbEstimado
            // 
            this.rdbEstimado.AutoSize = true;
            this.rdbEstimado.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEstimado.Location = new System.Drawing.Point(371, 324);
            this.rdbEstimado.Name = "rdbEstimado";
            this.rdbEstimado.Size = new System.Drawing.Size(74, 20);
            this.rdbEstimado.TabIndex = 28;
            this.rdbEstimado.TabStop = true;
            this.rdbEstimado.Text = "Estimado";
            this.rdbEstimado.UseVisualStyleBackColor = true;
            this.rdbEstimado.CheckedChanged += new System.EventHandler(this.rdbEstimado_CheckedChanged);
            // 
            // rdbReal
            // 
            this.rdbReal.AutoSize = true;
            this.rdbReal.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReal.Location = new System.Drawing.Point(282, 324);
            this.rdbReal.Name = "rdbReal";
            this.rdbReal.Size = new System.Drawing.Size(47, 20);
            this.rdbReal.TabIndex = 27;
            this.rdbReal.TabStop = true;
            this.rdbReal.Text = "Real";
            this.rdbReal.UseVisualStyleBackColor = true;
            this.rdbReal.CheckedChanged += new System.EventHandler(this.rdbReal_CheckedChanged);
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempo.Enabled = false;
            this.cmbTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "Dias",
            "Meses",
            "Bimestres",
            "Trimestres",
            "Cuatrimestres",
            "Semestres",
            "Años"});
            this.cmbTiempo.Location = new System.Drawing.Point(282, 372);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(161, 28);
            this.cmbTiempo.TabIndex = 29;
            // 
            // cmbInteres
            // 
            this.cmbInteres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInteres.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInteres.FormattingEnabled = true;
            this.cmbInteres.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Bimestral",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
            this.cmbInteres.Location = new System.Drawing.Point(282, 165);
            this.cmbInteres.Name = "cmbInteres";
            this.cmbInteres.Size = new System.Drawing.Size(161, 28);
            this.cmbInteres.TabIndex = 23;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Enabled = false;
            this.txtTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(282, 424);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(161, 27);
            this.txtTiempo.TabIndex = 30;
            // 
            // txtInteres
            // 
            this.txtInteres.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(282, 223);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(161, 27);
            this.txtInteres.TabIndex = 26;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(282, 74);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(161, 27);
            this.txtMonto.TabIndex = 22;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(332, 124);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(64, 21);
            this.lblInteres.TabIndex = 25;
            this.lblInteres.Text = "Interes";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(332, 286);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(68, 21);
            this.lblTiempo.TabIndex = 24;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(332, 31);
            this.lblCapital.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(61, 21);
            this.lblCapital.TabIndex = 21;
            this.lblCapital.Text = "Monto";
            // 
            // CapitalSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(692, 747);
            this.ControlBox = false;
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbEstimado);
            this.Controls.Add(this.rdbReal);
            this.Controls.Add(this.cmbTiempo);
            this.Controls.Add(this.cmbInteres);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblCapital);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CapitalSimple";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapitalSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbEstimado;
        private System.Windows.Forms.RadioButton rdbReal;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.ComboBox cmbInteres;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblCapital;
    }
}