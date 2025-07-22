using ApplicationBusiness;
using Entity;
using Microsoft.Extensions.DependencyInjection;
using Repository.AdditionalDataClass;
using Repository.QueryObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Vistas;

namespace WinFormsCleanArquitecture
{
    public partial class FormBeer : Form
    {

        private readonly IRepositoryAdditionalData<Beer, BeerAdditionalData> _repository;
        private readonly IServiceProvider _serviceProvider;
        private readonly GetBeerById<BeerAdditionalData> _getBeerById;
        private readonly BeerWithBrandAndQuery _beerWithBrandAndQuery;

        public FormBeer(IRepositoryAdditionalData<Beer, BeerAdditionalData> repository, IServiceProvider serviceProvider,
            GetBeerById<BeerAdditionalData> getBeerById,
            BeerWithBrandAndQuery beerWithBrandAndQuery)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _repository = repository;
            _getBeerById = getBeerById;
            _beerWithBrandAndQuery = beerWithBrandAndQuery;
        }

        private async void FormBeer_Load(object sender, EventArgs e)
        {
            await Refresh();
            AddColumns();
        }


        private async Task Refresh()
        {
            var beers = await _beerWithBrandAndQuery.GetAllAsync();
            dgv.DataSource = beers;
        }

        private void AddColumns()
        {
            DataGridViewButtonColumn editBtnColumn = new DataGridViewButtonColumn
            {
                Text = "Editar",
                Name = "btnDgvEditar",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            editBtnColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            dgv.Columns.Add(editBtnColumn);

            DataGridViewButtonColumn deleteBtnColumn = new DataGridViewButtonColumn
            {
                Text = "Eliminar",
                Name = "btnDgvDelete",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };

            dgv.Columns.Add(deleteBtnColumn);

        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

            switch (dgv.Columns[e.ColumnIndex].Name)
            {
                case "btnDgvDelete":
                    if (MessageBox.Show("¿Estás seguro de eliminar esta cerveza?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        await _repository.DeleteAsync(id);
                        await Refresh();
                    }
                    break;
                case "btnDgvEditar":

                    var beerDTO = await _getBeerById.ExecuteAsync(id);
                    var form = _serviceProvider.GetRequiredService<FormNewEditBeer>();
                    form.SetInfo(beerDTO);
                    form.ShowDialog();
                    await Refresh();
                    break;
                default:
                    break;
            }


        }

        private async void btnNuevaCerveza_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormNewEditBeer>();
            form.ShowDialog();
            await Refresh();
        }
    }
}
