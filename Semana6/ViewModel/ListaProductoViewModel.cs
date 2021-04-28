using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Entity;

namespace Semana6.ViewModel
{
    public class ListaProductoViewModel
    {
        public ObservableCollection<Producto> Productos { get; set; }

        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }
        public ListaProductoViewModel()
        {

            Productos = new Model.ProductosModel().Productos;

            NuevoCommand = new RelayCommand<Window>(
                param => Abrir()
                );

            ConsultarCommand = new RelayCommand<object>(
                o => { Productos = new Model.ProductosModel().Productos; }
                );

            void Abrir()
            {
                View.ManProductos window = new View.ManProductos(null);
                window.ShowDialog();
            }
        }
    }
}
