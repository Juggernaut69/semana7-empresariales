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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Business;
using Entity;

namespace Semana6
{
    public partial class MainWindow : Window
    {
        public int ID { get; set; }
        public MainWindow( int Id )
        {
            InitializeComponent();
            ID = Id;
            if( ID>0)
            {
                BCategoria bCategoria = new BCategoria();
                List<Categoria> categorias = new List<Categoria>();
                categorias = bCategoria.Listar(ID);
                if( categorias.Count > 0)
                {
                    txtNombre.Text = categorias[0].NombreCategoria.ToString();
                    txtDescripcion.Text = categorias[0].Descripcion.ToString();
                }
            }
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            BCategoria Bcategoria = null;
            bool result = true;
            try
            {
                Bcategoria = new BCategoria();
                if (ID > 0)
                    result = Bcategoria.Actualizar( new Categoria { IdCategoria=ID, NombreCategoria = txtNombre.Text, Descripcion = txtDescripcion.Text } );
                else
                    result = Bcategoria.Insertar(new Categoria { IdCategoria = 26, NombreCategoria = txtNombre.Text, Descripcion = txtDescripcion.Text });
                if (!result)
                    MessageBox.Show("Comunicarse con el Administrador");
                Close();
            } catch ( Exception)
            {
                MessageBox.Show("Comunicarse con Administrador");
            } finally
            {
                Bcategoria = null;
            }

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            BCategoria Bcategoria = null;
            bool result = true;
            try
            {
                Bcategoria = new BCategoria();
                if (ID > 0)
                    result = Bcategoria.Eliminar(ID);
                if (!result)
                    MessageBox.Show("Comunicarse con el Administrador");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Comunicarse con Administrador");
            }
            finally
            {
                Bcategoria = null;
            }
        }
    }
}
