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
    public partial class VistaMovimientos : Form
    {
        private CompraVentaDataSetTableAdapters.MovimientosTableAdapter movimientoAD;

        public VistaMovimientos()
        {
            InitializeComponent();
            movimientoAD = new CompraVentaDataSetTableAdapters.MovimientosTableAdapter();
        }

        private void movimientosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movimientosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void VistaMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Movimientos' Puede moverla o quitarla según sea necesario.
            foreach (DataRow row in movimientoAD.ObtenerTodo().Rows)
            {
                movimientosDataGridView.Rows.Add(row.Field<DateTime>(1).ToString("dd/MM/yyyy"), row.Field<string>(2), row.Field<int>(3), row.Field<int>(4), row.Field<string>(5), row.Field<int>(6));
            }

        }
    }
}
