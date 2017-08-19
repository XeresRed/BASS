using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CompraVenta
{
    public partial class TomaFoto : Form
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice video;
        private string ruta;

        public TomaFoto()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void TomaFoto_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo x in dispositivos)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        public void setRuta(string root)
        {
            ruta = root;
        }

        public string getRuta()
        {
            return ruta;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Iniciar"))
            {
                video = new VideoCaptureDevice(dispositivos[comboBox1.SelectedIndex].MonikerString);
                videoSourcePlayer1.VideoSource = video;
                videoSourcePlayer1.Start();
                button1.Text = "Capturar";
                button2.Visible = true;
            }
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Imagenes | *.jpg";
                sf.InitialDirectory = "...\\Imagenes";
                sf.ShowDialog();

                if(sf.FileName != null)
                {
                    try
                    {
                        Bitmap map = videoSourcePlayer1.GetCurrentVideoFrame();
                        map.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        setRuta(sf.FileName);
                        map.Dispose();
                        MessageBox.Show("Se guardo con exito", "Bass", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A ocurrido un error, por favor pongase en contacto con servicio tecnico\n" +
                    "Definición de error: " + ex.Message, "BASS", MessageBoxButtons.OK);
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("La imagen debe tene nombre", "Bass", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            this.Hide();
        }
    }
}
