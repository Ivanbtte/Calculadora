namespace Calculadora
{
    partial class MontoVencida
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.cmbInteres = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtAnualidad = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblAnualidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(137, 427);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(161, 27);
            this.txtMonto.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "%";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(226, 492);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(83, 29);
            this.btnRegresar.TabIndex = 47;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(102, 492);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 29);
            this.btnCalcular.TabIndex = 46;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Bimestral",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
            this.cmbTiempo.Location = new System.Drawing.Point(137, 298);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(161, 28);
            this.cmbTiempo.TabIndex = 44;
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
            this.cmbInteres.Location = new System.Drawing.Point(137, 147);
            this.cmbInteres.Name = "cmbInteres";
            this.cmbInteres.Size = new System.Drawing.Size(161, 28);
            this.cmbInteres.TabIndex = 40;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(137, 343);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(161, 27);
            this.txtTiempo.TabIndex = 45;
            // 
            // txtInteres
            // 
            this.txtInteres.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(137, 197);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(161, 27);
            this.txtInteres.TabIndex = 43;
            // 
            // txtAnualidad
            // 
            this.txtAnualidad.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnualidad.Location = new System.Drawing.Point(137, 68);
            this.txtAnualidad.Name = "txtAnualidad";
            this.txtAnualidad.Size = new System.Drawing.Size(161, 27);
            this.txtAnualidad.TabIndex = 39;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(187, 111);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(60, 20);
            this.lblInteres.TabIndex = 42;
            this.lblInteres.Text = "Interes";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(187, 252);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(75, 20);
            this.lblTiempo.TabIndex = 41;
            this.lblTiempo.Text = "Periodos";
            // 
            // lblAnualidad
            // 
            this.lblAnualidad.AutoSize = true;
            this.lblAnualidad.Location = new System.Drawing.Point(176, 32);
            this.lblAnualidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnualidad.Name = "lblAnualidad";
            this.lblAnualidad.Size = new System.Drawing.Size(86, 20);
            this.lblAnualidad.TabIndex = 38;
            this.lblAnualidad.Text = "Anualidad";
            // 
            // MontoVencida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(441, 590);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbTiempo);
            this.Controls.Add(this.cmbInteres);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtAnualidad);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblAnualidad);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MontoVencida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MontoVencida";
            this.Load += new System.EventHandler(this.MontoVencida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.ComboBox cmbInteres;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtAnualidad;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblAnualidad;
    }
}