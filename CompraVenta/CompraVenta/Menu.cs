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
    public partial class Menu : Form
    {
        private bool acceso;
        private string nombreUser;
        private string cedula;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(string ced, string nombre, bool empleado)
        {
            InitializeComponent();
            Mbienvenida.Text ="Bienvenido " +  nombre;
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            cedula = ced;
            nombreUser = nombre;
            acceso = empleado;
            
            if (empleado)
            {
                button12.Enabled = false;   
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra view = new Compra(cedula, acceso);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ManejoUsuarios view = new ManejoUsuarios(cedula);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!Settings.Default["fondo"].Equals(""))
            {
                panel1.BackColor = Settings.Default.fondo;
                label2.Font = Settings.Default.Fuente;
                label3.Font = Settings.Default.Fuente;
                label4.Font = Settings.Default.Fuente;
                label5.Font = Settings.Default.Fuente;
                label6.Font = Settings.Default.Fuente;
                label7.Font = Settings.Default.Fuente;
                label8.Font = Settings.Default.Fuente;
                label9.Font = Settings.Default.Fuente;
                label10.Font = Settings.Default.Fuente;
                label11.Font = Settings.Default.Fuente;
                label12.Font = Settings.Default.Fuente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venta view = new Venta(cedula);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inventario view = new Inventario(cedula);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VistaMovimientos view = new VistaMovimientos();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Reporte view = new Reporte();
            this.Hide();
            view.ShowDialog();
            this.Show();
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gastos view = new Gastos(cedula);
            this.Hide();
            view.ShowDialog();
            this.Show();
        }
    }
}
