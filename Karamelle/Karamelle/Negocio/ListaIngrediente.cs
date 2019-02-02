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
    public class ListaIngrediente:Conexion
    {
        public int IDPastel { get; set; }
        public int IDInsumo { get; set; }
        public decimal Cantidad { get; set; }

        public bool GuardarLista()//Guarda en la Tabla Insumo
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO ListaIngrediente (IDPastel,IDInsumo,Cantidad) values (?,?,?)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ID", IDPastel);
                comm.Parameters.AddWithValue("@Nombre", IDInsumo);
                comm.Parameters.AddWithValue("@Unidad", Cantidad);

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
        public bool ActualizarLista()//Actaualizar en la Tabla Insumo
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Lista set IDInsumo = ?, Cantidad = ? where IDPastel = ?";
                comm.CommandType = CommandType.Text;

                comm.Parameters.AddWithValue("@Nombre", IDInsumo);
                comm.Parameters.AddWithValue("@Unidad", Cantidad);
                comm.Parameters.AddWithValue("@ID", IDPastel);

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
        public DataTable CargarLista(int pastel)
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "select T0.IDInsumo,T1.Nombre,T0.Cantidad,Unidad from ListaIngrediente T0,Insumo T1 where T0.IDInsumo = T1.IDInsumo and T0.IDPastel = ?";
                comm.Parameters.AddWithValue("@ID", pastel);
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
        public bool EliminarLista()//Guarda en la Tabla Insumo
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM ListaIngrediente where IDPastel = ?";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ID", IDPastel);
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
