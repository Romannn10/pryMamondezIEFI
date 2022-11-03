using System;
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
        private string NombreYApellidoCliente;
        private Int32 Documento;
        private string BarrioCliente;
        private string DireccionCliente;
        private string ActividadCliente;
        private Int32 EdadCliente;
        private string MontoAPagar;

        public string NombreYApellido
        {
            get { return NombreYApellidoCliente; }
            set { NombreYApellidoCliente = value; }
        }
        public Int32 DNI
        {
            get { return Documento; }
            set { Documento = value; }
        }
        public string Barrio
        {
            get { return BarrioCliente; }
            set { BarrioCliente = value; }
        }
        public string Direccion
        {
            get { return DireccionCliente; }
            set { DireccionCliente = value; }
        }
        public string Actividad
        {
            get { return ActividadCliente; }
            set { ActividadCliente = value; }
        }
        public Int32 Edad
        {
            get { return EdadCliente; }
            set { EdadCliente = value; }
        }
        public string Monto
        {
            get { return MontoAPagar; }
            set { MontoAPagar = value; }
        }
        public void Agregar()
        {
            try
            {
                string Agregar = "INSERT INTO Principal ([DNI_Socio], [Nombre_Apellido], [Direccion], [Codigo_Barrio], [Actividad], [Saldo], [Edad])" +
                        "VALUES ('" + DNI + "','" + NombreYApellido + "','" + Direccion + "','" + Barrio + "','" + Actividad + "','" + Monto + "','" + Edad + "')";
                //Conecto la base de datos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                //El comando toma la conexion
                Comando.Connection = conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                Comando.CommandText = Agregar;
                Comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Los datos no pudieron registrarse");
            }

        }
    }
}
