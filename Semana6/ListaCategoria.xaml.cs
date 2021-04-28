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
using Business;
using Entity;
namespace Semana6
{
    public partial class ListaCategoria : Window
    {
        public ListaCategoria()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            BCategoria Bcategoria = null;
            try
            {
                Bcategoria = new BCategoria();
                dgvCategoria.ItemsSource = Bcategoria.Listar(0);
            } catch ( Exception)
            {
                MessageBox.Show("Comunicarse con el administrador");
            } finally
            {
                Bcategoria = null;
            }
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            // Se coloca 0 porque es uno nuevo
            MainWindow manCategoria = new MainWindow(0);
            manCategoria.ShowDialog();
            Cargar();
        }

        private void DgvCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idCategoria;
            var item = (Categoria)dgvCategoria.SelectedItem;
            if (null == item) return;
            idCategoria = Convert.ToInt32(item.IdCategoria);
            // Coloco 0 porque es uno nuevo
            MainWindow manCategoria = new MainWindow(idCategoria);
            manCategoria.ShowDialog();
            Cargar();
        }
    }
}
