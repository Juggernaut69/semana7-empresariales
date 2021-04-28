using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Business;
using Entity;
using Semana6.Model;

namespace Semana6.ViewModel
{
    public class ManProductoViewModel : ViewModelBase
    {

        #region propiedades
        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        string _CantidadPorUnidad;

        public string CantidadPorUnidad
        {
            get { return _CantidadPorUnidad; }
            set
            {
                if (_CantidadPorUnidad != value)
                {
                    _CantidadPorUnidad = value;
                    OnPropertyChanged();
                }
            }
        }

        int _PrecioUnidad;

        public int PrecioUnidad
        {
            get { return _PrecioUnidad; }
            set
            {
                if (_PrecioUnidad != value)
                {
                    _PrecioUnidad = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand GrabarCommand { set; get; }
        public ICommand CerrarCommand { set; get; }
        public ICommand EliminarCommand { set; get; }

        public ManProductoViewModel( Producto pro)
        {
            ListaProductoViewModel viewModel = new ListaProductoViewModel();

            if (pro != null)
            {
                ID = pro.IdProducto;
                Nombre = pro.NombreProducto;
                CantidadPorUnidad = pro.CantidadPorUnidad;
                PrecioUnidad = pro.PrecioUnidad;
            }

            GrabarCommand = new RelayCommand<object>(
                o =>
                {
                    int idProd = Convert.ToInt32(ID);
                    int precio = Convert.ToInt32(PrecioUnidad);
                    if (idProd > 0)
                        new ProductosModel().Actualizar(new Entity.Producto
                        {
                            IdProducto = idProd,
                            NombreProducto = Nombre,
                            CantidadPorUnidad = CantidadPorUnidad,
                            PrecioUnidad = precio
                        });
                    else
                        new ProductosModel().Insertar(new Entity.Producto
                        {
                            NombreProducto = Nombre,
                            CantidadPorUnidad = CantidadPorUnidad,
                            PrecioUnidad = precio
                        });
                });

            CerrarCommand = new RelayCommand<Window>(param => Cerrar(param));

            EliminarCommand = new RelayCommand<object>(
                o =>
                {
                    int idProd = Convert.ToInt32(ID);
                    if (idProd > 0)
                    {
                        new ProductosModel().Eliminar(idProd);
                    }
                });

        }

        void Cerrar(Window window)
        {
            window.Close();
        }

    }
}
