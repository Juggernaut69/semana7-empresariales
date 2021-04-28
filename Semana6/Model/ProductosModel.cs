using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;
using System.Collections.ObjectModel;

namespace Semana6.Model
{
    public class ProductosModel
    {
        public ObservableCollection<Producto> Productos { get; set; }

        public bool Insertar(Producto producto)
        {
            return (new BProducto()).Insertar(producto);
        }

        public bool Actualizar(Producto producto)
        {
            return (new BProducto()).Actualizar(producto);
        }

        public bool Eliminar(int Id)
        {
            return (new BProducto()).Eliminar(Id);
        }

        public ProductosModel()
        {
            var lista = (new BProducto().Listar(0));
            Productos = new ObservableCollection<Producto>(lista);
        }
    }
}
