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
    public partial class Inventario : Form
    {
        private CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter caracteristicaAD;
        private CompraVentaDataSetTableAdapters.ProductoTableAdapter productoAD;
        private string cedulaUsuario;


        public Inventario()
        {
            InitializeComponent();
        }

        public Inventario(string ced)
        {
            InitializeComponent();
            cedulaUsuario = ced;
            productoAD = new CompraVentaDataSetTableAdapters.ProductoTableAdapter();
            caracteristicaAD = new CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter();
            SelectorBusqueda.SelectedIndex = 0;
            comboBox2.Visible = false;
            
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in productoAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<string>(0), row.Field<string>(1), row.Field<string>(2), row.Field<int>(3), row.Field<int>(4), row.Field<string>(6), row.Field<string>(5));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text.Equals("Buscar"))
            {
                button1.Text = "Mostrar Todo";
                for (int k = 0; k < dataGridView1.RowCount; k++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        dataGridView1.Rows[k].Cells[j].Value = "";
                    }
                }
                int i = 0;

                if (!SelectorBusqueda.Text.Equals(""))
                {
                    switch (SelectorBusqueda.Text)
                    {
                        case "Referencia de producto":
                            i = 0;
                            foreach (DataRow row in productoAD.BuscarTodoPorRef(textBox1.Text).Rows)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = row.Field<string>(0);
                                dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(1);
                                dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                                dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(3);
                                dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(4);
                                dataGridView1.Rows[i].Cells[5].Value = row.Field<string>(6);
                                dataGridView1.Rows[i].Cells[6].Value = row.Field<string>(5);
                                i++;
                            }
                            dataGridView1.Update();
                            break;
                        case "Departamento":
                            i = 0;
                            foreach (DataRow row in productoAD.BuscarTodoPorDepto(comboBox2.Text).Rows)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = row.Field<string>(0);
                                dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(1);
                                dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                                dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(3);
                                dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(4);
                                dataGridView1.Rows[i].Cells[5].Value = row.Field<string>(6);
                                dataGridView1.Rows[i].Cells[6].Value = row.Field<string>(5);
                                i++;
                            }
                            dataGridView1.Update();
                            break;
                        case "Nombre":
                            i = 0;
                            foreach (DataRow row in productoAD.BuscarTodoPorNombre(textBox1.Text).Rows)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = row.Field<string>(0);
                                dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(1);
                                dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                                dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(3);
                                dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(4);
                                dataGridView1.Rows[i].Cells[5].Value = row.Field<string>(6);
                                dataGridView1.Rows[i].Cells[6].Value = row.Field<string>(5);
                                i++;
                            }
                            dataGridView1.Update();
                            break;
                        case "Precio Mayor A":
                            i = 0;
                            foreach (DataRow row in productoAD.PrecioMayorA(int.Parse(textBox1.Text)).Rows)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = row.Field<string>(0);
                                dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(1);
                                dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                                dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(3);
                                dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(4);
                                dataGridView1.Rows[i].Cells[5].Value = row.Field<string>(6);
                                dataGridView1.Rows[i].Cells[6].Value = row.Field<string>(5);
                                i++;
                            }
                            dataGridView1.Update();
                            break;
                        case "Precio Menor A":
                            i = 0;
                            foreach (DataRow row in productoAD.PrecioMenorA(int.Parse(textBox1.Text)).Rows)
                            {
                                dataGridView1.Rows[i].Cells[0].Value = row.Field<string>(0);
                                dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(1);
                                dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                                dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(3);
                                dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(4);
                                dataGridView1.Rows[i].Cells[5].Value = row.Field<string>(6);
                                dataGridView1.Rows[i].Cells[6].Value = row.Field<string>(5);
                                i++;
                            }
                            dataGridView1.Update();
                            break;

                    }

                }
            }
            else
            {
                mostrarInformacion();
                button1.Text = "Buscar";
            }
        }

        private void mostrarInformacion()
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in productoAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<string>(0), row.Field<string>(1), row.Field<string>(2), row.Field<int>(3), row.Field<int>(4), row.Field<string>(6));
            }
        }

        private void SelectorBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SelectorBusqueda.Text.Equals(""))
            {
                switch (SelectorBusqueda.Text)
                {
                    case "Departamento":
                        comboBox2.Visible = true;
                        textBox1.Visible = false;
                        break;
                    default:
                        comboBox2.Visible = false;
                        textBox1.Visible = true;
                        break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().ToLower().Equals("venta"))
            {
                Añadir view = new Añadir(cedulaUsuario, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                view.ShowDialog();
            }
            else
            {
                MessageBox.Show("El articulo seleccionado no se puede modificar debido a que esta en estado de contrato ", "BASS", MessageBoxButtons.OK);
            }
        }
    }
}
