using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCV.clases
{
    public class Venta
    {
        public Vehiculo VehiculoVendido { get; set; }
        public Cliente Cliente { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }

        public void MostrarDetalleVenta()
        {
            Console.WriteLine($"{FechaVenta} : {Cliente.Nombre} {Cliente.Apellidos} " +
                $"compró {VehiculoVendido.Marca} en ${PrecioVenta} ");
        }
        public string[] itemView() 
        {
            string[] data = {VehiculoVendido.Marca, Cliente.Nombre, PrecioVenta.ToString(), FechaVenta.ToString()};
            return data;
        }
    }
}
