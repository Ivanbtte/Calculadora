﻿namespace Calculadora
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
            this.interesCompuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasaDeInteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interesSimpleToolStripMenuItem,
            this.interesCompuestoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.interesSimpleToolStripMenuItem.Name = "interesSimpleToolStripMenuItem";
            this.interesSimpleToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.interesSimpleToolStripMenuItem.Text = "Interes Simple";
            // 
            // interesCompuestoToolStripMenuItem
            // 
            this.interesCompuestoToolStripMenuItem.Name = "interesCompuestoToolStripMenuItem";
            this.interesCompuestoToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.interesCompuestoToolStripMenuItem.Text = "Interes Compuesto";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

