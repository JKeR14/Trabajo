using DemoCV.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        void ListarVentas()
        {
            listventa.Items.Clear();
            foreach (Venta venta in GlobalVar.concesionario.ventitas())
            {
                listventa.Items.Add(new ListViewItem(venta.itemView()));
            }
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            cargaClientes();
            cargaVehiculos();
            listventa.View = View.Details;
            listventa.GridLines = true;
            listventa.Columns.Add("Cliente");
            listventa.Columns.Add("Vehiculo");
            listventa.Columns.Add("Precio");
            listventa.Columns.Add("Fecha");
        }

        void cargaClientes()
        {
            cb_clientes.Items.AddRange(GlobalVar.clientes.ToArray());

        }

        void cargaVehiculos()
        {
            cb_vehiculo.Items.AddRange(GlobalVar.Inventario.Lista().ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cb_clientes.Text))
            {
                MessageBox.Show("Debes ingresar un cliente valido");
                cb_clientes.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cb_vehiculo.Text))
            {
                MessageBox.Show("Debes ingresar un vehiculo valido");
                cb_vehiculo.Focus();
                return;
            }
            decimal precio;
            bool isOk = decimal.TryParse(tx_precio.Text, out precio);
            if (!isOk)
            {
                MessageBox.Show("Ingresa dinero valido");
                tx_precio.Focus();
                return;
            }

            Cliente clienteSeleccionado = cb_clientes.SelectedItem as Cliente;
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;

            GlobalVar.concesionario.RegistrarVenta(vehiculoSeleccionado, clienteSeleccionado);

            ListarVentas();
        }

        private void cb_vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehiculo vehiculoSeleccionado = cb_vehiculo.SelectedItem as Vehiculo;
            decimal precio;
            precio = vehiculoSeleccionado.Precio;
            tx_precio.Text = precio.ToString();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
