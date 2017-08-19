using System;
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
    public partial class Confirmar : Form
    {
        private string permiso = "";

        private string cedula;
        private string nombre_user;

        private CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter trazaAD;
        private CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;

        public Confirmar()
        {
            InitializeComponent();
        }

        public Confirmar(string message)
        {
            InitializeComponent();
            cedula = message;
            label1.Text = "Cambiar la clave de eliminación";
            button4.Text = "Cambiar";
            trazaAD = new CompraVentaDataSetTableAdapters.TrazabilidadTableAdapter();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();

            foreach (DataRow row in encargadoAD.obtenerUsuario(cedula).Rows)
            {
                nombre_user = row.Field<string>(1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Equals("Enviar"))
            {
                if (textBox1.Text.Equals(Settings.Default.ClaveEliminacion))
                {
                    setContraseña("si");
                }
                else
                {
                    setContraseña("no");
                }
            }
            else
            {
                string origin_clave = Settings.Default.ClaveEliminacion;
                Settings.Default.ClaveEliminacion = textBox1.Text;
                Settings.Default.Save();
                string mensaje = "El usuario " + nombre_user + " identificado con numero de cedula: " + cedula + " Ha actualizado la clave de eliminacion " + origin_clave + " a: " + textBox1.Text;
                trazaAD.Insert(cedula, mensaje, DateTime.Now, "Modificacion", "Clave Eliminación");
                MessageBox.Show("La clave se a actualizado con exito.", "BASS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.Hide();
        }

        public void setContraseña(string cod)
        {
            permiso = cod;
        }

        public string getContraseña()
        {
            return permiso;
        }
    }
}
