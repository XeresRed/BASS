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
    public partial class Añadir : Form
    {
        private string cedula;
        private string idProdc;
        private CompraVentaDataSetTableAdapters.ProductoTableAdapter productoAD;

        public Añadir()
        {
            InitializeComponent();
        }

        public Añadir(string ced, string referencia)
        {
            InitializeComponent();
            productoAD = new CompraVentaDataSetTableAdapters.ProductoTableAdapter();
            cedula = ced;
            idProdc = referencia;

            fechaLabel.Text = "¿Qué desea hacer con el articulo " + referencia + "?";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopUpCaracteristicas view = new PopUpCaracteristicas(idProdc);
            this.Hide();
            view.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerCaracteristica view = new VerCaracteristica(idProdc);
            this.Hide();
            view.ShowDialog();
        }
    }
}
