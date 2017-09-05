using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoInteligenciaCompu
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        OpenFileDialog dialog = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult resultado = dialog.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pictureBox1.Image = Image.FromFile(dialog.FileName);
                Salida.Items.Add("Cargando Imagen...");
            }
        }
        Modelo.Binario[,] b;
        private void Transformar_Click(object sender, EventArgs e)
        {
            Salida.Items.Add("Convertiendo la Imagen en BitMap...");
            Bitmap a = new Bitmap(pictureBox1.Image);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = BinaryImage(a, 60);
            Salida.Items.Add("Convirtiedo imagen en bits");
            b = new Modelo.Binario[a.Width,a.Height];
            string val = "";
            for (int i = 0; i < a.Width; i++)
            {
                val = "";
                for (int j = 0; j < a.Height; j++)
                {
                    Color col = a.GetPixel(i, j);
                    byte gray = (byte)(col.R * 0.3f + col.G * 0.59f + col.B * 0.11f);
                    if (gray > 60)
                    {
                        b[i, j] = new Modelo.Binario();
                        b[i, j].posx = i;
                        b[i, j].posy = j;
                        b[i, j].valor = 0;
                        val = val + b[i, j].valor;
                    }
                    else
                    {
                        b[i, j] = new Modelo.Binario();
                        b[i, j].posx = i;
                        b[i, j].posy = j;
                        b[i, j].valor = 1;
                        val = val + b[i, j].valor;
                    }
                }
                Salida.Items.Add(val);

            }
            Salida.Items.Add("Binarización Completada");
        }

        public void Analis(Modelo.Binario[,] bin)
        {
            foreach (Modelo.Binario item in bin)
            {
                
            }
        }

        public Bitmap BinaryImage(Bitmap source, int umb)
        {
            Modelo.Binario[,] bina = new Modelo.Binario[source.Width,source.Height];
            Salida.Items.Add("Adquireindo Propiedades de la Imagen...");
            Bitmap target = new Bitmap(source.Width, source.Height, source.PixelFormat);

            for (int i = 0; i < source.Width; i++)
            {
                for (int e = 0; e < source.Height; e++)
                {
                    Color col = source.GetPixel(i, e);
                    byte gray = (byte)(col.R * 0.3f + col.G * 0.59f + col.B * 0.11f);
                    byte value = 0;
                    if (gray > umb)
                    {
                        value = 255;
                    }
                    Color newColor = System.Drawing.Color.FromArgb(value, value, value);
                    target.SetPixel(i, e, newColor);
                }
            }
            return target;
        }
    }
}
