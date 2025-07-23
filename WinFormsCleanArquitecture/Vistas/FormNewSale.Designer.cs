namespace Views.Vistas
{
    partial class FormNewSale
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnNuevaVenta = new Button();
            lblCerveza = new Label();
            lblCantidad = new Label();
            cboBeers = new ComboBox();
            npdCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dgv = new DataGridView();
            IdBeer = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BeerName = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblTotalMoney = new Label();
            ((System.ComponentModel.ISupportInitialize)npdCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.Location = new Point(464, 334);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(159, 39);
            btnNuevaVenta.TabIndex = 1;
            btnNuevaVenta.Text = "Nueva venta";
            btnNuevaVenta.UseVisualStyleBackColor = true;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // lblCerveza
            // 
            lblCerveza.AutoSize = true;
            lblCerveza.Location = new Point(27, 80);
            lblCerveza.Name = "lblCerveza";
            lblCerveza.Size = new Size(54, 17);
            lblCerveza.TabIndex = 2;
            lblCerveza.Text = "Cerveza";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(267, 80);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(60, 17);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // cboBeers
            // 
            cboBeers.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBeers.FormattingEnabled = true;
            cboBeers.Location = new Point(98, 77);
            cboBeers.Name = "cboBeers";
            cboBeers.Size = new Size(143, 25);
            cboBeers.TabIndex = 3;
            // 
            // npdCantidad
            // 
            npdCantidad.Location = new Point(333, 78);
            npdCantidad.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            npdCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            npdCantidad.Name = "npdCantidad";
            npdCantidad.Size = new Size(155, 25);
            npdCantidad.TabIndex = 4;
            npdCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(517, 72);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(106, 33);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { IdBeer, Quantity, BeerName, UnitPrice, Total });
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new Point(27, 125);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(596, 195);
            dgv.TabIndex = 6;
            // 
            // IdBeer
            // 
            IdBeer.HeaderText = "IdBeer";
            IdBeer.Name = "IdBeer";
            IdBeer.ReadOnly = true;
            IdBeer.Visible = false;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Cantidad";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // BeerName
            // 
            BeerName.HeaderText = "Nombre";
            BeerName.Name = "BeerName";
            BeerName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            UnitPrice.DefaultCellStyle = dataGridViewCellStyle1;
            UnitPrice.HeaderText = "Precio Unitario";
            UnitPrice.Name = "UnitPrice";
            UnitPrice.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            Total.DefaultCellStyle = dataGridViewCellStyle2;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(47, 345);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(61, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total: ";
            // 
            // lblTotalMoney
            // 
            lblTotalMoney.AutoSize = true;
            lblTotalMoney.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalMoney.Location = new Point(116, 345);
            lblTotalMoney.Name = "lblTotalMoney";
            lblTotalMoney.Size = new Size(56, 25);
            lblTotalMoney.TabIndex = 7;
            lblTotalMoney.Text = "$0.00";
            // 
            // FormNewSale
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 488);
            Controls.Add(lblTotalMoney);
            Controls.Add(lblTotal);
            Controls.Add(dgv);
            Controls.Add(btnAgregar);
            Controls.Add(npdCantidad);
            Controls.Add(cboBeers);
            Controls.Add(lblCantidad);
            Controls.Add(lblCerveza);
            Controls.Add(btnNuevaVenta);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewSale";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva venta";
            Load += FormNewSale_Load;
            ((System.ComponentModel.ISupportInitialize)npdCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevaVenta;
        private Label lblCerveza;
        private Label lblCantidad;
        private ComboBox cboBeers;
        private NumericUpDown npdCantidad;
        private Button btnAgregar;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn IdBeer;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BeerName;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn Total;
        private Label lblTotal;
        private Label lblTotalMoney;
    }
}