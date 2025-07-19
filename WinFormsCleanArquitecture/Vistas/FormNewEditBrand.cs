using ApplicationBusiness;
using DTOs;
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
                var brandEditdto = new BrandDto
                {
                    Id = _id,
                    Name = txtNombreMarca.Text.Trim()
                };

                await _editeBrand.ExecuteAsync(brandEditdto);

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
                var brandDto = new BrandDto { Name = txtNombreMarca.Text.Trim() };
                await _addBrand.ExecuteAsync(brandDto);
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

        public void SetInfo(BrandDto brandDto)
        {   
            _id = brandDto.Id;
            Text = "Editar Marca";
            btnGuardarAltaMarca.Text = "Editar";
            txtNombreMarca.Text = brandDto.Name;
        }

    }
}
 

