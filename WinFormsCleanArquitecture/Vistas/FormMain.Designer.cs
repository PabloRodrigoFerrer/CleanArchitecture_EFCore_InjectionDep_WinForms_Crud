﻿namespace WinFormsCleanArquitecture
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            marcasToolStripMenuItem = new ToolStripMenuItem();
            cervezasToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { configuraciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(715, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { marcasToolStripMenuItem, cervezasToolStripMenuItem, nuevaVentaToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(52, 20);
            configuraciónToolStripMenuItem.Text = "Tablas";
            // 
            // marcasToolStripMenuItem
            // 
            marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            marcasToolStripMenuItem.Size = new Size(180, 22);
            marcasToolStripMenuItem.Text = "Marcas";
            marcasToolStripMenuItem.Click += marcasToolStripMenuItem_Click;
            // 
            // cervezasToolStripMenuItem
            // 
            cervezasToolStripMenuItem.Name = "cervezasToolStripMenuItem";
            cervezasToolStripMenuItem.Size = new Size(180, 22);
            cervezasToolStripMenuItem.Text = "Cervezas";
            cervezasToolStripMenuItem.Click += cervezasToolStripMenuItem_Click;
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(180, 22);
            nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            nuevaVentaToolStripMenuItem.Click += nuevaVentaToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 436);
            Controls.Add(menuStrip1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem marcasToolStripMenuItem;
        private ToolStripMenuItem cervezasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
    }
}
