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
    /// Lógica de interacción para ManProductos.xaml
    /// </summary>
    public partial class ManProductos : Window
    {
        ManProductoViewModel viewModel;

        public ManProductos(Producto producto)
        {
            InitializeComponent();
            viewModel = new ManProductoViewModel(producto);
            this.DataContext = viewModel;
        }
    }
}
