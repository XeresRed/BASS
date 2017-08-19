using System;
using System.Collections;
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
    public partial class ListaDeIngreso : Form
    {
        private CompraVentaDataSetTableAdapters.ingresosTableAdapter ingresoAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private ArrayList idEncargado;
        private string cedula;

        public ListaDeIngreso()
        {
            InitializeComponent();
            ingresoAD = new CompraVentaDataSetTableAdapters.ingresosTableAdapter();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            idEncargado = new ArrayList();

            foreach (DataRow row in encargadoAD.GetData().Rows)
            {
                idEncargado.Add(row.Field<string>(0));
                comboBox1.Items.Add(row.Field<string>(1));
            }


            foreach (DataRow row in ingresoAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<DateTime>(3).ToString("dd/MM/yyyy"));
            }
        }

        public ListaDeIngreso(string ced)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in ingresoAD.ObtenerEncargadoIngreso((string) idEncargado[comboBox1.SelectedIndex]).Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<DateTime>(3).ToString("dd/MM/yyyy"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in ingresoAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<DateTime>(3).ToString("dd/MM/yyyy"));
            }
        }
    }
}
