using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Semana6.ViewModel;
using Entity;

namespace Semana6.View
{
    /// <summary>
    /// Lógica de interacción para ListaProductos.xaml
    /// </summary>
    public partial class ListaProductos : Window
    {
        ListaProductoViewModel viewModel;

        public ListaProductos()
        {
            InitializeComponent();
            viewModel = new ListaProductoViewModel();
            this.DataContext = viewModel;
        }

        private void Producto_Seleccionado(object sender, SelectionChangedEventArgs e)
        {
            var item = (Producto)dgvProducto.SelectedItem;
            if (null == item) return;
            ManProductos manProducto = new ManProductos(item);
            manProducto.ShowDialog();
        }
    }
}
