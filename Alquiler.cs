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
    public partial class Alquiler : Form
    {
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        List<Alquileres> alquileres= new List<Alquileres>();
        public Alquiler()
        {
            InitializeComponent();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reescrialq();
            this.Dispose();
        }

        private void Alquiler_Load(object sender, EventArgs e)
        {
            cargarVehiculos();
            cargarAlquileres();
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
                comboBoxPlacas.Items.Add(vehtemp.Placa);
                vehtemp.Marca = reader.ReadLine();
                vehtemp.Modelo = int.Parse(reader.ReadLine());
                vehtemp.Color = reader.ReadLine();
                vehtemp.PrecioK = Convert.ToDouble(reader.ReadLine());

                vehiculos.Add(vehtemp);
            }
            reader.Close();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            if ((textBoxKilometros.Text != "") && (textBoxNit.Text != "") && (comboBoxPlacas.Text != ""))
            {
                Alquileres alqtemp = new Alquileres();
                alqtemp.Nit = int.Parse(textBoxNit.Text);
                alqtemp.Placa = comboBoxPlacas.SelectedItem.ToString();
                alqtemp.Fealq = dateTimePickerAlquiler.Value.ToShortDateString();
                alqtemp.Fedev = dateTimePicker2Devolucion.Value.ToShortDateString();
                alqtemp.Krec = Convert.ToDouble(textBoxKilometros.Text);
                alquileres.Add(alqtemp);

                MessageBox.Show("El alquiler se registro correctamente");
            }
            else
                MessageBox.Show("Debe llenar todos los campos");
        }

        private void cargarAlquileres()
        {
            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquileres alquite = new Alquileres();
                alquite.Nit = int.Parse(reader.ReadLine());
                alquite.Placa = reader.ReadLine();
                alquite.Fealq = reader.ReadLine();
                alquite.Fedev = reader.ReadLine();
                alquite.Krec = Convert.ToDouble(reader.ReadLine());

                alquileres.Add(alquite);
            }
            reader.Close();
        }

        private void reescrialq()
        {
            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var temp in alquileres)
            {
                writer.WriteLine(temp.Nit);
                writer.WriteLine(temp.Placa);
                writer.WriteLine(temp.Fealq);
                writer.WriteLine(temp.Fedev);
                writer.WriteLine(temp.Krec);

            }
            writer.Close();
        }

        private void Alquiler_FormClosed(object sender, FormClosedEventArgs e)
        {
            reescrialq();
        }
    }
}
