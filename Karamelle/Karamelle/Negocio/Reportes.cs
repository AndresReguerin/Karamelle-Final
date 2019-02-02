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
    public  class Reportes : Conexion
    {
        public DataTable CargarReporte1()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "select T0.IDPedido ,T2.IDInsumo,Nombre,(T0.Cantidad * T1.Cantidad )'Canti',T2.Unidad from Detalle T0 ,ListaIngrediente T1 , Insumo T2  where t0.IDPastel = T1.IDPastel and T1.IDInsumo = T2.IDInsumo ";
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
        public DataTable CargarReporte2()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Select Top 100 T0.IDPastel,T1.Nombre , Sum(Cantidad) 'Cantidad'from   Detalle T0 , Pastel T1 where T0.IDPastel  = T1.IDPastel Group by T0.IDPastel ,T1.Nombre Order by count(1) desc ";
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
        public DataTable CargarReporte3()
        {
            try
            {
                OleDbConnection conn = Conectar();
                OleDbCommand comm = new OleDbCommand();
                comm.Connection = conn;
                comm.CommandText = "Select IDPedido,IDCliente,RTRIM(T1.Nombre + ' '+ T1.Apellido)'Cliente',Nit,IDDecorador,RTRIM(T2.Nombre + ' '+ T2.Apellido)'Decorador',IDPastelero,RTRIM(T3.Nombre + ' '+ T3.Apellido)'Pastelero',FechaPedido,FechaEntrega, CASE T0.Estado when 1 then 'Pendiente' when 2 then 'Realizado'when 3 then 'Cancelado' End 'Estad' from Pedido T0 ,Persona T1,Persona T2 , Persona T3 where t0.IDCliente = T1.IDPersona and T0.IDDecorador = T2.IDPersona and T0.IDPastelero = T3.IDPersona ";
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
