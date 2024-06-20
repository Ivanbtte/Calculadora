namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interesSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasaDeInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interesCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasaDeInteresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadVencidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPresenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPresenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesAnticipadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPresenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.valorPresenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.montoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.anualidadToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesSimpleToolStripMenuItem,
            this.interesCompuestoToolStripMenuItem,
            this.anualidadVencidaToolStripMenuItem,
            this.anualidadesAnticipadasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interesSimpleToolStripMenuItem
            // 
            this.interesSimpleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitalToolStripMenuItem,
            this.capitalToolStripMenuItem1,
            this.tasaDeInteresToolStripMenuItem,
            this.tiempoToolStripMenuItem});
            this.interesSimpleToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interesSimpleToolStripMenuItem.Image = global::Calculadora.Properties.Resources.money;
            this.interesSimpleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.interesSimpleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.interesSimpleToolStripMenuItem.Name = "interesSimpleToolStripMenuItem";
            this.interesSimpleToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.interesSimpleToolStripMenuItem.Text = "Interes Simple";
            // 
            // capitalToolStripMenuItem
            // 
            this.capitalToolStripMenuItem.Name = "capitalToolStripMenuItem";
            this.capitalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capitalToolStripMenuItem.Text = "Monto";
            this.capitalToolStripMenuItem.Click += new System.EventHandler(this.capitalToolStripMenuItem_Click);
            // 
            // capitalToolStripMenuItem1
            // 
            this.capitalToolStripMenuItem1.Name = "capitalToolStripMenuItem1";
            this.capitalToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.capitalToolStripMenuItem1.Text = "Capital";
            this.capitalToolStripMenuItem1.Click += new System.EventHandler(this.capitalToolStripMenuItem1_Click);
            // 
            // tasaDeInteresToolStripMenuItem
            // 
            this.tasaDeInteresToolStripMenuItem.Name = "tasaDeInteresToolStripMenuItem";
            this.tasaDeInteresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tasaDeInteresToolStripMenuItem.Text = "Tasa de Interes";
            this.tasaDeInteresToolStripMenuItem.Click += new System.EventHandler(this.tasaDeInteresToolStripMenuItem_Click);
            // 
            // tiempoToolStripMenuItem
            // 
            this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
            this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiempoToolStripMenuItem.Text = "Tiempo";
            this.tiempoToolStripMenuItem.Click += new System.EventHandler(this.tiempoToolStripMenuItem_Click);
            // 
            // interesCompuestoToolStripMenuItem
            // 
            this.interesCompuestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.montoToolStripMenuItem,
            this.capitalToolStripMenuItem2,
            this.tasaDeInteresToolStripMenuItem1,
            this.tiempoToolStripMenuItem1});
            this.interesCompuestoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interesCompuestoToolStripMenuItem.Image = global::Calculadora.Properties.Resources.InteresCompuesto;
            this.interesCompuestoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.interesCompuestoToolStripMenuItem.Name = "interesCompuestoToolStripMenuItem";
            this.interesCompuestoToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.interesCompuestoToolStripMenuItem.Text = "Interes Compuesto";
            // 
            // montoToolStripMenuItem
            // 
            this.montoToolStripMenuItem.Name = "montoToolStripMenuItem";
            this.montoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.montoToolStripMenuItem.Text = "Monto";
            this.montoToolStripMenuItem.Click += new System.EventHandler(this.montoToolStripMenuItem_Click);
            // 
            // capitalToolStripMenuItem2
            // 
            this.capitalToolStripMenuItem2.Name = "capitalToolStripMenuItem2";
            this.capitalToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.capitalToolStripMenuItem2.Text = "Capital";
            this.capitalToolStripMenuItem2.Click += new System.EventHandler(this.capitalToolStripMenuItem2_Click_1);
            // 
            // tasaDeInteresToolStripMenuItem1
            // 
            this.tasaDeInteresToolStripMenuItem1.Name = "tasaDeInteresToolStripMenuItem1";
            this.tasaDeInteresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tasaDeInteresToolStripMenuItem1.Text = "Tasa de interes";
            this.tasaDeInteresToolStripMenuItem1.Click += new System.EventHandler(this.tasaDeInteresToolStripMenuItem1_Click);
            // 
            // tiempoToolStripMenuItem1
            // 
            this.tiempoToolStripMenuItem1.Name = "tiempoToolStripMenuItem1";
            this.tiempoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.tiempoToolStripMenuItem1.Text = "Tiempo";
            this.tiempoToolStripMenuItem1.Click += new System.EventHandler(this.tiempoToolStripMenuItem1_Click);
            // 
            // anualidadVencidaToolStripMenuItem
            // 
            this.anualidadVencidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorPresenteToolStripMenuItem,
            this.anualidadesToolStripMenuItem});
            this.anualidadVencidaToolStripMenuItem.Image = global::Calculadora.Properties.Resources.AV;
            this.anualidadVencidaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anualidadVencidaToolStripMenuItem.Name = "anualidadVencidaToolStripMenuItem";
            this.anualidadVencidaToolStripMenuItem.Size = new System.Drawing.Size(165, 36);
            this.anualidadVencidaToolStripMenuItem.Text = "Anualidades Vencidas";
            // 
            // valorPresenteToolStripMenuItem
            // 
            this.valorPresenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorPresenteToolStripMenuItem1,
            this.anualidadToolStripMenuItem1,
            this.periodosToolStripMenuItem1});
            this.valorPresenteToolStripMenuItem.Name = "valorPresenteToolStripMenuItem";
            this.valorPresenteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.valorPresenteToolStripMenuItem.Text = "Valor presente";
            // 
            // valorPresenteToolStripMenuItem1
            // 
            this.valorPresenteToolStripMenuItem1.Name = "valorPresenteToolStripMenuItem1";
            this.valorPresenteToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.valorPresenteToolStripMenuItem1.Text = "Valor presente";
            this.valorPresenteToolStripMenuItem1.Click += new System.EventHandler(this.valorPresenteToolStripMenuItem1_Click);
            // 
            // anualidadToolStripMenuItem1
            // 
            this.anualidadToolStripMenuItem1.Name = "anualidadToolStripMenuItem1";
            this.anualidadToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.anualidadToolStripMenuItem1.Text = "Anualidad";
            this.anualidadToolStripMenuItem1.Click += new System.EventHandler(this.anualidadToolStripMenuItem1_Click);
            // 
            // periodosToolStripMenuItem1
            // 
            this.periodosToolStripMenuItem1.Name = "periodosToolStripMenuItem1";
            this.periodosToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.periodosToolStripMenuItem1.Text = "Periodos";
            this.periodosToolStripMenuItem1.Click += new System.EventHandler(this.periodosToolStripMenuItem1_Click);
            // 
            // anualidadesToolStripMenuItem
            // 
            this.anualidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.montoToolStripMenuItem1,
            this.anualidadToolStripMenuItem,
            this.periodosToolStripMenuItem});
            this.anualidadesToolStripMenuItem.Name = "anualidadesToolStripMenuItem";
            this.anualidadesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.anualidadesToolStripMenuItem.Text = "Anualidades";
            // 
            // montoToolStripMenuItem1
            // 
            this.montoToolStripMenuItem1.Name = "montoToolStripMenuItem1";
            this.montoToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.montoToolStripMenuItem1.Text = "Monto";
            this.montoToolStripMenuItem1.Click += new System.EventHandler(this.montoToolStripMenuItem1_Click);
            // 
            // anualidadToolStripMenuItem
            // 
            this.anualidadToolStripMenuItem.Name = "anualidadToolStripMenuItem";
            this.anualidadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.anualidadToolStripMenuItem.Text = "Anualidad";
            this.anualidadToolStripMenuItem.Click += new System.EventHandler(this.anualidadToolStripMenuItem_Click);
            // 
            // periodosToolStripMenuItem
            // 
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.periodosToolStripMenuItem.Text = "Periodos";
            this.periodosToolStripMenuItem.Click += new System.EventHandler(this.periodosToolStripMenuItem_Click);
            // 
            // anualidadesAnticipadasToolStripMenuItem
            // 
            this.anualidadesAnticipadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorPresenteToolStripMenuItem2,
            this.anualidadesToolStripMenuItem1});
            this.anualidadesAnticipadasToolStripMenuItem.Image = global::Calculadora.Properties.Resources.AA;
            this.anualidadesAnticipadasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anualidadesAnticipadasToolStripMenuItem.Name = "anualidadesAnticipadasToolStripMenuItem";
            this.anualidadesAnticipadasToolStripMenuItem.Size = new System.Drawing.Size(181, 36);
            this.anualidadesAnticipadasToolStripMenuItem.Text = "Anualidades Anticipadas";
            // 
            // valorPresenteToolStripMenuItem2
            // 
            this.valorPresenteToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorPresenteToolStripMenuItem3,
            this.anualidadToolStripMenuItem2,
            this.periodosToolStripMenuItem2});
            this.valorPresenteToolStripMenuItem2.Name = "valorPresenteToolStripMenuItem2";
            this.valorPresenteToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.valorPresenteToolStripMenuItem2.Text = "Valor Presente";
            // 
            // valorPresenteToolStripMenuItem3
            // 
            this.valorPresenteToolStripMenuItem3.Name = "valorPresenteToolStripMenuItem3";
            this.valorPresenteToolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.valorPresenteToolStripMenuItem3.Text = "Valor Presente";
            this.valorPresenteToolStripMenuItem3.Click += new System.EventHandler(this.valorPresenteToolStripMenuItem3_Click);
            // 
            // anualidadToolStripMenuItem2
            // 
            this.anualidadToolStripMenuItem2.Name = "anualidadToolStripMenuItem2";
            this.anualidadToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.anualidadToolStripMenuItem2.Text = "Anualidad";
            this.anualidadToolStripMenuItem2.Click += new System.EventHandler(this.anualidadToolStripMenuItem2_Click);
            // 
            // periodosToolStripMenuItem2
            // 
            this.periodosToolStripMenuItem2.Name = "periodosToolStripMenuItem2";
            this.periodosToolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.periodosToolStripMenuItem2.Text = "Periodos";
            this.periodosToolStripMenuItem2.Click += new System.EventHandler(this.periodosToolStripMenuItem2_Click);
            // 
            // anualidadesToolStripMenuItem1
            // 
            this.anualidadesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.montoToolStripMenuItem2,
            this.anualidadToolStripMenuItem3,
            this.periodosToolStripMenuItem3});
            this.anualidadesToolStripMenuItem1.Name = "anualidadesToolStripMenuItem1";
            this.anualidadesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.anualidadesToolStripMenuItem1.Text = "Anualidades";
            // 
            // montoToolStripMenuItem2
            // 
            this.montoToolStripMenuItem2.Name = "montoToolStripMenuItem2";
            this.montoToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.montoToolStripMenuItem2.Text = "Monto";
            this.montoToolStripMenuItem2.Click += new System.EventHandler(this.montoToolStripMenuItem2_Click);
            // 
            // anualidadToolStripMenuItem3
            // 
            this.anualidadToolStripMenuItem3.Name = "anualidadToolStripMenuItem3";
            this.anualidadToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.anualidadToolStripMenuItem3.Text = "Anualidad";
            this.anualidadToolStripMenuItem3.Click += new System.EventHandler(this.anualidadToolStripMenuItem3_Click);
            // 
            // periodosToolStripMenuItem3
            // 
            this.periodosToolStripMenuItem3.Name = "periodosToolStripMenuItem3";
            this.periodosToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.periodosToolStripMenuItem3.Text = "Periodos";
            this.periodosToolStripMenuItem3.Click += new System.EventHandler(this.periodosToolStripMenuItem3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.calculadora1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(857, 405);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interesSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interesCompuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tasaDeInteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tasaDeInteresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anualidadVencidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorPresenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorPresenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anualidadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anualidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anualidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anualidadesAnticipadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorPresenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem valorPresenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem anualidadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem anualidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem montoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem anualidadToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

