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
    /// Lógica de interacción para ListaCategorias.xaml
    /// </summary>
    public partial class ListaCategorias : Window
    {

        ListaCategoriaViewModel viewModel;

        public ListaCategorias()
        {
            InitializeComponent();
            viewModel = new ListaCategoriaViewModel();
            this.DataContext = viewModel;
        }

         private void Categoria_Seleccionada(object sender, SelectionChangedEventArgs e)
        {
            var item = (Categoria)dgvCategoria.SelectedItem;
            if (null == item) return;
            // idCategoria = Convert.ToInt32(item.IdCategoria);
            // Coloco 0 porque es uno nuevo
            ManCategoria manCategoria = new ManCategoria(item);
            manCategoria.ShowDialog();
        }
    }
}
