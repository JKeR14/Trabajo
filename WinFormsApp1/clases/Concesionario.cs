using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1;

namespace DemoCV.clases
{
    public class Concesionario
    {
        public string Nombre { get; set; }
        public Inventario Inventario { get; set; }
        public List<Venta> VentasRealizadas = new List<Venta>();

        public void RegistrarVenta(Vehiculo vehiculo, Cliente cliente)
        {
            if (cliente.DineroDisponible >= vehiculo.Precio && GlobalVar.Inventario.ExisteVehiculo(vehiculo))
            {
                Venta nuevaVenta = new Venta()
                {
                    VehiculoVendido = vehiculo,
                    Cliente = cliente,
                    PrecioVenta = vehiculo.Precio,
                    FechaVenta = DateTime.Now

                };
                MessageBox.Show("Compra realizada");
                VentasRealizadas.Add(nuevaVenta);
                cliente.ComprarVehiculo(vehiculo, Inventario);
            }
            else 
            {
                MessageBox.Show("No Tienes dinero suficiente para efectuar la compra");
            }
        }

        public void MostrarHistorialVentas()
        {
            foreach (var venta in VentasRealizadas)
            {
                venta.MostrarDetalleVenta();
            }
        }
        public List<Venta>ventitas() 
        { 
            return VentasRealizadas;
        }
    }
}
