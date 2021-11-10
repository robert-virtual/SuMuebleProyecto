using SuMueble.DataAccess;
using SuMueble.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace SuMueble.Views
{
    public partial class ClientesView : UserControl
    {
        List<Cliente> Clientes = new List<Cliente>();
        public ClientesView()
        {
            InitializeComponent();
            LoadClients();
        }

        void LoadClients()
        {
            using (var db = new SuMuebleDBContext())
            {
                Clientes = db.Clientes.Include("Venta").ToList();
            }
            RefreshDgv(Clientes);
        } 

        void RefreshDgv(List<Cliente> clientes)
        {
            dgv_clientes.DataSource = null;
            dgv_clientes.DataSource = clientes;
        }

        private void txt_buscar_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            var clientesPorNombre = Clientes.Where(cliente => 
            {
                return cliente.Nombre.Contains(txt_buscar_nombre.Text);
            }).ToList();

            RefreshDgv(clientesPorNombre) ;

        }

        private void btn_buscar_por_monto_Click(object sender, System.EventArgs e)
        {
            var min = n_monto_min.Value;
            var max = n_monto_max.Value;
            var clientesPorMonto = Clientes.Where(cliente =>
           {
               var ventasminmax = cliente.Ventas.Where(venta => venta.Total >= min && venta.Total <= max);

               return ventasminmax != null;
           });
        }
    }
}
