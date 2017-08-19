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
    public partial class Gastos : Form
    {
        private CompraVentaDataSetTableAdapters.gastosTableAdapter gastosAD;
        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private string cedula_usuario;
        private string nombre_Encargado;

        private string Original_Detalle;
        private int Original_Valor;
        private DateTime Original_fecha;
        private int Original_Id;

        private ArrayList idGasto;

        public Gastos()
        {
            InitializeComponent();
        }

        public Gastos(string usuario)
        {
            InitializeComponent();
            cedula_usuario = usuario;

            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            gastosAD = new CompraVentaDataSetTableAdapters.gastosTableAdapter();

            idGasto = new ArrayList();

            foreach (DataRow row in encargadoAD.obtenerUsuario(usuario))
            {
                nombre_Encargado = row.Field<string>(1);
            }


        }

        private void añadirTabla()
        {
            idGasto.Clear();
            foreach (DataRow row in gastosAD.GetData().Rows)
            {
                idGasto.Add(row.Field<int>(0));
            }
            dataGridView1.Rows.Add(FechaTxt.Value.ToString("dd/MM/yyyy"), detalleText.Text, ValorTXT.Text);

        }

        public void Actualizar()
        {
            idGasto.Clear();
            foreach (DataRow row in gastosAD.GetData().Rows)
            {
                idGasto.Add(row.Field<int>(0));
                dataGridView1.Rows.Add(row.Field<string>(3), row.Field<string>(1), row.Field<string>(2));
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                e.Handled = true;
                ValorTXT.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Registrar"))
            {
                gastosAD.Insert(detalleText.Text, int.Parse(ValorTXT.Text), FechaTxt.Value);
                añadirTabla();
                string mensaje = "El usuario " + nombre_Encargado + " identificado con numero de cedula: " + cedula_usuario + " Ha registrado un gasto por: " + ValorTXT.Text;
                MessageBox.Show("Se ha registrado con exito el gasto.", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                trazaAD.Insert(cedula_usuario, mensaje, DateTime.Now, "Registro", "Gastos");
                limpiar();
            }
            else
            {
                Confirmar view = new Confirmar();
                view.ShowDialog();
                string permiso = view.getContraseña();

                if (permiso.Equals("si"))
                {
                    gastosAD.Update(detalleText.Text, int.Parse(ValorTXT.Text), FechaTxt.Value, Original_Id, Original_Detalle, Original_Valor, Original_fecha);
                    añadirTabla();
                    string mensaje = "El usuario " + nombre_Encargado + " identificado con numero de cedula: " + cedula_usuario + " Ha actualizado el gasto " + Original_Id + " por: " + ValorTXT.Text;
                    MessageBox.Show("Se ha actualizado con exito el gasto.", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    trazaAD.Insert(cedula_usuario, mensaje, DateTime.Now, "Modificacion", "Gastos");
                }
                else
                {
                    MessageBox.Show("No tiene permiso para eliminar la compra", "BASS", MessageBoxButtons.OK);
                }
            }
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            idGasto.Clear();
            foreach (DataRow row in gastosAD.GetData().Rows)
            {
                idGasto.Add(row.Field<int>(0));
                dataGridView1.Rows.Add(row.Field<string>(3), row.Field<string>(1), row.Field<string>(2));
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idGasto.Capacity > 0)
            {
                Original_Id = (int)idGasto[e.RowIndex];
                Original_fecha = FechaTxt.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ValorTXT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Original_Valor = int.Parse(ValorTXT.Text);
                Original_Detalle = detalleText.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                button2.Visible = true;
                button3.Visible = true;
                button1.Text = "Actualizar";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button1.Text = "Registrar";

            limpiar();
        }

        private void limpiar()
        {
            detalleText.Text = "";
            ValorTXT.Text = "";
            FechaTxt.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Confirmar view = new Confirmar();
            view.ShowDialog();
            string permiso = view.getContraseña();

            if (permiso.Equals("si"))
            {
                gastosAD.Delete(Original_Id, Original_Detalle, Original_Valor, Original_fecha);
                string mensaje = "El usuario " + nombre_Encargado + " identificado con numero de cedula: " + cedula_usuario + " Ha eliminado el gasto " + Original_Detalle + " por: " + ValorTXT.Text;     
                
                MessageBox.Show("Se ha eliminado con exito el gasto.", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                trazaAD.Insert(cedula_usuario, mensaje, DateTime.Now, "Eliminacion", "Gastos");


            }
            else
            {
                MessageBox.Show("No tiene permiso para eliminar la compra", "BASS", MessageBoxButtons.OK);
            }
        } 
    }
}
