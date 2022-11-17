using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos 4 espacios de nombre
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace pryMamondezIEFI.Resources
{
    internal class ClsClientes
    {

        public string varNombreMontoMayor = "";

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
        private Int32 varCantidadClientes;
        private Decimal varPromedioSaldos;
        private Decimal varTotalSaldos;
        private Decimal varMontoMayor;
        //Con la variable privada vamos a interactuar en la base
        //con la variable publica interactuamos con el formulario
        public Int32 CantClientes
        {
            get { return varCantidadClientes; }
        }
        public Decimal PromSaldos
        {
            get { return varPromedioSaldos; }
        }
        public Decimal TotSaldos
        {
            get { return varTotalSaldos; }
        }
        public decimal MontoMayor
        {
            get { return varMontoMayor; }
        }
        public void Listar(DataGridView dgvDeudores)
        {
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexion.ConnectionString = CadenaConexion;
                //Abre la conexion de la BD, es un canal
                conexion.Open();
                //Necesitamos mndar una orden para que nos traiga datos de la BD 
                //usamos el objeto comando
                //Indicamos la conexion que tiene que utilizar
                Comando.Connection = conexion;
                //Indicamos el tipo de comando
                //Trae una tabla el comando
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                //Es una tabla virtual que esta en la ram
                OleDbDataReader DR = Comando.ExecuteReader();
                dgvDeudores.Rows.Clear();
                varCantidadClientes = 0;
                varTotalSaldos = 0;
                varPromedioSaldos = 0;
                varMontoMayor = 0;
                clsActividad Actividad = new clsActividad();
                clsBarrio Barrio = new clsBarrio();
                string DActividad = "";
                string DBarrio = "";

                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {

                    //Mientras hayan datos para leer en el Datareader
                    while (DR.Read())
                    {
                        DActividad = Actividad.Buscar(DR.GetInt32(4));
                        DBarrio = Barrio.Buscar(DR.GetInt32(3));
                        //Añade filas a la grilla tomando las posiciones de los campos de la tabla clientes

                        dgvDeudores.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetString(2), DBarrio, DActividad, DR.GetDecimal(5), DR.GetInt32(6));
                        varCantidadClientes++;
                        varTotalSaldos = varTotalSaldos + DR.GetDecimal(5);


                        if (DR.GetDecimal(5) > varMontoMayor)
                        {
                            varNombreMontoMayor = DR.GetString(1);
                            varMontoMayor = DR.GetDecimal(5);
                        }
                    }
                    varPromedioSaldos = varTotalSaldos / varCantidadClientes;
                    //while (DR.GetDecimal(5) > varMontoMayor)
                    //{
                    //    varMontoMayor = DR.GetDecimal(5);
                    //}
                }
                conexion.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

            }
        }
        public void ListarPorBarrio(DataGridView dgvListadoBarrios, Int32 CodigoBarrio)
        {
            //Conecto la base de datos
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();
            //El comando toma la conexion
            Comando.Connection = conexion;
            //Este comando me trae la tabla del access
            Comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla
            Comando.CommandText = Tabla;
            OleDbDataReader Lector = Comando.ExecuteReader();
            dgvListadoBarrios.Rows.Clear();
            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            clsActividad activi = new clsActividad();
            string act = "";

            if (Lector.HasRows)
            {
                while (Lector.Read())
                {

                    if (Lector.GetInt32(3) == CodigoBarrio)
                    {
                        act = activi.Buscar(Lector.GetInt32(4));
                        NombreBarrio = Barrios.Buscar(Lector.GetInt32(3));
                        dgvListadoBarrios.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), NombreBarrio, act, Lector.GetDecimal(5), Lector.GetInt32(6));
                    }
                }
            }
        }

        public void GenerarReporte()
        {
            string DatosLeidos = "";
            string[] VecDatos = new string[4];

            StreamWriter Reporte = new StreamWriter("Reporte.csv", false);
            Reporte.WriteLine("Listado de clientes de este barrio");
            Reporte.WriteLine("");
            Reporte.WriteLine("DNI; Nombre Y Apellido; Direccion; Barrio; Actividad; Saldo; Edad");


            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                DatosLeidos = AD.ReadLine();
                 
            }
            AD.Close();
            AD.Dispose();

            Reporte.Close();
            Reporte.Dispose();
        }


    
    }
}
