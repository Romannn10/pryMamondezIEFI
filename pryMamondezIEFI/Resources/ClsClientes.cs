﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos 3 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMamondezIEFI.Resources
{
    internal class ClsClientes
    {
        //Conectamos la Base de datos
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la base
        private OleDbCommand Comando = new OleDbCommand();
        //Objeto para adaptar los datos de la base
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Ruta de base de datos
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Gimnasio1.accdb";
        //Nombre de tabla a llamar
        private string Tabla = "Principal";
        public void Listar(DataGridView dgvDeudores)
        {
            //Conectar a la BD
            conexion.ConnectionString = CadenaConexion;
            //Abrimos la BD
            conexion.Open();
            //Conectar el comando a la BD
            Comando.Connection = conexion;
            //Traemos la tabla
            Comando.CommandType = CommandType.TableDirect;
            //selecciona la tabla
            Comando.CommandText = Tabla;//Nombre tabla
            //conectamos adaptador a la bd, traemos los datos y los subimos a la tabla
            adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            //llenamos grilla
            dgvDeudores.DataSource = ds.Tables[0];
            conexion.Close();
        }
    }
}
