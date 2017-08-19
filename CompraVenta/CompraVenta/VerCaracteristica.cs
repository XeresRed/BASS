using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVenta
{
    public partial class VerCaracteristica : Form
    {
        private string idProdcut;
        public VerCaracteristica()
        {
            InitializeComponent();
        }

        public VerCaracteristica(string referencia)
        {
            InitializeComponent();
            idProdcut = referencia;
        }

        private void caracteristicasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.caracteristicasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void VerCaracteristica_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Caracteristicas' Puede moverla o quitarla según sea necesario.

            this.caracteristicasTableAdapter.FillById(this.compraVentaDataSet.Caracteristicas, idProdcut);
        }
    }
}
