using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        List<Alquileres> alquileres = new List<Alquileres>();
        List<Clientes> clientes = new List<Clientes>();
        List<Vehiculos> vehiculos = new List<Vehiculos>();
        List<DatosAlquiler> datosAlquilers = new List<DatosAlquiler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alquiler alq = new Alquiler();
            alq.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarVehiculos();
            cargarClientes();
            cargarAlquileres();
            calcularAlquileres();
        }

        private void cargarVehiculos()
        {
            vehiculos.Clear();
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

            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();
        }

        private void cargarClientes()
        {
            clientes.Clear();
            string fileName = "Clientes.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Clientes clitemp = new Clientes();
                clitemp.Nit = int.Parse(reader.ReadLine());
                clitemp.Nombre = reader.ReadLine();
                clitemp.Direccion = reader.ReadLine();

                clientes.Add(clitemp);
            }

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Refresh();
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
        }

        private void rEGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }

        private void rECARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarClientes();
            cargarVehiculos();
            cargarAlquileres();
            calcularAlquileres();
        }

        private void aLQUILERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alquiler alq = new Alquiler();
            alq.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cargarAlquileres()
        {
            alquileres.Clear();

            string fileName = "Alquileres.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while(reader.Peek() > -1)
            {
                Alquileres atemp = new Alquileres();
                atemp.Nit = int.Parse(reader.ReadLine());
                atemp.Placa = reader.ReadLine();
                atemp.Fealq = reader.ReadLine();
                atemp.Fedev = reader.ReadLine();
                atemp.Krec = Convert.ToDouble(reader.ReadLine());

                alquileres.Add(atemp);
            }
            reader.Close();
        }
        
        private void calcularAlquileres()
        {
            double mayorKm = 0;
            string lab = "";
            datosAlquilers.Clear();
            foreach(var temp in alquileres)
            {
                DatosAlquiler datemp = new DatosAlquiler();
                Clientes clite = clientes.Find(u => u.Nit == temp.Nit);
                datemp.NombreCliente = clite.Nombre;
                Vehiculos vete = vehiculos.Find(a => a.Placa == temp.Placa);
                datemp.PlacaV = vete.Placa;
                datemp.MarcaV = vete.Marca;
                datemp.ModeloV = vete.Modelo;
                datemp.ColorV = vete.Color;
                datemp.PrecioKV = vete.PrecioK;
                datemp.FechaDev = temp.Fedev;
                datemp.Total = (temp.Krec * vete.PrecioK);
                if (temp.Krec > mayorKm)
                {
                    mayorKm = temp.Krec;
                    lab = "";
                    lab = mayorKm.ToString() + "km - Nit: " + temp.Nit.ToString() + " - Vehículo: " + vete.Placa;
                }

                datosAlquilers.Add(datemp);
            }
            dataGridViewAlquileres.DataSource = null;
            dataGridViewAlquileres.Refresh();
            dataGridViewAlquileres.DataSource = datosAlquilers;
            dataGridViewAlquileres.Refresh();
            labelMayorRecorrido.Text = lab;
        }

    }
}
