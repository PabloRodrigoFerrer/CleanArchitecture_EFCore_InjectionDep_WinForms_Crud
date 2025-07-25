using Microsoft.Extensions.DependencyInjection;
using Views;
using Views.Vistas;

namespace WinFormsCleanArquitecture
{
    public partial class FormMain : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FormMain(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HolaMundo");
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var form = new FormBrand();
            var form = _serviceProvider.GetRequiredService<FormBrand>();
            form.ShowDialog();

        }

        private void cervezasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormBeer>();
            form.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormNewSale>();
            form.ShowDialog();
        }
    }
}
