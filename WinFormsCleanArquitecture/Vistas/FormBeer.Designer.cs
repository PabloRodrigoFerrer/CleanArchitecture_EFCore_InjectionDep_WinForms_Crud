namespace WinFormsCleanArquitecture
{
    partial class FormBeer
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
            btnNuevaCerveza = new Button();
            dgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNuevaCerveza);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 510);
            panel1.TabIndex = 1;
            // 
            // btnNuevaCerveza
            // 
            btnNuevaCerveza.BackColor = Color.DimGray;
            btnNuevaCerveza.FlatAppearance.BorderColor = Color.Gray;
            btnNuevaCerveza.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnNuevaCerveza.FlatStyle = FlatStyle.Flat;
            btnNuevaCerveza.ForeColor = Color.WhiteSmoke;
            btnNuevaCerveza.Location = new Point(12, 33);
            btnNuevaCerveza.Name = "btnNuevaCerveza";
            btnNuevaCerveza.Size = new Size(110, 63);
            btnNuevaCerveza.TabIndex = 2;
            btnNuevaCerveza.Text = "Add Cerveza";
            btnNuevaCerveza.UseVisualStyleBackColor = false;
            btnNuevaCerveza.Click += btnNuevaCerveza_Click;
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
            dgv.Size = new Size(672, 510);
            dgv.TabIndex = 2;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // FormBeer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dgv);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormBeer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBeer";
            Load += FormBeer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnNuevaCerveza;
        private DataGridView dgv;
    }
}