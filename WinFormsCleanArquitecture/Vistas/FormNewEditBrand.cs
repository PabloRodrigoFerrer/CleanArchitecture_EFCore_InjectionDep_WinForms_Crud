using ApplicationBusiness;
using DTOs;
using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Vistas
{
    public partial class AltaMarca : Form
    {
        private readonly AddBrand _addBrand;
        private readonly EditBrand _editeBrand;
        private int _id = 0;
        public AltaMarca(AddBrand addBrand, EditBrand editeBrand)
        {
            InitializeComponent();
            _addBrand = addBrand;
            _editeBrand = editeBrand;
        }

        private void AltaMarca_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnGuardarAltaMarca_Click(object sender, EventArgs e)
        {
            if (ValidadCampo())
                return;

            var respuesta = MessageBox.Show($"Desea agregagar a {txtNombreMarca.Text.Trim()}?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes && _id == 0)
                await Add();
            else if (_id != 0)
                await Edit();

            this.Close();
        }

        private async Task Edit() 
        {
            try
            {
                var brand = new Brand
                {
                    Id = _id,
                    Name = txtNombreMarca.Text.Trim()
                };

                await _editeBrand.ExecuteAsync(brand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async Task Add()
        {
            try
            {
                var brand = new Brand { Name = txtNombreMarca.Text.Trim() };
                await _addBrand.ExecuteAsync(brand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidadCampo()
        {
            if (string.IsNullOrEmpty(txtNombreMarca.Text.Trim()))
            {
                MessageBox.Show("El nombre de la marca no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public void SetInfo(Brand Brand)
        {   
            _id = Brand.Id;
            Text = "Editar Marca";
            btnGuardarAltaMarca.Text = "Editar";
            txtNombreMarca.Text = Brand.Name;
        }

    }
}
 

