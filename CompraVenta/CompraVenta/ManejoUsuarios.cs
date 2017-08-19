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
using CompraVenta.Properties;

namespace CompraVenta
{
    public partial class ManejoUsuarios : Form
    {
        private string nombre_Original;
        private string cedula;
        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private string nombreUsuario;
        private ArrayList Modificaciones;
        private string permiso;
        private string cedulaMod;


        public ManejoUsuarios()
        {
            InitializeComponent();
        }

        public ManejoUsuarios(string ced)
        {
            InitializeComponent();
            cedula = ced;
            button1.Visible = false;
            Modificaciones = new  ArrayList();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();

            label5.Text = "Clave de Eliminación: " + Settings.Default.ClaveEliminacion;

            foreach (DataRow row in encargadoAD.obtenerUsuario(ced))
            {
                nombreUsuario = row.Field<string>(1);
            }
            
        }

        private void departamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compraVentaDataSet);

        }

        private void ManejoUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Trazabilidad' Puede moverla o quitarla según sea necesario.
            this.trazabilidadTableAdapter.Fill(this.compraVentaDataSet.Trazabilidad);
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Encargado' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'compraVentaDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            foreach (DataRow row in departamentoTableAdapter.GetData().Rows)
            {
                departamentoDataGridView.Rows.Add(row.Field<string>(0));
  
            }
            departamentoDataGridView.Update();
            foreach (DataRow row in encargadoTableAdapter.GetData().Rows)
            {
                Modificaciones.Add(row.Field<string>(4));
                encargadoDataGridView.Rows.Add(row.Field<string>(0), row.Field<string>(1), row.Field<string>(3));
            }
            encargadoDataGridView.Update();

            foreach (DataRow row in trazaAD.GetData().Rows)
            {
                trazabilidadDataGridView.Rows.Add(row.Field<int>(0), row.Field<string>(1), row.Field<string>(2), row.Field<DateTime>(3).ToString("dd/MM/yyyy"), row.Field<string>(4), row.Field<string>(5));
            }
        }

        private void departamentoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAñadirDepto.Text = "Actualizar";

            nombre_Original = NameDeptoTxt.Text =(string) departamentoDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            btnEliminarDepto.Visible = true;
            button1.Visible = true;
        }

        private void btnAñadirDepto_Click(object sender, EventArgs e)
        {
            if (btnAñadirDepto.Text.Equals("Añadir"))
            {
                
                if (!NameDeptoTxt.Text.Equals(""))
                {
                    DialogResult result = MessageBox.Show("¿Desea añadir el departamento " + NameDeptoTxt.Text + "?", "BASS", MessageBoxButtons.YesNo);
                    if(result == DialogResult.Yes)
                    {
                        departamentoTableAdapter.Insert(NameDeptoTxt.Text);
                        departamentoDataGridView.Rows.Add(NameDeptoTxt.Text);
                        MessageBox.Show("Se ha registrado con exito el departamento " + NameDeptoTxt.Text, "BASS", MessageBoxButtons.OK);
                        trazaAD.Insert(cedula, "El usuario" + nombreUsuario + "Registro el departamento " + NameDeptoTxt.Text, DateTime.Now, "Departamento","Registro");
                        NameDeptoTxt.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nombre para añadirlo", "BASS", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!NameDeptoTxt.Text.Equals(""))
                {
                    
                    DialogResult result = MessageBox.Show("¿Desea actualizar el departamento " + nombre_Original + "?", "BASS", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        departamentoTableAdapter.Update(NameDeptoTxt.Text, nombre_Original) ;
                        departamentoDataGridView.Rows.Clear();
                        foreach (DataRow row in departamentoTableAdapter.GetData().Rows)
                        {
                            departamentoDataGridView.Rows.Add(row.Field<string>(0));
                        }
                        MessageBox.Show("Se ha actualizado con exito el departamento " + nombre_Original, "BASS", MessageBoxButtons.OK);
                        NameDeptoTxt.Text = "";
                        btnAñadirDepto.Text = "Añadir";
                        btnEliminarDepto.Visible = false;
                        trazaAD.Insert(cedula, "El usuario " +nombreUsuario +" Actualizo el nombre del departamento " + nombre_Original +  " a " + NameDeptoTxt.Text, DateTime.Now,"Departamento","Actualización");
                    }
                    else
                    {
                        btnAñadirDepto.Text = "Añadir";
                        btnEliminarDepto.Visible = false;
                    }
                }
            }
        }

        private void btnEliminarDepto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el departamento " + NameDeptoTxt.Text + "?", "BASS", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                trazaAD.Insert(cedula,"El usuario " + nombreUsuario +  " Elimino el departamento " + NameDeptoTxt.Text, DateTime.Now,"Departamento","Eliminacion");
                departamentoTableAdapter.Delete(NameDeptoTxt.Text);
                departamentoDataGridView.Rows.Clear();
                foreach (DataRow row in departamentoTableAdapter.GetData().Rows)
                {
                    departamentoDataGridView.Rows.Add(row.Field<string>(0));
                }
                departamentoDataGridView.Update();
                MessageBox.Show("Se ha eliminado con exito el departamento " + NameDeptoTxt.Text, "BASS", MessageBoxButtons.OK);
                NameDeptoTxt.Text = "";
            }
            else
            {
                btnEliminarDepto.Visible = false;
                btnAñadirDepto.Text = "Añadir";
            }
        }

        private void departamentoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnEliminarDepto.Visible = false;
            btnAñadirDepto.Text = "Añadir";
            NameDeptoTxt.Text = "";
            button1.Visible = false;
        }

        private void encargadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AñadirUsuario.Text = "Actualizar Usuario";
            EliminarUsuario.Visible = true;
            CancelarUsuario.Visible = true;
            permiso = (string) Modificaciones[e.RowIndex];
            cedulaMod = (string)encargadoDataGridView.Rows[e.RowIndex].Cells[0].Value;
        }

        private void encargadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizarEncargadoTabla()
        {
            encargadoDataGridView.Rows.Clear();
            foreach (DataRow row in encargadoTableAdapter.GetData().Rows)
            {
                Modificaciones.Add(row.Field<string>(4));
                encargadoDataGridView.Rows.Add(row.Field<string>(0), row.Field<string>(1), row.Field<string>(3));
            }
        }

        private void CancelarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario.Visible = false;
            CancelarUsuario.Visible = false;
            AñadirUsuario.Text = "Añadir usuario";
        }

        private void AñadirUsuario_Click(object sender, EventArgs e)
        {
            if(AñadirUsuario.Text.Equals("Añadir usuario"))
            {
                PopUpAgregarUsuario view = new PopUpAgregarUsuario(cedula);
                this.Hide();
                view.ShowDialog();
                this.Show();
                actualizarEncargadoTabla();
            }
            else
            {
                if (permiso.ToLower().Equals("no"))
                {
                    PopUpAgregarUsuario view = new PopUpAgregarUsuario(cedulaMod, cedula);
                    this.Hide();
                    view.ShowDialog();
                    this.Show();
                    actualizarEncargadoTabla();
                }
                else
                {
                    MessageBox.Show("Este usuario es inmodificable ", "BASS", MessageBoxButtons.OK);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBox1.Text.Equals(""))
            {
                switch (comboBox1.Text)
                {
                    case "Tipo":
                        comboBox2.Items.Clear();
                        comboBox2.Visible = true;
                        comboBox2.Items.Add("Registro");
                        comboBox2.Items.Add("Modificacion");
                        comboBox2.Items.Add("Elimancion");
                        textBox2.Visible = false;
                        textBox2.Text = "";
                        break;
                    case "Modulo ":
                        comboBox2.Items.Clear();
                        comboBox2.Visible = true;
                        comboBox2.Items.Add("Compra");
                        comboBox2.Items.Add("Venta");
                        comboBox2.Items.Add("Contratos");
                        comboBox2.Items.Add("Clientes");
                        comboBox2.Items.Add("Productos");
                        comboBox2.Items.Add("Usuarios");
                        textBox2.Visible = false;
                        textBox2.Text = "";
                        break;
                    default:
                        comboBox2.Items.Clear();
                        comboBox2.Visible = false;
                        textBox2.Visible = true;
                        textBox2.Text = "";
                        break;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trazabilidadDataGridView.Rows.Clear();
            int i = 0;
            if (!comboBox1.Text.Equals(""))
            {
                switch (comboBox1.Text)
                {
                    case "Identificador":
                        i = 0;
                        foreach (DataRow row in trazaAD.ObtenerTrazaId(int.Parse(textBox2.Text)).Rows)
                        {
                            trazabilidadDataGridView.Rows[i].Cells[0].Value = row.Field<int>(0);
                            trazabilidadDataGridView.Rows[i].Cells[1].Value = row.Field<string>(1);
                            trazabilidadDataGridView.Rows[i].Cells[2].Value = row.Field<string>(2);
                            trazabilidadDataGridView.Rows[i].Cells[3].Value = row.Field<DateTime>(3).ToString("dd/MM/yyyy");
                            trazabilidadDataGridView.Rows[i].Cells[4].Value = row.Field<string>(4);
                            trazabilidadDataGridView.Rows[i].Cells[5].Value = row.Field<string>(5);
                            i++;
                        }
                        trazabilidadDataGridView.Update();
                        break;
                    case "Cedula de usuario":
                        i = 0;
                        foreach (DataRow row in trazaAD.obtenerCedulaID(textBox2.Text).Rows)
                        {
                            trazabilidadDataGridView.Rows[i].Cells[0].Value = row.Field<int>(0);
                            trazabilidadDataGridView.Rows[i].Cells[1].Value = row.Field<string>(1);
                            trazabilidadDataGridView.Rows[i].Cells[2].Value = row.Field<string>(2);
                            trazabilidadDataGridView.Rows[i].Cells[3].Value = row.Field<DateTime>(3).ToString("dd/MM/yyyy");
                            trazabilidadDataGridView.Rows[i].Cells[4].Value = row.Field<string>(4);
                            trazabilidadDataGridView.Rows[i].Cells[5].Value = row.Field<string>(5);
                            i++;
                        }
                        trazabilidadDataGridView.Update();
                        break;
                    case "Modulo ":
                        i = 0;
                        foreach (DataRow row in trazaAD.ObtenerModulo((string) comboBox2.SelectedValue).Rows)
                        {
                            trazabilidadDataGridView.Rows[i].Cells[0].Value = row.Field<int>(0);
                            trazabilidadDataGridView.Rows[i].Cells[1].Value = row.Field<string>(1);
                            trazabilidadDataGridView.Rows[i].Cells[2].Value = row.Field<string>(2);
                            trazabilidadDataGridView.Rows[i].Cells[3].Value = row.Field<DateTime>(3).ToString("dd/MM/yyyy");
                            trazabilidadDataGridView.Rows[i].Cells[4].Value = row.Field<string>(4);
                            trazabilidadDataGridView.Rows[i].Cells[5].Value = row.Field<string>(5);
                            i++;
                        }
                        trazabilidadDataGridView.Update();
                        break;
                    case "Tipo":
                        i = 0;
                        foreach (DataRow row in trazaAD.obtenerTipo((string) comboBox2.SelectedValue).Rows)
                        {
                            trazabilidadDataGridView.Rows[i].Cells[0].Value = row.Field<int>(0);
                            trazabilidadDataGridView.Rows[i].Cells[1].Value = row.Field<string>(1);
                            trazabilidadDataGridView.Rows[i].Cells[2].Value = row.Field<string>(2);
                            trazabilidadDataGridView.Rows[i].Cells[3].Value = row.Field<DateTime>(3).ToString("dd/MM/yyyy");
                            trazabilidadDataGridView.Rows[i].Cells[4].Value = row.Field<string>(4);
                            trazabilidadDataGridView.Rows[i].Cells[5].Value = row.Field<string>(5);
                            i++;
                        }
                        trazabilidadDataGridView.Update();
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.fondo = MyDialog.Color;
                Settings.Default.Save();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.Default.Fuente = fontDialog1.Font ;
                Settings.Default.Save();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListaDeIngreso view = new ListaDeIngreso();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Confirmar view = new Confirmar(cedula);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }
    }
}
