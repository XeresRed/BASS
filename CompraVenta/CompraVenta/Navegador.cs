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
    public partial class Navegador : Form
    {
        public Navegador()
        {
            InitializeComponent();
        }

        public void setPagina(string url)
        {
            toolStripTextBox1.Text = url;
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
