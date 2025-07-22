using ApplicationBusiness;
using ApplicationBusiness.DTOs;
using Entity;
using Repository.AdditionalDataClass;
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
    public partial class FormNewEditBeer : Form
    {
        private readonly AddBeer<BeerAdditionalData> _addBeer;
        private readonly EditBeer<BeerAdditionalData> _editBeer;
        private readonly IRepository<Brand> _brandRepository;
        private int _beerId = 0;

       
        public FormNewEditBeer(AddBeer<BeerAdditionalData> addBeer, EditBeer<BeerAdditionalData> editBeer, IRepository<Brand> repository)
        {
            InitializeComponent();
            _addBeer = addBeer;
            _editBeer = editBeer;
            _brandRepository = repository;
        }

        private async void FormNewEditBeer_Load(object sender, EventArgs e)
        {
            var brands = await _brandRepository.GetAllAsync();
            cboBrands.DataSource = brands;
            cboBrands.DisplayMember = "Name";
            cboBrands.ValueMember = "Id";

        }


        private async void btnGuardarBeer_Click(object sender, EventArgs e)
        {

            if (_beerId == 0)
            {
                var beerDTO = new BeerDTO
                {
                    Name = txtName.Text,
                    IdBrand = Convert.ToInt32(cboBrands.SelectedValue),
                    Alcohol = Convert.ToDecimal(txtAlcohol.Text),
                    Description = txtDescripcion.Text.Trim()
                };

                await _addBeer.ExecuteAsync(beerDTO);
            }
            else if (_beerId > 0)
            {
                await _editBeer.ExecuteAsync(new BeerDTO
                {
                    Id = _beerId,
                    Name = txtName.Text,
                    IdBrand = Convert.ToInt32(cboBrands.SelectedValue),
                    Alcohol = Convert.ToDecimal(txtAlcohol.Text),
                    Description = txtDescripcion.Text.Trim()
                });
            }

            this.Close();
        }


        public void SetInfo(BeerDTO beerDto)
        {
            _beerId = beerDto.Id;
            txtName.Text = beerDto.Name;
            cboBrands.SelectedValue = beerDto.IdBrand;
            txtAlcohol.Text = beerDto.Alcohol.ToString();
            txtDescripcion.Text = beerDto.Description;

            btnGuardarBeer.Text = "Editar";
            this.Text = "Editar Cerveza";

        }

      
    }
}
