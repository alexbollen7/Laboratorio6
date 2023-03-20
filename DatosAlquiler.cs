using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    internal class DatosAlquiler
    {
        string nombreCliente;
        string placaV;
        string marcaV;
        int modeloV;
        string colorV;
        double precioKV;
        string fechaDev;
        double total;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string PlacaV { get => placaV; set => placaV = value; }
        public string MarcaV { get => marcaV; set => marcaV = value; }
        public int ModeloV { get => modeloV; set => modeloV = value; }
        public string ColorV { get => colorV; set => colorV = value; }
        public double PrecioKV { get => precioKV; set => precioKV = value; }
        public string FechaDev { get => fechaDev; set => fechaDev = value; }
        public double Total { get => total; set => total = value; }
    }
}
