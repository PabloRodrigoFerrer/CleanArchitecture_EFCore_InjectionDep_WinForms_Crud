namespace Views.Vistas
{
    partial class FormNewEditBeer
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
            cboBrands = new ComboBox();
            lblNombre = new Label();
            lblMarca = new Label();
            lblAlcochol = new Label();
            btnGuardarBeer = new Button();
            txtName = new TextBox();
            txtAlcohol = new TextBox();
            SuspendLayout();
            // 
            // cboBrands
            // 
            cboBrands.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBrands.FormattingEnabled = true;
            cboBrands.Location = new Point(103, 123);
            cboBrands.Name = "cboBrands";
            cboBrands.Size = new Size(219, 23);
            cboBrands.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(57, 126);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "Marca";
            // 
            // lblAlcochol
            // 
            lblAlcochol.AutoSize = true;
            lblAlcochol.Location = new Point(43, 183);
            lblAlcochol.Name = "lblAlcochol";
            lblAlcochol.Size = new Size(54, 15);
            lblAlcochol.TabIndex = 1;
            lblAlcochol.Text = "Alcochol";
            // 
            // btnGuardarBeer
            // 
            btnGuardarBeer.Location = new Point(133, 239);
            btnGuardarBeer.Name = "btnGuardarBeer";
            btnGuardarBeer.Size = new Size(143, 30);
            btnGuardarBeer.TabIndex = 2;
            btnGuardarBeer.Text = "Guardar";
            btnGuardarBeer.UseVisualStyleBackColor = true;
            btnGuardarBeer.Click += btnGuardarBeer_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(219, 23);
            txtName.TabIndex = 3;
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(103, 180);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(219, 23);
            txtAlcohol.TabIndex = 3;
            // 
            // FormNewEditBeer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 361);
            Controls.Add(txtAlcohol);
            Controls.Add(txtName);
            Controls.Add(btnGuardarBeer);
            Controls.Add(lblAlcochol);
            Controls.Add(lblMarca);
            Controls.Add(lblNombre);
            Controls.Add(cboBrands);
            Name = "FormNewEditBeer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormNewEditBeer";
            Load += FormNewEditBeer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboBrands;
        private Label lblNombre;
        private Label lblMarca;
        private Label lblAlcochol;
        private Button btnGuardarBeer;
        private TextBox txtName;
        private TextBox txtAlcohol;
    }
}