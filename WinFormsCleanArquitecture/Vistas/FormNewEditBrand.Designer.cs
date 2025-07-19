namespace Views.Vistas
{
    partial class AltaMarca
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
            lblNombreMarca = new Label();
            txtNombreMarca = new TextBox();
            btnGuardarAltaMarca = new Button();
            SuspendLayout();
            // 
            // lblNombreMarca
            // 
            lblNombreMarca.AutoSize = true;
            lblNombreMarca.Location = new Point(28, 44);
            lblNombreMarca.Name = "lblNombreMarca";
            lblNombreMarca.Size = new Size(103, 15);
            lblNombreMarca.TabIndex = 0;
            lblNombreMarca.Text = "Nombre de marca";
            // 
            // txtNombreMarca
            // 
            txtNombreMarca.Location = new Point(137, 41);
            txtNombreMarca.Name = "txtNombreMarca";
            txtNombreMarca.Size = new Size(206, 23);
            txtNombreMarca.TabIndex = 1;
            // 
            // btnGuardarAltaMarca
            // 
            btnGuardarAltaMarca.Location = new Point(137, 105);
            btnGuardarAltaMarca.Name = "btnGuardarAltaMarca";
            btnGuardarAltaMarca.Size = new Size(159, 35);
            btnGuardarAltaMarca.TabIndex = 2;
            btnGuardarAltaMarca.Text = "Guardar";
            btnGuardarAltaMarca.UseVisualStyleBackColor = true;
            btnGuardarAltaMarca.Click += btnGuardarAltaMarca_Click;
            // 
            // AltaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 195);
            Controls.Add(btnGuardarAltaMarca);
            Controls.Add(txtNombreMarca);
            Controls.Add(lblNombreMarca);
            Name = "AltaMarca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormNewEditBrand";
            Load += AltaMarca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreMarca;
        private TextBox txtNombreMarca;
        private Button btnGuardarAltaMarca;
    }
}