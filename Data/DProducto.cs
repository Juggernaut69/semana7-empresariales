using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class DProducto
    {
        public List<Producto> Listar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Producto> productos = null;

            try
            {
                comandText = "USP_GetProductos";
                productos = new List<Producto>();

                using (SqlDataReader reader = SQLHelper.ExecuteReader(
                    SQLHelper.Connection, comandText, CommandType.StoredProcedure))
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            IdProducto = reader["idproducto"] != null ?
                                Convert.ToInt32(reader["idproducto"]) : 0,
                            NombreProducto = reader["nombreProducto"] != null ?
                                Convert.ToString(reader["nombreProducto"]) : string.Empty,
                            CantidadPorUnidad = reader["cantidadPorUnidad"] != null ?
                                Convert.ToString(reader["cantidadPorUnidad"]) : string.Empty,
                            PrecioUnidad = reader["precioUnidad"] != null ?
                                Convert.ToInt32(reader["precioUnidad"]) : 0
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;

        }

        public void Insertar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_InsProducto";
                parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@nombreproducto", SqlDbType.VarChar);
                parameters[0].Value = producto.NombreProducto;
                parameters[1] = new SqlParameter("@cantidadporunidad", SqlDbType.VarChar);
                parameters[1].Value = producto.CantidadPorUnidad;
                parameters[2] = new SqlParameter("@preciounidad", SqlDbType.Int);
                parameters[2].Value = producto.PrecioUnidad;
                SQLHelper.ExecuteNonQuery(SQLHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Actualizar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_UpdProducto";
                parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@idproducto", SqlDbType.Int);
                parameters[0].Value = producto.IdProducto;
                parameters[1] = new SqlParameter("@nombreproducto", SqlDbType.VarChar);
                parameters[1].Value = producto.NombreProducto;
                parameters[2] = new SqlParameter("@cantidadporunidad", SqlDbType.VarChar);
                parameters[2].Value = producto.CantidadPorUnidad;
                parameters[3] = new SqlParameter("@preciounidad", SqlDbType.Int);
                parameters[3].Value = producto.PrecioUnidad;
                SQLHelper.ExecuteNonQuery(SQLHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Eliminar(int IdProducto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_DelProducto";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idproducto", SqlDbType.Int);
                parameters[0].Value = IdProducto;
                SQLHelper.ExecuteNonQuery(SQLHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
