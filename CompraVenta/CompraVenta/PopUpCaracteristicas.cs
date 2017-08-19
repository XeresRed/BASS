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
    public partial class PopUpCaracteristicas : Form
    {
        private CompraVentaDataSetTableAdapters.ProductoTableAdapter productoAD;
        private CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter caracteristicaAD;
        private string idpro;

        public PopUpCaracteristicas()
        {
            InitializeComponent();
        }

        public PopUpCaracteristicas(string idProduct)
        {
            InitializeComponent();
            idpro = idProduct;
            caracteristicaAD = new CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter();
            productoAD = new CompraVentaDataSetTableAdapters.ProductoTableAdapter();
        }

        private void caracteristicasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.caracteristicasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void PopUpCaracteristicas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Caracteristicas' Puede moverla o quitarla según sea necesario.
            this.caracteristicasTableAdapter.Fill(this.compraVentaDataSet.Caracteristicas);

            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(label2, "Es el numero de serie o identificador del producto; sin este codigo no se podra hacer el registro de caracteristica");

            this.toolTip2.IsBalloon = true;
            this.toolTip2.SetToolTip(label1, "Es la marca del producto");

            this.toolTip3.IsBalloon = true;
            this.toolTip3.SetToolTip(label6, "Es la referencia en especifico del producto. por ejemplo: El computador Asus 555XN, Asus es la marcar y 555XN es la referencia.");



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!serieTextBox.Text.Equals(""))
            {
                caracteristicaAD.Insert(serieTextBox.Text, idpro, marcaTextBox.Text, referenciaTextBox.Text, descripcionTextBox.Text);
                MessageBox.Show("se ha registrado con exito la caracteristica", "Bass", MessageBoxButtons.OK);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Se debe ingresar el numero de serie", "Bass", MessageBoxButtons.OK);
            }
           
        }

        private void limpiarCampos()
        {
            serieTextBox.Text = "";
            marcaTextBox.Text = "";
            referenciaTextBox.Text = "";
            descripcionTextBox.Text = "";
        }
    }
}
