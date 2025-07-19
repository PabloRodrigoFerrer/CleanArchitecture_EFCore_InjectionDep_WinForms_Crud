namespace WinFormsCleanArquitecture
{
    partial class FormBrand
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
            panel1 = new Panel();
            btnNuevaMarca = new Button();
            dgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevaMarca);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 450);
            panel1.TabIndex = 0;
            // 
            // btnNuevaMarca
            // 
            btnNuevaMarca.Location = new Point(12, 29);
            btnNuevaMarca.Name = "btnNuevaMarca";
            btnNuevaMarca.Size = new Size(98, 36);
            btnNuevaMarca.TabIndex = 2;
            btnNuevaMarca.Text = "Add Marca";
            btnNuevaMarca.UseVisualStyleBackColor = true;
            btnNuevaMarca.Click += btnNuevaMarca_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new Point(128, 0);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(672, 450);
            dgv.TabIndex = 1;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // FormBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBrand";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marcas";
            Load += FormBrand_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv;
        private Button btnNuevaMarca;
    }
}