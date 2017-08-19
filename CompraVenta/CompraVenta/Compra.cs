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
    public partial class Compra : Form
    {
        private string cedulaUsuario;
        private CompraVentaDataSetTableAdapters.CompraTableAdapter compraAD;
        private CompraVentaDataSetTableAdapters.ProductoTableAdapter productoAD;
        private CompraVentaDataSetTableAdapters.DepartamentoTableAdapter departamentoAD;
        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter EncargadoAD;
        private CompraVentaDataSetTableAdapters.MovimientosTableAdapter movimientoAD;
        private string cedulaCliente;
        private string nombreEncargado;
        private string Original_Cedula_Cliente;
        private string Original_Cedula_Usuario;
        private int Original_Id_Compra;
        private string Original_Id_Producto;
        private int Original_Cantidad;
        private int Original_Valor_Venta;
        private int Original_Unitario;
        private int Original_Post;
        private DateTime Original_Fecha;
        private string rutaDocumento;
        int maxCompra = 1;

        public Compra()
        {
            InitializeComponent();
        }

        public Compra(string ced, bool empleado)
        {
            rutaDocumento = "";
            InitializeComponent();

            // INICIALIZO LOS COMPONENTES DE LA BD
            compraAD = new CompraVentaDataSetTableAdapters.CompraTableAdapter();
            productoAD = new CompraVentaDataSetTableAdapters.ProductoTableAdapter();
            departamentoAD = new CompraVentaDataSetTableAdapters.DepartamentoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            EncargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            movimientoAD = new CompraVentaDataSetTableAdapters.MovimientosTableAdapter();

            // OBTENER EL NOMBRE DE ENCARGADO
            foreach (DataRow row in EncargadoAD.obtenerUsuario(ced))
            {
                nombreEncargado = row.Field<string>(1);
            }

            cedulaUsuario = ced;
            dateTimePicker1.Visible = false;
            CantidadProducto.Value = 1;
            label3.Text = "Vendedor: " + nombreEncargado;

            // SE ESTABLECEN TODOS LOS DEPARTAMENTOS
            foreach(DataRow row in departamentoAD.GetData().Rows)
            {
                DepartamentoCombo.Items.Add(row.Field<string>(0));
            }
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            foreach (DataRow row in compraAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(7), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<string>(1));
            }

            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(valorUnitarioTextBox, "Es el valor total de la compra.");
            this.toolTip2.IsBalloon = true;
            this.toolTip2.SetToolTip(valorVentaTextBox, "Es el valor al que se va vender cada objeto individualmente.");

            if (!compraAD.MaxIdcompra().Equals(null))
            {
                maxCompra = (int)compraAD.MaxIdcompra() + 1;
                label11.Text = "No. Compra: " + maxCompra;
            }
            else
            {
                label11.Text = "No. Compra: 1";
            }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            PopUpAgregarCliente view = new PopUpAgregarCliente(cedulaUsuario);
            view.ShowDialog();
            cedulaCliente = view.getCedula();


            if (!cedulaCliente.Equals(""))
            {
                label9.ForeColor = Color.LightSeaGreen;
                label10.ForeColor = Color.LightSeaGreen;
                label10.Text = "Si";
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            label9.ForeColor = Color.Red;
            label10.ForeColor = Color.Red;
            label10.Text = "No";
            cedulaCliente = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusquedaLabel.Text = comboBox1.Text;
            if (!comboBox1.Text.Equals(""))
            {
                switch (comboBox1.Text)
                {
                    case "Fecha menor A":
                        dateTimePicker1.Visible = true;
                        textBox1.Visible = false;
                        break;
                    case "Fecha mayor A":
                        dateTimePicker1.Visible = true;
                        textBox1.Visible = false;
                        break;
                    default:
                        dateTimePicker1.Visible = false;
                        textBox1.Visible = true;
                        break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int k = 0;k < dataGridView1.RowCount; k++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[k].Cells[j].Value = "";
                }
            }
            int i = 0;
            MostrarTodo.Enabled = true;


            if (!comboBox1.Text.Equals(""))
            {
                switch (comboBox1.Text)
                {
                    case "Cedula de cliente":
                        i = 0;
                        foreach (DataRow row in compraAD.ObtenerCedulaCliente(textBox1.Text).Rows )
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Cedula de empleado":
                        i = 0;
                        foreach (DataRow row in compraAD.obtenerporUsuario(textBox1.Text).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Identificador de compra":
                        i = 0;
                        foreach (DataRow row in compraAD.obtenerIdCompra(int.Parse(textBox1.Text)).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Fecha menor A":
                        i = 0;
                        foreach (DataRow row in compraAD.ObtenerFechaMenorA(dateTimePicker1.Value.ToString("dd/MM/yyyy")).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Fecha mayor A":
                        i = 0;
                        foreach (DataRow row in compraAD.obtenerFechaMayorA(dateTimePicker1.Value.ToString("dd/MM/yyyy")).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Compra Menor A":
                        i = 0;
                        foreach (DataRow row in compraAD.obtenerCompraMenorA(int.Parse(textBox1.Text)).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                    case "Compra Mayor A":
                        i = 0;
                        foreach (DataRow row in compraAD.obtenerCompraMayorA(int.Parse(textBox1.Text)).Rows)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = row.Field<int>(0);
                            dataGridView1.Rows[i].Cells[1].Value = row.Field<string>(3);
                            dataGridView1.Rows[i].Cells[2].Value = row.Field<string>(2);
                            dataGridView1.Rows[i].Cells[3].Value = row.Field<int>(5);
                            dataGridView1.Rows[i].Cells[4].Value = row.Field<int>(7);
                            dataGridView1.Rows[i].Cells[5].Value = row.Field<int>(6);
                            dataGridView1.Rows[i].Cells[6].Value = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                            dataGridView1.Rows[i].Cells[7].Value = row.Field<string>(1);
                            i++;
                        }
                        dataGridView1.Update();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar primero una opción para busqueda", "BASS", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ReferenciaText.Text.Equals("")) {
                if (label10.Text.Equals("Si")) {

                    if (!pesoText.Text.Equals(""))
                    {
                        productoAD.Insert(ReferenciaText.Text, DepartamentoCombo.Text, NombreText.Text, int.Parse(valorVentaTextBox.Text), (int)CantidadProducto.Value, "Venta", pesoText.Text, rutaDocumento);
                    }
                    else
                    {
                        productoAD.Insert(ReferenciaText.Text, DepartamentoCombo.Text, NombreText.Text, int.Parse(valorVentaTextBox.Text), (int)CantidadProducto.Value, "Venta", "No aplica", rutaDocumento);
                    }

                    compraAD.Insert(cedulaUsuario, cedulaCliente, ReferenciaText.Text, fechaDateTimePicker.Value, int.Parse(valorUnitarioTextBox.Text), (int)CantidadProducto.Value, int.Parse(valorVentaTextBox.Text), int.Parse(valorVentaTextBox.Text));

                    movimientoAD.Insert(fechaDateTimePicker.Value, maxCompra+"",int.Parse(valorUnitarioTextBox.Text),0,"Compra",0);

                    trazaAD.Insert(cedulaUsuario, "El usuario " + nombreEncargado + " identificado con numero de cedula: " + cedulaUsuario + " Ha registrado una compra por: " + valorUnitarioTextBox.Text + "\n" +
                            "El objeto comprado fue: " + NombreText.Text + " Ubicado en el departamento de: " + DepartamentoCombo.Text, DateTime.Now, "Registro", "Compra");

                    mostrarInformacion();

                    LimpiarCampos();
                    MessageBox.Show("Se ha registrado con exito la compra", "BASS", MessageBoxButtons.OK);

                    if (!compraAD.MaxIdcompra().Equals(null))
                    {
                      int maxCompra = (int)compraAD.MaxIdcompra() + 1;
                      label11.Text = "No. Compra: " + maxCompra;
                    }
                    else
                    {
                      label11.Text = "No. Compra: 1";
                    }
                }
                else
                {
                    MessageBox.Show("No se ha añadido un cliente a la compra", "BASS", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No se ha añadido una referencia a el producto.", "BASS", MessageBoxButtons.OK);
            }
            

        }

        private void LimpiarCampos()
        {
            valorUnitarioTextBox.Text = "";
            valorVentaTextBox.Text = "";
            CantidadProducto.Value = 1;
            fechaDateTimePicker.Value = DateTime.Now;
            ReferenciaText.Text = "";
            NombreText.Text = "";
            pesoText.Text = "";
           // button1.Visible = false;
            label13.ForeColor = Color.Red;
            label14.ForeColor = Color.Red;
            label14.Text = "No";
            rutaDocumento = "";
        }

        public void mostrarInformacion()
        {
            try
            {
                int dato1 = 0;
                string dato2 = "";
                string dato3 = "";
                int dato4 = 0;
                int dato5 = 0;
                int dato6 = 0;
                string dato7 = "";
                string dato8 = "";
                foreach (DataRow row in compraAD.GetData().Rows)
                {
                    dato1 = row.Field<int>(0);
                    dato2 = row.Field<string>(3);
                    dato3 = row.Field<string>(2);
                    dato4 = row.Field<int>(5);
                    dato5 = row.Field<int>(7);
                    dato6 = row.Field<int>(6);
                    dato7 = row.Field<DateTime>(4).ToString("dd/MM/yyyy");
                    dato8 = row.Field<string>(1);
                }
                dataGridView1.Rows.Add(dato1, dato2, dato3, dato4, dato5, dato6, dato7, dato8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Definición de error: " + ex.Message , "BASS", MessageBoxButtons.OK);
                throw ;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pesoText.Enabled = true;
            }
            else
            {
                pesoText.Enabled = false;
            }
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in compraAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(7), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<string>(1));
            }
            MostrarTodo.Enabled = false;
        }


        private void Eliminar_Click(object sender, EventArgs e)
        {

            Confirmar view = new Confirmar();
            view.ShowDialog();
            string permiso = view.getContraseña();

            if (permiso.Equals("si"))
            {

                compraAD.Delete(Original_Id_Compra, Original_Cedula_Usuario, Original_Cedula_Cliente, Original_Id_Producto, Original_Fecha, Original_Unitario, Original_Cantidad, Original_Valor_Venta, Original_Post);
                trazaAD.Insert(Original_Cedula_Usuario, "El usuario " + nombreEncargado + " con cedula " + Original_Cedula_Usuario + " elimino la compra: " + Original_Id_Compra + "\n" +
                    "Con un valor de: " + Original_Unitario, DateTime.Now, "Eliminacion", "Compra");
                mostrarInformacion();
                MessageBox.Show("Se ha Eliminado con exito la compra", "BASS", MessageBoxButtons.OK);
            }
            else
            {

                MessageBox.Show("No tiene permiso para eliminar la compra", "BASS", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                Original_Id_Compra = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                Original_Id_Producto = (string) dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                Original_Cedula_Cliente = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Original_Unitario = (int)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                Original_Valor_Venta = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                Original_Cantidad = (int)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
                Original_Fecha = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                Original_Cedula_Usuario = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Original_Post = Original_Valor_Venta;
                Eliminar.Enabled = true;
                label7.ForeColor = Color.LightSeaGreen;
                label8.ForeColor = Color.LightSeaGreen;
                label8.Text = Original_Id_Compra+"";
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador view = new Navegador();
            view.setPagina("https://www.runt.com.co/portel/libreria/php/01.030518.html");
            view.ShowDialog();
        }

        private void DepartamentoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep = DepartamentoCombo.Text;

            if (dep.ToLower().Equals("moto") || dep.ToLower().Equals("moto ")
                || dep.ToLower().Equals(" moto") || dep.ToLower().Equals(" moto ") || dep.ToLower().Equals("carro")
                || dep.ToLower().Equals("carro ")|| dep.ToLower().Equals(" carro") || dep.ToLower().Equals(" carro ") )
            {
                linkLabel1.Visible = true;
            }
            else
            {
                linkLabel1.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files| *.*";
            openFileDialog1.Title = "Select a Cursor File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rutaDocumento = openFileDialog1.FileName;
                label13.ForeColor = Color.LightSeaGreen;
                label14.ForeColor = Color.LightSeaGreen;
                label14.Text = "Si";

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
