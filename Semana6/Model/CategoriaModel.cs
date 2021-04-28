﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;
using System.Collections.ObjectModel;

namespace Semana6.Model
{
    public class CategoriaModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public bool Insertar( Categoria categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }

        public bool Actualizar( Categoria categoria )
        {
            return (new BCategoria()).Actualizar(categoria);
        }

        public bool Eliminar(int Id)
        {
            return (new BCategoria()).Eliminar(Id);
        }

        public CategoriaModel()
        {
            var lista = (new BCategoria().Listar(0));
            Categorias = new ObservableCollection<Categoria>(lista);
        }
    }
}
