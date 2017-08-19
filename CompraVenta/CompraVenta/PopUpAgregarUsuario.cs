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
    public partial class PopUpAgregarUsuario : Form
    {
        private string origin_cedula;
        private string origin_nombre;
        private string origin_password;
        private string origin_Admin;
        private string cedulUsuario;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;

        public PopUpAgregarUsuario()
        {
            InitializeComponent();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
        }

        public PopUpAgregarUsuario(string cedulaUser)
        {
            InitializeComponent();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            cedulUsuario = cedulaUser;
        }

        public PopUpAgregarUsuario(string cedMod,string CedulaUser)
        {
            InitializeComponent();
            origin_cedula = cedMod;
            textBox1.Text = cedMod;
            cedulUsuario = CedulaUser;
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();

            foreach(DataRow row in encargadoAD.obtenerUsuario(cedMod).Rows)
            {
                origin_nombre = nombreTextBox.Text = row.Field<string>(1);
                origin_password = direccionTextBox.Text = row.Field<string>(2);
                origin_Admin = row.Field<string>(3);
            }

            if (origin_Admin.ToLower().Equals("si"))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }


            button2.Text = "Actualizar usuario";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string admin = "";
            if (radioButton1.Checked && !radioButton2.Checked)
            {
                admin = "Si";
            }
            else if (!radioButton1.Checked && radioButton2.Checked)
            {
                admin = "No";
            }
            else
            {
                MessageBox.Show("Solo debe seleccionar una opción.", "BASS", MessageBoxButtons.OK);
            }
            string nombreEncargado = "";
            foreach (DataRow row in encargadoAD.obtenerUsuario(cedulUsuario).Rows)
            {
                nombreEncargado = row.Field<string>(1);
            }
            if (button2.Text.Equals("Actualizar usuario"))
            {
                if (!admin.Equals(""))
                {
                    if (textBox2.Text.Equals(direccionTextBox.Text)) {
                        encargadoAD.Update(textBox1.Text, nombreTextBox.Text, direccionTextBox.Text, admin, "Si",0, origin_cedula, origin_nombre, origin_password, origin_Admin, "Si",0);

                        trazaAD.Insert(cedulUsuario, "el usuario " + nombreEncargado + "Actualizo el usuario " + origin_nombre + "\n" +
                           "Los datos Originales son: " + origin_cedula + "\n" +
                           origin_nombre + "\n" +
                           origin_password + "\n" +
                           origin_Admin + " ,Se puede buscar por el numero de cedula: " + textBox1.Text, DateTime.Now,"Usuario","Modificiacion");
                        MessageBox.Show("Se ha actualizado con exito el usuario.", "BASS", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "BASS", MessageBoxButtons.OK);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Se debe seleccionar si es el usuario es administrador o no", "BASS", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (!admin.Equals("") )
                {
                    if (direccionTextBox.Text.Equals(textBox2.Text))
                    {
                        encargadoAD.Insert(textBox1.Text, nombreTextBox.Text, direccionTextBox.Text, admin, "Si", 0);
                        trazaAD.Insert(cedulUsuario, "El usuario " + nombreEncargado + " a añadido a el usuario \n" +
                            nombreTextBox.Text + " Con cedula " + textBox1.Text + ".", DateTime.Now, "Usuario", "Registro");
                        MessageBox.Show("Se ha registrado con exito el usuario.", "BASS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.", "BASS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                     MessageBox.Show("Se debe seleccionar si es el usuario es administrador o no", "BASS", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
        }
            

            


        }
    }
}
