using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CompraVenta
{
    public partial class Reporte : Form
    {
        private CompraVentaDataSetTableAdapters.VentaTableAdapter ventaAD;
        private CompraVentaDataSetTableAdapters.CompraTableAdapter compraAD;
        private CompraVentaDataSetTableAdapters.ContratoTableAdapter contratoAD;

        public Reporte()
        {
            InitializeComponent();
            ventaAD = new CompraVentaDataSetTableAdapters.VentaTableAdapter();
            compraAD = new CompraVentaDataSetTableAdapters.CompraTableAdapter();
            contratoAD = new CompraVentaDataSetTableAdapters.ContratoTableAdapter();

            comboBox1.SelectedIndex = 0;

            

            DateTime FechaCompra = DateTime.Now;
            DateTime FechaVenta = DateTime.Now;
            DateTime FechaContrato = DateTime.Now;

            if (contratoAD.MinimaFecha() != (null))
            {
                 FechaCompra = (DateTime)compraAD.MinimaFecha();
            }
            if (contratoAD.MinimaFecha() != (null))
            {
                 FechaVenta = (DateTime)ventaAD.MinimaFecha();
            }
            if (contratoAD.MinimaFecha() != (null)) {
                 FechaContrato = (DateTime)contratoAD.MinimaFecha();
            }

            if (FechaCompra < FechaVenta && FechaCompra < FechaContrato)
            {
                DesdeFecha.Value = FechaCompra;
            }
            else if (FechaVenta < FechaCompra && FechaVenta < FechaContrato)
            {
                DesdeFecha.Value = FechaVenta;
            }
            else if (FechaContrato < FechaCompra && FechaContrato < FechaVenta)
            {
                DesdeFecha.Value = FechaContrato;
            }
            else
            {
                DesdeFecha.Value = FechaCompra;
            }
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            string[] series = {"Ventas","Compras","Contratos" };

            int[] puntos = new int[3];
            foreach (DataRow row in ventaAD.NumeroVentas(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
            {
               
                puntos[0]++;
            }

            foreach (DataRow row in compraAD.NumeroCompra(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
            {
                puntos[1]++;
            }

            foreach (DataRow row in contratoAD.NumeroContratos(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy"), "Contrato"))
            {
                puntos[2]++;
            }


            chart1.Palette = ChartColorPalette.SeaGreen;


            chart1.Titles.Add("Numero de movimientos");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = chart1.Series.Add(series[i]);
                

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
            chart1.Update();
        }

        private void DesdeFecha_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Total Movimientos") && DesdeFecha.Value < HastaFecha.Value)
            {
                
                chart1.Series.Clear();
                chart1.Titles.Clear();
                

                string[] series = { "Ventas", "Compras", "Contratos" };

                int[] puntos = new int[3];
                foreach (DataRow row in ventaAD.NumeroVentas(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
                {

                    puntos[0]++;
                }

                foreach (DataRow row in compraAD.NumeroCompra(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
                {
                    puntos[1]++;
                }

                foreach (DataRow row in contratoAD.NumeroContratos(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy"), "Contrato"))
                {
                    puntos[2]++;
                }


                chart1.Palette = ChartColorPalette.SeaGreen;


                chart1.Titles.Add("Numero de movimientos");

                for (int i = 0; i < series.Length; i++)
                {
                    Series serie = chart1.Series.Add(series[i]);

                    serie.Points.Clear();
                    
                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }
                chart1.Update();
            }
        }

        private void HastaFecha_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Total Movimientos") && DesdeFecha.Value < HastaFecha.Value)
            {
                chart1.Series.Clear();
                chart1.Titles.Clear();
                

                string[] series = { "Ventas", "Compras", "Contratos" };

                int[] puntos = new int[3];
                foreach (DataRow row in ventaAD.NumeroVentas(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
                {

                    puntos[0]++;
                }

                foreach (DataRow row in compraAD.NumeroCompra(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy")))
                {
                    puntos[1]++;
                }

                foreach (DataRow row in contratoAD.NumeroContratos(DesdeFecha.Value.ToString("dd/MM/yyyy"), HastaFecha.Value.ToString("dd/MM/yyyy"), "Contrato"))
                {
                    puntos[2]++;
                }


                chart1.Palette = ChartColorPalette.SeaGreen;


                chart1.Titles.Add("Numero de movimientos");

                for (int i = 0; i < series.Length; i++)
                {
                    Series serie = chart1.Series.Add(series[i]);

                    serie.Points.Clear();

                    serie.Label = puntos[i].ToString();

                    serie.Points.Add(puntos[i]);
                }
                chart1.Update();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Imagenes | *.jpg";
            sf.InitialDirectory = "...\\Imagenes";
            sf.ShowDialog();

            if (sf.FileName != null)
            {
                try
                {
                    chart1.SaveImage(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Se guardo con exito", "Bass", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A ocurrido un error, por favor pongase en contacto con servicio tecnico\n" +
                "Definición de error: " + ex.Message, "BASS", MessageBoxButtons.OK);
                    throw;
                }
            }

            
        }
    }
}
