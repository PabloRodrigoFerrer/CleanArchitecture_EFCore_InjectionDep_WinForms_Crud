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
    public partial class FormNewSale : Form
    {

        private readonly IRepositoryAdditionalData<Beer, BeerAdditionalData> _beerRepository;
        private readonly CreateSale _createSale;
        public FormNewSale(CreateSale createSale,
                           IRepositoryAdditionalData<Beer, BeerAdditionalData> beerRepository)
        {
            InitializeComponent();
            _beerRepository = beerRepository;
            _createSale = createSale;
        }


        private async void FormNewSale_Load(object sender, EventArgs e)
        {
            await ChargeData();
        }


        private async Task ChargeData()
        {
            var beers = await _beerRepository.GetAllAsync();
            cboBeers.DataSource = beers;
            cboBeers.ValueMember = "Id";
            cboBeers.DisplayMember = "Name";

            if (cboBeers.Items.Count > 0)
                cboBeers.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal unitPrice = ((Beer)cboBeers.SelectedItem).Precio;
            int idBeer = ((Beer)cboBeers.SelectedItem).Id;
            string name = ((Beer)cboBeers.SelectedItem).Name;
            int quantity = int.Parse(npdCantidad.Value.ToString());

            dgv.Rows.Add(idBeer, quantity, name, unitPrice, unitPrice * quantity);

            npdCantidad.Value = 1;
            if (cboBeers.Items.Count > 0)
            {
                cboBeers.SelectedIndex = 0;
            }
            cboBeers.Focus();
            GetTotal();
        }

        private async void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var saleDTO = new SaleDTO();
                saleDTO.Concepts = new List<ConceptDTO>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    var conceptDTO = new ConceptDTO
                    {
                        IdBeer = int.Parse(row.Cells[0].Value.ToString()),
                        UnitPrice = decimal.Parse(row.Cells[3].Value.ToString()),
                        Quantity = int.Parse(row.Cells[1].Value.ToString())
                    };

                    saleDTO.Concepts.Add(conceptDTO);
                }

                await _createSale.ExecuteAsync(saleDTO);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void GetTotal() 
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgv.Rows) 
            {
                total += decimal.Parse(row.Cells[4].Value.ToString());
            }
            
            lblTotalMoney.Text = total.ToString("C");
        }
    }

}
