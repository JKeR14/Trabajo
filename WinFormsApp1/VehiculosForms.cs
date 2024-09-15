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
    public partial class VehiculosForms : Form
    {
        string IdGlobal = "";
        List<Vehiculo> Vehiculos = new List<Vehiculo>();
        public VehiculosForms()
        {
            InitializeComponent();
        }

        private void VehiculosForms_Load(object sender, EventArgs e)
        {
            listvehiculo.View = View.Details;
            listvehiculo.GridLines = true;
            listvehiculo.Columns.Add("Id");
            listvehiculo.Columns.Add("Marca");
            listvehiculo.Columns.Add("Modelo");
            listvehiculo.Columns.Add("Año");
            listvehiculo.Columns.Add("Precio");
            listvehiculo.Columns.Add("Kilometraje");

            foreach (ColumnHeader column in listvehiculo.Columns)
            {
                if (column.Index == 0)
                    column.Width = 0;
                else
                {
                    column.Width = 100;
                }
            }
        }

        void Listar()
        {
            listvehiculo.Items.Clear();
            foreach (Vehiculo vehiculos in GlobalVar.Inventario.Lista())
            {
                listvehiculo.Items.Add(new ListViewItem(vehiculos.itemView()));
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tx_marca.Text))
            {
                MessageBox.Show("Debes ingresar una marca");
                tx_marca.Focus();
                return;
            }
            if (String.IsNullOrEmpty(tx_modelo.Text))
            {
                MessageBox.Show("Debes ingresar un modelo");
                tx_modelo.Focus();
                return;
            }
            decimal Precio;
            bool isOk = decimal.TryParse(tx_precio.Text, out Precio);
            if (!isOk)
            {
                MessageBox.Show("Ingresa dinero valido");
                tx_precio.Focus();
                return;
            }

            int Año, Kilometraje;
            isOk = int.TryParse(tx_año.Text, out Año);
            if (!isOk)
            {
                MessageBox.Show("Ingresa año válido");
                tx_año.Focus();
                return;
            }
            isOk = int.TryParse(tx_km.Text, out Kilometraje);
            if (!isOk)
            {
                MessageBox.Show("Ingresa kilometraje válido");
                tx_km.Focus();
                return;
            }
            Vehiculo v = new Vehiculo()
            {
                Marca = tx_marca.Text,
                Modelo = tx_modelo.Text,
                Año = Convert.ToInt16(tx_año.Text),
                Kilometraje = Convert.ToInt16(tx_km.Text),
                Precio = Convert.ToDecimal(tx_precio.Text),
            };
            if (string.IsNullOrEmpty(IdGlobal))
            {
                MessageBox.Show("Vehiculo almacenado");
                Vehiculos.Add(v);
                GlobalVar.Inventario.AgregarVehiculo(v);


            }
            else
            {
                Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(x => x.Id == IdGlobal).FirstOrDefault()!;
                vehiculo_modificar.Marca = tx_marca.Text;
                vehiculo_modificar.Modelo = tx_modelo.Text;
                vehiculo_modificar.Año = Convert.ToInt16(tx_año.Text);
                vehiculo_modificar.Kilometraje = Convert.ToInt32(tx_km.Text);
                vehiculo_modificar.Precio = Convert.ToDecimal(tx_precio.Text);
                IdGlobal = "";
            }
            Listar();

        }

        private void listvehiculo_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (listvehiculo.Columns[e.ColumnIndex].Index == 0)
            {
                e.Cancel = true;
                e.NewWidth = listvehiculo.Columns[e.ColumnIndex].Width;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listvehiculo.SelectedItems[0].Text;
            Vehiculo vehiculo_eliminar = GlobalVar.Inventario.Lista().Where(x => x.Id == id).FirstOrDefault()!;
            GlobalVar.Inventario.EliminarVehiculo(vehiculo_eliminar);
            Listar();
            MessageBox.Show("Elemento eliminado");
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String id = listvehiculo.SelectedItems[0].Text;
            IdGlobal = id;
            Vehiculo vehiculo_modificar = GlobalVar.Inventario.Lista().Where(x => x.Id == id).FirstOrDefault()!;
            tx_marca.Text = vehiculo_modificar.Marca;
            tx_modelo.Text = vehiculo_modificar.Modelo;
            tx_año.Text = Convert.ToString(vehiculo_modificar.Año);
            tx_km.Text = Convert.ToString(vehiculo_modificar.Kilometraje);
            tx_precio.Text = Convert.ToString(vehiculo_modificar.Precio);

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
