using ApplicationBusiness;
using Entity;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FormBrand : Form
    {

        private IRepository<Brand> _repository;
        private IServiceProvider _serviceProvider;

        public FormBrand(IRepository<Brand> repository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _repository = repository;
            _serviceProvider = serviceProvider;
        }
        private async void FormBrand_Load(object sender, EventArgs e)
        {
            await Refresh();
            AddColums();
        }

        private async Task Refresh()
        {
            var brands = await _repository.GetAllAsync();

            dgv.DataSource = brands;
        }


        private async void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AltaMarca>();
            form.ShowDialog();
            await Refresh();

        }

        private void AddColums()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "btnDgvEditar",
                HeaderText = "",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
            };
            editButtonColumn.DefaultCellStyle.BackColor = Color.Blue;
            dgv.Columns.Add(editButtonColumn);


            DataGridViewButtonColumn DeleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "btnDgvDelete",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true,
            };
            DeleteButtonColumn.DefaultCellStyle.BackColor = Color.DarkRed;
            dgv.Columns.Add(DeleteButtonColumn);
        }

        private async void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);

            if (dgv.Columns[e.ColumnIndex].Name == "btnDgvEditar") 
            {
                var form = _serviceProvider.GetRequiredService<AltaMarca>();
                var marca = await _repository.GetByIdAsync(id);

                form.SetInfo(marca);
                form.ShowDialog();
                await Refresh();

            }
            else if (dgv.Columns[e.ColumnIndex].Name == "btnDgvDelete")
            {
                var confirmResult = 
                    MessageBox.Show("¿Está seguro de que desea eliminar esta marca?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                    await _repository.DeleteAsync(id);
                    await Refresh();
            }

        }
    }
}
