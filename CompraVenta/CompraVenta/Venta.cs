using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVenta
{
    public partial class Venta : Form
    {
        private string Cedula_Usuario = "";
        private string Nombre_Encargado = "";

        private string Cedula_Cliente = "";

        private string Ruta_Documento = "";
        private int Original_Cantidad = 0;
        private int original_Valor = 0;
        private ArrayList idProductos;
        private int maxCompra;

        private string serie;

        private CompraVentaDataSetTableAdapters.ProductoTableAdapter productoAD;
        private CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter caracteristicaAD;
        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        private CompraVentaDataSetTableAdapters.VentaTableAdapter ventaAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private CompraVentaDataSetTableAdapters.DepartamentoTableAdapter departamentoAD;
        private CompraVentaDataSetTableAdapters.MovimientosTableAdapter movimientoAD;

        public Venta()
        {
            InitializeComponent();
        }

        public Venta(string cedulaUser)
        {
            InitializeComponent();

            //CEDULA DE ENCARGADO
            Cedula_Usuario = cedulaUser;

            //INICIALIZACION DE ADAPTADORES DE BD
            productoAD = new CompraVentaDataSetTableAdapters.ProductoTableAdapter();
            caracteristicaAD = new CompraVentaDataSetTableAdapters.CaracteristicasTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            departamentoAD = new CompraVentaDataSetTableAdapters.DepartamentoTableAdapter();
            ventaAD = new CompraVentaDataSetTableAdapters.VentaTableAdapter();
            movimientoAD = new CompraVentaDataSetTableAdapters.MovimientosTableAdapter();

            idProductos = new ArrayList();

            //Llenado de combobox con el nombre de deparatamentos
            foreach (DataRow row in departamentoAD.GetData().Rows)
            {
                DepartamentoCombo.Items.Add(row.Field<string>(0));
            }

            //Nombre de Encargado
            foreach (DataRow row in encargadoAD.obtenerUsuario(Cedula_Usuario).Rows)
            {
                Nombre_Encargado = row.Field<string>(1);
                VendedorLbl.Text = "Vendedor: " + Nombre_Encargado;
            }

        }

        private void ModuloVenta_Load(object sender, EventArgs e)
        {
           // ventaAD = new CompraVentaDataSetTableAdapters.VentaTableAdapter();
            
            foreach (DataRow row in ventaAD.GetData().Rows)
            {
                 dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<string>(1));
            }

            

            if (!ventaAD.MAXiDvENTA().Equals(null))
            {
                maxCompra = (int)ventaAD.MAXiDvENTA() + 1;
                NoVentaLbl.Text = "No. Venta: " + maxCompra;
            }
            else
            {
                NoVentaLbl.Text = "No. Venta: 1";
            }
        }

        private void AgregarCbtn_Click(object sender, EventArgs e)
        {
            PopUpAgregarCliente view = new PopUpAgregarCliente(Cedula_Usuario);
            view.ShowDialog();
            Cedula_Cliente = view.getCedula();

            if (!Cedula_Cliente.Equals(""))
            {
                label9.ForeColor = Color.LightSeaGreen;
                label1.ForeColor = Color.LightSeaGreen;
                label1.Text = "Si";
                QuitarCbtn.Visible = true;
            }
        }

        private void DepartamentoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!DepartamentoCombo.Text.Equals(""))
            {
                idProductos.Clear();
                NombreProductoCombo.Items.Clear();
                NombreProductoCombo.Text = "";
                ValorVentaText.Text = "";
                CantidadProducto.Value = 0;
                ReferenciaTxt.Text = "";
                pesotxt.Text = "";
                Ruta_Documento = "";
                noImportalbl.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                label6.Text = "No";
                button2.Enabled = false;

                foreach (DataRow row in productoAD.ObtenerProductoDepto(DepartamentoCombo.Text,"Venta").Rows)
                {
                    idProductos.Add(row.Field<string>(0));
                    NombreProductoCombo.Items.Add(row.Field<string>(2));
                }
            }
            else
            {

            }
        }

        private void NombreProductoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!NombreProductoCombo.Text.Equals(""))
            {
                foreach (DataRow row in productoAD.BuscarporId((string) idProductos[NombreProductoCombo.SelectedIndex], "Venta").Rows)
                {
                    CantidadProducto.Value = row.Field<int>(4);
                    Original_Cantidad = row.Field<int>(4);
                    original_Valor = row.Field<int>(3);
                    ValorVentaText.Text = row.Field<int>(3) + "";
                    ReferenciaTxt.Text = row.Field<string>(0);
                    pesotxt.Text = row.Field<string>(6);
                    Ruta_Documento = row.Field<string>(7);

                    if (!row.Field<string>(7).Equals(""))
                    {
                        noImportalbl.ForeColor = Color.LightSeaGreen;
                        label6.ForeColor = Color.LightSeaGreen;
                        label6.Text = "Si";
                    }
                }

                foreach (DataRow row in caracteristicaAD.obtenerCaracteristica(ReferenciaTxt.Text).Rows)
                {
                    if (!row.Field<string>(0).Equals(""))
                    {
                        button2.Enabled = true;
                    }
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ReferenciaTxt.Text.Equals(""))
            {
                foreach (DataRow row in productoAD.BuscarporId(ReferenciaTxt.Text,"Venta").Rows)
                {
                    CantidadProducto.Value = row.Field<int>(4);
                    Original_Cantidad = row.Field<int>(4);
                    original_Valor = row.Field<int>(3);
                    ValorVentaText.Text = row.Field<int>(3).ToString();
                    ReferenciaTxt.Text = row.Field<string>(0);
                    pesotxt.Text = row.Field<string>(6);
                    Ruta_Documento = row.Field<string>(7);

                    if (!row.Field<int>(7).Equals(""))
                    {
                        noImportalbl.ForeColor = Color.LightSeaGreen;
                        noImportalbl.ForeColor = Color.LightSeaGreen;
                        label6.Text = "Si";
                    }
                }

                foreach (DataRow row in caracteristicaAD.obtenerCaracteristica(ReferenciaTxt.Text).Rows)
                {
                    if (!row.Field<string>(0).Equals(""))
                    {
                        button2.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo de referencia debe tener una referencia valida.","BASS",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void DescuentoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (DescuentoChk.Checked)
            {
                DescuentoValor.Visible = true;
                ProcentajeLbl.Visible = true;
                DescuentoLbl.Visible = true;
            }
            else
            {
                DescuentoValor.Visible = false;
                ProcentajeLbl.Visible = false;
                DescuentoLbl.Visible = false;
            }
        }

        private void TipoBusquedaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblTipoBusqueda.Text = TipoBusquedaCombo.Text;
            if (TipoBusquedaCombo.Text.Contains("Fecha"))
            {
                TxtBusqueda.Visible = false;
                BusquedaFecha.Visible = true;
            }
            else
            {
                TxtBusqueda.Visible = true;
                BusquedaFecha.Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistrarVentaBtn_Click(object sender, EventArgs e)
        {
            if (label1.Text.Equals("Si"))
            {
                int CantidadNueva = Original_Cantidad - (int)CantidadProducto.Value;

               

                if (CantidadNueva > 0)
                {
                    productoAD.Update(DepartamentoCombo.Text, NombreProductoCombo.Text, original_Valor, CantidadNueva, "Venta", pesotxt.Text, Ruta_Documento, ReferenciaTxt.Text, DepartamentoCombo.Text, NombreProductoCombo.Text, original_Valor, Original_Cantidad, "Venta", pesotxt.Text, Ruta_Documento);
                }
                else if (CantidadNueva == 0)
                {
                    productoAD.Update(DepartamentoCombo.Text, NombreProductoCombo.Text, original_Valor, CantidadNueva, "Sin elementos", pesotxt.Text, Ruta_Documento, ReferenciaTxt.Text, DepartamentoCombo.Text, NombreProductoCombo.Text, original_Valor, Original_Cantidad, "Venta", pesotxt.Text, Ruta_Documento);
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada supera la cantidad del producto, Cantidad total: " + Original_Cantidad, "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                int salida = Convert.ToInt32(ValorVentaText.Text);

                ventaAD.Insert(Cedula_Usuario, Cedula_Cliente, ReferenciaTxt.Text, FechaVenta.Value, salida, (int)CantidadProducto.Value, salida);

                string mensaje = "";

                if (DescuentoChk.Checked)
                {
                    movimientoAD.Insert(FechaVenta.Value, maxCompra + "", salida, 0, "Venta", (int) DescuentoValor.Value);
                    mensaje = "El usuario " + Nombre_Encargado + " identificado con numero de cedula: " + Cedula_Usuario + " Ha registrado una venta por: " + ValorVentaText.Text + " con un descuento del: " + DescuentoValor.Value + "%. \n" +
                             "El valor original del producto es: " + original_Valor + " el objeto vendido fue: " + NombreProductoCombo.Text + " Ubicado en el departamento de: " + DepartamentoCombo.Text;
                }
                else
                {
                    movimientoAD.Insert(FechaVenta.Value, maxCompra + "", salida, 0, "Venta", 0);
                    mensaje = "El usuario " + Nombre_Encargado + " identificado con numero de cedula: " + Cedula_Usuario + " Ha registrado una venta por: " + ValorVentaText.Text + "\n" +
                             "El objeto vendido fue: " + NombreProductoCombo.Text + " Ubicado en el departamento de: " + DepartamentoCombo.Text;
                }


                trazaAD.Insert(Cedula_Usuario, mensaje, DateTime.Now, "Registro","Venta");
                mostrarInformacion();
                MessageBox.Show("Se ha registrado con exito la venta.", "BASS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se ha añadido un cliente a la compra", "BASS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void mostrarInformacion()
        {

            idProductos.Clear();
            NombreProductoCombo.Items.Clear();
            NombreProductoCombo.Text = "";
            DepartamentoCombo.Text = "";
            DescuentoChk.Checked = false;
            ValorVentaText.Text = "";
            CantidadProducto.Value = 0;
            ReferenciaTxt.Text = "";
            pesotxt.Text = "";
            Ruta_Documento = "";
            noImportalbl.ForeColor = Color.Red;
            label6.ForeColor = Color.Red;
            label6.Text = "No";

            foreach (DataRow row in ventaAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<string>(1));
            }
        }

        private void DescuentoValor_ValueChanged(object sender, EventArgs e)
        {
            string m_valor = ValorVentaText.Text;
            if (DescuentoChk.Checked && !ValorVentaText.Text.Equals("") && CantidadProducto.Value > 0)
            {
                Decimal cantidadDescuento = DescuentoValor.Value/100;
                Decimal cantidadConvertida = Decimal.Parse(ValorVentaText.Text) - (Decimal.Parse(ValorVentaText.Text) * cantidadDescuento);
                int valor = (int)cantidadConvertida;
                ValorVentaText.Text = valor.ToString();
            }
            else
            {
                ValorVentaText.Text = m_valor;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text.Equals("Si")) {
                if (!Ruta_Documento.Equals(""))
                {
                    Process.Start(Ruta_Documento);
                }
            }
            else
            {
                MessageBox.Show("Este producto no tiene documento de propiedad.","BASS",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            //MostrarTodo.Enabled = true;


            if (!TipoBusquedaCombo.Text.Equals(""))
            {
                switch (TipoBusquedaCombo.Text)
                {
                    case "Cedula de cliente":
                        
                        foreach (DataRow row in ventaAD.ObtenerPorCedulaC(TxtBusqueda.Text).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Cedula de empleado":
                        
                        foreach (DataRow row in ventaAD.ObtenerCedulaU(TxtBusqueda.Text).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Identificador de compra":
                        
                        foreach (DataRow row in ventaAD.ObtenerPorId(int.Parse(TxtBusqueda.Text)).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Fecha menor A":
                        
                        foreach (DataRow row in ventaAD.FechaMenorA(BusquedaFecha.Value.ToString("dd/MM/yyyy")).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Fecha mayor A":
                        
                        foreach (DataRow row in ventaAD.FechaMayorA(BusquedaFecha.Value.ToString("dd/MM/yyyy")).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Compra Menor A":
                        
                        foreach (DataRow row in ventaAD.VentaMenorA(int.Parse(TxtBusqueda.Text)).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
                        break;
                    case "Compra Mayor A":
                        
                        foreach (DataRow row in ventaAD.VentaMayoA(int.Parse(TxtBusqueda.Text)).Rows)
                        {
                            dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
                        }
                        
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
            dataGridView1.Rows.Clear();
            foreach (DataRow row in ventaAD.GetData().Rows)
            {
                dataGridView1.Rows.Add(row.Field<int>(0), row.Field<string>(3), row.Field<string>(2), row.Field<int>(5), row.Field<int>(6), row.Field<DateTime>(4).ToString("dd/MM/yyyy"), row.Field<int>(1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerCaracteristica view = new VerCaracteristica(ReferenciaTxt.Text);
            view.ShowDialog();
        }

        private void ValorVentaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
                ValorVentaText.Text = "";
                return;
            }
        }
    }
}
