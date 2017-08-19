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
    public partial class PopUpAgregarCliente : Form
    {
        CompraVentaDataSetTableAdapters.ClienteTableAdapter clienteAD;
        CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private string original_nombre;
        private string original_telefono;
        private string original_direccion;
        private string original_ciudad;
        private string original_contrato;
        private string original_vigente;
        private string original_depto;
        private string original_foto;
        private string idUser1;
        private string cedulaCliente = "";
        private string imagen;
        private string ready = "";
        private string nombreEncargado;

        public PopUpAgregarCliente()
        {
            InitializeComponent();
            
        }

        public PopUpAgregarCliente(string idUser)
        {
            InitializeComponent();
            idUser1 = idUser; 
            clienteAD = new CompraVentaDataSetTableAdapters.ClienteTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            button3.Enabled = false;
            foreach (DataRow row in encargadoAD.obtenerUsuario(idUser))
            {
                nombreEncargado = row.Field<string>(1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataRow row in clienteAD.obtenerCliente(textBox1.Text).Rows)
                {
                        nombreTextBox.Text = row.Field<string>(1);
                        telefonoTextBox.Text = row.Field<string>(2);
                        direccionTextBox.Text = row.Field<string>(3);
                        ciudadTextBox.Text = row.Field<string>(4);
                        deptoTextBox.Text = row.Field<string>(5);
                        textBox2.Text = row.Field<int>(6)+ "";
                        textBox3.Text = row.Field<int>(7) + "";
                    original_foto = imagen = row.Field<string>(8);
                    pictureBox1.Image = Image.FromFile(imagen);

                }

                if (!nombreTextBox.Text.Equals(""))
                {
                    button2.Text = "Actualizar cliente";
                    button4.Enabled = false;
                    button5.Text = "Actualizar Foto";
                    original_nombre = nombreTextBox.Text;
                    original_telefono = telefonoTextBox.Text;
                    original_direccion = direccionTextBox.Text;
                    original_ciudad = ciudadTextBox.Text;
                    original_depto = deptoTextBox.Text;
                    original_contrato = textBox2.Text;
                    original_vigente = textBox3.Text;
                    button3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado a el cliente con cedula " + textBox1.Text + "\n" +
                            "Revise la cedula o ingrese uno nuevo", "BASS", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A ocurrido un error, por favor pongase en contacto con servicio tecnico\n" +
                    "Definición de error (1) : " + ex.Message, "BASS", MessageBoxButtons.OK);
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (button2.Text.Equals("Actualizar cliente"))
            {
                string diferente = "";
                if (!imagen.Equals(original_foto))
                {
                    diferente = "se cambio la imagen del cliente";
                }
                trazaAD.Insert(idUser1, "el usuario: " + nombreEncargado + ", a actualizado el cliente con cedula " + textBox1.Text + ".\n" +
                    "Los datos originales son: \n" +
                    "Cedula: " + textBox1.Text + " - Nombre: " + original_nombre + " - Telefono: " + original_telefono + " - Direccion: " + original_direccion + "\n" +
                    "- Ciudad" + original_ciudad + " - Departamento: " + original_depto + " - Contratos: " + original_contrato + " - Vigente: " + original_vigente + " " + diferente, DateTime.Now, "Modificacion", "Cliente");

                clienteAD.Update(nombreTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, ciudadTextBox.Text, deptoTextBox.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text),imagen, textBox1.Text,
                    original_nombre, original_telefono, original_direccion, original_ciudad, original_depto, int.Parse(original_contrato), int.Parse(original_vigente),original_foto);
                ready = "ok";
                MessageBox.Show("Se ha actualizado a el cliente con exito.", "BASS", MessageBoxButtons.OK);
            }
            else
            {
                if (clienteAD.obtenerCliente(textBox1.Text).Count <= 0)
                {
                    clienteAD.Insert(textBox1.Text, nombreTextBox.Text, telefonoTextBox.Text, direccionTextBox.Text, ciudadTextBox.Text, deptoTextBox.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text),imagen);
                    MessageBox.Show("Se ha registrado a el cliente con exito.", "BASS", MessageBoxButtons.OK);
                    trazaAD.Insert(idUser1,"El usuario: "+ nombreEncargado + ", a registrado a el cliente " + nombreTextBox.Text + "\n" +
                        "con numero de cedula: " + textBox1.Text,DateTime.Now, "Registro", "Cliente");
                    button3.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ya se ha registrado un cliente con esa cedula.", "BASS", MessageBoxButtons.OK);
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (button2.Text.Equals("Actualizar cliente")) {
                bool resp = original_ciudad.Equals(ciudadTextBox.Text) && original_contrato.Equals(textBox2.Text) && original_depto.Equals(deptoTextBox.Text) && original_direccion.Equals(direccionTextBox.Text) &&
                     original_foto.Equals(imagen) && original_nombre.Equals(nombreTextBox.Text) && original_telefono.Equals(telefonoTextBox.Text) && original_vigente.Equals(textBox3.Text);

                if (resp || ready.Equals("ok")) {
                    setCedula(textBox1.Text);
                    this.Hide();
                }
                else
                {
                    button3.Enabled = false;
                    MessageBox.Show("A modificado a el4 usuario sin guardar los cambios.", "BASS", MessageBoxButtons.OK);
                }
            }
            else if(button2.Text.Equals("Registrar Cliente"))
            {
                setCedula(textBox1.Text);
                this.Hide();
            }
            



        }

        public void setCedula(string ced)
        {
            cedulaCliente = ced;
        }

        public string getCedula()
        {
            return cedulaCliente;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TomaFoto view = new TomaFoto();
            this.Hide();
            view.ShowDialog();
            imagen = view.getRuta();
            this.Show();

            pictureBox1.Image = Image.FromFile(imagen);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagenes JPG| *.jpg";
            openFileDialog1.Title = "Select a Cursor File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagen = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(imagen);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador view = new Navegador();
            view.setPagina("http://www.rues.org.co/RUES_Web/");
            view.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navegador view = new Navegador();
            view.setPagina("https://wsp.registraduria.gov.co/certificado/Datos.aspx");
            view.ShowDialog();
        }
    }
}
