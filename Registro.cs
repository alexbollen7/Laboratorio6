using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6
{
    public partial class Registro : Form
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        public Registro()
        {
            InitializeComponent();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reescribirveh();
            this.Dispose();
        }
        private void reescribirveh()
        {
            string fileName = "Vehiculos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach(var temp in vehiculos)
            {
                writer.WriteLine(temp.Placa);
                writer.WriteLine(temp.Marca);
                writer.WriteLine(temp.Modelo.ToString());
                writer.WriteLine(temp.Color);
                writer.WriteLine(temp.PrecioK.ToString()); ;

            }
            writer.Close();
        }
        private void buttonRegistro_Click(object sender, EventArgs e)
        {

            Vehiculos vehte = vehiculos.Find(u => u.Placa == textBoxPlaca.Text);
            if ((textBoxPlaca.Text != "") && (textBoxModelo.Text != "") && (textBoxMarca.Text != "") && (textBoxColor.Text != "") && (textBox5Precio.Text != ""))
            {
                if (vehte == null)
                {
                    Vehiculos vehtemp = new Vehiculos();
                    vehtemp.Placa = textBoxPlaca.Text;
                    vehtemp.Marca = textBoxMarca.Text;
                    vehtemp.Modelo = int.Parse(textBoxModelo.Text);
                    vehtemp.Color = textBoxColor.Text;
                    vehtemp.PrecioK = Convert.ToDouble(textBox5Precio.Text);
                    vehiculos.Add(vehtemp);

                    MessageBox.Show("El vehículo se registro correctamente");
                }
                else
                    MessageBox.Show("Esta intentando guardar una placa ya registrada");
            }
            else
                MessageBox.Show("Necesita llenar todos los datos");
        }
        private void cargarVehiculos()
        {
            string fileName = "Vehiculos.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculos vehtemp = new Vehiculos();
                vehtemp.Placa = reader.ReadLine();
                vehtemp.Marca = reader.ReadLine();
                vehtemp.Modelo = int.Parse(reader.ReadLine());
                vehtemp.Color = reader.ReadLine();
                vehtemp.PrecioK = Convert.ToDouble(reader.ReadLine());

                vehiculos.Add(vehtemp);
            }
            reader.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cargarVehiculos();
        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            reescribirveh();
        }
    }
}
