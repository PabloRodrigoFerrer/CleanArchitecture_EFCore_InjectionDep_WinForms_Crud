using ApplicationBusiness;
using Entity;
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
        private int _idBeer = 0;
        private readonly AddBeer _addBeer;
        private readonly EditBeer _editBeer;
        private readonly IRepository<Brand> _brandRepository;

        public FormNewEditBeer(AddBeer addBeer , EditBeer editBeer, IRepository<Brand> repository)
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
            
            if (_idBeer == 0) 
            {
                var beer = new Beer
                {
                    Name = txtName.Text,
                    BrandId = Convert.ToInt32(cboBrands.SelectedValue),
                    Alcohol = Convert.ToDecimal(txtAlcohol.Text)
                };

                await _addBeer.ExecuteAsync(beer);
            }
            else if (_idBeer > 0)
            {
                await _editBeer.ExecuteAsync(new Beer
                {
                    Id = _idBeer,
                    Name = txtName.Text,
                    BrandId = Convert.ToInt32(cboBrands.SelectedValue),
                    Alcohol = Convert.ToDecimal(txtAlcohol.Text)
                });
            }
         
            this.Close();           
        }

      
        public void SetInfo(Beer beer) 
        {   
            _idBeer = beer.Id;
            txtName.Text = beer.Name;
            cboBrands.SelectedValue = beer.BrandId;
            txtAlcohol.Text = beer.Alcohol.ToString();
            btnGuardarBeer.Text = "Editar";
            this.Text = "Editar Cerveza";
        }
        

    }
}
