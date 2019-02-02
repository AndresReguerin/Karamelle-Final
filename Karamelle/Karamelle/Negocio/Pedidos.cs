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
    public class Pedidos:Conexion
    {
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public string Nit { get; set; }
        public int IDDecorador { get; set; }
        public int IDPastelero { get; set; }
        public DateTime FechaEntrega { get; set; }

        public int IDPedidoMax()
        {
            OleDbConnection conn = Conectar();
            OleDbCommand comm = new OleDbCommand();
            comm.Connection = conn;
            comm.CommandText = "Select COUNT(IDPedido) + 1 from Pedido";
            OleDbDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                return Convert.ToInt32(reader[0].ToString());
            }
            return -1;
        }//obtiene el sgte Id para registrar
        public bool GuardarPedido()//Guarda en la Tabla Pastel
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Pedido (IDPedido,IDCliente,Nit,IDDecorador,IDPastelero,FechaPedido,FechaEntrega,Estado) values (?,?,?,?,?,GETDATE(),?,1)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ID", ID);
                comm.Parameters.AddWithValue("@Cliente", IDCliente);
                comm.Parameters.AddWithValue("@Nit", Nit);
                comm.Parameters.AddWithValue("@IDDecorador", IDDecorador);
                comm.Parameters.AddWithValue("@IDPastelero", IDPastelero);
                comm.Parameters.AddWithValue("@FechaEntrega", FechaEntrega.Date);
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
        public bool ActualizarEstado(int est,int id)//Guarda en la Tabla Pastel
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Pedido set Estado = ?  where IDPedido = ?";
                comm.CommandType = CommandType.Text;
                
                comm.Parameters.AddWithValue("@Estado", est);
                comm.Parameters.AddWithValue("@ID", id);

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
        
        public DataTable CargarPedido()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Select IDPedido,IDCliente,RTRIM(T1.Nombre + ' '+ T1.Apellido)'Cliente',Nit,IDDecorador,RTRIM(T2.Nombre + ' '+ T2.Apellido)'Decorador',IDPastelero,RTRIM(T3.Nombre + ' '+ T3.Apellido)'Pastelero',FechaPedido,FechaEntrega, CASE T0.Estado when 1 then 'Pendiente' when 2 then 'Realizado'when 3 then 'Cancelado' End 'Estad' from Pedido T0 ,Persona T1,Persona T2 , Persona T3 where t0.IDCliente = T1.IDPersona and T0.IDDecorador = T2.IDPersona and T0.IDPastelero = T3.IDPersona  and T0.Estado <> 3";
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
        public DataTable CargarPedidoid(int a)
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Select IDPedido,IDCliente,RTRIM(T1.Nombre + ' '+ T1.Apellido)'Cliente',Nit,IDDecorador,RTRIM(T2.Nombre + ' '+ T2.Apellido)'Decorador',IDPastelero,RTRIM(T3.Nombre + ' '+ T3.Apellido)'Pastelero',FechaPedido,FechaEntrega, CASE T0.Estado when 1 then 'Pendiente' when 2 then 'Realizado'when 3 then 'Cancelado' End 'Estado' from Pedido T0 ,Persona T1,Persona T2 , Persona T3 where t0.IDCliente = T1.IDPersona and T0.IDDecorador = T2.IDPersona and T0.IDPastelero = T3.IDPersona and T0.IDPedido = ? ";
                comm.Parameters.AddWithValue("@IDPedido", a);
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
       
    }
}
