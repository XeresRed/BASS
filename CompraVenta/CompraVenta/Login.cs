using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompraVenta.Properties;

namespace CompraVenta
{
    public partial class Login : Form
    {
        CompraVentaDataSetTableAdapters.EncargadoTableAdapter encargadoAD;
        CompraVentaDataSetTableAdapters.ingresosTableAdapter ingresoAD;

        public Login()
        {
            InitializeComponent();
            encargadoAD = new CompraVentaDataSetTableAdapters.EncargadoTableAdapter();
            ingresoAD = new CompraVentaDataSetTableAdapters.ingresosTableAdapter();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

                string nombre = "";
                string EsEmpleado = "";

                foreach(DataRow row in encargadoAD.LoginEmpleado(CedulaText.Text, ContraseñaText.Text).Rows)
                {
                    nombre = row.Field<string>(1);
                    EsEmpleado = row.Field<string>(3);
                }

                if (!nombre.Equals("")) 
                {
                    ingresoAD.Insert(CedulaText.Text, DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture), DateTime.Now);
                    if (EsEmpleado.ToLower().Equals("si"))
                    {
                        Menu view = new Menu(CedulaText.Text, nombre, false);
                        this.Hide();
                        view.ShowDialog();
                        this.Show();
                        CedulaText.Text = "";
                        ContraseñaText.Text = "";
                    }
                    else
                    {
                      
                        Menu view = new Menu(CedulaText.Text, nombre, true);
                        this.Hide();
                        view.ShowDialog();
                        this.Show();
                        CedulaText.Text = "";
                        ContraseñaText.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, revise su contraseña o su cedula e intentelo de nuevo.", "BASS", MessageBoxButtons.OK);
                }

   
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!Settings.Default.Fuente.Equals(""))
            {
                label1.Font = Settings.Default.Fuente;
                label2.Font = Settings.Default.Fuente;

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AboutBox1 view = new AboutBox1();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }
    }
}
