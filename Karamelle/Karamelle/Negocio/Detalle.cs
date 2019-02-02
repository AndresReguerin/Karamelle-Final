using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing;
using System.IO;
using System.Collections;

namespace Karamelle.Negocio
{
    public class Detalle : Conexion
    {
        public int IDDetalle { get; set; }
        public int IDPedido { get; set; }
        public int IDPastel { get; set; }
        public string Tamaño { get; set; }
        public int Cantidad { get; set; }
        public string Decoracion { get; set; }
        public int IDDetalleMax()
        {
            OleDbConnection conn = Conectar();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select COUNT(IDDetalle) + 1 from Detalle";
            OleDbDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                return Convert.ToInt32(reader[0].ToString());
            }
            return -1;
        }//obtiene el sgte Id para registrar
        public bool GuardarDetalle()//Actaualizar en la Tabla Pastel
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO  Detalle (IDDetalle,IDPedido,IDPastel,Tamaño,Cantidad,Decoracion,Estado) values (?,?,?,?,?,?,1)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@IDDetalle", IDDetalle);
                comm.Parameters.AddWithValue("@IDPedido", IDPedido);
                comm.Parameters.AddWithValue("@IDPastel", IDPastel);
                comm.Parameters.AddWithValue("@Tamaño", Tamaño);
                comm.Parameters.AddWithValue("@Cantidad", Cantidad);
                comm.Parameters.AddWithValue("@Decoracion", Decoracion);
                if (comm.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                return false;

            }

        }
        public DataTable CargarDetallePedido(int ped)
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT T0.IDPastel,T1.Nombre,T0.Cantidad,T0.Tamaño,T0.Decoracion from Detalle T0 ,Pastel T1 where T0.IDPastel = T1.IDPastel and T0.IDPedido = ? ";
                comm.Parameters.AddWithValue("@ped", ped);
                DataTable dtCargo = new DataTable();
                OleDbDataAdapter adap = new OleDbDataAdapter(comm);
                adap.Fill(dtCargo);
                return dtCargo;
            }
            catch
            {
                return null;
            }
        }

        public DataTable CargarDetPastelero(int past)
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "select T0.IDPedido,T0.IDPastel,T2.Nombre,T0.Tamaño,Cantidad,Decoracion from Detalle T0, Pedido T1,Pastel T2  where T0.IDPedido = T1.IDPedido and T0.IDPastel = T2.IDPastel and T1.IDPastelero = ? and T0.Estado = 1";
                comm.Parameters.AddWithValue("@ped", past);
                DataTable dtCargo = new DataTable();
                OleDbDataAdapter adap = new OleDbDataAdapter(comm);
                adap.Fill(dtCargo);
                return dtCargo;
            }
            catch
            {
                return null;
            }
        }
        public DataTable CargarDetDecorador(int past)
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "select T0.IDPedido,T0.IDPastel,T2.Nombre,T0.Tamaño,Cantidad,Decoracion from Detalle T0, Pedido T1,Pastel T2  where T0.IDPedido = T1.IDPedido and T0.IDPastel = T2.IDPastel and T1.IDDecorador = ? and T0.Estado = 2 ";
                comm.Parameters.AddWithValue("@ped", past);
                DataTable dtCargo = new DataTable();
                OleDbDataAdapter adap = new OleDbDataAdapter(comm);
                adap.Fill(dtCargo);
                return dtCargo;
            }
            catch
            {
                return null;
            }
        }

        public bool actualizarEstado(int idestado,int idped,int idpa)//Actaualizar en la Tabla Pastel
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Detalle set Estado = ? where IDPastel = ? and IDPedido = ?";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@IDDetalle", idestado);
                comm.Parameters.AddWithValue("@IDPastel", idpa);
                comm.Parameters.AddWithValue("@IDPedido", idped);
                

                if (comm.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                return false;

            }

        }
    }
}
