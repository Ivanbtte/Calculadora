namespace Calculadora
{
    partial class AA_VP
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
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.cmbInteres = new System.Windows.Forms.ComboBox();
            this.txtAnualidad = new System.Windows.Forms.TextBox();
            this.lblAnualidad = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVP
            // 
            this.txtVP.Enabled = false;
            this.txtVP.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVP.Location = new System.Drawing.Point(140, 472);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(161, 27);
            this.txtVP.TabIndex = 60;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(140, 398);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(161, 27);
            this.txtTiempo.TabIndex = 59;
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
            this.cmbTiempo.Location = new System.Drawing.Point(140, 336);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(161, 28);
            this.cmbTiempo.TabIndex = 58;
            // 
            // txtInteres
            // 
            this.txtInteres.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(140, 227);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(161, 27);
            this.txtInteres.TabIndex = 57;
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
            this.cmbInteres.Location = new System.Drawing.Point(140, 170);
            this.cmbInteres.Name = "cmbInteres";
            this.cmbInteres.Size = new System.Drawing.Size(161, 28);
            this.cmbInteres.TabIndex = 56;
            // 
            // txtAnualidad
            // 
            this.txtAnualidad.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnualidad.Location = new System.Drawing.Point(140, 91);
            this.txtAnualidad.Name = "txtAnualidad";
            this.txtAnualidad.Size = new System.Drawing.Size(161, 27);
            this.txtAnualidad.TabIndex = 55;
            // 
            // lblAnualidad
            // 
            this.lblAnualidad.AutoSize = true;
            this.lblAnualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnualidad.Location = new System.Drawing.Point(185, 58);
            this.lblAnualidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnualidad.Name = "lblAnualidad";
            this.lblAnualidad.Size = new System.Drawing.Size(89, 20);
            this.lblAnualidad.TabIndex = 61;
            this.lblAnualidad.Text = "Anualidad";
            this.lblAnualidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(195, 147);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(66, 20);
            this.lblInteres.TabIndex = 62;
            this.lblInteres.Text = "Interes";
            this.lblInteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(185, 303);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(79, 20);
            this.lblTiempo.TabIndex = 64;
            this.lblTiempo.Text = "Periodos";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Valor presente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(115, 529);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(83, 29);
            this.btnCalcular.TabIndex = 66;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.IndianRed;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegresar.Location = new System.Drawing.Point(218, 529);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(83, 29);
            this.btnRegresar.TabIndex = 67;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // AA_VP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(441, 590);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.lblAnualidad);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.cmbTiempo);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.cmbInteres);
            this.Controls.Add(this.txtAnualidad);
            this.Name = "AA_VP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anualidades anticipadas valor presente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.ComboBox cmbInteres;
        private System.Windows.Forms.TextBox txtAnualidad;
        private System.Windows.Forms.Label lblAnualidad;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
    }
}