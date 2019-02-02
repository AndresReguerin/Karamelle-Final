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
   public  class Usuario:Conexion
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public int Loguearse()
        {

            try
            {

                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT IDUsuario FROM Usuario WHERE Login = ? AND Password = ?";
                comm.Parameters.Add("@Log", OleDbType.VarChar).Value = Login;
                comm.Parameters.Add("@Pasw", OleDbType.VarChar).Value = Password;
                OleDbDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    return Convert.ToInt32(reader[0].ToString());
                }
                return -1;
            }
            catch (Exception)
            {

                return -1;
                throw;
            }
        }
        public bool GuardarUsuario()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO USUARIO (IDUsuario,Login,Password) values (?,?,?)";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@ID", ID);
                comm.Parameters.AddWithValue("@Login", Login);
                comm.Parameters.AddWithValue("@Password", Password);
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
        public bool ActualizarUsuario()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Usuario SET Login = ?, Password = ? where IDUsuario = ? ";
                comm.CommandType = CommandType.Text;

                comm.Parameters.AddWithValue("@Login", Login);
                comm.Parameters.AddWithValue("@Password", Password);
                comm.Parameters.AddWithValue("@IDUsuario", ID);
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
